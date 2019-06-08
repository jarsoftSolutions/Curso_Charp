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
         


        public string NombreCompleto
        {
            get
            {
                return Nombre + " " + Apellido; //$"{Nombre} {Apellido}";
            }
        }


        public PropiedadesPersona()
        {

        }
        public PropiedadesPersona(string nombre)
        {
            this.Nombre = nombre;
        }

        public PropiedadesPersona(string nombre, string apellido, int edad, string colorPelo, string estadoCivil) : this(nombre)
        {
            Apellido = apellido;
            Edad = edad;
            ColorPelo = colorPelo;
            EstadoCivil = estadoCivil;
        }
    }
}
