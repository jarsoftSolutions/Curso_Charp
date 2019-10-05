using ColmadoFact.MyControls.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ColmadoFact
{
    public partial class Form1 : FormBase
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            colTextBox1.Text = "Hola de Nuevo ";
            colTextBox1.SetDefaultProperty(true);
            MessageBox.Show(colTextBox1.Text);
        }
    }
}
