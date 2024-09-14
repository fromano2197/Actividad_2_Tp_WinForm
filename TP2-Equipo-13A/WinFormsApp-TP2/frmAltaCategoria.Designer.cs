namespace WinFormsApp_TP2
{
    partial class frmAltaCategoria
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAltaCategoria));
            this.lblAgregarCategoria = new System.Windows.Forms.Label();
            this.txtAgregarCategoria = new System.Windows.Forms.TextBox();
            this.btnAgregarCategoria = new System.Windows.Forms.Button();
            this.btnCancelarCategoria = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblAgregarCategoria
            // 
            this.lblAgregarCategoria.AutoSize = true;
            this.lblAgregarCategoria.Location = new System.Drawing.Point(164, 121);
            this.lblAgregarCategoria.Name = "lblAgregarCategoria";
            this.lblAgregarCategoria.Size = new System.Drawing.Size(210, 16);
            this.lblAgregarCategoria.TabIndex = 0;
            this.lblAgregarCategoria.Text = "Ingrese la Categoria a dar de Alta:";
            // 
            // txtAgregarCategoria
            // 
            this.txtAgregarCategoria.Location = new System.Drawing.Point(402, 121);
            this.txtAgregarCategoria.Name = "txtAgregarCategoria";
            this.txtAgregarCategoria.Size = new System.Drawing.Size(207, 22);
            this.txtAgregarCategoria.TabIndex = 1;
            // 
            // btnAgregarCategoria
            // 
            this.btnAgregarCategoria.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregarCategoria.Location = new System.Drawing.Point(167, 229);
            this.btnAgregarCategoria.Name = "btnAgregarCategoria";
            this.btnAgregarCategoria.Size = new System.Drawing.Size(139, 32);
            this.btnAgregarCategoria.TabIndex = 2;
            this.btnAgregarCategoria.Text = "Agregar";
            this.btnAgregarCategoria.UseVisualStyleBackColor = true;
            this.btnAgregarCategoria.Click += new System.EventHandler(this.btnAgregarCategoria_Click);
            // 
            // btnCancelarCategoria
            // 
            this.btnCancelarCategoria.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelarCategoria.Location = new System.Drawing.Point(470, 229);
            this.btnCancelarCategoria.Name = "btnCancelarCategoria";
            this.btnCancelarCategoria.Size = new System.Drawing.Size(139, 32);
            this.btnCancelarCategoria.TabIndex = 3;
            this.btnCancelarCategoria.Text = "Cancelar";
            this.btnCancelarCategoria.UseVisualStyleBackColor = true;
            this.btnCancelarCategoria.Click += new System.EventHandler(this.btnCancelarCategoria_Click);
            // 
            // frmAltaCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(772, 318);
            this.Controls.Add(this.btnCancelarCategoria);
            this.Controls.Add(this.btnAgregarCategoria);
            this.Controls.Add(this.txtAgregarCategoria);
            this.Controls.Add(this.lblAgregarCategoria);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmAltaCategoria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar Categoria";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAgregarCategoria;
        private System.Windows.Forms.TextBox txtAgregarCategoria;
        private System.Windows.Forms.Button btnAgregarCategoria;
        private System.Windows.Forms.Button btnCancelarCategoria;
    }
}