using EasyPark.EasyPark.Domain.Entitys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EasyPark.EasyPark.Domain.Interface.Repositorys
{
    public interface IPrestadorServicosRepository
    {
        void AtualizarServico(PrestadorServico prestadorServico);
        void CriaServicos(PrestadorServico prestadorServico);
        Task<List<PrestadorServico>> GerarServicos(int idUsuarioCriador);
        Task<PrestadorServico> GeraServicoById(int ServicoId);
        void RemoverServico(int ServicoId);
    }
}
