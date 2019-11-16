using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsoDeControles.Clase01
{
    public class DataManager
    {
        public const string NOMBRE_BD = "datosPersona.data";
        public const string HEADER_BD = "ID|NOMBRE|APELLIDO|TELEFONO|DIRECCION|EMAIL";
        public const string PIPE_BD = "|";

        private List<Persona> personas;

        public List<Persona> Personas
        {
            get { return personas; }
            set { personas = value; }
        }

        public DataManager()
        {
            Personas = new List<Persona>();
        }

        /// <summary>
        /// Crea la Base datos local
        /// </summary>
        private void CrearBD()
        {
            //Si no Existe el archivo los Creamos
            if (!File.Exists("datosPersona.data"))
            {
                File.Create(NOMBRE_BD);
            }
        }
        public bool RegistrarPersona(Persona persona)
        {
            //crear la Base de datos si no existe
          //  CrearBD();
            //Aberiguar si tiene registros en la BD
            bool tienedatos = TieneDatos();
            //Si No existe en la Lista
            var PersonaLista = Personas.FirstOrDefault(p => p.Id == persona.Id);
            //Si no Existe la Agrego como Nueva
            if (PersonaLista ==null)
            {
                Personas.Add(persona);
                PersonaLista = persona;
            }
            else
            {
                PersonaLista.Id = persona.Id;
                PersonaLista.Nombre = persona.Nombre;
                PersonaLista.Apellido = persona.Apellido;
                PersonaLista.Telefono = persona.Telefono;
                PersonaLista.Direccion = persona.Direccion;
                PersonaLista.Email = persona.Email;
            }

            //procesamos el Insert a la base de datos
            using (var escr = new StreamWriter(NOMBRE_BD,true))//el True para que mantenga la info
            {
                //Si no tiene datos entonces Escribo el Header
                if (!tienedatos)
                {
                    escr.WriteLine(HEADER_BD);
                }
                string data = $"{PersonaLista.Id}{PIPE_BD}{PersonaLista.Nombre}{PIPE_BD}{PersonaLista.Apellido}{PIPE_BD}{PersonaLista.Telefono}{PIPE_BD}{PersonaLista.Direccion}{PIPE_BD}{PersonaLista.Email}";
                escr.WriteLine(data);
            }
            return true;
        }



        /// <summary>
        /// Retorna True O False si existen O NO registros
        /// </summary>
        /// <returns></returns>
        private bool TieneDatos()
        {
            //Si no existe
            if (!File.Exists(NOMBRE_BD))
            {
                return false;
            }
            using (var lect = new StreamReader(NOMBRE_BD))
            {
                //Leer todo lo que tenga el Archivo
                var data = lect.ReadToEnd();
                //Si tiene Datos retorna Tue
                if (data !=null && data.Length>0)
                {
                    return true;
                }
                //Falso Cuando No tiene
                return false;
            }
        }

    }
}
