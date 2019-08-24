using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion.Mantenimientos
{
    using Entidades;
    using Negocio;

    public partial class FrmPersona : Form
    {
       private PersonaMant Mant { get; set; }

        private DataTable ListaPersona;

        public FrmPersona()
        {
            InitializeComponent();
            Mant = new PersonaMant();
        }
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarControles();
        }

        private bool Validar()
        {
            //Limpia los Errores de todos los controles
            ControlErrores.Clear();

            if (TxtNombre.Text.Trim()==string.Empty)
            {
                //Le Establece el error al Control que estamos Validando
                ControlErrores.SetError(TxtNombre, "El Nombre es un Campo Obligatorio");   
                //MessageBox.Show("El Nombre es un Campo Obligatorio");
                return false;
            }
            if (TxtApellido.Text.Trim() == string.Empty)
            {
                //Le Establece el error al Control que estamos Validando
                ControlErrores.SetError(TxtApellido, "El Apellido es un Campo Obligatorio");
                //MessageBox.Show("El Apellido es un Campo Obligatorio");
                return false;
            }

            return true;
        }
        private void LimpiarControles()
        {
            TxtNombre.Text = string.Empty;
            TxtApellido.Text = "";
            txtEdad.Text = "0";
            CboEstadoCivil.SelectedIndex = -1;
            CoboColor.SelectedIndex = -1;
            chkActivo.Checked = false;
            TxtId.Text = "0";
        }
      

        private void FrmPersona_Load(object sender, EventArgs e)
        { 
        

            this.DtListado.AutoGenerateColumns = false;
            DtListado.DataSource = Mant.ListadoPersonas;
            personasSearch = new List<Persona2>();
            ListaPersona = new DataTable();
            ListaPersona.Columns.Add("Id", typeof(int));
            ListaPersona.Columns.Add("Nombre", typeof(string));
            ListaPersona.Columns.Add("Apellido", typeof(string));
            ListaPersona.Columns.Add("Edad", typeof(int));
            ListaPersona.Columns.Add("ColorPelo", typeof(string));
            ListaPersona.Columns.Add("EstadoCivil", typeof(string));
            ListaPersona.Columns.Add("Activo", typeof(bool));
            ListaPersona.Columns.Add("Cliente", typeof(string));
            ListaPersona.Columns.Add("FechaNacimiento", typeof(DateTime));
            int index = 1;

            foreach (var item in Mant.ListadoPersonas)
            {
                DataRow dataRow = ListaPersona.NewRow();
                dataRow["Id"] = index;
                dataRow["Activo"] = item.Activo;
                dataRow["Nombre"] = item.Nombre;
                dataRow["Apellido"] = item.Apellido;
                dataRow["Edad"] = item.Edad;
                dataRow["ColorPelo"] = item.ColorPelo;
                dataRow["EstadoCivil"] = item.EstadoCivil;
              
                dataRow["Cliente"] = item.Cliente;
                dataRow["FechaNacimiento"] = item.FechaNacimiento;
                ListaPersona.Rows.Add(dataRow);
                index++;
            }

            DtListado.DataSource = null;
            DtListado.DataSource = ListaPersona;

        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (!Validar())//Si existen errores no Continua el Programa
            {
                return;
            }

            //Persona persona = new Persona()
            //{
            //    Activo = chkActivo.Checked,
            //    Apellido = TxtApellido.Text,
            //    ColorPelo = CoboColor.Text.ToString(),
            //    Edad = Convert.ToInt32(txtEdad.Text),
            //    EstadoCivil = CboEstadoCivil.Text.ToString(),
            //    FechaNacimiento = TxtFechaNac.Value,
            //    Nombre = TxtNombre.Text
            //};
            //Mant.Agregar(persona);
            //LimpiarControles();
            //DtListado.DataSource = null;
            //DtListado.DataSource = Mant.ListadoPersonas;
            bool EsNuevo = true;
            if (int.Parse(TxtId.Text)!=0)
            {
                EsNuevo = false;
            }
            int index =int.Parse(TxtId.Text);
            if (EsNuevo)
            {
                index = ListaPersona.Rows.Count + 1;

                DataRow dataRow = ListaPersona.NewRow();
                dataRow["Id"] = index;
                dataRow["Activo"] = chkActivo.Checked;
                dataRow["Nombre"] = TxtNombre.Text;
                dataRow["Apellido"] = TxtApellido.Text;
                dataRow["Edad"] = txtEdad.Text;
                dataRow["ColorPelo"] = CoboColor.Text;
                dataRow["EstadoCivil"] = CboEstadoCivil.Text;

                dataRow["Cliente"] =$"{dataRow["Nombre"]} {dataRow["Apellido"]}" ;
                dataRow["FechaNacimiento"] = TxtFechaNac.Value;
                ListaPersona.Rows.Add(dataRow);
            }
            else
            {
                DataRow dataRow = ListaPersona.AsEnumerable().Where(p=> (int)p["Id"]==index).FirstOrDefault();
                if (dataRow ==null)
                {
                    return;
                }
                
                dataRow["Activo"] = chkActivo.Checked;
                dataRow["Nombre"] = TxtNombre.Text;
                dataRow["Apellido"] = TxtApellido.Text;
                dataRow["Edad"] = txtEdad.Text;
                dataRow["ColorPelo"] = CoboColor.Text;
                dataRow["EstadoCivil"] = CboEstadoCivil.Text;
                dataRow["Cliente"] = $"{dataRow["Nombre"]} {dataRow["Apellido"]}";
                dataRow["FechaNacimiento"] = TxtFechaNac.Value;
            }


            DtListado.DataSource = null;
            DtListado.DataSource = ListaPersona ;
        }

        private void TxtFechaNac_ValueChanged(object sender, EventArgs e)
        {
             
            var valor = (DateTime.Now - TxtFechaNac.Value).TotalDays / 365;
            txtEdad.Text =string.Format("{0:N0}", valor);

        }
        List<Persona2> personasSearch;
        private void TxtBuscar_TextChanged(object sender, EventArgs e)
        {
            // Buscar(TxtBuscar.Text);
            // BuscarlINQ(TxtBuscar.Text);
            // Buscar En Datatable
            // BuscarEnDatatable(TxtBuscar.Text);
            BuscarEnDatatableLinq(TxtBuscar.Text);
        }

        private void Buscar(string criterio)
        {
            personasSearch.Clear();
            /// Forma 1 de Buscar
            //for (int i = 0; i < Mant.ListadoPersonas.Count; i++)
            //{
            //    if (Mant.ListadoPersonas[i].Nombre.Contains(criterio))
            //    {
            //        personasSearch.Add(Mant.ListadoPersonas[i]);
            //    }
            //}

            ///Forma 2
            foreach (var item in Mant.ListadoPersonas)
            {
                if (item.Nombre.Contains(criterio))
                {
                    personasSearch.Add(item);
                }
                
            }

            DtListado.DataSource = null;
         DtListado.DataSource = personasSearch;

        }
        private void BuscarlINQ(string criterio)
        {
            //busqueda Usando LinQ
            personasSearch = Mant.ListadoPersonas.Where(p => p.Nombre.Contains(criterio)).ToList();
            DtListado.DataSource = null;
            DtListado.DataSource = personasSearch;

        }

        private void BuscarEnDatatable(string criterio)
        {
            DataView dataView = new DataView(ListaPersona);

            dataView.RowFilter = "Nombre Like '%" + criterio + "%'";
            dataView.Sort = "Nombre";
            DtListado.DataSource = null;
            DtListado.DataSource = dataView;
        }
        private void BuscarEnDatatableLinq(string criterio)
        {
            DataTable OdataTable=null;
            var Result = ListaPersona.AsEnumerable().Where(p => p["Nombre"].ToString().Contains(criterio)).ToList();
            if (Result.Count>0)
            {
                OdataTable = Result.CopyToDataTable();
            }
            DtListado.DataSource = null;
            DtListado.DataSource = OdataTable;
            if (criterio=="")
            {
                DtListado.DataSource = ListaPersona;
            }
        }

        private void DtListado_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataRowView OdataRowView = (DataRowView)DtListado.CurrentRow.DataBoundItem;
            DataRow OdataRow = OdataRowView.Row;
            TxtNombre.Text = OdataRow["Nombre"].ToString();
            TxtApellido.Text = OdataRow["Apellido"].ToString();
            txtEdad.Text = OdataRow["Edad"].ToString();
            TxtFechaNac.Text = OdataRow["FechaNacimiento"].ToString();
            chkActivo.Checked =(bool)OdataRow["Activo"];
           CboEstadoCivil.Text= OdataRow["EstadoCivil"].ToString();
            CoboColor.Text = OdataRow["ColorPelo"].ToString();
            TxtId.Text = OdataRow["Id"].ToString();
        }
    }
}
