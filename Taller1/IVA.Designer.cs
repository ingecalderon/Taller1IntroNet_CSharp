namespace Taller1
{
    partial class frmIVA
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
            this.lblVlrProducto = new System.Windows.Forms.Label();
            this.txtValorProducto = new System.Windows.Forms.TextBox();
            this.lblVlrIVA = new System.Windows.Forms.Label();
            this.lblVlrIVA2 = new System.Windows.Forms.Label();
            this.lblVlrTotalProducto = new System.Windows.Forms.Label();
            this.lblVlrTotalProducto2 = new System.Windows.Forms.Label();
            this.picIVA = new System.Windows.Forms.PictureBox();
            this.lblTituloIVA = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picIVA)).BeginInit();
            this.SuspendLayout();
            // 
            // lblVlrProducto
            // 
            this.lblVlrProducto.AutoSize = true;
            this.lblVlrProducto.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVlrProducto.Location = new System.Drawing.Point(162, 92);
            this.lblVlrProducto.Name = "lblVlrProducto";
            this.lblVlrProducto.Size = new System.Drawing.Size(219, 19);
            this.lblVlrProducto.TabIndex = 1;
            this.lblVlrProducto.Text = "Digite el valor del producto:";
            // 
            // txtValorProducto
            // 
            this.txtValorProducto.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorProducto.Location = new System.Drawing.Point(392, 88);
            this.txtValorProducto.MaxLength = 16;
            this.txtValorProducto.Name = "txtValorProducto";
            this.txtValorProducto.Size = new System.Drawing.Size(184, 26);
            this.txtValorProducto.TabIndex = 2;
            this.txtValorProducto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValorProducto_KeyPress);
            // 
            // lblVlrIVA
            // 
            this.lblVlrIVA.AutoSize = true;
            this.lblVlrIVA.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVlrIVA.Location = new System.Drawing.Point(272, 142);
            this.lblVlrIVA.Name = "lblVlrIVA";
            this.lblVlrIVA.Size = new System.Drawing.Size(110, 19);
            this.lblVlrIVA.TabIndex = 3;
            this.lblVlrIVA.Text = "Valor del IVA:";
            // 
            // lblVlrIVA2
            // 
            this.lblVlrIVA2.AutoSize = true;
            this.lblVlrIVA2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVlrIVA2.Location = new System.Drawing.Point(392, 142);
            this.lblVlrIVA2.Name = "lblVlrIVA2";
            this.lblVlrIVA2.Size = new System.Drawing.Size(174, 19);
            this.lblVlrIVA2.TabIndex = 4;
            this.lblVlrIVA2.Text = "Aqui va el valor del IVA";
            this.lblVlrIVA2.Visible = false;
            // 
            // lblVlrTotalProducto
            // 
            this.lblVlrTotalProducto.AutoSize = true;
            this.lblVlrTotalProducto.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVlrTotalProducto.Location = new System.Drawing.Point(187, 192);
            this.lblVlrTotalProducto.Name = "lblVlrTotalProducto";
            this.lblVlrTotalProducto.Size = new System.Drawing.Size(197, 19);
            this.lblVlrTotalProducto.TabIndex = 5;
            this.lblVlrTotalProducto.Text = "Valor Total del Producto:";
            // 
            // lblVlrTotalProducto2
            // 
            this.lblVlrTotalProducto2.AutoSize = true;
            this.lblVlrTotalProducto2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVlrTotalProducto2.Location = new System.Drawing.Point(392, 192);
            this.lblVlrTotalProducto2.Name = "lblVlrTotalProducto2";
            this.lblVlrTotalProducto2.Size = new System.Drawing.Size(181, 19);
            this.lblVlrTotalProducto2.TabIndex = 6;
            this.lblVlrTotalProducto2.Text = "Aqui va el Vlr Total Prod";
            this.lblVlrTotalProducto2.Visible = false;
            // 
            // picIVA
            // 
            this.picIVA.Image = global::Taller1.Properties.Resources.calculadora_form;
            this.picIVA.Location = new System.Drawing.Point(12, 42);
            this.picIVA.Name = "picIVA";
            this.picIVA.Size = new System.Drawing.Size(133, 176);
            this.picIVA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picIVA.TabIndex = 6;
            this.picIVA.TabStop = false;
            // 
            // lblTituloIVA
            // 
            this.lblTituloIVA.AutoSize = true;
            this.lblTituloIVA.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloIVA.Location = new System.Drawing.Point(233, 20);
            this.lblTituloIVA.Name = "lblTituloIVA";
            this.lblTituloIVA.Size = new System.Drawing.Size(280, 39);
            this.lblTituloIVA.TabIndex = 0;
            this.lblTituloIVA.Text = "CALCULADORA DE IVA";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Location = new System.Drawing.Point(216, 253);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(119, 46);
            this.btnCalcular.TabIndex = 7;
            this.btnCalcular.Text = "&Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(383, 253);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(119, 46);
            this.btnLimpiar.TabIndex = 8;
            this.btnLimpiar.Text = "&Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // frmIVA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(214)))), ((int)(((byte)(233)))));
            this.ClientSize = new System.Drawing.Size(602, 332);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.lblTituloIVA);
            this.Controls.Add(this.picIVA);
            this.Controls.Add(this.lblVlrTotalProducto2);
            this.Controls.Add(this.lblVlrTotalProducto);
            this.Controls.Add(this.lblVlrIVA2);
            this.Controls.Add(this.lblVlrIVA);
            this.Controls.Add(this.txtValorProducto);
            this.Controls.Add(this.lblVlrProducto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmIVA";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "App Calcular IVA";
            ((System.ComponentModel.ISupportInitialize)(this.picIVA)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblVlrProducto;
        private System.Windows.Forms.TextBox txtValorProducto;
        private System.Windows.Forms.Label lblVlrIVA;
        private System.Windows.Forms.Label lblVlrIVA2;
        private System.Windows.Forms.Label lblVlrTotalProducto;
        private System.Windows.Forms.Label lblVlrTotalProducto2;
        private System.Windows.Forms.PictureBox picIVA;
        private System.Windows.Forms.Label lblTituloIVA;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnLimpiar;
    }
}