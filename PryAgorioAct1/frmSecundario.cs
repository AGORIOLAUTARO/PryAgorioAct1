using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PryAgorioAct1
{
    public partial class frmSecundario : Form
    {
        public frmSecundario()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            frmPrincipal frmPrincipal = new frmPrincipal();
            frmPrincipal.ShowDialog();

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {   // le digo a la caja de texto que al apretar cancelar se borre todo lo que habia adentro automaticamente
            // "" significa VACIO
            txtUsuario.Text = "";

            txtContraseña.Text = "";

            cmbModulo.SelectedIndex = -1;
        }

        private void txtContraseña_TextChanged(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "")
            {


                txtContraseña.Enabled = false;
            }
            else
            {
                txtContraseña.Enabled = true;
            } 
                
        }   
    }      
}
    }
}
