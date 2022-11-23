using EasyPark.EasyPark.Domain.Requests;
using EasyPark.EasyPark.Domain.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EasyPark.EasyPark.Domain.Interface.Services
{
    public interface IClienteService
    {
        Task<VitrineServicos> BuscaServicosAsync(string servicoBuscado);
        Task<VitrineServicos> ExibirServicosVitrinePrincipalAsync(int totalRegistro);
        Task<VitrineServicos> FiltroBuscaGeral(BuscaRequest buscaRequest);
    }
}
