using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    using Entidades;

   public class PersonaMant
    {
        public List<Persona> ListadoPersonas { get; set; }

        public bool Agregar(Persona persona)
        {
            bool Result = true;
            this.ListadoPersonas.Add(persona);
            return Result;    
        }

        /// <summary>
        /// Constructor de Personas Mant
        /// </summary>
        public PersonaMant()
        {
            this.ListadoPersonas = new List<Persona>();
        }

    }
}
