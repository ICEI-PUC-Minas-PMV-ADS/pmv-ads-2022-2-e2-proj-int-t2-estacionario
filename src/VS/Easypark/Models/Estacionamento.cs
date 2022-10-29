using System;

namespace Easypark.Models
{
    public class Estacionamento
    {
        [key]
        public int codigoEstacionamento { get; set; }

        [ForeignKey]
        public int clienteId { get; set; }

        public string nomeEstacionamento { get; set; }
        public string CNPJ { get; set; }

        public EnderecoModel endereco { get; set; }
        public bool lavaJato { get; set; } = false;
        public VagaModel vaga { get; set; }
        public VagaModel vagaDeficiente { get; set; }
        public VagaModel vagaCarroEletrico { get; set; }
        public VagaModel vagaIdoso { get; set; }
        public VagaModel vagaRegular { get; set; }

        public class VagaModel{

            public int vagasTotal;
            public int vagasLivre;
        }

        public void CadastrarLavaJato()
        {
            lavaJato = true;
        }

    }
}
