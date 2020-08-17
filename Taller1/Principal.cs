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
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Gracias por utilizar nuestra aplicación!!", "Salir", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Application.Exit();           
        }

        private void btnSaludar_Click(object sender, EventArgs e)
        {
            // Abrir App Saludar en forma Modal
            frmSaludar saludar = new frmSaludar(); 
            saludar.ShowDialog();
        }

        private void btnIVA_Click(object sender, EventArgs e)
        {
            // Abrir App IVA en forma Modal
            frmIVA IVA_SH = new frmIVA();
            IVA_SH.ShowDialog();
        }

        private void btnAreaCirculo_Click(object sender, EventArgs e)
        {
            // Abrir App Area del Circulo en forma Modal
            frmAreaCirculo circulo = new frmAreaCirculo();
            circulo.ShowDialog();
        }

        private void btnPromedio_Click(object sender, EventArgs e)
        {
            // Abrir App promedio de notas en forma Modal
            frmPromedioNotas notas = new frmPromedioNotas();
            notas.ShowDialog();
        }
    }
}
