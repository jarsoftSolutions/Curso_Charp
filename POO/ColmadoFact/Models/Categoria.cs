using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColmadoFact.Models
{
   public class Categoria 
    {
        public int Id { get; set; }
        [MaxLength(100,ErrorMessage ="El Maximo de Caracteres son 100")]
        [MinLength(2,ErrorMessage ="Debe Tener al Menos 2 Caracteres")]
        public string Descripcion { get; set; }
        public bool Activa { get; set; }

         
    }
}
