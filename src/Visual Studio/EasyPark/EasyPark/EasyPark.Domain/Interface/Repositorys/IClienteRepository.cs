using EasyPark.EasyPark.Domain.Entitys;
using EasyPark.EasyPark.Domain.Requests;
using EasyPark.EasyPark.Domain.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EasyPark.EasyPark.Domain.Interface.Repositorys
{
    public interface IClienteRepository
    {
        Task<VitrineServicos> BuscarServicosVitrine(string textoBusca);
        Task<List<EstacionamentoResponse>> FiltroBuscarServicosVitrineEstacionamento(BuscaRequest buscaRequest);
        Task<List<PrestadorServicoResponse>> FiltroBuscarServicosVitrinePrestadorServico(BuscaRequest buscaRequest);
        Task<List<Estacionamento>> ObtemListaGeralEstacionamentosAsync(int quantidadeServicos);
        Task<List<PrestadorServico>> ObtemListaGeralPrestadorServicosAsync(int quantidadePrestadorServicos);
    }
}
