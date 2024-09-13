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
    public partial class frmAgregarImagen : Form
    {
        Articulo articulo = null;
        public frmAgregarImagen(Articulo articulo)
        {
            InitializeComponent();
            this.articulo = articulo;

            
        }

        private void frmAgregarImagen_Load(object sender, EventArgs e)
        {
            

            try
            {
                if (articulo != null)
                {
                    txtArticuloSeleccionado.Text = articulo.Nombre;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
}

        private void txtURLImagen_TextChanged(object sender, EventArgs e)
        {
            {
                cargarImagen(txtURLImagen.Text);
            }
            void cargarImagen(string imagen)
            {
                try
                {
                    ptbImagenNueva.Load(imagen);
                }
                catch (Exception ex)
                {
                    ptbImagenNueva.Load("https://img.freepik.com/vector-premium/no-hay-foto-disponible-icono-vector-simbolo-imagen-predeterminado-imagen-proximamente-sitio-web-o-aplicacion-movil_87543-10615.jpg");
                }
            }
        }

        private void btnAgregarImagen_Click(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            ImagenNegocio imagen = new ImagenNegocio();

            
            try
            {
                articulo.UrlImagen.ImagenUrl = (string)txtURLImagen.Text;
                if (articulo.UrlImagen.ImagenUrl != null)
                {

                    imagen.agregar(articulo.Id, articulo.UrlImagen.ImagenUrl);
                    MessageBox.Show("Imagen agregada con exito");

                }

                negocio.listar();

                Close();
                


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }


}
    }
    }

