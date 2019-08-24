using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    [Table("Ciudades")]
    public class Ciudad
    {
        public int Id { get; set; }
        public int IdPais { get; set; }
        public string ciudad { get; set; }
    }
}
