using EasyPark.EasyPark.Domain.Entitys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EasyPark.EasyPark.Domain.Requests
{
    public class PrestadorServicosRequest
    {
        public string NomePrestador { get; set; }
        public string NomeServico { get; set; }
        public string HorarioFuncionamento { get; set; }
        public string TelefonePrestador { get; set; }
        public string Endereco { get; set; }
        public int EstadoAtuacao { get; set; }
        public int UsuarioPrestadorCriador { get; set; }
        public List<Estado> estados { get; set; }
    }
}
