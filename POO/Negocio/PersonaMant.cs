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
            AsignarDatos();
        }

        private void AsignarDatos()
        {

            this.ListadoPersonas.Add(new Persona()
            {
                Activo = true,
                Apellido = "Martinez",
                ColorPelo = "Negro",
                Edad = 29,
                EstadoCivil = "Soltero",
                FechaNacimiento = DateTime.Now.AddYears(-20),
                Nombre = "JOSE ANGEL"

            });
            this.ListadoPersonas.Add(new Persona()
            {
                Activo = true,
                Apellido = "SANCHEZ",
                ColorPelo = "Negro",
                Edad = 29,
                EstadoCivil = "Soltero",
                FechaNacimiento = DateTime.Now.AddYears(-20),
                Nombre = "LEON"

            });
            this.ListadoPersonas.Add(new Persona()
            {
                Activo = true,
                Apellido = "ROSARIO",
                ColorPelo = "Negro",
                Edad = 29,
                EstadoCivil = "Soltero",
                FechaNacimiento = DateTime.Now.AddYears(-20),
                Nombre = "RAMON"

            });
        }
    }
}
