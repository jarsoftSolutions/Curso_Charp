using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Environment;

namespace UsoDeControles.Clase01
{
    public class AccesFiles
    {
        private List<Archivo> ListadoArchivos { get; set; }


        public List<Archivo> GetArchivos()
        {
            //Pregunto si no existe la Lista de archivo
            if (ListadoArchivos == null)
            {
                // Si esta Null creo la la Lista
                ListadoArchivos = new List<Archivo>();
            }
            //Si ya tengo los Archivos no lo Busco de Nuevo
            //y Retorno la lista
            if (ListadoArchivos.Count > 0)
            {
                return ListadoArchivos;
            }
            // Obtener todos los Archivos de una Carpeta en Especifico
            var ListaFiles = Directory.GetFiles(GetFolderPath(SpecialFolder.MyDocuments));
            //Variable auxiliares
            string filename, extension;
            //Recorrer todos los Archivos otenidos
            foreach (var item in ListaFiles)
            {
                //la Variale Item contiene la ruta fisica completa del archivo

                //Obtener el Nombre del archivo sin la Extension
                filename = Path.GetFileNameWithoutExtension(item);
                //Obtener la Extesion del archivo
                extension = Path.GetExtension(item);
                //Agregar cada item a la Lista de archivos a retornar
                ListadoArchivos.Add(new Archivo(filename, extension, item));
            }
            //Retornar la lista de archivos obtenida
            return ListadoArchivos;
        }


    }
}
