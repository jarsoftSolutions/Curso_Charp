using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace Presentacion.Mantenimientos
{
    public partial class FrmPaises : Form
    {
        private Paises OPais { get; set; }

        public FrmPaises()
        {
            InitializeComponent();
            OPais = new Paises();
        }

        private void FrmPaises_Load(object sender, EventArgs e)
        {
            //MainViewModel Main = new MainViewModel();
            //if (Main.AbrirConexion())
            //    MessageBox.Show("Estamos Conectado a la Base de Datos", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //else
            //    MessageBox.Show("Ocurrio un error al Conectar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            //Paisdb opaises = new Paisdb()
            //{
            //    Id = 0,
            //    Pais = "Estados Unidos"
            //};
            //if (OPais.Guardar(opaises))
            //    MessageBox.Show("Registro Insertado Correctamente", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);

            var Listado = OPais.ListadoPaises();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Pais opaises = new Pais()
            {
                Id = 0,
                pais = txtPais.Text
            };
            var PaisGuardado = OPais.GuardarPais(opaises);
            if (PaisGuardado !=null)
            {
                txtId.Text = PaisGuardado.Id.ToString();
            }
        }
    }
}
