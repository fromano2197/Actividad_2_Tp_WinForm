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
    public partial class frmDetalle : Form
    {
        private Articulo articulo = null;
        public frmDetalle(Articulo articulo)
        {
            InitializeComponent();
            this.articulo = articulo;
            Text = "Detalle Articulo";
        }

        private void frmDetalle_Load(object sender, EventArgs e)
        {
            MarcaNegocio marcaNegocio = new negocio.MarcaNegocio();
            CategoriaNegocio categoriaNegocio = new negocio.CategoriaNegocio();
            try
            {


                txtCodigoDetalle.Text = articulo.Codigo;
                txtNombreDetalle.Text = articulo.Nombre;
                txtDescripcionDetalle.Text = articulo.Descripcion;

                cargarImagen(articulo.UrlImagen.ImagenUrl);

                txtMarcaDetalle.Text = articulo.Marca.Descripcion;
                txtCategoriaDetalle.Text = articulo.Categoria.Descripcion;
                txtPrecioDetalle.Text = articulo.Precio.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void cargarImagen(string imagen)
        {
            try
            {
                ptbImagen.Load(imagen);
            }
            catch (Exception ex)
            {
                ptbImagen.Load("https://img.freepik.com/vector-premium/no-hay-foto-disponible-icono-vector-simbolo-imagen-predeterminado-imagen-proximamente-sitio-web-o-aplicacion-movil_87543-10615.jpg");
            }
        }
    }
}

