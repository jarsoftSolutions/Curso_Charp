using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Entidades
{
    public class Persona:PropiedadesPersona
    {

        public Persona()
        {
            this.CambiarNombre("Jose Angel","Ramirez");
        }

        public void CambiarNombre()
        {
            
        }
        /// <summary>
        ///  Metodo Sobrecargado con un Parametro
        /// </summary>
        /// <param name="nuevonombre"></param>
        public void CambiarNombre(string nuevonombre)
        {
            this.Nombre = nuevonombre;
        }

        public void Add(string v)
        {
           
        }

        /// <summary>
        /// Metodo Sobrecargado con 2 Parametros
        /// </summary>
        /// <param name="nuevonombre"></param>
        /// <param name="apellido"></param>
        public void CambiarNombre(string nuevonombre,string apellido)
        {
            this.CambiarNombre(nuevonombre);
            this.Apellido = apellido;
        }
        
        public string Saludar(string nombre)
        {
            
            return $"Hola {nombre}";
        }

        ///Listas

        public string Saludar(List<string> nombres)
        {
            string mensaje = "";
            //Recorrer la Lista mediante un For each
            foreach (string valor in nombres)
            {
                mensaje += $"Hola {valor}\n";
            }
            //Recorrer Las Lista mediante un for    
            for (int i = 0; i < nombres.Count; i++)
            {
                mensaje += $"Hola {nombres[i]}\n";
            }
            return $"{string.Format("{0}", string.Join("", nombres.Select(p => $"Hola {p}\n")))}";
        }


        ///LISTAR PERSONAS
        
        public string Saludar(List<Persona> personas)
        {
            string mensaje = "";
            //Recorrer la Lista mediante un For each
            foreach (Persona persona in personas)
            {
                mensaje += $"Hola {persona.Nombre}\n";
            }
            
            //Recorrer Las Lista mediante un for    
            for (int i = 0; i < personas.Count; i++)
            {
                mensaje += $"Hola {personas[i].Nombre}\n";
            }
            return $"{string.Format("{0}", string.Join("", personas.Select(p => $"Hola {p.Nombre}\n")))}";
        }


        public void RecibeObjeto(object objeto)
        {

        }




    }


}
