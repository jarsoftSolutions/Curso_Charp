using ColmadoFact.Models;
using ColmadoFact.Negocio;
using System;
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
    public partial class frmListadoProducto : Form
    {
        public frmListadoProducto()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        public  class obj
        {
          public  string Descripcion ;
            public int Id  ;
            public decimal Precio  ;
            public decimal PrecioLimite  ;
            public string Referencia ;
            public string Categoria  ;
        }
        public void MostrarProductos()
        {
            var variable = 5;
            var otra = variable;

            using (var db = new Db())
            {
                 
                var Product = db.Productos
                                           .Select(
                                            p => new
                                            {
                                                p.Descripcion,
                                                p.Id,
                                                p.Precio,
                                                p.PrecioLimite,
                                                p.Referencia,
                                                Categoria = p.Categoria == null ? "" : p.Categoria.Descripcion
                                            }).ToList();
                dataGridView1.DataSource = Product.ToList();
            }
        }
        private void BtnRegistrarProducto_Click(object sender, EventArgs e)
        {
            var form = new FrmProducto()
            {
                StartPosition = FormStartPosition.CenterScreen,
                EsNuevo = true,
                Main=this,
            };
            form.ShowDialog(this);
        }

        private void frmListadoProducto_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = false;
            MostrarProductos();
        }
    }
}
