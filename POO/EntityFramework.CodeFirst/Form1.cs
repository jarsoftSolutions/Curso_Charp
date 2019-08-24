using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntityFramework.CodeFirst
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            using (var serv=new ServicioBase())
            {
                serv.Personas.Remove(new Entidades.Persona() { Id=1 });
                serv.SaveChanges();
                var todasPersonas = serv.Personas.ToList();
            }
        }
    }
}
