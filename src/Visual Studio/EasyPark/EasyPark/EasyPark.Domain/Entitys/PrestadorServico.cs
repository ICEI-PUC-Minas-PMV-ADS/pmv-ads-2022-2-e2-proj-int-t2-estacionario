using System;
using System.Collections.Generic;

#nullable disable

namespace EasyPark.EasyPark.Domain.Entitys
{
    public partial class PrestadorServico
    {
        public int PrestadorServicosId { get; set; }
        public string NomePrestador { get; set; }
        public string NomeServico { get; set; }
        public string HorarioFuncionamento { get; set; }
        public string TelefonePrestador { get; set; }
        public string Endereco { get; set; }
        public int Estado { get; set; }
        public int PrestadorCriador { get; set; }

        public virtual Estado EstadoNavigation { get; set; }
        public virtual Usuario PrestadorCriadorNavigation { get; set; }
    }
}
