using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
namespace Easypark.Models
{
        public class VagaModel{
            [Key]
            public int codigoVagasDisponiveis {get; set;}
            //[ForeignKey]
            public int codigoEstacionamento { get; set; }
            public int vagasTotal;
            public int vagasLivre;
        }
}