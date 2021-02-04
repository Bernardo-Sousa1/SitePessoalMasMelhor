using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SitePessoalMasMelhor.Models
{
    public class ExpProfissional
    {
        public int ExpProfissionalId { get; set;}

        public string Empresa { get; set;}

        public string Funcao { get; set; }

        public string Detalhes { get; set;}

        [DataType(DataType.Date)]
        [Display(Name= "Data de inicio")]
        public DateTime Data { get; set;}
    }
}
