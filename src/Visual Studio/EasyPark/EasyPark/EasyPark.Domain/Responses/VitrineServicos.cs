using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EasyPark.EasyPark.Domain.Responses
{
    public class VitrineServicos
    {
        public List<PrestadorServicoResponse> VitrinePrestadoresServicos { get; set; }
        public List<EstacionamentoResponse> VitrineEstacionamento { get; set; }
        public int BuscaQuantidadeRegistro { get; set; }
    }
}
