﻿using ColmadoFact.Models;
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
    }
}
