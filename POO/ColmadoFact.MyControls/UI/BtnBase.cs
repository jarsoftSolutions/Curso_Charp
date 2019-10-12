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
    [ToolboxItem(false)]
    public partial class BtnBase : Button
    {
        public BtnBase()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Esta propiedad Indica si el boton puede seguir ejecutandose
        /// </summary>
        public bool PuedeSeguir { get; set; }

        /// <summary>
        /// Evento que se ejecuta antes del hacer del Boton 
        /// </summary>
        public event  EventHandler HacerAntes;
        /// <summary>
        /// Evento que se Dispara luego de hacerAntes del boton
        /// </summary>
        public event EventHandler Hacer;
        /// <summary>
        /// Evento que se ejecuta despues del Click del boton
        /// </summary>
        public event EventHandler HacerDespues;


        public FormBase Formulario { get; set; }

        public BtnBase(IContainer container)
        {
            container.Add(this); 
            InitializeComponent();
          
        }
        protected override void OnClick(EventArgs e)
        {
            
            PuedeSeguir = true;
            DispararHacerAntes();
            if (!PuedeSeguir) return;
            DispararHacer();
            if (!PuedeSeguir) return;
            DispararDespues();

        }

       

        private void DispararHacerAntes()
        {
            if (HacerAntes == null) return;
            HacerAntes(this, null);
        }
       

        private void DispararHacer()
        {
            if (Hacer == null) return;
            Hacer(this, null);
        }

        private void DispararDespues()
        {
            if (HacerDespues == null) return;
            HacerDespues(this, null);
        }
    }
}
