namespace Taller1
{
    partial class frmMenu
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnSaludar = new System.Windows.Forms.Button();
            this.btnIVA = new System.Windows.Forms.Button();
            this.btnAreaCirculo = new System.Windows.Forms.Button();
            this.btnPromedio = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.lblBienvenida = new System.Windows.Forms.Label();
            this.picMainSaludo = new System.Windows.Forms.PictureBox();
            this.picMainCalcular = new System.Windows.Forms.PictureBox();
            this.picMainCirculo = new System.Windows.Forms.PictureBox();
            this.picMainPromedio = new System.Windows.Forms.PictureBox();
            this.picMainSalir = new System.Windows.Forms.PictureBox();
            this.tipMain = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picMainSaludo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMainCalcular)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMainCirculo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMainPromedio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMainSalir)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSaludar
            // 
            this.btnSaludar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaludar.Location = new System.Drawing.Point(25, 210);
            this.btnSaludar.Name = "btnSaludar";
            this.btnSaludar.Size = new System.Drawing.Size(120, 50);
            this.btnSaludar.TabIndex = 0;
            this.btnSaludar.Text = "&Saludar";
            this.btnSaludar.UseVisualStyleBackColor = true;
            this.btnSaludar.Click += new System.EventHandler(this.btnSaludar_Click);
            // 
            // btnIVA
            // 
            this.btnIVA.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIVA.Location = new System.Drawing.Point(200, 210);
            this.btnIVA.Name = "btnIVA";
            this.btnIVA.Size = new System.Drawing.Size(120, 50);
            this.btnIVA.TabIndex = 1;
            this.btnIVA.Text = "&Calcular IVA";
            this.btnIVA.UseVisualStyleBackColor = true;
            this.btnIVA.Click += new System.EventHandler(this.btnIVA_Click);
            // 
            // btnAreaCirculo
            // 
            this.btnAreaCirculo.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAreaCirculo.Location = new System.Drawing.Point(375, 210);
            this.btnAreaCirculo.Name = "btnAreaCirculo";
            this.btnAreaCirculo.Size = new System.Drawing.Size(120, 50);
            this.btnAreaCirculo.TabIndex = 2;
            this.btnAreaCirculo.Text = "&Area de un Círculo";
            this.btnAreaCirculo.UseVisualStyleBackColor = true;
            this.btnAreaCirculo.Click += new System.EventHandler(this.btnAreaCirculo_Click);
            // 
            // btnPromedio
            // 
            this.btnPromedio.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPromedio.Location = new System.Drawing.Point(550, 210);
            this.btnPromedio.Name = "btnPromedio";
            this.btnPromedio.Size = new System.Drawing.Size(120, 50);
            this.btnPromedio.TabIndex = 3;
            this.btnPromedio.Text = "&Promedio Notas";
            this.btnPromedio.UseVisualStyleBackColor = true;
            this.btnPromedio.Click += new System.EventHandler(this.btnPromedio_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(291, 402);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(120, 50);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "Sa&lir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // lblBienvenida
            // 
            this.lblBienvenida.AutoSize = true;
            this.lblBienvenida.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBienvenida.Location = new System.Drawing.Point(87, 38);
            this.lblBienvenida.Name = "lblBienvenida";
            this.lblBienvenida.Size = new System.Drawing.Size(529, 22);
            this.lblBienvenida.TabIndex = 5;
            this.lblBienvenida.Text = "\"BIENVENIDOS!!  -  TALLER 1 PROGRAMACION C# .NET\"";
            // 
            // picMainSaludo
            // 
            this.picMainSaludo.Image = global::Taller1.Properties.Resources.saludar;
            this.picMainSaludo.Location = new System.Drawing.Point(35, 100);
            this.picMainSaludo.Name = "picMainSaludo";
            this.picMainSaludo.Size = new System.Drawing.Size(100, 100);
            this.picMainSaludo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picMainSaludo.TabIndex = 6;
            this.picMainSaludo.TabStop = false;
            this.tipMain.SetToolTip(this.picMainSaludo, "Aplicación Saludo");
            // 
            // picMainCalcular
            // 
            this.picMainCalcular.Image = global::Taller1.Properties.Resources.calcular;
            this.picMainCalcular.Location = new System.Drawing.Point(210, 100);
            this.picMainCalcular.Name = "picMainCalcular";
            this.picMainCalcular.Size = new System.Drawing.Size(100, 100);
            this.picMainCalcular.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picMainCalcular.TabIndex = 7;
            this.picMainCalcular.TabStop = false;
            this.tipMain.SetToolTip(this.picMainCalcular, "Aplicación Calculo de IVA");
            // 
            // picMainCirculo
            // 
            this.picMainCirculo.Image = global::Taller1.Properties.Resources.circulo;
            this.picMainCirculo.Location = new System.Drawing.Point(384, 100);
            this.picMainCirculo.Name = "picMainCirculo";
            this.picMainCirculo.Size = new System.Drawing.Size(100, 100);
            this.picMainCirculo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picMainCirculo.TabIndex = 8;
            this.picMainCirculo.TabStop = false;
            this.tipMain.SetToolTip(this.picMainCirculo, "Aplicación Area de Circulo");
            // 
            // picMainPromedio
            // 
            this.picMainPromedio.Image = global::Taller1.Properties.Resources.promedio;
            this.picMainPromedio.Location = new System.Drawing.Point(559, 100);
            this.picMainPromedio.Name = "picMainPromedio";
            this.picMainPromedio.Size = new System.Drawing.Size(100, 100);
            this.picMainPromedio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picMainPromedio.TabIndex = 9;
            this.picMainPromedio.TabStop = false;
            this.tipMain.SetToolTip(this.picMainPromedio, "Aplicación Promedio de Notas");
            // 
            // picMainSalir
            // 
            this.picMainSalir.Image = global::Taller1.Properties.Resources.salir;
            this.picMainSalir.Location = new System.Drawing.Point(301, 296);
            this.picMainSalir.Name = "picMainSalir";
            this.picMainSalir.Size = new System.Drawing.Size(100, 100);
            this.picMainSalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picMainSalir.TabIndex = 10;
            this.picMainSalir.TabStop = false;
            this.tipMain.SetToolTip(this.picMainSalir, "Salir del Programa");
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(702, 479);
            this.ControlBox = false;
            this.Controls.Add(this.picMainSalir);
            this.Controls.Add(this.picMainPromedio);
            this.Controls.Add(this.picMainCirculo);
            this.Controls.Add(this.picMainCalcular);
            this.Controls.Add(this.picMainSaludo);
            this.Controls.Add(this.lblBienvenida);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnPromedio);
            this.Controls.Add(this.btnAreaCirculo);
            this.Controls.Add(this.btnIVA);
            this.Controls.Add(this.btnSaludar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal - Taller 1";
            ((System.ComponentModel.ISupportInitialize)(this.picMainSaludo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMainCalcular)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMainCirculo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMainPromedio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMainSalir)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSaludar;
        private System.Windows.Forms.Button btnIVA;
        private System.Windows.Forms.Button btnAreaCirculo;
        private System.Windows.Forms.Button btnPromedio;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label lblBienvenida;
        private System.Windows.Forms.PictureBox picMainSaludo;
        private System.Windows.Forms.PictureBox picMainCalcular;
        private System.Windows.Forms.PictureBox picMainCirculo;
        private System.Windows.Forms.PictureBox picMainPromedio;
        private System.Windows.Forms.PictureBox picMainSalir;
        private System.Windows.Forms.ToolTip tipMain;
    }
}

