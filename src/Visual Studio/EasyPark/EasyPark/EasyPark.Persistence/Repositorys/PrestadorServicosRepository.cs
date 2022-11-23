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
    public class PrestadorServicosRepository: IPrestadorServicosRepository
    {
        private readonly EasyParkContext _easyParkContext;

        public PrestadorServicosRepository(EasyParkContext easyParkContext)
        {
            _easyParkContext = easyParkContext;
        }

        

        public void AtualizarServico(PrestadorServico prestadorServico)
        {
            _easyParkContext.Entry(prestadorServico).State = EntityState.Modified;
                        _easyParkContext.SaveChanges();
        }

        public async Task<PrestadorServico> GeraServicoById(int ServicoId)
        {
            return _easyParkContext.PrestadorServicos.Where(x => x.PrestadorServicosId == ServicoId)
                .Include(x => x.EstadoNavigation)
                .FirstOrDefault();
        }

        public void RemoverServico(int ServicoId)
        {
            var selecionaServico = _easyParkContext.PrestadorServicos.FirstOrDefault(x => x.PrestadorServicosId == ServicoId);
            _easyParkContext.Remove(selecionaServico);
            _easyParkContext.SaveChanges();
        }

        public async Task<List<PrestadorServico>> GerarServicos(int idUsuarioCriador)
        {
            return _easyParkContext.PrestadorServicos.Where(x => x.PrestadorCriador == idUsuarioCriador)
                .Include(x => x.EstadoNavigation)
                .ToList();

        }

        public void CriaServicos(PrestadorServico prestadorServico)
        {
            _easyParkContext.PrestadorServicos.Add(prestadorServico);
            _easyParkContext.SaveChanges();
        }
    }
}
