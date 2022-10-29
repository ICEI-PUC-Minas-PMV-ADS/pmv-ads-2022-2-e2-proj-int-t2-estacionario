using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
namespace Easypark.Models
{

        public class EnderecoModel{
            [Key]
            public int codigoEstacionamento { get; set; }
            public string nomeLogradouro { get; set; }
            public int numero { get; set; }
            public string nomeBairro { get; set; }
            public string nomeCidade { get; set; }
            public string nomeEstado { get; set; }
        }
}