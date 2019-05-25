using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    using Entidades;

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
     
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Persona david = new Persona();
            david.Nombre = "David";
            david.Edad = 30;

            Persona Roberto = new Persona("Roberto");
            Roberto.Edad = 30;
            

        }
    }
}
