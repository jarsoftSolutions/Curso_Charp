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
    public partial class FrmAsync : Form
    {
        public FrmAsync()
        {
            InitializeComponent();
        }

        private    void button1_Click(object sender, EventArgs e)
        {
             Task mtarea = new Task(Tarea);
             mtarea.Start();
            //Tarea();
        }
       public async   void Tarea()
        {
            for (int i = 0; i <= 2; i++)
            {
                Console.Write(i);
                await Task.Delay(10000);

            }
            MessageBox.Show("Proceso Concluido");
        }
    }
}
