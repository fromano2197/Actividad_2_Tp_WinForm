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
using System.Collections.Generic;

namespace WinFormsApp_TP2
{
    public partial class frmAltaArticulo : Form
    {
        private Articulo articulo = null;

        public frmAltaArticulo()
        {
            InitializeComponent();
        }
        public frmAltaArticulo(Articulo articulo)
        {
            InitializeComponent();
            this.articulo = articulo;
            Text = "Modificar Articulo";
        }




        private void btnAceptar_Click_1(object sender, EventArgs e)
        {
     
            ArticuloNegocio negocio = new ArticuloNegocio();

            try
            {
                if (articulo == null)
                {
                    articulo = new Articulo(); 
                }
                articulo.Codigo = (string)txtCodigo.Text;
                articulo.Nombre = (string)txtNombre.Text;
                articulo.Descripcion = (string)txtDescripcion.Text;
                if (articulo.UrlImagen == null)
                {
                    articulo.UrlImagen = new Imagen();
                }
                articulo.UrlImagen.ImagenUrl = txtURL.Text;
                articulo.Categoria = (Categoria)cboCategoria.SelectedItem;
                articulo.Marca = (Marca)cboMarca.SelectedItem;
                decimal p = 0;
                if (decimal.TryParse(txtPrecio.Text,out p))
                {
                    articulo.Precio = p;
                }
                else
                {
                    articulo.Precio = 0;
                }
           
                if (articulo.Id ==0 )
                {
                    negocio.agregar(articulo);
                    MessageBox.Show("Articulo agregado con exito");
                }
                else
                {
                    negocio.modificar(articulo);
                    MessageBox.Show("Articulo modificado con exito");
                }
                
                negocio.listar();
                Close();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }


        private void frmAltaArticulo_Load(object sender, EventArgs e)
        {
            MarcaNegocio marcaNegocio = new negocio.MarcaNegocio();
            CategoriaNegocio categoriaNegocio = new negocio.CategoriaNegocio();

            try
            {
                cboMarca.DataSource = marcaNegocio.listar();
                cboMarca.ValueMember = "Id";
                cboMarca.DisplayMember = "Descripcion";
                cboCategoria.DataSource = categoriaNegocio.listar();
                cboCategoria.ValueMember = "Id";
                cboCategoria.DisplayMember = "Descripcion";

                if (articulo != null)
                {
                    txtCodigo.Text = articulo.Codigo;
                    txtNombre.Text = articulo.Nombre;
                    txtDescripcion.Text = articulo.Descripcion;
                    txtURL.Text = articulo.UrlImagen?.ImagenUrl ?? ""; 
                    cargarImagen(txtURL.Text);

                    cboMarca.SelectedValue = articulo.Marca.Id;
                    cboCategoria.SelectedValue = articulo.Categoria.Id;
                    txtPrecio.Text = articulo.Precio.ToString("F2");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void txtURL_Leave(object sender, EventArgs e)
        {
            cargarImagen(txtURL.Text);
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

