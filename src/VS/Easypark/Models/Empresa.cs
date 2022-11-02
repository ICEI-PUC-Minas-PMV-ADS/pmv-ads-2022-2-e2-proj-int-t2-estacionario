using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Easypark.Models
{
    [Table("Empresas")]
    public class Empresa
    {
        [Key]
        public int CNPJ { get; set; }

        [Display(Name ="Nome da Empresa")]
        [Required(ErrorMessage ="Obrigatório informar o Nome da Empresa!")]
        public string Nome_Empresa { get; set; }

        [Required(ErrorMessage = "Obrigatório informar a cidade!")]
        public string Cidade { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o bairro!")]
        public string Bairro { get; set; }

        [Display(Name ="Endereço")]
        [Required(ErrorMessage = "Obrigatório informar a rua e o número!")]
        public string Endereco { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o telefone!")]
        public int Telefone { get; set; }
    }
}
