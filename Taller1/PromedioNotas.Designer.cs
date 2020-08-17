namespace Taller1
{
    partial class frmPromedioNotas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPromedioNotas));
            this.lblTituloPromedio = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.picPromedio = new System.Windows.Forms.PictureBox();
            this.txtNota1 = new System.Windows.Forms.TextBox();
            this.lblNota1 = new System.Windows.Forms.Label();
            this.txtNota2 = new System.Windows.Forms.TextBox();
            this.lblNota2 = new System.Windows.Forms.Label();
            this.txtNota3 = new System.Windows.Forms.TextBox();
            this.lblNota3 = new System.Windows.Forms.Label();
            this.lblPromedio = new System.Windows.Forms.Label();
            this.lblResultado = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picPromedio)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTituloPromedio
            // 
            this.lblTituloPromedio.AutoSize = true;
            this.lblTituloPromedio.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloPromedio.Location = new System.Drawing.Point(87, 16);
            this.lblTituloPromedio.Name = "lblTituloPromedio";
            this.lblTituloPromedio.Size = new System.Drawing.Size(436, 39);
            this.lblTituloPromedio.TabIndex = 1;
            this.lblTituloPromedio.Text = "CALCULAR EL PROMEDIO DE NOTAS";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(383, 284);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(119, 46);
            this.btnLimpiar.TabIndex = 11;
            this.btnLimpiar.Text = "&Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnCalcular
            // 
            this.btnCalcular.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Location = new System.Drawing.Point(216, 284);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(119, 46);
            this.btnCalcular.TabIndex = 10;
            this.btnCalcular.Text = "&Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // picPromedio
            // 
            this.picPromedio.Image = global::Taller1.Properties.Resources.promedio;
            this.picPromedio.InitialImage = ((System.Drawing.Image)(resources.GetObject("picPromedio.InitialImage")));
            this.picPromedio.Location = new System.Drawing.Point(18, 73);
            this.picPromedio.Name = "picPromedio";
            this.picPromedio.Size = new System.Drawing.Size(150, 150);
            this.picPromedio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPromedio.TabIndex = 11;
            this.picPromedio.TabStop = false;
            // 
            // txtNota1
            // 
            this.txtNota1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNota1.Location = new System.Drawing.Point(409, 104);
            this.txtNota1.MaxLength = 5;
            this.txtNota1.Name = "txtNota1";
            this.txtNota1.Size = new System.Drawing.Size(153, 26);
            this.txtNota1.TabIndex = 3;
            this.txtNota1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValorProducto_KeyPress);
            // 
            // lblNota1
            // 
            this.lblNota1.AutoSize = true;
            this.lblNota1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNota1.Location = new System.Drawing.Point(263, 108);
            this.lblNota1.Name = "lblNota1";
            this.lblNota1.Size = new System.Drawing.Size(129, 19);
            this.lblNota1.TabIndex = 2;
            this.lblNota1.Text = "Digite la Nota 1:";
            // 
            // txtNota2
            // 
            this.txtNota2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNota2.Location = new System.Drawing.Point(409, 141);
            this.txtNota2.MaxLength = 5;
            this.txtNota2.Name = "txtNota2";
            this.txtNota2.Size = new System.Drawing.Size(153, 26);
            this.txtNota2.TabIndex = 5;
            this.txtNota2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // lblNota2
            // 
            this.lblNota2.AutoSize = true;
            this.lblNota2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNota2.Location = new System.Drawing.Point(263, 145);
            this.lblNota2.Name = "lblNota2";
            this.lblNota2.Size = new System.Drawing.Size(129, 19);
            this.lblNota2.TabIndex = 4;
            this.lblNota2.Text = "Digite la Nota 2:";
            // 
            // txtNota3
            // 
            this.txtNota3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNota3.Location = new System.Drawing.Point(409, 179);
            this.txtNota3.MaxLength = 5;
            this.txtNota3.Name = "txtNota3";
            this.txtNota3.Size = new System.Drawing.Size(153, 26);
            this.txtNota3.TabIndex = 7;
            this.txtNota3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            // 
            // lblNota3
            // 
            this.lblNota3.AutoSize = true;
            this.lblNota3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNota3.Location = new System.Drawing.Point(263, 183);
            this.lblNota3.Name = "lblNota3";
            this.lblNota3.Size = new System.Drawing.Size(129, 19);
            this.lblNota3.TabIndex = 6;
            this.lblNota3.Text = "Digite la Nota 3:";
            // 
            // lblPromedio
            // 
            this.lblPromedio.AutoSize = true;
            this.lblPromedio.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPromedio.Location = new System.Drawing.Point(167, 236);
            this.lblPromedio.Name = "lblPromedio";
            this.lblPromedio.Size = new System.Drawing.Size(230, 19);
            this.lblPromedio.TabIndex = 8;
            this.lblPromedio.Text = "El Promedio de las notas es: ";
            this.lblPromedio.Visible = false;
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.Location = new System.Drawing.Point(403, 236);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(159, 19);
            this.lblResultado.TabIndex = 9;
            this.lblResultado.Text = "Aqui va el resultado";
            this.lblResultado.Visible = false;
            // 
            // frmPromedioNotas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGreen;
            this.ClientSize = new System.Drawing.Size(610, 351);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.lblPromedio);
            this.Controls.Add(this.txtNota3);
            this.Controls.Add(this.lblNota3);
            this.Controls.Add(this.txtNota2);
            this.Controls.Add(this.lblNota2);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.picPromedio);
            this.Controls.Add(this.txtNota1);
            this.Controls.Add(this.lblNota1);
            this.Controls.Add(this.lblTituloPromedio);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPromedioNotas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "App Promedio Notas";
            ((System.ComponentModel.ISupportInitialize)(this.picPromedio)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTituloPromedio;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.PictureBox picPromedio;
        private System.Windows.Forms.TextBox txtNota1;
        private System.Windows.Forms.Label lblNota1;
        private System.Windows.Forms.TextBox txtNota2;
        private System.Windows.Forms.Label lblNota2;
        private System.Windows.Forms.TextBox txtNota3;
        private System.Windows.Forms.Label lblNota3;
        private System.Windows.Forms.Label lblPromedio;
        private System.Windows.Forms.Label lblResultado;
    }
}