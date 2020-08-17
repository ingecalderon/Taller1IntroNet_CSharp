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
    public partial class frmAreaCirculo : Form
    {
        public frmAreaCirculo()
        {
            InitializeComponent();
        }

        private void txtValorRadio_KeyPress(object sender, KeyPressEventArgs e)
        {
            // No permitir digitar letras
            if (e.KeyChar >= 48 && e.KeyChar <= 57 || e.KeyChar == 8 || e.KeyChar == 44)
                    {
                e.Handled = false;
                    }
            else
            {
                e.Handled = true;
            }

            //Ejecutar proceso presionando tecla enter
            if (e.KeyChar == 13)
            {
                btnCalcular.PerformClick();
            }
        }
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (txtValorRadio.Text == string.Empty)
            {
                MessageBox.Show("No digitaste ningún valor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtValorRadio.Focus();
            }
            else
            {
                Double radio, area;
                radio = Double.Parse(txtValorRadio.Text);
                area = System.Math.PI * Math.Pow(radio, 2);
                lblVlrAreaCirculo.Text = Convert.ToString(area);
                lblVlrAreaCirculo.Visible = true;
                lblVlrAreaCirculo.Text = String.Format("{0:0.00}", double.Parse(lblVlrAreaCirculo.Text));
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtValorRadio.Text = string.Empty;
            txtValorRadio.Focus();
            lblVlrAreaCirculo.Visible = false;
        }
    }
}
