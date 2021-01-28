using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SitePessoalMasMelhor.Models
{
    public class Contacto
    {
        public int ContactoId { get; set; }

        public string Nome { get; set; }

        public string Email { get; set; }

        public string Mensagem { get; set; }
    }
}
