using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using SitePessoalMasMelhor.Models;

namespace SitePessoalMasMelhor.Data
{
    public class SitePessoalBdContext : DbContext
    {
        public SitePessoalBdContext(DbContextOptions<SitePessoalBdContext> options)
            : base(options)
        {
        }
        public DbSet<ExpProfissional>ExpProfissional { get; set; }
        public DbSet<FormAcademica> FormAcademica { get; set; }
        public DbSet<SitePessoalMasMelhor.Models.SobreMim> SobreMim { get; set; }
        public DbSet<SitePessoalMasMelhor.Models.Contacto> Contacto { get; set; }
    }
}
