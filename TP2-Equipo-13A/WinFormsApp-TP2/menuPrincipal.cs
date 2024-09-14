using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WinFormsApp_TP2
{
    public partial class frmMenuPrincipal : Form
    {
        public frmMenuPrincipal()
        {
            InitializeComponent();
        }

        private void pboInventario_Click(object sender, EventArgs e)
        {
             frmPrincipal inventario = new frmPrincipal();
            inventario.ShowDialog();
        }

        private void frmMenuPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void pboAgregarMarcas_Click(object sender, EventArgs e)
        {
            frmAltaMarca marca = new frmAltaMarca();
            marca.ShowDialog();

        }

        private void pboAgregarCategorias_Click(object sender, EventArgs e)
        {
            frmAltaCategoria categoria = new frmAltaCategoria();
            categoria.ShowDialog();
        }
    }
}
