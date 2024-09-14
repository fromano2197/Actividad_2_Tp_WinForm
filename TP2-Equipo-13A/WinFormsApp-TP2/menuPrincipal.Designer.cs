namespace WinFormsApp_TP2
{
    partial class frmMenuPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenuPrincipal));
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pboInventario = new System.Windows.Forms.PictureBox();
            this.pboAgregarMarcas = new System.Windows.Forms.PictureBox();
            this.pboAgregarCategorias = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboInventario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboAgregarMarcas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboAgregarCategorias)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(116, 11);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(399, 184);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 24;
            this.pictureBox2.TabStop = false;
            // 
            // pboInventario
            // 
            this.pboInventario.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pboInventario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pboInventario.Image = ((System.Drawing.Image)(resources.GetObject("pboInventario.Image")));
            this.pboInventario.InitialImage = null;
            this.pboInventario.Location = new System.Drawing.Point(13, 229);
            this.pboInventario.Margin = new System.Windows.Forms.Padding(4);
            this.pboInventario.Name = "pboInventario";
            this.pboInventario.Size = new System.Drawing.Size(175, 158);
            this.pboInventario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboInventario.TabIndex = 25;
            this.pboInventario.TabStop = false;
            this.pboInventario.Click += new System.EventHandler(this.pboInventario_Click);
            // 
            // pboAgregarMarcas
            // 
            this.pboAgregarMarcas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pboAgregarMarcas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pboAgregarMarcas.Image = ((System.Drawing.Image)(resources.GetObject("pboAgregarMarcas.Image")));
            this.pboAgregarMarcas.InitialImage = null;
            this.pboAgregarMarcas.Location = new System.Drawing.Point(220, 229);
            this.pboAgregarMarcas.Margin = new System.Windows.Forms.Padding(4);
            this.pboAgregarMarcas.Name = "pboAgregarMarcas";
            this.pboAgregarMarcas.Size = new System.Drawing.Size(179, 158);
            this.pboAgregarMarcas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboAgregarMarcas.TabIndex = 27;
            this.pboAgregarMarcas.TabStop = false;
            this.pboAgregarMarcas.Click += new System.EventHandler(this.pboAgregarMarcas_Click);
            // 
            // pboAgregarCategorias
            // 
            this.pboAgregarCategorias.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pboAgregarCategorias.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pboAgregarCategorias.Image = ((System.Drawing.Image)(resources.GetObject("pboAgregarCategorias.Image")));
            this.pboAgregarCategorias.InitialImage = null;
            this.pboAgregarCategorias.Location = new System.Drawing.Point(430, 229);
            this.pboAgregarCategorias.Margin = new System.Windows.Forms.Padding(4);
            this.pboAgregarCategorias.Name = "pboAgregarCategorias";
            this.pboAgregarCategorias.Size = new System.Drawing.Size(186, 158);
            this.pboAgregarCategorias.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboAgregarCategorias.TabIndex = 28;
            this.pboAgregarCategorias.TabStop = false;
            this.pboAgregarCategorias.Click += new System.EventHandler(this.pboAgregarCategorias_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(50, 407);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 20);
            this.label1.TabIndex = 29;
            this.label1.Text = "Inventario";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(274, 407);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 20);
            this.label3.TabIndex = 31;
            this.label3.Text = "Marcas";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(474, 407);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 20);
            this.label4.TabIndex = 32;
            this.label4.Text = "Categorias";
            // 
            // frmMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(629, 458);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pboAgregarCategorias);
            this.Controls.Add(this.pboAgregarMarcas);
            this.Controls.Add(this.pboInventario);
            this.Controls.Add(this.pictureBox2);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(647, 505);
            this.MinimizeBox = false;
            this.Name = "frmMenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Principal";
            this.Load += new System.EventHandler(this.frmMenuPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboInventario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboAgregarMarcas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboAgregarCategorias)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pboInventario;
        private System.Windows.Forms.PictureBox pboAgregarMarcas;
        private System.Windows.Forms.PictureBox pboAgregarCategorias;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}