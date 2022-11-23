using EasyPark.EasyPark.Domain.Entitys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EasyPark.EasyPark.Domain.Requests
{
    public class BuscaRequest
    {
        public string Termo { get; set; }
        public string CampoBusca { get; set; }
                public string FiltroGuincho { get; set; }
        public string FiltroChaveiro { get; set; }
        public string FiltroLavaRapido { get; set; } 
        public int Estado { get; set; }
        public bool Guincho { get; set; }
        public bool Chaveiro { get; set; }
        public bool LavaRapido { get; set; }
        public bool Estacionamento { get; set; }
        public List<Estado> estados { get; set; }
    }
}
