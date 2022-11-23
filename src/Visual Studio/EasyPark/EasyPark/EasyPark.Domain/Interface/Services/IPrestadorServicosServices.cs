using EasyPark.EasyPark.Domain.Entitys;
using EasyPark.EasyPark.Domain.Requests;
using EasyPark.EasyPark.Domain.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EasyPark.EasyPark.Domain.Interface.Services
{
    public interface IPrestadorServicosServices
    {
        void AtualizarServico(PrestadorServicoResponse prestadorServicoResponse);
        void CriarServicos(PrestadorServicosRequest prestadorServicosRequest);
        Task<List<PrestadorServicoResponse>> GeraServicos(int usuarioIdCriador);
        Task<PrestadorServicoResponse> GeraServicoViaId(int servicoId);
        Task<List<Estado>> ObterEstados();
        void RemoverServico(int servicoId);
    }
}
