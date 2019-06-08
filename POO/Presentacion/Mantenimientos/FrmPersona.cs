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
    public partial class FrmPersona : Form
    {
        public FrmPersona()
        {
            InitializeComponent();
        }

        
         

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarControles();
        }

        private void LimpiarControles()
        {
            TxtNombre.Text = "";
            TxtApellido.Text = "";
            txtEdad.Text = "";
            CboEstadoCivil.SelectedIndex = -1;
            CoboColor.SelectedIndex = -1;

        }
    }
}
