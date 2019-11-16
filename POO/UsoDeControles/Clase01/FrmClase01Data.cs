using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UsoDeControles.Clase01
{
    public partial class FrmClase01Data : Form
    {
        public FrmClase01Data()
        {
            InitializeComponent();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            var Opersona = new Persona()
            {
                Id = 1,
                Apellido = "Heramandez",
                Nombre = "JOSE ANGEL",
                Telefono = "809-844-8940",
                Direccion = "Calle Eustaquia de Jesus No. 19",
                Email = "Joseangelramirezo2@gmail.com"
            };
            DataManager dataManager = new DataManager();
            dataManager.RegistrarPersona(Opersona);

        }
    }
}
