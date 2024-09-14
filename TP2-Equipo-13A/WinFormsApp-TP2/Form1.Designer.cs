namespace WinFormsApp_TP2
{
    partial class frmPrincipal
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.ptbImagen = new System.Windows.Forms.PictureBox();
            this.dgvLista = new System.Windows.Forms.DataGridView();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.lblFiltro = new System.Windows.Forms.Label();
            this.txtBusquedaRapida = new System.Windows.Forms.TextBox();
            this.lblCampo = new System.Windows.Forms.Label();
            this.lblCriterio = new System.Windows.Forms.Label();
            this.lblFiltrar = new System.Windows.Forms.Label();
            this.cboCampo = new System.Windows.Forms.ComboBox();
            this.cboCriterio = new System.Windows.Forms.ComboBox();
            this.txtFiltroAvanzado = new System.Windows.Forms.TextBox();
            this.btnAgregarImagen = new System.Windows.Forms.Button();
            this.iconoCerrar = new System.Windows.Forms.PictureBox();
            this.iconoMaximizar = new System.Windows.Forms.PictureBox();
            this.iconoRestaurar = new System.Windows.Forms.PictureBox();
            this.iconoMinimizar = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnDetalle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ptbImagen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconoCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconoMaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconoRestaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconoMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ptbImagen
            // 
            this.ptbImagen.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ptbImagen.Location = new System.Drawing.Point(644, 97);
            this.ptbImagen.Margin = new System.Windows.Forms.Padding(4);
            this.ptbImagen.Name = "ptbImagen";
            this.ptbImagen.Size = new System.Drawing.Size(480, 311);
            this.ptbImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbImagen.TabIndex = 1;
            this.ptbImagen.TabStop = false;
            // 
            // dgvLista
            // 
            this.dgvLista.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvLista.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvLista.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvLista.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dgvLista.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvLista.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.GrayText;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLista.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvLista.ColumnHeadersHeight = 30;
            this.dgvLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvLista.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvLista.EnableHeadersVisualStyles = false;
            this.dgvLista.GridColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dgvLista.Location = new System.Drawing.Point(24, 97);
            this.dgvLista.Margin = new System.Windows.Forms.Padding(4);
            this.dgvLista.Name = "dgvLista";
            this.dgvLista.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLista.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvLista.RowHeadersVisible = false;
            this.dgvLista.RowHeadersWidth = 51;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.dgvLista.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvLista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLista.Size = new System.Drawing.Size(488, 311);
            this.dgvLista.TabIndex = 2;
            this.dgvLista.SelectionChanged += new System.EventHandler(this.dgvLista_SelectionChanged);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(24, 412);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(145, 41);
            this.btnAgregar.TabIndex = 3;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnModificar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.Location = new System.Drawing.Point(191, 414);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(4);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(145, 41);
            this.btnModificar.TabIndex = 4;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(355, 414);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(157, 39);
            this.btnEliminar.TabIndex = 5;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnFiltrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFiltrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFiltrar.Location = new System.Drawing.Point(1024, 47);
            this.btnFiltrar.Margin = new System.Windows.Forms.Padding(4);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(100, 28);
            this.btnFiltrar.TabIndex = 6;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = true;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // lblFiltro
            // 
            this.lblFiltro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblFiltro.AutoSize = true;
            this.lblFiltro.Location = new System.Drawing.Point(24, 50);
            this.lblFiltro.Name = "lblFiltro";
            this.lblFiltro.Size = new System.Drawing.Size(52, 16);
            this.lblFiltro.TabIndex = 8;
            this.lblFiltro.Text = "Buscar:";
            // 
            // txtBusquedaRapida
            // 
            this.txtBusquedaRapida.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBusquedaRapida.Location = new System.Drawing.Point(87, 44);
            this.txtBusquedaRapida.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBusquedaRapida.Name = "txtBusquedaRapida";
            this.txtBusquedaRapida.Size = new System.Drawing.Size(155, 22);
            this.txtBusquedaRapida.TabIndex = 9;
            this.txtBusquedaRapida.TextChanged += new System.EventHandler(this.txtBusquedaRapida_TextChanged);
            // 
            // lblCampo
            // 
            this.lblCampo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCampo.AutoSize = true;
            this.lblCampo.Location = new System.Drawing.Point(412, 53);
            this.lblCampo.Name = "lblCampo";
            this.lblCampo.Size = new System.Drawing.Size(54, 16);
            this.lblCampo.TabIndex = 10;
            this.lblCampo.Text = "Campo:";
            // 
            // lblCriterio
            // 
            this.lblCriterio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCriterio.AutoSize = true;
            this.lblCriterio.Location = new System.Drawing.Point(640, 53);
            this.lblCriterio.Name = "lblCriterio";
            this.lblCriterio.Size = new System.Drawing.Size(52, 16);
            this.lblCriterio.TabIndex = 11;
            this.lblCriterio.Text = "Criterio:";
            // 
            // lblFiltrar
            // 
            this.lblFiltrar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblFiltrar.AutoSize = true;
            this.lblFiltrar.Location = new System.Drawing.Point(844, 50);
            this.lblFiltrar.Name = "lblFiltrar";
            this.lblFiltrar.Size = new System.Drawing.Size(39, 16);
            this.lblFiltrar.TabIndex = 12;
            this.lblFiltrar.Text = "Filtro:";
            // 
            // cboCampo
            // 
            this.cboCampo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cboCampo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCampo.FormattingEnabled = true;
            this.cboCampo.Location = new System.Drawing.Point(475, 47);
            this.cboCampo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboCampo.Name = "cboCampo";
            this.cboCampo.Size = new System.Drawing.Size(121, 24);
            this.cboCampo.TabIndex = 13;
            this.cboCampo.SelectedIndexChanged += new System.EventHandler(this.cboCampo_SelectedIndexChanged);
            // 
            // cboCriterio
            // 
            this.cboCriterio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cboCriterio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCriterio.FormattingEnabled = true;
            this.cboCriterio.Location = new System.Drawing.Point(701, 48);
            this.cboCriterio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboCriterio.Name = "cboCriterio";
            this.cboCriterio.Size = new System.Drawing.Size(121, 24);
            this.cboCriterio.TabIndex = 14;
            // 
            // txtFiltroAvanzado
            // 
            this.txtFiltroAvanzado.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtFiltroAvanzado.Location = new System.Drawing.Point(892, 49);
            this.txtFiltroAvanzado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtFiltroAvanzado.Name = "txtFiltroAvanzado";
            this.txtFiltroAvanzado.Size = new System.Drawing.Size(124, 22);
            this.txtFiltroAvanzado.TabIndex = 15;
            // 
            // btnAgregarImagen
            // 
            this.btnAgregarImagen.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAgregarImagen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregarImagen.Location = new System.Drawing.Point(940, 412);
            this.btnAgregarImagen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAgregarImagen.Name = "btnAgregarImagen";
            this.btnAgregarImagen.Size = new System.Drawing.Size(184, 39);
            this.btnAgregarImagen.TabIndex = 17;
            this.btnAgregarImagen.Text = "Agregar Imagen";
            this.btnAgregarImagen.UseVisualStyleBackColor = true;
            this.btnAgregarImagen.Click += new System.EventHandler(this.btnAgregarImagen_Click);
            // 
            // iconoCerrar
            // 
            this.iconoCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconoCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconoCerrar.Image = ((System.Drawing.Image)(resources.GetObject("iconoCerrar.Image")));
            this.iconoCerrar.Location = new System.Drawing.Point(1339, 12);
            this.iconoCerrar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.iconoCerrar.Name = "iconoCerrar";
            this.iconoCerrar.Size = new System.Drawing.Size(20, 20);
            this.iconoCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconoCerrar.TabIndex = 18;
            this.iconoCerrar.TabStop = false;
            this.iconoCerrar.Click += new System.EventHandler(this.iconoCerrar_Click);
            // 
            // iconoMaximizar
            // 
            this.iconoMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconoMaximizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconoMaximizar.Image = ((System.Drawing.Image)(resources.GetObject("iconoMaximizar.Image")));
            this.iconoMaximizar.Location = new System.Drawing.Point(1303, 12);
            this.iconoMaximizar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.iconoMaximizar.Name = "iconoMaximizar";
            this.iconoMaximizar.Size = new System.Drawing.Size(20, 20);
            this.iconoMaximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconoMaximizar.TabIndex = 19;
            this.iconoMaximizar.TabStop = false;
            this.iconoMaximizar.Click += new System.EventHandler(this.iconoMaximizar_Click);
            // 
            // iconoRestaurar
            // 
            this.iconoRestaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconoRestaurar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconoRestaurar.Image = ((System.Drawing.Image)(resources.GetObject("iconoRestaurar.Image")));
            this.iconoRestaurar.Location = new System.Drawing.Point(1303, 12);
            this.iconoRestaurar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.iconoRestaurar.Name = "iconoRestaurar";
            this.iconoRestaurar.Size = new System.Drawing.Size(20, 20);
            this.iconoRestaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconoRestaurar.TabIndex = 20;
            this.iconoRestaurar.TabStop = false;
            this.iconoRestaurar.Visible = false;
            this.iconoRestaurar.Click += new System.EventHandler(this.iconoRestaurar_Click);
            // 
            // iconoMinimizar
            // 
            this.iconoMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconoMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconoMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("iconoMinimizar.Image")));
            this.iconoMinimizar.Location = new System.Drawing.Point(1265, 11);
            this.iconoMinimizar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.iconoMinimizar.Name = "iconoMinimizar";
            this.iconoMinimizar.Size = new System.Drawing.Size(20, 20);
            this.iconoMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconoMinimizar.TabIndex = 21;
            this.iconoMinimizar.TabStop = false;
            this.iconoMinimizar.Click += new System.EventHandler(this.iconoMinimizar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1197, 354);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(179, 108);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // btnDetalle
            // 
            this.btnDetalle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDetalle.Location = new System.Drawing.Point(644, 412);
            this.btnDetalle.Margin = new System.Windows.Forms.Padding(4);
            this.btnDetalle.Name = "btnDetalle";
            this.btnDetalle.Size = new System.Drawing.Size(119, 39);
            this.btnDetalle.TabIndex = 23;
            this.btnDetalle.Text = "Detalle";
            this.btnDetalle.UseVisualStyleBackColor = true;
            this.btnDetalle.Click += new System.EventHandler(this.btnDetalle_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1179, 468);
            this.Controls.Add(this.btnDetalle);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.iconoMinimizar);
            this.Controls.Add(this.iconoRestaurar);
            this.Controls.Add(this.iconoMaximizar);
            this.Controls.Add(this.iconoCerrar);
            this.Controls.Add(this.btnAgregarImagen);
            this.Controls.Add(this.txtFiltroAvanzado);
            this.Controls.Add(this.cboCriterio);
            this.Controls.Add(this.cboCampo);
            this.Controls.Add(this.lblFiltrar);
            this.Controls.Add(this.lblCriterio);
            this.Controls.Add(this.lblCampo);
            this.Controls.Add(this.txtBusquedaRapida);
            this.Controls.Add(this.lblFiltro);
            this.Controls.Add(this.btnFiltrar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.dgvLista);
            this.Controls.Add(this.ptbImagen);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Articulos";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ptbImagen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconoCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconoMaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconoRestaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconoMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ptbImagen;
        private System.Windows.Forms.DataGridView dgvLista;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.Label lblFiltro;
        private System.Windows.Forms.TextBox txtBusquedaRapida;
        private System.Windows.Forms.Label lblCampo;
        private System.Windows.Forms.Label lblCriterio;
        private System.Windows.Forms.Label lblFiltrar;
        private System.Windows.Forms.ComboBox cboCampo;
        private System.Windows.Forms.ComboBox cboCriterio;
        private System.Windows.Forms.TextBox txtFiltroAvanzado;
        private System.Windows.Forms.Button btnAgregarImagen;
        private System.Windows.Forms.PictureBox iconoCerrar;
        private System.Windows.Forms.PictureBox iconoMaximizar;
        private System.Windows.Forms.PictureBox iconoRestaurar;
        private System.Windows.Forms.PictureBox iconoMinimizar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnDetalle;
    }
}

