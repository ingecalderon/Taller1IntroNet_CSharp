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
    public partial class frmPromedioNotas : Form
    {
        public frmPromedioNotas()
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

            //Pasar a la siguiente nota
            if (e.KeyChar == 13)
            {
                txtNota2.Focus();
            }
        }



        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
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
            
            //Pasar a la siguiente nota
            if (e.KeyChar == 13)
            {
                txtNota3.Focus();
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
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
            if (txtNota1.Text == string.Empty || txtNota2.Text == string.Empty || txtNota3.Text == string.Empty)
                {
                MessageBox.Show("Falta una nota por digitar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNota1.Focus();
            }

            else
            {
                Double nota1, nota2, nota3, suma, promedio;
                nota1 = Double.Parse(txtNota1.Text);
                nota2 = Double.Parse(txtNota3.Text);
                nota3 = Double.Parse(txtNota1.Text);
                suma = nota1+nota2+nota3;
                promedio = suma / 3;
                lblResultado.Text = Convert.ToString(promedio);
                lblPromedio.Visible = true;
                lblResultado.Visible = true;
                lblResultado.Text = String.Format("{0:0.00}", double.Parse(lblResultado.Text));
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNota1.Text = string.Empty;
            txtNota2.Text = string.Empty;
            txtNota3.Text = string.Empty;
            lblPromedio.Visible = false;
            lblResultado.Visible = false;
        }
    }
}
