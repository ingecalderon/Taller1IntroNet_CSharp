namespace Taller1
{
    partial class frmSaludar
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
            this.components = new System.ComponentModel.Container();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.btnSaludar = new System.Windows.Forms.Button();
            this.picSaludo = new System.Windows.Forms.PictureBox();
            this.lblSaludo = new System.Windows.Forms.Label();
            this.btnNuevoSaludo = new System.Windows.Forms.Button();
            this.tipSaludar = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picSaludo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(230, 134);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(139, 19);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Digite el nombre:";
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(375, 127);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(150, 26);
            this.txtNombre.TabIndex = 1;
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            // 
            // btnSaludar
            // 
            this.btnSaludar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaludar.Location = new System.Drawing.Point(241, 235);
            this.btnSaludar.Name = "btnSaludar";
            this.btnSaludar.Size = new System.Drawing.Size(100, 50);
            this.btnSaludar.TabIndex = 2;
            this.btnSaludar.Tag = "De Click";
            this.btnSaludar.Text = "&Saludar";
            this.btnSaludar.UseVisualStyleBackColor = true;
            this.btnSaludar.Click += new System.EventHandler(this.btnSaludar2_Click);
            // 
            // picSaludo
            // 
            this.picSaludo.Image = global::Taller1.Properties.Resources.saludo_form;
            this.picSaludo.Location = new System.Drawing.Point(27, 95);
            this.picSaludo.Name = "picSaludo";
            this.picSaludo.Size = new System.Drawing.Size(150, 150);
            this.picSaludo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picSaludo.TabIndex = 3;
            this.picSaludo.TabStop = false;
            this.tipSaludar.SetToolTip(this.picSaludo, "Digita el nombre en el cuadro de texto");
            // 
            // lblSaludo
            // 
            this.lblSaludo.AutoSize = true;
            this.lblSaludo.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaludo.Location = new System.Drawing.Point(111, 19);
            this.lblSaludo.Name = "lblSaludo";
            this.lblSaludo.Size = new System.Drawing.Size(350, 39);
            this.lblSaludo.TabIndex = 4;
            this.lblSaludo.Text = "APLICATIVO QUE TE SALUDA";
            // 
            // btnNuevoSaludo
            // 
            this.btnNuevoSaludo.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoSaludo.Location = new System.Drawing.Point(375, 235);
            this.btnNuevoSaludo.Name = "btnNuevoSaludo";
            this.btnNuevoSaludo.Size = new System.Drawing.Size(100, 50);
            this.btnNuevoSaludo.TabIndex = 5;
            this.btnNuevoSaludo.Text = "&Otro Nombre";
            this.btnNuevoSaludo.UseVisualStyleBackColor = true;
            this.btnNuevoSaludo.Click += new System.EventHandler(this.btnNuevoSaludo_Click);
            // 
            // frmSaludar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(573, 324);
            this.Controls.Add(this.btnNuevoSaludo);
            this.Controls.Add(this.lblSaludo);
            this.Controls.Add(this.picSaludo);
            this.Controls.Add(this.btnSaludar);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblNombre);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSaludar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "App Saludar";
            ((System.ComponentModel.ISupportInitialize)(this.picSaludo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button btnSaludar;
        private System.Windows.Forms.PictureBox picSaludo;
        private System.Windows.Forms.Label lblSaludo;
        private System.Windows.Forms.Button btnNuevoSaludo;
        private System.Windows.Forms.ToolTip tipSaludar;
    }
}