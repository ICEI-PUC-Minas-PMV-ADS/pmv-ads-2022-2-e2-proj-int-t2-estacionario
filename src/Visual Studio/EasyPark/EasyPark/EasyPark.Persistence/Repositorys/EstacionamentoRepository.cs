using EasyPark.EasyPark.Domain.Entitys;
using EasyPark.EasyPark.Domain.Interface.Repositorys;
using EasyPark.EasyPark.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EasyPark.EasyPark.Persistence.Repositorys
{
    public class EstacionamentoRepository: IEstacionamentoRepository
    {
        private readonly EasyParkContext _easyParkContext;

        public EstacionamentoRepository(EasyParkContext easyParkContext)
        {
            _easyParkContext = easyParkContext;
        }

        public void RemoverEstacionamento(int estacionamentoId)
        {
            var selecioneEstacionamento = _easyParkContext.Estacionamentos.Where(x => x.EstacionamentoId == estacionamentoId).FirstOrDefault();
            _easyParkContext.Remove(selecioneEstacionamento);
            _easyParkContext.SaveChanges();
        }

        public void AtualizarEstacionamento(Estacionamento estacionamento)
        {
            _easyParkContext.Entry(estacionamento).State = EntityState.Modified;
            _easyParkContext.SaveChanges();
        }


        public void CriarEstacionamento(Estacionamento estacionamento)
        {
            _easyParkContext.Estacionamentos.Add(estacionamento);
            _easyParkContext.SaveChanges();
        }

        public async Task<Estacionamento> GeraEstacionamentoById(int estacionamentoId)
        {
            return _easyParkContext.Estacionamentos.Where(x => x.EstacionamentoId == estacionamentoId)
                .Include(x => x.EstadoNavigation)
                .FirstOrDefault();
        }

        public async Task<List<Estacionamento>> GeraListaEstacionamentos(int empresaIdCriador)
        {
            return _easyParkContext.Estacionamentos.Where(x => x.UsuarioCriador == empresaIdCriador)
                .Include(x => x.EstadoNavigation)
                .ToList();
        }
    }
}
