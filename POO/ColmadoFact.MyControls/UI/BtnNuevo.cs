using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColmadoFact.MyControls.UI
{
    public partial class BtnNuevo : BtnBase
    {
        public BtnNuevo()
        {
            InitializeComponent();
        }

        public BtnNuevo(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        protected override void OnClick(EventArgs e)
        {
            base.OnClick(e);
            var formulario = Formulario ?? FindForm() as FormBase;
            formulario.Limpiar();
            formulario.EsNuevo = true;
        }
    }
}
