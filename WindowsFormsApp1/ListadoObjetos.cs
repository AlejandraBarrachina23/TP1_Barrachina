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
    public partial class frmObjetos : Form
    {
        ValidadorDatos validar = new ValidadorDatos();
        public frmObjetos()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                validar.ContenidoTextBox(txtbObjeto.Text, "Objeto"); // -> valida que el textbox no este vacío
                validar.ItemRepetidoEnListado(lstbIzquierda, txtbObjeto.Text, "Objeto"); // -> valida que el elemento ingresado no este repetido
                lstbIzquierda.Items.Add(txtbObjeto.Text); // -> agrega un elemento a la lista
                txtbObjeto.Clear(); // -> limpia el contendio del textbox

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void btnMoverTodos_Click(object sender, EventArgs e)
        {
            try
            {
                validar.ListaVacia(lstbIzquierda); // -> valida que la lista no este vacia

                List<string> ListaFiltro = new List<string>(); // <- Creo una lista alternativa para guardar
                                                               //aquellos elementos que no esten en repetidos luego agrego
                                                               //a la lista de la derecha, la listra filtrada.
                foreach (string item in lstbIzquierda.Items)
                {
                    if (!lstbDerecha.Items.Contains(item))
                    {
                        ListaFiltro.Add(item);
                    }
                }

                foreach (var item in ListaFiltro)
                {
                    lstbDerecha.Items.Add(item);
                    lstbIzquierda.Items.Remove(item);
                }

                // lstbIzquierda.Items.AddRange(ListaFiltro);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnMoverUnoDerecha_Click(object sender, EventArgs e)
        {
            try
            {
                validar.ListaVacia(lstbIzquierda);
                validar.ItemSeleccionado(lstbIzquierda, "objeto");
                validar.ItemRepetidoEnListado(lstbDerecha, lstbIzquierda.SelectedItem.ToString(), "objeto");
                lstbDerecha.Items.Add(lstbIzquierda.SelectedItem);
                lstbIzquierda.Items.Remove(lstbIzquierda.SelectedItem);
                
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnMoverUnoIzquierda_Click(object sender, EventArgs e)
        {

            try
            {
                validar.ListaVacia(lstbDerecha);
                validar.ItemSeleccionado(lstbDerecha, "Objeto");
                validar.ItemRepetidoEnListado(lstbIzquierda, lstbDerecha.SelectedItem.ToString(), "objeto");
                lstbIzquierda.Items.Add(lstbDerecha.SelectedItem);
                lstbDerecha.Items.Remove(lstbDerecha.SelectedItem);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            try
            {
                validar.ListaVacia(lstbDerecha);
                validar.ItemSeleccionado(lstbDerecha, "Objeto");
                lstbDerecha.Items.Remove(lstbDerecha.SelectedItem);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }
    }
}
