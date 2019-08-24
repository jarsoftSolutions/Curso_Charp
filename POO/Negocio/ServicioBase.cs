using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
namespace Negocio
{
   public class ServicioBase:DbContext
    {
        public ServicioBase():base("Data source=localhost;Initial Catalog=CursoCsharp;Integrated Security=true")
        {

        }
      
        public DbSet<Pais> Pais { get; set; }
        public DbSet<Ciudad> Ciudad { get; set; }
    }
}
