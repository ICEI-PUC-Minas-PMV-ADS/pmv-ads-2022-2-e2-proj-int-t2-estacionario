using EasyPark.EasyPark.Domain.Entitys;
using EasyPark.EasyPark.Domain.Interface.Repositorys;
using EasyPark.EasyPark.Domain.Interface.Services;
using EasyPark.EasyPark.Domain.Requests;
using EasyPark.EasyPark.Domain.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EasyPark.EasyPark.Core.Services
{
    public class UsuariosService: IUsuariosService
    {
        private readonly IUsuariosRepository _usuariosRepository;

        public UsuariosService(IUsuariosRepository usuariosRepository)
        {
            _usuariosRepository = usuariosRepository;
        }

        public async Task<UsuariosStatusCadastroResponse> CadastrarUsuario(UsuariosRequest usuariosRequest)
        {
            var statusCadastro = new UsuariosStatusCadastroResponse();
            var MapearUsuarioRequestToEntidade = new Usuario()
            {
                Email=usuariosRequest.Email,
                NivelAcesso=usuariosRequest.NivelAcesso,
                Nome=usuariosRequest.NomeUsuario,
                Senha=usuariosRequest.Senha
            };

            var consultaCadastroExistente = _usuariosRepository.ValidaCadastroExistente(MapearUsuarioRequestToEntidade.Email);
            if(!consultaCadastroExistente)
            {
                _usuariosRepository.SalvarUsuario(MapearUsuarioRequestToEntidade);
                statusCadastro.ContaCriada = true;
            }
            else
            {
                statusCadastro.CadastroExiste = true;
            }

            return statusCadastro;
        }

        public async Task<UsuariosResponse> PersistirLoginAsyinc(UsuariosRequest usuarioRequest)
        {
            try
            {
                var verificaDadosLogin = _usuariosRepository.PersisteLogin(new Usuario { Email = usuarioRequest.Email, Senha = usuarioRequest.Senha }).Result;

                if(verificaDadosLogin==null)
                {
                    return null;
                }

                var resultadoLogin = new UsuariosResponse()
                {
                    NivelAcesso = verificaDadosLogin.NivelAcesso,
                    NomeUsuario = verificaDadosLogin.Nome,
                    UsuarioId = verificaDadosLogin.UsuarioId
                };

                return resultadoLogin;
            }
            catch (Exception EX)
            {
                throw new Exception(EX.Message);
            }
        }


    }
}
