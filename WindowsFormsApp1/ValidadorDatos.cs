using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    class ValidadorDatos
    {
        public void ContenidoTextBox(string ingreso, string nombreCampo) {

             if (ingreso.Trim() == "") {
                
                throw new Exception("El campo " + nombreCampo + " está vacío.");
             }
        }

        public void SeleccionRadioButton(GroupBox opciones, string nombreCampo) {

            if (!opciones.Controls.OfType<RadioButton>().Any(unRadioButton => unRadioButton.Checked))
            {
                throw new Exception("No selecciono ningún " + nombreCampo);
            }
        }

        public void SeleccionCheckBox(GroupBox opciones, string nombreCampo) {

            if (!opciones.Controls.OfType<CheckBox>().Any(unCheckBox => unCheckBox.Checked)) {

                throw new Exception("No selecciono ningún " + nombreCampo);
            }

        }

        public void SeleccionComboBox(ComboBox opciones, string nombreCampo) {

            if (opciones.SelectedIndex == -1) {

                throw new Exception("No selecciono ningún " + nombreCampo);
            }
        }

        public void ItemRepetidoEnListado(ListBox listado, string itemRevisar, string nombreCampo) {

            if (listado.Items.Contains(itemRevisar)) {

                throw new Exception("El " + nombreCampo + " ingresado esta repetido");
            }
        }

        public void ItemSeleccionado(ListBox listado, string nombreCampo) {

            if (listado.SelectedIndex == -1) {

                throw new Exception("Debe seleccionar un " + nombreCampo);
            }
        }

        public void ListaVacia(ListBox listado) {

            if (listado.Items.Count == 0) {

                throw new Exception("La lista esta vacia");
            }
        }

        public void DataGridViewVacio(DataGridView Grilla) {

            if (Grilla.Rows.Count == 0) {

                throw new Exception("La grilla esta vacia");
            }
        }

        public void DatosDelFormulario(TextBox txtbNombre, TextBox txtApellido, GroupBox gboxSexo, GroupBox gboxMusica, ComboBox cboxColor) {

            this.ContenidoTextBox(txtbNombre.Text, "'Nombre'");
            this.ContenidoTextBox(txtApellido.Text, "'Apellido'");
            this.SeleccionRadioButton(gboxSexo, "'Sexo'");
            this.SeleccionCheckBox(gboxMusica, "'Estilo musical'");
            this.SeleccionComboBox(cboxColor, "'Color'");

        }

    }
}
