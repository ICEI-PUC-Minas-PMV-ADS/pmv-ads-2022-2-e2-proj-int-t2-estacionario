using EasyPark.EasyPark.Domain.Entitys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EasyPark.EasyPark.Domain.Responses
{
    public class PrestadorServicoResponse
    {
        public int PrestadorServicosId { get; set; }
        public string NomePrestador { get; set; }
        public string NomeServico { get; set; }
        public string HorarioFuncionamento { get; set; }
        public string TelefonePrestador { get; set; }
        public string Endereco { get; set; }
        public string Estado { get; set; }
        public int EstadoId { get; set; }
        public int PrestadorCriador { get; set; }
        public string NomeResponsavel { get; set; }
public List<Estado> estados { get; set; }

    }
}
