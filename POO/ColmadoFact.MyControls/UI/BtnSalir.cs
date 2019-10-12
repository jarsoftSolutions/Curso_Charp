using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColmadoFact.MyControls.UI
{
    [ToolboxItem(true)]
    public partial class BtnSalir : BtnBase
    {
        public BtnSalir()
        {
            InitializeComponent();
        }

        public BtnSalir(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
        protected override void OnClick(EventArgs e)
        {
            base.OnClick(e);
            // EN este codigo todas las evaluaciones es la misma.
            //equivale a la primera


            /// 1
             var elForm = Formulario ?? FindForm();
            /// 2
            // var elForm = Formulario==null?FindForm():Formulario;

            /// 3
            //FormBase elForm = null;
            //if (Formulario == null)
            //{
            //    elForm = FindForm() as FormBase;
            //}
            //else
            //{
            //    elForm = Formulario;
            //}

            /// 4
            //if (Formulario == null)
            //    elForm = FindForm() as FormBase;
            //else
            //    elForm = Formulario;


            if (elForm !=null)
            {
                //Cierra el Formulacio
                elForm.Close();
            }
            ///Si no esta Null cierra tamien el Formulario
            // elForm?.Close();
            //var algo = elForm?.ControlBox;
            //if (algo ==null)
            //{

            //}
        }
    }
}
