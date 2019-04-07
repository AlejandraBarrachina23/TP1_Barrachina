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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
            IsMdiContainer = true;
        }

        private void btnPersonas_Click(object sender, EventArgs e)
        {
            frmPersona formularioSecundario = new frmPersona();
            formularioSecundario.MdiParent = this;
            formularioSecundario.Show();
                        
        }

        private void btnObjetos_Click(object sender, EventArgs e)
        {
            frmObjetos formularioSecundario = new frmObjetos();
            formularioSecundario.MdiParent = this;
            formularioSecundario.Show();
        }

    }
}
