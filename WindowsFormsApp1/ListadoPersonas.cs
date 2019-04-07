using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class frmPersona : Form
    {
        ValidadorDatos validarDatos = new ValidadorDatos();
        FuncionesGlobales Utilidades = new FuncionesGlobales();
        private List<Persona> ListadoPersona = new List<Persona>();
        private BindingList<Persona> listaBindeable;

        public frmPersona()
        {
            InitializeComponent();
        }

        private void lbNombre_Click(object sender, EventArgs e)
        {

        }

        private void frmPersona_Load(object sender, EventArgs e)
        {
            string[] ListadoColores = new string[] { "Rojo", "Amarillo", "Verde", "Azul", "Marron", "Rosa", "Naranja", "Violeta", "Negro", "Blanco" };
            Utilidades.CargarComboBox(ListadoColores, ref cboxColor);

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                Persona unaPersona = Utilidades.CrearNuevaPersona(txtbNombre, txtApellido, gboxSexo, gboxMusica, cboxColor, dtpFechaNacimiento);
                //Lleno grilla          
                listaBindeable = new BindingList<Persona>(ListadoPersona);
                dgvDatosPersona.DataSource = listaBindeable;
                ListadoPersona.Add(unaPersona);
                listaBindeable.ResetBindings();
                Utilidades.LimpiarFormulario(this);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dtpFechaNacimiento_ValueChanged(object sender, EventArgs e)
        {
            lbEdad.Text = "Edad: " + Utilidades.CalcularEdad(dtpFechaNacimiento, DateTime.Now).ToString();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Utilidades.LimpiarFormulario(this);

        }

        private void dgvDatosPersona_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            btnModificar.Enabled = true;
            btnEliminar.Enabled = true;
            Object FilaSeleccionada = dgvDatosPersona.CurrentRow.DataBoundItem;
            Persona PersonaSeleccionada = (Persona)FilaSeleccionada;
            var gustosMusicales = PersonaSeleccionada.GustosMusicales.Split(',');

            //Lleno el formulario con la selección
            txtbNombre.Text = PersonaSeleccionada.Nombre;
            txtApellido.Text = PersonaSeleccionada.Apellido;
            dtpFechaNacimiento.Text = PersonaSeleccionada.FechaNacimiento;

            foreach (RadioButton esteRadioButton in gboxSexo.Controls.OfType<RadioButton>())
            {
                if (esteRadioButton.Text == PersonaSeleccionada.Sexo)
                {
                    esteRadioButton.Checked = true;

                }
            }

            foreach (CheckBox esteCheckBox in gboxMusica.Controls.OfType<CheckBox>())
            {
                if (gustosMusicales.Contains(esteCheckBox.Text))
                {
                    esteCheckBox.Checked = true;
                }
            }

            cboxColor.Text = PersonaSeleccionada.ColorPreferido;

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

            try
            {
                validarDatos.DataGridViewVacio(dgvDatosPersona);
                validarDatos.DatosDelFormulario(txtbNombre, txtApellido, gboxSexo, gboxMusica, cboxColor);
                Persona unaPersona = Utilidades.CrearNuevaPersona(txtbNombre, txtApellido, gboxSexo, gboxMusica, cboxColor, dtpFechaNacimiento);

                //validar que seleccione fila o desactivar boton <-----
                if (Utilidades.VentanaConfirmacion("modificar"))
                {

                    int posicionPersona = dgvDatosPersona.CurrentRow.Index;
                    ListadoPersona[posicionPersona] = unaPersona;
                    Utilidades.VentanaAviso("modificado");

                }

                listaBindeable.ResetBindings();
                btnModificar.Enabled = false;
                btnEliminar.Enabled = false;
                Utilidades.LimpiarFormulario(this);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                validarDatos.DataGridViewVacio(dgvDatosPersona);

                if (Utilidades.VentanaConfirmacion("eliminar"))
                {

                    int posicion = dgvDatosPersona.CurrentRow.Index;
                    ListadoPersona.RemoveAt(posicion);
                    Utilidades.VentanaAviso("eliminado");

                }

                listaBindeable.ResetBindings();
                btnModificar.Enabled = false;
                btnEliminar.Enabled = false;
                Utilidades.LimpiarFormulario(this);

                //dgvDatosPersona.Rows.RemoveAt(posicion);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
