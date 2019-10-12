using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColmadoFact.MyControls.UI
{
    public partial class BtnLimpiar : BtnBase
    {
        public BtnLimpiar()
        {
            InitializeComponent();
        }

        public BtnLimpiar(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        protected override void OnClick(EventArgs e)
        {
            base.OnClick(e);
            var form = Formulario ?? FindForm() as FormBase;
            form.Limpiar();
        }

    }
}
