using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Easypark.Models
{
    [Table("Clientes")]
    public class Cliente
    {
        [Key]
        public int cliente_id { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o nome!")]
        [Display(Name = "Nome")]
        public string nome { get; set; }
        
        [Required(ErrorMessage = "Obrigatório informar o tipo do carro!")]
        [Display(Name = "Tipo do Carro")]
        public string tipoCarro { get; set; }

        [Display(Name = "Modelo do Carro")]        
        public string modeloCarro { get; set; }

        [Required(ErrorMessage = "Obrigatório informar a placa do carro!")]
        [Display(Name = "Placa do Carro")]
        public string placaCarro { get; set; }
        
        //[ForeignKey]
        public int CNPJ { get; set; }
        //[ForeignKey]
        public int CPF { get; set; }
    }
}
