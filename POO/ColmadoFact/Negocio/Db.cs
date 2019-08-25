using ColmadoFact.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColmadoFact.Negocio
{
    public class Db : DbContext
    {

        public Db() : base("Data Source=.;initial catalog=ColmadoFact;integrated security=true; ")
        {

        }

        public DbSet<Categoria> Categorias { get; set; }

    }
}
