using EasyPark.EasyPark.Domain.Entitys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EasyPark.EasyPark.Domain.Requests
{
    public class EstacionamentoRequest
    {
        public int EstacionamentoId { get; set; }
        public string NomeEstacionamento { get; set; }
        public string Endereco { get; set; }
        public string NomeFuncionamento { get; set; }
        public string HorarioFuncionamento { get; set; }
        public int EstadoAtuacao { get; set; }
        public string Telefone { get; set; }
        public int TotaisVagas { get; set; }
        public int VagasEletricas { get; set; }
        public int VagasPreferenciais { get; set; }
        public int  VagasComuns { get; set; }
        public int UsuarioEmpresaCriador { get; set; }
public List<Estado> estados { get; set; }
    }
}
