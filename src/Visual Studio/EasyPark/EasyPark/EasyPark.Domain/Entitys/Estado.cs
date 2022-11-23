using System;
using System.Collections.Generic;

#nullable disable

namespace EasyPark.EasyPark.Domain.Entitys
{
    public partial class Estado
    {
        public Estado()
        {
            Estacionamentos = new HashSet<Estacionamento>();
            PrestadorServicos = new HashSet<PrestadorServico>();
        }

        public int EstadoId { get; set; }
        public string NomeEstado { get; set; }

        public virtual ICollection<Estacionamento> Estacionamentos { get; set; }
        public virtual ICollection<PrestadorServico> PrestadorServicos { get; set; }
    }
}
