using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsoDeControles.Clase01
{
  public  class Archivo
    {
        
        /// <summary>
        /// Obtiene o establece el Nombre fisico del Archivo
        /// </summary>
        public string FileName { get; set; }
        /// <summary>
        /// Obtiene o Establece La extension den archivo
        /// </summary>
        public string Extension { get; set; }
        /// <summary>
        /// Obtien o establece la Ruta del Archivo
        /// </summary>
        public string Path { get; set; }

        public Archivo(string fileName, string extension, string path)
        {
            FileName = fileName;
            Extension = extension;
            Path = path;
        }
    }
}
