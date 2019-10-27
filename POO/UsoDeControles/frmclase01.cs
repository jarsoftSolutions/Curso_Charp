using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UsoDeControles.Clase01;

namespace UsoDeControles
{
    public partial class frmclase01 : Form
    {
        public frmclase01()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Crear el Objeto de la clase accesFile
            AccesFiles cls01 = new AccesFiles();
            //Obtener la Lista de los Archivos
            var ArchivosLista = cls01.GetArchivos();
            //Recorrer los archivos Otenidos
            foreach (var arcivo in ArchivosLista)
            {
                //Preparar un arreglo por cuantas columnas tengo
                var array = new string[3]{arcivo.FileName,arcivo.Path,arcivo.Extension  };
                //Declarar el item te tipo ListViewItem para agregar al listato
                ListViewItem item = new ListViewItem(array);
                //En el tag agrego el archivo de tipo Archivo.
                item.Tag = arcivo;
                //Agrego dico item a la Lista.
                listView1.Items.Add(item);
            }
        }

        private void listView1_ItemActivate(object sender, EventArgs e)
        {
            var currentItem = listView1.FocusedItem.Tag as Archivo;
            Process.Start(currentItem.Path);

        }
    }
}
