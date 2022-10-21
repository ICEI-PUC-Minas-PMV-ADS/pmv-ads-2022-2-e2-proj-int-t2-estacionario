using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Easypark.Models
{
    [Table("Vagas")]
    public class Vaga
    {
        [Key]
        public int codVaga { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o tipo de vaga!")]
        [Display(Name = "Tipo da Vaga")]
        public string tipoVaga { get; set; }

        [Required(ErrorMessage = "Obrigatório informar se a vaga está ocupada!")]
        [Display(Name = "Vaga Ocupada?")]
        public ocupacao preenchido { get; set; }

        [Display(Name = "Cliente Número")]
        public int cliente_id { get; set; }
        [ForeignKey("cliente_id")]
        public Cliente Cliente { get; set; }
    }

    public enum ocupacao
    { 
        Sim,
        Não
    }
}