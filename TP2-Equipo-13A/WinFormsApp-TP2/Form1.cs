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
    public partial class frmPrincipal : Form
    {
        private List<Articulo> listaArticulos;
        public frmPrincipal()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            dgvLista.AutoGenerateColumns = true;
            try
            {
                ArticuloNegocio art = new ArticuloNegocio();
                listaArticulos = art.listar();
                dgvLista.DataSource = listaArticulos;
                dgvLista.Columns["UrlImagen"].Visible = false;
                cargarImagen(listaArticulos[0].UrlImagen.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al cargar los datos: " + ex.Message);
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
               ptbImagen.Load("https://www.shutterstock.com/image-vector/404-error-page-not-found-260nw-1775265947.jpg");
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmAltaArticulo frmAltaArticulo = new frmAltaArticulo();
            frmAltaArticulo.ShowDialog();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            eliminar();
        }

        private void eliminar()
        {
            ArticuloNegocio negocio = new  ArticuloNegocio();
            Articulo seleccionado;
            try
            {
                DialogResult respuesta = MessageBox.Show("¿Desea eliminar el registro?", "Eliminando", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (respuesta == DialogResult.Yes)
                {
                    seleccionado = (Articulo)dgvLista.CurrentRow.DataBoundItem;
                    negocio.eliminar(seleccionado.Id);
                    cargar();
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void cargar()
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            try
            {
                listaArticulos = negocio.listar();
                dgvLista.DataSource = listaArticulos;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void dgvLista_SelectionChanged(object sender, EventArgs e)
        {
            Articulo selccionado = (Articulo)dgvLista.CurrentRow.DataBoundItem;
            cargarImagen(selccionado.UrlImagen.ToString());
        }
    }
}
