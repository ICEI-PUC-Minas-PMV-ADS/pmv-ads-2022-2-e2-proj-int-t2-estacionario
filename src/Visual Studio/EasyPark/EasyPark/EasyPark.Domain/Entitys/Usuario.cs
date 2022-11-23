using System;
using System.Collections.Generic;

#nullable disable

namespace EasyPark.EasyPark.Domain.Entitys
{
    public partial class Usuario
    {
        public Usuario()
        {
            Estacionamentos = new HashSet<Estacionamento>();
            PrestadorServicos = new HashSet<PrestadorServico>();
        }

        public int UsuarioId { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public int NivelAcesso { get; set; }

        public virtual ICollection<Estacionamento> Estacionamentos { get; set; }
        public virtual ICollection<PrestadorServico> PrestadorServicos { get; set; }
    }
}
