using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Taller1
{
    public partial class frmSaludar : Form
    {
        public frmSaludar()
        {
            InitializeComponent();
        }

        private void btnSaludar2_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == string.Empty)
            {
                MessageBox.Show("No digitaste ningún nombre", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNombre.Focus();
            }
            else
            {   // Cambiar texto a mayuscula
                txtNombre.CharacterCasing = CharacterCasing.Upper;
                MessageBox.Show("Hola " + txtNombre.Text + " ,Saludos!!", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnNuevoSaludo_Click(object sender, EventArgs e)
        {
            txtNombre.Text = "";
            txtNombre.Focus();
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Ejecutar proceso presionando tecla enter
            if (e.KeyChar == 13)
            {
                btnSaludar.PerformClick();
            }
        }
    }
}
