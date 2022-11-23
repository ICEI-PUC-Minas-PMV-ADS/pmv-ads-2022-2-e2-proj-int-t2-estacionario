using System;
using System.Collections.Generic;

#nullable disable

namespace EasyPark.EasyPark.Domain.Entitys
{
    public partial class Estacionamento
    {
        public int EstacionamentoId { get; set; }
        public string NomeEstacionamento { get; set; }
        public string HorarioFuncionamento { get; set; }
        public string Endereco { get; set; }
        public int Estado { get; set; }
        public string Telefone { get; set; }
        public int TotaisVagas { get; set; }
        public int VagasEletricas { get; set; }
        public int VagasPreferenciais { get; set; }
        public int VagasComuns { get; set; }
        public int UsuarioCriador { get; set; }

        public virtual Estado EstadoNavigation { get; set; }
        public virtual Usuario UsuarioCriadorNavigation { get; set; }
    }
}
