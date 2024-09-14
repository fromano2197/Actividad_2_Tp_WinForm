namespace WinFormsApp_TP2
{
    partial class frmAgregarImagen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAgregarImagen));
            this.lblURLImagen = new System.Windows.Forms.Label();
            this.txtURLImagen = new System.Windows.Forms.TextBox();
            this.ptbImagenNueva = new System.Windows.Forms.PictureBox();
            this.btnAgregarImagen = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtArticuloSeleccionado = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.ptbImagenNueva)).BeginInit();
            this.SuspendLayout();
            // 
            // lblURLImagen
            // 
            this.lblURLImagen.AutoSize = true;
            this.lblURLImagen.Location = new System.Drawing.Point(125, 58);
            this.lblURLImagen.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblURLImagen.Name = "lblURLImagen";
            this.lblURLImagen.Size = new System.Drawing.Size(82, 16);
            this.lblURLImagen.TabIndex = 0;
            this.lblURLImagen.Text = "URL Imagen";
            // 
            // txtURLImagen
            // 
            this.txtURLImagen.Location = new System.Drawing.Point(256, 54);
            this.txtURLImagen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtURLImagen.Name = "txtURLImagen";
            this.txtURLImagen.Size = new System.Drawing.Size(301, 22);
            this.txtURLImagen.TabIndex = 1;
            this.txtURLImagen.TextChanged += new System.EventHandler(this.txtURLImagen_TextChanged);
            // 
            // ptbImagenNueva
            // 
            this.ptbImagenNueva.Location = new System.Drawing.Point(99, 98);
            this.ptbImagenNueva.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ptbImagenNueva.Name = "ptbImagenNueva";
            this.ptbImagenNueva.Size = new System.Drawing.Size(507, 308);
            this.ptbImagenNueva.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbImagenNueva.TabIndex = 2;
            this.ptbImagenNueva.TabStop = false;
            // 
            // btnAgregarImagen
            // 
            this.btnAgregarImagen.Location = new System.Drawing.Point(240, 438);
            this.btnAgregarImagen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAgregarImagen.Name = "btnAgregarImagen";
            this.btnAgregarImagen.Size = new System.Drawing.Size(220, 33);
            this.btnAgregarImagen.TabIndex = 3;
            this.btnAgregarImagen.Text = "Agregar";
            this.btnAgregarImagen.UseVisualStyleBackColor = true;
            this.btnAgregarImagen.Click += new System.EventHandler(this.btnAgregarImagen_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(125, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nombre Articulo";
            // 
            // txtArticuloSeleccionado
            // 
            this.txtArticuloSeleccionado.Location = new System.Drawing.Point(256, 22);
            this.txtArticuloSeleccionado.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtArticuloSeleccionado.Name = "txtArticuloSeleccionado";
            this.txtArticuloSeleccionado.Size = new System.Drawing.Size(301, 22);
            this.txtArticuloSeleccionado.TabIndex = 5;
            // 
            // frmAgregarImagen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(719, 513);
            this.Controls.Add(this.txtArticuloSeleccionado);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAgregarImagen);
            this.Controls.Add(this.ptbImagenNueva);
            this.Controls.Add(this.txtURLImagen);
            this.Controls.Add(this.lblURLImagen);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmAgregarImagen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar Imagen";
            this.Load += new System.EventHandler(this.frmAgregarImagen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ptbImagenNueva)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblURLImagen;
        private System.Windows.Forms.TextBox txtURLImagen;
        private System.Windows.Forms.PictureBox ptbImagenNueva;
        private System.Windows.Forms.Button btnAgregarImagen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtArticuloSeleccionado;
    }
}