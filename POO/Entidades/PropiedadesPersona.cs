using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
   public class PropiedadesPersona
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Edad { get; set; }
        public string ColorPelo { get; set; }
        public string EstadoCivil { get; set; }
        public bool Activo { get; set; }
        public string Cliente { get { return $"{Nombre} {Apellido}"; } }
        public DateTime FechaNacimiento { get; set; }

    }
}
