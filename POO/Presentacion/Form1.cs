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


            //Persona Roberto = new Persona();
            //Roberto.Add("");
            ////Roberto.Edad = 30;
            ////Roberto.RecibeObjeto(Roberto);

            ////List<string> Nombres = new List<string>()
            ////{
            ////    "JOse Angel",
            ////    "Mancebo",
            ////    "David",

            ////};
            ////MessageBox.Show(Roberto.Saludar(Nombres));

            //List<string> Nombres;// Declar la Variable
            //var Nombres2=new List<string>();//Crear Variable e Instanciar
            //Nombres = new List<string>();
            //Nombres.Add("JOSE ANGEL");
            //List<decimal> Sueldos = new List<decimal>();

            //for (int i = 0; i < 9; i++)
            //{
            //    Sueldos.Add(30000*i);

            //}

            Singleton.saludar();

        }
    }
}
