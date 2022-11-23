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
    public class PrestadorServicosServices: IPrestadorServicosServices
    {
        private readonly IPrestadorServicosRepository _prestadorServicosRepository;
        private readonly IUtilidadesRepository _utilidadesRepository;

        public PrestadorServicosServices(IPrestadorServicosRepository prestadorServicosRepository, IUtilidadesRepository utilidadesRepository)
        {
            _prestadorServicosRepository = prestadorServicosRepository;
            _utilidadesRepository = utilidadesRepository;
        }

        public async Task<PrestadorServicoResponse> GeraServicoViaId(int servicoId)
        {
            try
            {

                var obtemServicos = _prestadorServicosRepository.GeraServicoById(servicoId).Result;

                

                var recuperaListaEstado = _utilidadesRepository.GetEstados();

                var recuperaServicos = new PrestadorServicoResponse()
                {
                    Endereco = obtemServicos.Endereco,
                    estados=recuperaListaEstado,
                    EstadoId=obtemServicos.EstadoNavigation.EstadoId,
                    HorarioFuncionamento=obtemServicos.HorarioFuncionamento,
                    NomePrestador=obtemServicos.NomePrestador,
                    NomeServico=obtemServicos.NomeServico,
                    TelefonePrestador=obtemServicos.TelefonePrestador,
                    PrestadorServicosId=obtemServicos.PrestadorServicosId
                };

                return recuperaServicos;
            }
            catch (Exception EX)
            {
                throw new Exception(EX.Message);
            }
                    }

        public void AtualizarServico(PrestadorServicoResponse prestadorServicoResponse)
        {
            try
            {

                var mapearDadosServicosParaEntidade = new PrestadorServico()
                {
                    Endereco = prestadorServicoResponse.Endereco,
                    HorarioFuncionamento = prestadorServicoResponse.HorarioFuncionamento,
                    NomePrestador = prestadorServicoResponse.NomePrestador,
                    NomeServico = prestadorServicoResponse.NomeServico,
                    PrestadorServicosId = prestadorServicoResponse.PrestadorServicosId,
                    TelefonePrestador = prestadorServicoResponse.TelefonePrestador,
                    Estado = prestadorServicoResponse.EstadoId,
                    PrestadorCriador=prestadorServicoResponse.PrestadorCriador
                };

                _prestadorServicosRepository.AtualizarServico(mapearDadosServicosParaEntidade);
            }
            catch (Exception EX)
            {
                throw new Exception(EX.Message);
            }
        }



        public void RemoverServico(int servicoId)
        {
            try
            {
                _prestadorServicosRepository.RemoverServico(servicoId);

            }
            catch (Exception Ex)
            {
                throw new Exception(Ex.Message);
            }
        }

        public async Task<List<PrestadorServicoResponse>> GeraServicos(int usuarioIdCriador)
        {
            try
            {

                var obtemServicos = _prestadorServicosRepository.GerarServicos(usuarioIdCriador).Result;

                var viewModelServicos = new List<PrestadorServicoResponse>();

                foreach (var listarServicos in obtemServicos)
                {
                    viewModelServicos.Add(new PrestadorServicoResponse()
                    {
                        Endereco=listarServicos.Endereco,
                        Estado=listarServicos.EstadoNavigation.NomeEstado,
                        HorarioFuncionamento=listarServicos.HorarioFuncionamento,
                        NomeServico=listarServicos.NomeServico,
                        PrestadorServicosId=listarServicos.PrestadorServicosId,
                        NomePrestador=listarServicos.NomePrestador,
                        TelefonePrestador=listarServicos.TelefonePrestador
                    });
                        
                }

                                return viewModelServicos;
            }
            catch (Exception EX)
            {
                throw new Exception(EX.Message);
            }
        }


        public async Task<List<Estado>> ObterEstados()
        {
            return _utilidadesRepository.GetEstados();
        }

        public void CriarServicos(PrestadorServicosRequest prestadorServicosRequest)
        {
            try
            {
                var mapearPrestadorServicosToEntity = new PrestadorServico()
                {
                    Endereco=prestadorServicosRequest.Endereco,
                    Estado=prestadorServicosRequest.EstadoAtuacao,
                    HorarioFuncionamento=prestadorServicosRequest.HorarioFuncionamento,
                    NomePrestador=prestadorServicosRequest.NomePrestador,
                    NomeServico=prestadorServicosRequest.NomeServico,
PrestadorCriador=prestadorServicosRequest.UsuarioPrestadorCriador,
TelefonePrestador=prestadorServicosRequest.TelefonePrestador
                };

                _prestadorServicosRepository.CriaServicos(mapearPrestadorServicosToEntity);

            }
            catch (Exception EX)
            {
                throw new Exception(EX.Message);
            }
        }
    }
}
