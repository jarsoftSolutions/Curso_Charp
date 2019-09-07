using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColmadoFact.Models
{
   public class Marca
    {
        public int Id { get; set; }
        [MaxLength(100)]
        public string Descripcion { get; set; }

        public Marca()
        { 
            
        }
    }
}
