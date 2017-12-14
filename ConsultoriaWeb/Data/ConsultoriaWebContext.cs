using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ConsultoriaWeb.Models
{
    public class ConsultoriaWebContext : DbContext
    {
        public ConsultoriaWebContext (DbContextOptions<ConsultoriaWebContext> options)
            : base(options)
        {
        }

        public DbSet<ConsultoriaWeb.Models.Movie> Movie { get; set; }
    }
}
