
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
    using System.Drawing;
    using UI;
    [ToolboxItem(false)]
    public partial class ColTexboxbase : TextBox
    {
        public ColTexboxbase()
        {
            InitializeComponent();
        }
        public bool UsertDigited { get; set; }
        [Category("ColmadoFact"), Description("Obtiene o Establece el Nombre de la Columna de la Base de datos")]
        public string ControlSource { get; set; }
        [Category("ColmadoFact"), Description("Obtiene o Establece el valor intructivo para el usuario")]
        public string NullText
        {
            get => _nullText;
            set
            {
                _nullText = value;
                Text = value;
                SetDefaultProperty(false);
            }

        }
        /// <summary>
        /// Retorna el valor del objeto
        /// </summary>
        public string Value
        {
            get
            {
                return NullText == Text ? "" : Text;
            }
        }
        [Category("ColmadoFact"), Description("Obtiene o Establece si el valor en este textBox es Obligatorio")]
        public bool Requiered { get; set; }
        [Category("ColmadoFact"), Description("Obtiene o Establece se seleccionara el proximo Control al Presionar Enter")]
        public bool NextControlOnKeyEnter { get; set; }

        private FormBase formbase;
        private string _nullText;
     

        [Category("ColmadoFact"), Description("Obtiene o Establece el Formulario Padre de este Control")]
        public FormBase Formulario
        {
            // Retorna valor
            get => formbase ?? (FormBase)FindForm();
            // Setea/Establece/Asigna un valor
            set => formbase = value;
        }

        public ColTexboxbase(IContainer container)
        {
            container.Add(this);
            InitializeComponent();
            //this.KeyPress += (s, e) =>
            //{

            //};
        }
        protected override void OnKeyDown(KeyEventArgs e)
        {
            base.OnKeyDown(e);
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab)
            {
                UsertDigited = false;
                if (NextControlOnKeyEnter)
                {
                    Formulario.SelectNextControl(this, true, true, true, true);
                }
            }
            else
            {
                UsertDigited = true;
            }
        }
        protected override void OnLostFocus(EventArgs e)
        {
            base.OnLostFocus(e);
            if (NullText != null)
            {
                if (Value == null || Value.Trim() == string.Empty)
                {
                    Text = NullText;
                    SetDefaultProperty(false);
                }
            }
            else
            {
                SetDefaultProperty(true);
            }
        }

        //public override string Text
        //{
        //    get
        //    {
        //        return UsertDigited ? string.Empty : base.Text;
        //    }
        //    set
        //    {

        //        base.Text = value;

        //    }
        //}

        protected override void OnEnter(EventArgs e)
        {
            base.OnEnter(e);
            if (NullText != null)
            {
                //Text = string.Empty;
                if (Text == NullText)
                {
                    Text = string.Empty;
                }
                SetDefaultProperty(true);
            }
            //Cuando se Activa Selecciona Todo el Texto Del Control
            SelectAll();
        }
        /// <summary>
        /// Setea o establece las propiedasdes del Control
        /// </summary>
        /// <param name="setDefault">Si Es true es por que Se reestableceran las propiedades</param>
        public void SetDefaultProperty(bool setDefault)
        {
            if (setDefault)
            {
                ForeColor = SystemColors.ControlText;
            }
            else
            {
                ForeColor = Color.FromArgb(164, 157, 155);
            }
        }

    }
}
