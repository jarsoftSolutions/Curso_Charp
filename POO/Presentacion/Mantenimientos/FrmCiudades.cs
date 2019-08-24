using Negocio;
using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion.Mantenimientos
{
    public partial class FrmCiudades : Form
    {
        public Paises Pais { get; set; }
        public List<Pais> ListadoPais { get; set; }

        public Ciudades Ciudad { get; set; }


        public FrmCiudades()
        {
            InitializeComponent();
            //Creamos el Objetos de Paises del Proyecto Negocio
            Pais = new Paises();
            //Listamos todos los Paises  con el Metodo ListadoPaises
            ListadoPais = Pais.ListadoPaises();
            //Asignar el Listado al Combo para que lo presente
            CboPais.DataSource = ListadoPais;
            //Instanciamos la Clase Ciudad del proyecto Negocio
            Ciudad = new Ciudades();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            var Opais = CboPais.SelectedItem as Pais;
            if (Opais == null)
            {
                MessageBox.Show("Debe Seleccionar Un Pais", "Complete", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //Declaramos un Objeto para Insertar en la BD
            Ciudad Ociudad = new Ciudad()
            {
                Id = 0,
                ciudad = TxtCiudad.Text,
                IdPais = Opais.Id
            };
            //Preguntamos si se interto
            //if (Ciudad.Insertar(Ociudad))
            try
            {
                using (var api = new ServicioBase())
                {
                    api.Ciudad.Add(Ociudad);
                    
                    api.SaveChanges();
                }
            }
            catch (Exception ex)
            {

               
            }

            MessageBox.Show("La Ciudad Se ha Insertado Correctamente", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var Respuesta = MessageBox.Show("Seguro que desea Eliminar este Registro", "Confirmae", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (Respuesta== DialogResult.Yes)
            {
                MessageBox.Show("La Ciudad Se ha Eliminado Correctamente", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
    }
}
