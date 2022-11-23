using EasyPark.EasyPark.Domain.Entitys;
using EasyPark.EasyPark.Domain.Interface.Repositorys;
using EasyPark.EasyPark.Domain.Requests;
using EasyPark.EasyPark.Domain.Responses;
using EasyPark.EasyPark.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EasyPark.EasyPark.Persistence.Repositorys
{
    public class ClienteRepository: IClienteRepository
    {
        private readonly EasyParkContext _easyParkContext;

        public ClienteRepository(EasyParkContext easyParkContext)
        {
            _easyParkContext = easyParkContext;
        }

        public async Task<List<EstacionamentoResponse>> FiltroBuscarServicosVitrineEstacionamento(BuscaRequest buscaRequest)
        {
            var listEstacionamentos = new List<EstacionamentoResponse>();
            var resultadoBuscaVitrine = new VitrineServicos();
            var buscaEmEstacionamentos = _easyParkContext.Estacionamentos
                .Include(x => x.EstadoNavigation)
                .Include(x => x.UsuarioCriadorNavigation)
                .Where(x => x.Estado== buscaRequest.Estado)
                .ToList();
            if (buscaEmEstacionamentos != null)
            {


                foreach (var selecioneEstacionamento in buscaEmEstacionamentos)
                {
                    listEstacionamentos.Add(new EstacionamentoResponse()
                    {
                        Endereco = selecioneEstacionamento.Endereco,
                        HorarioFuncionamento = selecioneEstacionamento.HorarioFuncionamento,
                        NomeEstacionamento = selecioneEstacionamento.NomeEstacionamento,
                        NomeEstado = selecioneEstacionamento.EstadoNavigation.NomeEstado,
                        Telefone = selecioneEstacionamento.Telefone,
                        TotaisVagas = selecioneEstacionamento.TotaisVagas,
                        VagasComuns = selecioneEstacionamento.VagasComuns,
                        VagasEletricas = selecioneEstacionamento.VagasEletricas,
                        VagasPreferenciais = selecioneEstacionamento.VagasPreferenciais,
                        NomeResponsavel = selecioneEstacionamento.UsuarioCriadorNavigation.Nome
                    });
                }
            }




            return listEstacionamentos;
        }

        public async Task<List<PrestadorServicoResponse>> FiltroBuscarServicosVitrinePrestadorServico(BuscaRequest buscaRequest)    
        {
            
            var listPrestadorServicos = new List<PrestadorServicoResponse>();

            var buscaEmPrestadorServico = _easyParkContext.PrestadorServicos
                                    .Include(x => x.EstadoNavigation)
    .Include(x => x.PrestadorCriadorNavigation)
    .Where(x => x.Estado == buscaRequest.Estado && x.EstadoNavigation.EstadoId == buscaRequest.Estado)
    .ToList()
    .Where(x => x.NomeServico == buscaRequest.Termo)
    .ToList();

                        if (buscaEmPrestadorServico != null)
            {

                foreach (var selecionePrestador in buscaEmPrestadorServico)
                {
                    listPrestadorServicos.Add(new PrestadorServicoResponse()
                    {
                        
                        Endereco = selecionePrestador.Endereco,
                        Estado = selecionePrestador.EstadoNavigation.NomeEstado,
                        HorarioFuncionamento = selecionePrestador.HorarioFuncionamento,
                        NomePrestador = selecionePrestador.NomePrestador,
                        NomeServico = selecionePrestador.NomeServico,
                        TelefonePrestador = selecionePrestador.TelefonePrestador,
                        NomeResponsavel = selecionePrestador.PrestadorCriadorNavigation.Nome
                    });
                }
            }





            return listPrestadorServicos;
        }
        


        public async Task<List<Estacionamento>> ObtemListaGeralEstacionamentosAsync(int quantidadeServicos)
        {
            if(quantidadeServicos==0)
            {

                var listEstacionamentos =  _easyParkContext.Estacionamentos
                    .Include(x => x.EstadoNavigation)
                    .Include(x => x.UsuarioCriadorNavigation)
                    .ToList();
                return listEstacionamentos;
            }

            var listEstacionamentosCont= _easyParkContext.Estacionamentos
                    .Include(x => x.EstadoNavigation)
                    .Include(x => x.UsuarioCriadorNavigation)
                    .Take(quantidadeServicos)
                    .ToList();

            return listEstacionamentosCont;
    }


        public async Task<List<PrestadorServico>> ObtemListaGeralPrestadorServicosAsync(int quantidadePrestadorServicos)
        {
            if(quantidadePrestadorServicos==0)
            {

                var listPrestadorServicos =  _easyParkContext.PrestadorServicos
                    .Include(x => x.EstadoNavigation)
                    .Include(x => x.PrestadorCriadorNavigation)
                    .ToList();

                return listPrestadorServicos;
            }

            var listPrestadorServicoCount =  _easyParkContext.PrestadorServicos
    .Include(x => x.EstadoNavigation)
    .Include(x => x.PrestadorCriadorNavigation)
    .Take(quantidadePrestadorServicos)
    .ToList();
            return listPrestadorServicoCount;
                    }

        public async Task<VitrineServicos> BuscarServicosVitrine(string textoBusca)
        {
            var quantidadeRegistros = 0;
            var listPrestadorServicos = new List<PrestadorServicoResponse>();
            var listEstacionamentos = new List<EstacionamentoResponse>();

            var buscaEmEstacionamentos = _easyParkContext.Estacionamentos
                .Include(x => x.EstadoNavigation)
                .Include(x => x.UsuarioCriadorNavigation)
                .ToList()
.FindAll(x => x.NomeEstacionamento.Contains(textoBusca, StringComparison.InvariantCultureIgnoreCase) || x.Endereco.Contains(textoBusca, StringComparison.InvariantCultureIgnoreCase) || x.EstadoNavigation.NomeEstado.Contains(textoBusca, StringComparison.InvariantCultureIgnoreCase));

            var buscaEmPrestadorServico = _easyParkContext.PrestadorServicos
                                                .Include(x => x.EstadoNavigation)
                .Include(x => x.PrestadorCriadorNavigation)
                                                .ToList()
               .FindAll(x => x.NomeServico.Contains(textoBusca, StringComparison.InvariantCultureIgnoreCase) || x.Endereco.Contains(textoBusca, StringComparison.InvariantCultureIgnoreCase) || x.EstadoNavigation.NomeEstado.Contains(textoBusca, StringComparison.InvariantCultureIgnoreCase) || x.NomeServico.Contains(textoBusca, StringComparison.InvariantCultureIgnoreCase));

                        var resultadoBuscaVitrine = new VitrineServicos();

            if (buscaEmPrestadorServico != null)
            {

                foreach (var selecionePrestador in buscaEmPrestadorServico)
                {
                    listPrestadorServicos.Add(new PrestadorServicoResponse()
                    {
                        Endereco = selecionePrestador.Endereco,
                        Estado = selecionePrestador.EstadoNavigation.NomeEstado,
                        HorarioFuncionamento = selecionePrestador.HorarioFuncionamento,
                        NomePrestador = selecionePrestador.NomePrestador,
                        NomeServico = selecionePrestador.NomeServico,
                        TelefonePrestador = selecionePrestador.TelefonePrestador,
                        NomeResponsavel = selecionePrestador.PrestadorCriadorNavigation.Nome
                    });
                }
            }

            resultadoBuscaVitrine.VitrinePrestadoresServicos = listPrestadorServicos;

            if (buscaEmEstacionamentos != null)
            {


                foreach (var selecioneEstacionamento in buscaEmEstacionamentos)
                {
                    listEstacionamentos.Add(new EstacionamentoResponse()
                    {
                        Endereco = selecioneEstacionamento.Endereco,
                        HorarioFuncionamento = selecioneEstacionamento.HorarioFuncionamento,
                        NomeEstacionamento = selecioneEstacionamento.NomeEstacionamento,
                        NomeEstado = selecioneEstacionamento.EstadoNavigation.NomeEstado,
                        Telefone = selecioneEstacionamento.Telefone,
                        TotaisVagas = selecioneEstacionamento.TotaisVagas,
                        VagasComuns = selecioneEstacionamento.VagasComuns,
                        VagasEletricas = selecioneEstacionamento.VagasEletricas,
                        VagasPreferenciais = selecioneEstacionamento.VagasPreferenciais,
                        NomeResponsavel = selecioneEstacionamento.UsuarioCriadorNavigation.Nome
                    });
                }
            }

            resultadoBuscaVitrine.VitrineEstacionamento = listEstacionamentos;
            quantidadeRegistros = buscaEmEstacionamentos.Count() + buscaEmPrestadorServico.Count();
            resultadoBuscaVitrine.BuscaQuantidadeRegistro = quantidadeRegistros;
            return resultadoBuscaVitrine;
        }
        //até aqui

    }
}
