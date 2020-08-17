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
    public partial class frmIVA : Form
    {
        public frmIVA()
        {
            InitializeComponent();
        }

        private void txtValorProducto_KeyPress(object sender, KeyPressEventArgs e)
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
            Double valorproducto, valoriva, valortotal;
            valorproducto = Double.Parse(txtValorProducto.Text);
            valoriva = valorproducto * 0.19;
            valortotal = valorproducto + valoriva;
            lblVlrIVA2.Text = Convert.ToString(valoriva);
            lblVlrTotalProducto2.Text = Convert.ToString(valortotal);
            lblVlrIVA2.Visible = true;
            lblVlrTotalProducto2.Visible = true;
            // Formato moneda
            txtValorProducto.Text = String.Format("{0:N0}", double.Parse(txtValorProducto.Text));
            lblVlrIVA2.Text = String.Format("{0:N0}", double.Parse(lblVlrIVA2.Text));
            lblVlrTotalProducto2.Text = "$"+String.Format("{0:N0}", double.Parse(lblVlrTotalProducto2.Text));
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            lblVlrIVA2.Visible = false;
            lblVlrTotalProducto2.Visible = false;
            txtValorProducto.Text = string.Empty;
            txtValorProducto.Focus();
        }
    }
}
