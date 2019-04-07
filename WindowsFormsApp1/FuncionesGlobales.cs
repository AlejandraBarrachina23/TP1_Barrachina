using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    class FuncionesGlobales
    {
        public int CalcularEdad(DateTimePicker FechaNacimiento, DateTime FechaActual)
        {

            int Edad = FechaActual.Year - FechaNacimiento.Value.Year;

            if (FechaActual.Month < FechaNacimiento.Value.Month || (FechaActual.Month == FechaNacimiento.Value.Month && FechaActual.Day < FechaNacimiento.Value.Day))
            {

                Edad--;
            }

            return Edad;
        }

        public void CargarComboBox(string[] Listado, ref ComboBox Combo)
        {

            Combo.Items.AddRange(Listado);
            Combo.Sorted = true;
        }


        public void LimpiarFormulario(Form Formulario)
        {

            foreach (TextBox texto in Formulario.Controls.OfType<TextBox>())
            {
                texto.Clear();
            }

            foreach (GroupBox esteGrupo in Formulario.Controls.OfType<GroupBox>())
            {
                foreach (CheckBox esteCheckBox in esteGrupo.Controls.OfType<CheckBox>())
                {
                    esteCheckBox.Checked = false;
                }
            }

            foreach (GroupBox esteGrupo in Formulario.Controls.OfType<GroupBox>())
            {
                foreach (RadioButton esteRadioButton in esteGrupo.Controls.OfType<RadioButton>())
                {
                    esteRadioButton.Checked = false;
                }
            }

            foreach (ComboBox Combo in Formulario.Controls.OfType<ComboBox>())
            {

                Combo.SelectedIndex = -1;
            }

            foreach (DateTimePicker Fecha in Formulario.Controls.OfType<DateTimePicker>())
            {

                Fecha.Value = DateTime.Now;
            }
        }

        public Persona CrearNuevaPersona(TextBox txtbNombre, TextBox txtApellido, GroupBox gboxSexo, GroupBox gboxMusica, ComboBox cboxColor, DateTimePicker dtpFechaNacimiento)
        {

            ValidadorDatos validadorDatos = new ValidadorDatos();
            validadorDatos.DatosDelFormulario(txtbNombre, txtApellido, gboxSexo, gboxMusica, cboxColor);
            string OpcionNombre = txtbNombre.Text;
            string OpcionApellido = txtApellido.Text;
            string OpcionSexo = gboxSexo.Controls.OfType<RadioButton>().FirstOrDefault(boton => boton.Checked).Text;
            string OpcionColor = cboxColor.SelectedItem.ToString();
            string OpcionFechaNacimiento = dtpFechaNacimiento.Text;
            var CheckBoxSeleccionados = gboxMusica.Controls.OfType<CheckBox>().Where(boton => boton.Checked).Select(boton => boton.Text);
            string OpcionGustosMusicales = String.Join(",", CheckBoxSeleccionados);
            return new Persona(OpcionNombre, OpcionApellido, OpcionFechaNacimiento, OpcionSexo, OpcionGustosMusicales, OpcionColor);

        }

        public void VentanaAviso(string accion)
        {

            MessageBox.Show("El usuario ha sido " + accion + " con éxito", "ADVERTENCIA");

        }

        public bool VentanaConfirmacion(string accion){

            DialogResult Respuesta = MessageBox.Show("¿Estas seguro que desea " + accion + " el registro ?", "Aceptar", MessageBoxButtons.YesNo);

            if (Respuesta == DialogResult.Yes)
            {
                return true;
            }

            else {

                return false;
            }

           
        }
    }
}