using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SitePessoalMasMelhor.Models
{
    public class FormAcademica
    {
        public int FormAcademicaId { get; set; }

        public string Instituição { get; set; }

        public string Nome { get; set; }

        public string Duração { get; set; }

        public string DataDeConclusão { get; set; }
    }
}
