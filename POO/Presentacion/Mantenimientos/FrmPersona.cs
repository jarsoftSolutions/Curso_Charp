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

        private bool Validar()
        {
            //Limpia los Errores de todos los controles
            ControlErrores.Clear();

            if (TxtNombre.Text.Trim()==string.Empty)
            {
                //Le Establece el error al Control que estamos Validando
                ControlErrores.SetError(TxtNombre, "El Nombre es un Campo Obligatorio");   
                //MessageBox.Show("El Nombre es un Campo Obligatorio");
                return false;
            }
            if (TxtApellido.Text.Trim() == string.Empty)
            {
                //Le Establece el error al Control que estamos Validando
                ControlErrores.SetError(TxtApellido, "El Apellido es un Campo Obligatorio");
                //MessageBox.Show("El Apellido es un Campo Obligatorio");
                return false;
            }

            return true;
        }
        private void LimpiarControles()
        {
            TxtNombre.Text = string.Empty;
            TxtApellido.Text = "";
            txtEdad.Text = "0";
            CboEstadoCivil.SelectedIndex = -1;
            CoboColor.SelectedIndex = -1;
            chkActivo.Checked = false;

        }

        private void FrmPersona_Load(object sender, EventArgs e)
        {
            this.DtListado.AutoGenerateColumns = false;
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (!Validar())//Si existen errores no Continua el Programa
            {
                return;
            }
            
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
            DtListado.DataSource = null;
            DtListado.DataSource = Mant.ListadoPersonas;
        }

        private void TxtFechaNac_ValueChanged(object sender, EventArgs e)
        {
             
            var valor = (DateTime.Now - TxtFechaNac.Value).TotalDays / 365;
            txtEdad.Text =string.Format("{0:N0}", valor);

        }
    }
}
