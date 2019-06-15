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
    using Entidades;
    using Negocio;

    public partial class FrmPersona : Form
    {
       private PersonaMant Mant { get; set; }

        public FrmPersona()
        {
            InitializeComponent();
            Mant = new PersonaMant();
        }

        
         

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarControles();
        }

        private void LimpiarControles()
        {
            TxtNombre.Text = string.Empty;
            TxtApellido.Text = "";
            txtEdad.Text = "";
            CboEstadoCivil.SelectedIndex = -1;
            CoboColor.SelectedIndex = -1;
            chkActivo.Checked = false;

        }

        private void FrmPersona_Load(object sender, EventArgs e)
        {

        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            Persona persona = new Persona()
            {
                Activo = chkActivo.Checked,
                Apellido = TxtApellido.Text,
                ColorPelo = CoboColor.Text.ToString(),
                Edad = Convert.ToInt32(txtEdad.Text),
                EstadoCivil = CboEstadoCivil.Text.ToString(),
                FechaNacimiento = TxtFechaNac.Value,
                Nombre = TxtNombre.Text
            };
            Mant.Agregar(persona);
            LimpiarControles();
        }
    }
}
