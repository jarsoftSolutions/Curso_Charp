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
    public partial class BaseCheckBox : CheckBox
    {
        public BaseCheckBox()
        {
            InitializeComponent();
        }

        public BaseCheckBox(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }


        protected override void OnCheckedChanged(EventArgs e)
        {
             base.OnCheckedChanged(e);
            if (Checked)
            {
                this.FindForm().Text = "Esto es un formulario";
            }
            

        }
    }
}
