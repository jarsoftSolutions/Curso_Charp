using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ColmadoFact.MyControls.UI
{
    [ToolboxItem(true)]
    public partial class BtnGrabar : BtnBase
    {
        public BtnGrabar()
        {
            InitializeComponent();
        }

        public BtnGrabar(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
            this.HacerAntes += (s, e) =>
            {
                MessageBox.Show("Este es un mensaje del Boton grabar");
            };
          
        }
        //protected override void OnClick(EventArgs e)
        //{
        //   base.OnClick(e);

        //    PuedeSeguir = true;
        //    //Se manda a Ejecutar el HacerAntes
        //    this.HacerAntes += (s, j) =>
        //    {
        //        hacerAntesClick(s,j);
        //    };
        //    //Si no puede Seguir Sale del evento y no sigue ejecutando
        //    if (!PuedeSeguir) return;

        //   // Hacer(this, null);

        //    //Si no puede Seguir Sale del evento y no sigue ejecutando
        //    if (!PuedeSeguir) return;

        //    //HacerDespues(this, null);
        //}

 
    }
}
