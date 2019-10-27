using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ColmadoFact.MyControls
{

    /// <summary>
    /// Clase Auxiliar para Los Formularios y Este Proyecto
    /// </summary>
    public static class FactExtension
    {
        /// <summary>
        /// Limpia Todos Los Controles dentro de Un Formulario
        /// </summary>
        /// <param name="form">Este Formulario</param>
        public static void LimpiarMyControls(this Form form)
        {
            //var AllTextBox = GetControls(form).OfType<TextBox>().ToList();
            //var AllComboBox = GetControls(form).OfType<ComboBox>().ToList();
            //var AllCheckox = GetControls(form).OfType<CheckBox>().ToList();
            //var AllNumericUpdow = GetControls(form).OfType<NumericUpDown>().ToList();
            Limpiar(GetControls(form));
        }

        private static void Limpiar(IEnumerable<Control> controls)
        {
            foreach (Control item in controls)
            {
                if (item is TextBox)
                    item.Text = string.Empty;
                else if (item is ComboBox)
                    ((ComboBox)item).SelectedIndex = -1;
                else if (item is CheckBox)
                    ((CheckBox)item).Checked = false;
                else if (item is NumericUpDown)
                    ((NumericUpDown)item).Value = 0;
            }
        }

        private static List<Control> GetControls(Control form)
        {
            List<Control> ListaControles = new List<Control>();
            //Obtener todos los Controles del Control Enviado
            var AllControls = form.Controls;
            foreach (Control item in AllControls)
            {
                ListaControles.Add(item); 
                ListaControles.AddRange(GetControls(item));
            }

            return ListaControles;
        }
     }
}
