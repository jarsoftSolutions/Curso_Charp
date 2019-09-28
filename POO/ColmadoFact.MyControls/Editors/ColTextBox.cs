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

        public ColTextBox(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }
}
