namespace Taller1
{
    partial class frmAreaCirculo
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
            this.lblTituloAreaCirculo = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.txtValorRadio = new System.Windows.Forms.TextBox();
            this.lblVlrRadio = new System.Windows.Forms.Label();
            this.lblVlrAreaCirculo = new System.Windows.Forms.Label();
            this.lblAreaCirculo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTituloAreaCirculo
            // 
            this.lblTituloAreaCirculo.AutoSize = true;
            this.lblTituloAreaCirculo.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloAreaCirculo.Location = new System.Drawing.Point(97, 33);
            this.lblTituloAreaCirculo.Name = "lblTituloAreaCirculo";
            this.lblTituloAreaCirculo.Size = new System.Drawing.Size(406, 39);
            this.lblTituloAreaCirculo.TabIndex = 1;
            this.lblTituloAreaCirculo.Text = "CALCULAR AREA DE UN CIRCULO";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Taller1.Properties.Resources.circulo;
            this.pictureBox1.Location = new System.Drawing.Point(23, 112);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 150);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(413, 263);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(119, 46);
            this.btnLimpiar.TabIndex = 12;
            this.btnLimpiar.Text = "&Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnCalcular
            // 
            this.btnCalcular.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Location = new System.Drawing.Point(246, 263);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(119, 46);
            this.btnCalcular.TabIndex = 11;
            this.btnCalcular.Text = "&Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // txtValorRadio
            // 
            this.txtValorRadio.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorRadio.Location = new System.Drawing.Point(386, 147);
            this.txtValorRadio.MaxLength = 16;
            this.txtValorRadio.Name = "txtValorRadio";
            this.txtValorRadio.Size = new System.Drawing.Size(184, 26);
            this.txtValorRadio.TabIndex = 10;
            this.txtValorRadio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValorRadio_KeyPress);
            // 
            // lblVlrRadio
            // 
            this.lblVlrRadio.AutoSize = true;
            this.lblVlrRadio.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVlrRadio.Location = new System.Drawing.Point(190, 151);
            this.lblVlrRadio.Name = "lblVlrRadio";
            this.lblVlrRadio.Size = new System.Drawing.Size(188, 19);
            this.lblVlrRadio.TabIndex = 9;
            this.lblVlrRadio.Text = "Digite el valor del radio:";
            // 
            // lblVlrAreaCirculo
            // 
            this.lblVlrAreaCirculo.AutoSize = true;
            this.lblVlrAreaCirculo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVlrAreaCirculo.Location = new System.Drawing.Point(386, 203);
            this.lblVlrAreaCirculo.Name = "lblVlrAreaCirculo";
            this.lblVlrAreaCirculo.Size = new System.Drawing.Size(198, 19);
            this.lblVlrAreaCirculo.TabIndex = 14;
            this.lblVlrAreaCirculo.Text = "Aqui va el Area del Circulo";
            this.lblVlrAreaCirculo.Visible = false;
            // 
            // lblAreaCirculo
            // 
            this.lblAreaCirculo.AutoSize = true;
            this.lblAreaCirculo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAreaCirculo.Location = new System.Drawing.Point(242, 203);
            this.lblAreaCirculo.Name = "lblAreaCirculo";
            this.lblAreaCirculo.Size = new System.Drawing.Size(136, 19);
            this.lblAreaCirculo.TabIndex = 13;
            this.lblAreaCirculo.Text = "Area del Circulo:";
            // 
            // frmAreaCirculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 334);
            this.Controls.Add(this.lblVlrAreaCirculo);
            this.Controls.Add(this.lblAreaCirculo);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtValorRadio);
            this.Controls.Add(this.lblVlrRadio);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblTituloAreaCirculo);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAreaCirculo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "App Area del Circulo";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTituloAreaCirculo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.TextBox txtValorRadio;
        private System.Windows.Forms.Label lblVlrRadio;
        private System.Windows.Forms.Label lblVlrAreaCirculo;
        private System.Windows.Forms.Label lblAreaCirculo;
    }
}