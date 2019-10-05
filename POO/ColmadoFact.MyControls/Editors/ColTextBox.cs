using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColmadoFact.MyControls.Editors
{
    [ToolboxItem(true)]
    public partial class ColTextBox : ColTexboxbase
    {
        public ColTextBox()
        {
            InitializeComponent();
        }

        public new string Text
        {
            get => base.Value;
            set => base.Text = value;
        }
        //public override string Text
        //{
        //    get => base.Value;
        //    set => base.Text = value;
        //}

        public ColTextBox(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }
}
