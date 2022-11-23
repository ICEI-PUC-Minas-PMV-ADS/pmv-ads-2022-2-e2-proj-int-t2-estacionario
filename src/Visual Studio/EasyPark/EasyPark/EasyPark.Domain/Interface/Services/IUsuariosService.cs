using EasyPark.EasyPark.Domain.Requests;
using EasyPark.EasyPark.Domain.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EasyPark.EasyPark.Domain.Interface.Services
{
    public interface IUsuariosService
    {
        Task<UsuariosStatusCadastroResponse> CadastrarUsuario(UsuariosRequest usuariosRequest);
        Task<UsuariosResponse> PersistirLoginAsyinc(UsuariosRequest usuarioRequest);
    }
}
