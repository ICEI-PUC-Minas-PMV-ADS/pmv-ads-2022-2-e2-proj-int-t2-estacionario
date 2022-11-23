using EasyPark.EasyPark.Domain.Entitys;
using EasyPark.EasyPark.Domain.Requests;
using EasyPark.EasyPark.Domain.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EasyPark.EasyPark.Domain.Interface.Services
{
    public interface IEstacionamentoService
    {
        void AtualizarEstacionamento(EstacionamentoResponse estacionamentoResponse);
        void CriarEstacionamento(EstacionamentoRequest estacionamentoRequest);
        Task<EstacionamentoResponse> GeraEstacionamentoByIdAsync(int estacionamentoId);
        Task<List<EstacionamentoResponse>> GeraListaEstacionamento(int usuarioEmpresaCriador);
        Task<List<Estado>> ObterEstados();
        void RemoverEstacionamento(int estacionamentoId);
    }
}
