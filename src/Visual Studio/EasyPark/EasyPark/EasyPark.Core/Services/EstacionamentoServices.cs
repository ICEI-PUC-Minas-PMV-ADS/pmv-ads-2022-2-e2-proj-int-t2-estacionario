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
    public class EstacionamentoServices: IEstacionamentoService
    {
        private readonly IEstacionamentoRepository _estacionamentoRepository;
        private readonly IUtilidadesRepository _utilidadesRepository;

        public EstacionamentoServices(IEstacionamentoRepository estacionamentoRepository, IUtilidadesRepository utilidadesRepository)
        {
            _estacionamentoRepository = estacionamentoRepository;
            _utilidadesRepository = utilidadesRepository;
        }

        public void AtualizarEstacionamento(EstacionamentoResponse estacionamentoResponse)
        {
            try
            {
                var preparaAtualizacaoEstacionamento = new Estacionamento()
                {
                    Endereco=estacionamentoResponse.Endereco,
                    EstacionamentoId=estacionamentoResponse.EstacionamentoId,
                    Estado=estacionamentoResponse.EstadoAtuacao,
                    HorarioFuncionamento=estacionamentoResponse.HorarioFuncionamento,
                    NomeEstacionamento=estacionamentoResponse.NomeEstacionamento,
                    Telefone=estacionamentoResponse.Telefone,
                    TotaisVagas=estacionamentoResponse.TotaisVagas,
                    VagasComuns=estacionamentoResponse.VagasComuns,
                    VagasEletricas=estacionamentoResponse.VagasEletricas,
                    VagasPreferenciais=estacionamentoResponse.VagasPreferenciais,
                    UsuarioCriador=estacionamentoResponse.UsuarioEmpresaCriador
                };

                _estacionamentoRepository.AtualizarEstacionamento(preparaAtualizacaoEstacionamento);
            }
            catch (Exception EX)
            {
                throw new Exception(EX.Message);
            }
        }


        public async Task<EstacionamentoResponse> GeraEstacionamentoByIdAsync(int estacionamentoId)
        {
            try
            {
                var obtemEstacionamento = _estacionamentoRepository.GeraEstacionamentoById(estacionamentoId).Result;
                var geraListaEstados = _utilidadesRepository.GetEstados();

                var estacionamentoResponse = new EstacionamentoResponse()
                {
                    Endereco=obtemEstacionamento.Endereco,
                    EstacionamentoId=obtemEstacionamento.EstacionamentoId,
                    EstadoAtuacao=obtemEstacionamento.EstadoNavigation.EstadoId,
                    estados=geraListaEstados,
                    HorarioFuncionamento=obtemEstacionamento.HorarioFuncionamento,
                    NomeEstacionamento=obtemEstacionamento.NomeEstacionamento,
                    Telefone=obtemEstacionamento.Telefone,
                    TotaisVagas=obtemEstacionamento.TotaisVagas,
                    VagasComuns=obtemEstacionamento.VagasComuns,
                    VagasEletricas=obtemEstacionamento.VagasEletricas,
                    VagasPreferenciais=obtemEstacionamento.VagasPreferenciais
                };

                return estacionamentoResponse;
            }
            catch (Exception EX)
            {
                throw new Exception(EX.Message);
            }
        }

        public void RemoverEstacionamento(int estacionamentoId)
        {
            try
            {
                _estacionamentoRepository.RemoverEstacionamento(estacionamentoId);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public async Task<List<EstacionamentoResponse>> GeraListaEstacionamento(int usuarioEmpresaCriador)
        {
            try
            {
                var obtemListaEstacionamentos = _estacionamentoRepository.GeraListaEstacionamentos(usuarioEmpresaCriador).Result;

                var preparaListaEstacionamentos = new List<EstacionamentoResponse>();

                foreach (var listarEstacionamento in obtemListaEstacionamentos)
                {
                    preparaListaEstacionamentos.Add(new EstacionamentoResponse()
                    {
                        EstacionamentoId = listarEstacionamento.EstacionamentoId,
                        NomeEstado = listarEstacionamento.EstadoNavigation.NomeEstado,
                        HorarioFuncionamento = listarEstacionamento.HorarioFuncionamento,
                        NomeEstacionamento = listarEstacionamento.NomeEstacionamento,
                        Telefone = listarEstacionamento.Telefone,
                        TotaisVagas = listarEstacionamento.TotaisVagas,
                        VagasComuns = listarEstacionamento.VagasComuns,
                        VagasEletricas = listarEstacionamento.VagasEletricas,
                        VagasPreferenciais = listarEstacionamento.VagasPreferenciais,
                        Endereco = listarEstacionamento.Endereco

                    });
                }

                    return preparaListaEstacionamentos;
                
            }
            catch (Exception EX)
            {
                throw new Exception(EX.Message);
            }
        }


        public void CriarEstacionamento(EstacionamentoRequest estacionamentoRequest)
        {
try
            {

                var mapearEntidadeEstacionamento = new Estacionamento()
                {
                    Endereco = estacionamentoRequest.Endereco,
                    EstacionamentoId = estacionamentoRequest.EstacionamentoId,
                    Estado = estacionamentoRequest.EstadoAtuacao,
                    HorarioFuncionamento = estacionamentoRequest.HorarioFuncionamento,
                    NomeEstacionamento = estacionamentoRequest.NomeEstacionamento,
                    Telefone = estacionamentoRequest.Telefone,
                    TotaisVagas = estacionamentoRequest.TotaisVagas,
                    VagasComuns = estacionamentoRequest.VagasComuns,
                    VagasEletricas = estacionamentoRequest.VagasEletricas,
                    VagasPreferenciais = estacionamentoRequest.VagasPreferenciais,
                    UsuarioCriador = estacionamentoRequest.UsuarioEmpresaCriador
                };

                _estacionamentoRepository.CriarEstacionamento(mapearEntidadeEstacionamento);
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


    }
}
