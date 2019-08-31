using ColmadoFact.Models;
using ColmadoFact.Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ColmadoFact.Mantenimientos
{
    public partial class FrmCategorias : Form
    {

        public FrmCategorias()
        {
            InitializeComponent();
        }

        private void Limpiar()
        {
            TxtDescripcion.Text = String.Empty;
            TxtId.Text = string.Empty;
            ChkActivo.Checked = false;
        }
        private void MostrarItem(Categoria categoria)
        {
            if (categoria ==null)
            {
                return;
            }
            TxtId.Enabled = false;
            TxtDescripcion.Text = categoria.Descripcion;
            TxtId.Text = categoria.Id.ToString();
            ChkActivo.Checked = categoria.Activa;
            BtnGuardar.Enabled = true;
            BtnEliminar.Enabled = true;
        }


        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btnnuevo_Click(object sender, EventArgs e)
        {
            //Limpiar todo los datos
            Limpiar();
            TxtId.Enabled = false;
            //Habilitar el Guardado
            BtnGuardar.Enabled = true;
            //Desabilitar el Eliminar
            BtnEliminar.Enabled = false;
            //Llevar el Usuario a la Digitacion
            TxtDescripcion.Focus();

        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                var categoria = new Categoria();
                categoria.Descripcion = TxtDescripcion.Text;
                categoria.Activa = ChkActivo.Checked;

                if (!(TxtId.Text.Trim() == string.Empty))
                {
                    categoria.Id = Convert.ToInt32(TxtId.Text);

                }

                using (var db = new Db())
                {
                    if (categoria.Id == 0)
                        db.Categorias.Add(categoria);
                    else
                        db.Entry(categoria).State = EntityState.Modified;

                    if (db.SaveChanges() != 0)
                    {
                        MessageBox.Show("Registro Guardado Exitosamente", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        BtnEliminar.Enabled = false;
                        BtnGuardar.Enabled = false;
                        Limpiar();
                        MostrarDatos();
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void Eliminar(Categoria categoria)
        {
            using (var db = new Db())
            {
                db.Entry<Categoria>(categoria).State =  EntityState.Deleted;
                db.SaveChanges();
            }
            MostrarDatos();
        }
        private void MostrarDatos()
        {
            using (var db = new Db())
            {
                dataGridView1.DataSource = db.Categorias.ToList();
            }
             
           
        }

        private void FrmCategorias_Load(object sender, EventArgs e)
        {
            MostrarDatos();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex<=-1 )
            {
                return;
            }
            var cate = dataGridView1.CurrentRow.DataBoundItem as Categoria;
            MostrarItem(cate);
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow ==null)
            {
                return;
            }
            var respuesta = MessageBox.Show("Seguro que desea Eliminar esta Categoria", 
                                            "Confirme",
                                            MessageBoxButtons.YesNo,
                                            MessageBoxIcon.Question,
                                            MessageBoxDefaultButton.Button1);
            if (respuesta== DialogResult.No)
            {
                return;
            }
            var cate = dataGridView1.CurrentRow.DataBoundItem as Categoria;
            Eliminar(cate);
            BtnEliminar.Enabled = false;
            BtnGuardar.Enabled = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            using (var db = new Db())
            {
                dataGridView1.DataSource = db.Categorias.Where(p =>
                              p.Descripcion.ToLower().Contains(textBox1.Text.ToLower())
                              || p.Id.ToString().Contains(textBox1.Text)).ToList();
            }
        }
    }
}
