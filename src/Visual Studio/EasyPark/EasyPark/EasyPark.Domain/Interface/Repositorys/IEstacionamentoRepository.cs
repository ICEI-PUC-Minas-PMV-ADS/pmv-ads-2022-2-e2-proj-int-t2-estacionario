using EasyPark.EasyPark.Domain.Entitys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EasyPark.EasyPark.Domain.Interface.Repositorys
{
    public interface IEstacionamentoRepository
    {
        void AtualizarEstacionamento(Estacionamento estacionamento);
        void CriarEstacionamento(Estacionamento estacionamento);
        Task<Estacionamento> GeraEstacionamentoById(int estacionamentoId);
        Task<List<Estacionamento>> GeraListaEstacionamentos(int empresaIdCriador);
        void RemoverEstacionamento(int estacionamentoId);
    }
}
