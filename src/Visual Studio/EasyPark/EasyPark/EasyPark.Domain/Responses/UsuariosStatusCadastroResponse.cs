using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EasyPark.EasyPark.Domain.Responses
{
    public class UsuariosStatusCadastroResponse
    {
        public bool CadastroExiste { get; set; }
        public bool ContaCriada { get; set; }

    }
}
