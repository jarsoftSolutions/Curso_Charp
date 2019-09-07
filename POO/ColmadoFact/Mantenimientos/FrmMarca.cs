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
    public partial class FrmMarca : Form
    {
        public FrmMarca()
        {
            InitializeComponent();
        }

        private void Limpiar()
        {
            TxtDescripcion.Text = String.Empty;
            TxtId.Text = string.Empty; 
        }
        private void MostrarItem(Marca marca)
        {
            if (marca == null)
            {
                return;
            }
            TxtId.Enabled = false;
            TxtDescripcion.Text = marca.Descripcion;
            TxtId.Text = marca.Id.ToString(); 
            BtnGuardar.Enabled = true;
            BtnEliminar.Enabled = true;
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

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                var marca = new Marca();
                marca.Descripcion = TxtDescripcion.Text; 

                if (!(TxtId.Text.Trim() == string.Empty))
                {
                    marca.Id = Convert.ToInt32(TxtId.Text);

                }

                using (var db = new Db())
                {
                    if (marca.Id == 0)
                        db.Marcas.Add(marca);
                    else
                        db.Entry(marca).State = EntityState.Modified;

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
        private void Eliminar(Marca marca)
        {
            using (var db = new Db())
            {
                db.Entry<Marca>(marca).State = EntityState.Deleted;
                db.SaveChanges();
            }
            MostrarDatos();
        }
        private void MostrarDatos()
        {
            using (var db = new Db())
            {
                dataGridView1.DataSource = db.Marcas.ToList();
            }


        }

        private void FrmMarca_Load(object sender, EventArgs e)
        {
            MostrarDatos();

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex <= -1)
            {
                return;
            }
            var marca = dataGridView1.CurrentRow.DataBoundItem as Marca;
            MostrarItem(marca);
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                return;
            }
            var respuesta = MessageBox.Show("Seguro que desea Eliminar esta Categoria",
                                            "Confirme",
                                            MessageBoxButtons.YesNo,
                                            MessageBoxIcon.Question,
                                            MessageBoxDefaultButton.Button1);
            if (respuesta == DialogResult.No)
            {
                return;
            }
            var marca = dataGridView1.CurrentRow.DataBoundItem as Marca;
            Eliminar(marca);
            BtnEliminar.Enabled = false;
            BtnGuardar.Enabled = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            using (var db = new Db())
            {
                dataGridView1.DataSource = db.Marcas.Where(p =>
                              p.Descripcion.ToLower().Contains(textBox1.Text.ToLower())
                              || p.Id.ToString().Contains(textBox1.Text)).ToList();
            }
        }
    }
}
