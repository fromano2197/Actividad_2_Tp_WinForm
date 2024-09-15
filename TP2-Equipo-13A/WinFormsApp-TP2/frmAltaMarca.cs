using dominio;
using negocio;
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
    public partial class frmAltaMarca : Form
    {
        public frmAltaMarca()
        {
            InitializeComponent();
        }


        private void btnAgregarMarca_Click(object sender, EventArgs e)
        {
            MarcaNegocio negocio = new MarcaNegocio();
            try
            {
                Marca marca = new Marca();
                marca.Descripcion = txtAgregarMarca.Text;
                if(marca.Descripcion == "")
                {
                    MessageBox.Show("Por favor ingrese la Marca a agregar");

                }
                else
                {
                    negocio.agregarMarca(marca);
                    MessageBox.Show("Marca agregada con exito");
                    this.Close();
                }
                

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void frmAltaMarca_Load(object sender, EventArgs e)
        {

        }

        private void btnCancelarMarca_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
