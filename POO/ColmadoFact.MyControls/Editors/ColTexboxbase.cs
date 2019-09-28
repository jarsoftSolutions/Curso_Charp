
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ColmadoFact.MyControls.Editors
{
    using UI;
    [ToolboxItem(false)]
    public partial class ColTexboxbase : TextBox
    {
        public ColTexboxbase()
        {
            InitializeComponent();
        }
        [Category("ColmadoFact"),Description("Obtiene o Establece el Nombre de la Columna de la Base de datos")]
        public string ControlSource { get; set; }
        [Category("ColmadoFact"), Description("Obtiene o Establece el valor intructivo para el usuario")]
        public string NullText { get; set; }
        [Category("ColmadoFact"), Description("Obtiene o Establece si el valor en este textBox es Obligatorio")]
        public bool Requiered { get; set; }
        [Category("ColmadoFact"), Description("Obtiene o Establece se seleccionara el proximo Control al Presionar Enter")]
        public bool NextControlOnKeyEnter { get; set; }

        private FormBase formbase;

        [Category("ColmadoFact"), Description("Obtiene o Establece el Formulario Padre de este Control")]
        public FormBase Formulario
        {
            get => formbase ?? (FormBase)FindForm();
            set => formbase = value;
        }

        public ColTexboxbase(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

    }
}
