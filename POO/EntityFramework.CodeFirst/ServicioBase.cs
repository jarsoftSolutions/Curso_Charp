using Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework.CodeFirst
{
   public class ServicioBase:DbContext
    {
        public ServicioBase():base("Data source=localhost;Initial Catalog=PruebEntityFramework;Integrated Security=true")
        {
            
        }

       public DbSet<Persona> Personas { get; set; }
    }
}
