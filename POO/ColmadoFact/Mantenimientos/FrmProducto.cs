﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ColmadoFact.Mantenimientos
{
    public partial class FrmProducto : Form
    {
        public bool EsNuevo { get; set; }
        public frmListadoProducto Main { get;  set; }

        public FrmProducto()
        {
            InitializeComponent();
           
        }

        private void FrmProducto_Load(object sender, EventArgs e)
        {
            
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            this.LimpiarMyControls();
        }
    }
}
