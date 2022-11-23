using EasyPark.EasyPark.Domain.Entitys;
using EasyPark.EasyPark.Domain.Interface.Repositorys;
using EasyPark.EasyPark.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EasyPark.EasyPark.Persistence.Repositorys
{
    public class UsuariosRepository: IUsuariosRepository
    {
        private readonly EasyParkContext _easyParkContext;

        public UsuariosRepository(EasyParkContext easyParkContext)
        {
            _easyParkContext = easyParkContext;
        }

        public bool ValidaCadastroExistente(string email)
        {
            var consultaCadastro = _easyParkContext.Usuarios.Where(x => x.Email == email);
            if(consultaCadastro!= null && consultaCadastro.Count() > 0)
            {
                return true;
            }
            return false;
        }

        public void SalvarUsuario(Usuario usuario)
        {
            _easyParkContext.Add(usuario);
            _easyParkContext.SaveChanges();
        }

        public async Task<Usuario> PersisteLogin(Usuario usuario)
        {
            

            var validaLogin = _easyParkContext.Usuarios.Where(x => x.Email == usuario.Email && x.Senha == usuario.Senha).FirstOrDefault();
            

            if(validaLogin!=null)
            {
                return validaLogin;
            }
            return null;
        }
    }
}
