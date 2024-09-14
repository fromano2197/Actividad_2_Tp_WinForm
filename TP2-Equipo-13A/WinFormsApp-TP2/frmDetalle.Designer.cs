namespace WinFormsApp_TP2
{
    partial class frmDetalle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDetalle));
            this.txtCategoriaDetalle = new System.Windows.Forms.TextBox();
            this.txtMarcaDetalle = new System.Windows.Forms.TextBox();
            this.ptbImagen = new System.Windows.Forms.PictureBox();
            this.txtPrecioDetalle = new System.Windows.Forms.TextBox();
            this.lblPrecioDetalle = new System.Windows.Forms.Label();
            this.lblCategoriaDetalle = new System.Windows.Forms.Label();
            this.lblMarcaDetalle = new System.Windows.Forms.Label();
            this.txtDescripcionDetalle = new System.Windows.Forms.TextBox();
            this.txtNombreDetalle = new System.Windows.Forms.TextBox();
            this.lblNombreDetalle = new System.Windows.Forms.Label();
            this.lblDescripcionDetalle = new System.Windows.Forms.Label();
            this.txtCodigoDetalle = new System.Windows.Forms.TextBox();
            this.lblCodigoDetalle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ptbImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCategoriaDetalle
            // 
            this.txtCategoriaDetalle.Location = new System.Drawing.Point(251, 308);
            this.txtCategoriaDetalle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCategoriaDetalle.Name = "txtCategoriaDetalle";
            this.txtCategoriaDetalle.ReadOnly = true;
            this.txtCategoriaDetalle.Size = new System.Drawing.Size(160, 22);
            this.txtCategoriaDetalle.TabIndex = 48;
            // 
            // txtMarcaDetalle
            // 
            this.txtMarcaDetalle.Location = new System.Drawing.Point(251, 252);
            this.txtMarcaDetalle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMarcaDetalle.Name = "txtMarcaDetalle";
            this.txtMarcaDetalle.ReadOnly = true;
            this.txtMarcaDetalle.Size = new System.Drawing.Size(160, 22);
            this.txtMarcaDetalle.TabIndex = 47;
            // 
            // ptbImagen
            // 
            this.ptbImagen.Location = new System.Drawing.Point(467, 55);
            this.ptbImagen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ptbImagen.Name = "ptbImagen";
            this.ptbImagen.Size = new System.Drawing.Size(451, 352);
            this.ptbImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbImagen.TabIndex = 46;
            this.ptbImagen.TabStop = false;
            // 
            // txtPrecioDetalle
            // 
            this.txtPrecioDetalle.Location = new System.Drawing.Point(251, 370);
            this.txtPrecioDetalle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPrecioDetalle.Name = "txtPrecioDetalle";
            this.txtPrecioDetalle.ReadOnly = true;
            this.txtPrecioDetalle.Size = new System.Drawing.Size(160, 22);
            this.txtPrecioDetalle.TabIndex = 42;
            this.txtPrecioDetalle.TextChanged += new System.EventHandler(this.txtPrecioDetalle_TextChanged);
            // 
            // lblPrecioDetalle
            // 
            this.lblPrecioDetalle.AutoSize = true;
            this.lblPrecioDetalle.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblPrecioDetalle.Location = new System.Drawing.Point(145, 375);
            this.lblPrecioDetalle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrecioDetalle.Name = "lblPrecioDetalle";
            this.lblPrecioDetalle.Size = new System.Drawing.Size(46, 16);
            this.lblPrecioDetalle.TabIndex = 45;
            this.lblPrecioDetalle.Text = "Precio";
            // 
            // lblCategoriaDetalle
            // 
            this.lblCategoriaDetalle.AutoSize = true;
            this.lblCategoriaDetalle.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblCategoriaDetalle.Location = new System.Drawing.Point(145, 316);
            this.lblCategoriaDetalle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCategoriaDetalle.Name = "lblCategoriaDetalle";
            this.lblCategoriaDetalle.Size = new System.Drawing.Size(66, 16);
            this.lblCategoriaDetalle.TabIndex = 44;
            this.lblCategoriaDetalle.Text = "Categoria";
            // 
            // lblMarcaDetalle
            // 
            this.lblMarcaDetalle.AutoSize = true;
            this.lblMarcaDetalle.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblMarcaDetalle.Location = new System.Drawing.Point(145, 261);
            this.lblMarcaDetalle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMarcaDetalle.Name = "lblMarcaDetalle";
            this.lblMarcaDetalle.Size = new System.Drawing.Size(45, 16);
            this.lblMarcaDetalle.TabIndex = 43;
            this.lblMarcaDetalle.Text = "Marca";
            // 
            // txtDescripcionDetalle
            // 
            this.txtDescripcionDetalle.Location = new System.Drawing.Point(251, 188);
            this.txtDescripcionDetalle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDescripcionDetalle.Name = "txtDescripcionDetalle";
            this.txtDescripcionDetalle.ReadOnly = true;
            this.txtDescripcionDetalle.Size = new System.Drawing.Size(160, 22);
            this.txtDescripcionDetalle.TabIndex = 40;
            // 
            // txtNombreDetalle
            // 
            this.txtNombreDetalle.Location = new System.Drawing.Point(251, 121);
            this.txtNombreDetalle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNombreDetalle.Name = "txtNombreDetalle";
            this.txtNombreDetalle.ReadOnly = true;
            this.txtNombreDetalle.Size = new System.Drawing.Size(160, 22);
            this.txtNombreDetalle.TabIndex = 38;
            // 
            // lblNombreDetalle
            // 
            this.lblNombreDetalle.AutoSize = true;
            this.lblNombreDetalle.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblNombreDetalle.Location = new System.Drawing.Point(145, 129);
            this.lblNombreDetalle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombreDetalle.Name = "lblNombreDetalle";
            this.lblNombreDetalle.Size = new System.Drawing.Size(56, 16);
            this.lblNombreDetalle.TabIndex = 41;
            this.lblNombreDetalle.Text = "Nombre";
            // 
            // lblDescripcionDetalle
            // 
            this.lblDescripcionDetalle.AutoSize = true;
            this.lblDescripcionDetalle.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblDescripcionDetalle.Location = new System.Drawing.Point(145, 197);
            this.lblDescripcionDetalle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescripcionDetalle.Name = "lblDescripcionDetalle";
            this.lblDescripcionDetalle.Size = new System.Drawing.Size(79, 16);
            this.lblDescripcionDetalle.TabIndex = 39;
            this.lblDescripcionDetalle.Text = "Descripcion";
            // 
            // txtCodigoDetalle
            // 
            this.txtCodigoDetalle.Location = new System.Drawing.Point(251, 63);
            this.txtCodigoDetalle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCodigoDetalle.Name = "txtCodigoDetalle";
            this.txtCodigoDetalle.ReadOnly = true;
            this.txtCodigoDetalle.Size = new System.Drawing.Size(160, 22);
            this.txtCodigoDetalle.TabIndex = 37;
            // 
            // lblCodigoDetalle
            // 
            this.lblCodigoDetalle.AutoSize = true;
            this.lblCodigoDetalle.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblCodigoDetalle.Location = new System.Drawing.Point(145, 71);
            this.lblCodigoDetalle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCodigoDetalle.Name = "lblCodigoDetalle";
            this.lblCodigoDetalle.Size = new System.Drawing.Size(51, 16);
            this.lblCodigoDetalle.TabIndex = 36;
            this.lblCodigoDetalle.Text = "Codigo";
            // 
            // frmDetalle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1032, 489);
            this.Controls.Add(this.txtCategoriaDetalle);
            this.Controls.Add(this.txtMarcaDetalle);
            this.Controls.Add(this.ptbImagen);
            this.Controls.Add(this.txtPrecioDetalle);
            this.Controls.Add(this.lblPrecioDetalle);
            this.Controls.Add(this.lblCategoriaDetalle);
            this.Controls.Add(this.lblMarcaDetalle);
            this.Controls.Add(this.txtDescripcionDetalle);
            this.Controls.Add(this.txtNombreDetalle);
            this.Controls.Add(this.lblNombreDetalle);
            this.Controls.Add(this.lblDescripcionDetalle);
            this.Controls.Add(this.txtCodigoDetalle);
            this.Controls.Add(this.lblCodigoDetalle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "frmDetalle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmDetalle";
            this.Load += new System.EventHandler(this.frmDetalle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ptbImagen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCategoriaDetalle;
        private System.Windows.Forms.TextBox txtMarcaDetalle;
        private System.Windows.Forms.PictureBox ptbImagen;
        private System.Windows.Forms.TextBox txtPrecioDetalle;
        private System.Windows.Forms.Label lblPrecioDetalle;
        private System.Windows.Forms.Label lblCategoriaDetalle;
        private System.Windows.Forms.Label lblMarcaDetalle;
        private System.Windows.Forms.TextBox txtDescripcionDetalle;
        private System.Windows.Forms.TextBox txtNombreDetalle;
        private System.Windows.Forms.Label lblNombreDetalle;
        private System.Windows.Forms.Label lblDescripcionDetalle;
        private System.Windows.Forms.TextBox txtCodigoDetalle;
        private System.Windows.Forms.Label lblCodigoDetalle;
    }
}