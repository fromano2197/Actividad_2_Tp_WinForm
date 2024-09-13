using dominio;
using negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
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
            ArticuloNegocio art = new ArticuloNegocio();
            try
            {

                listaArticulos = art.listar();
                dgvLista.DataSource = listaArticulos;
                dgvLista.Columns["UrlImagen"].Visible = false;
                cargarImagen(listaArticulos[0].UrlImagen.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al cargar los datos: " + ex.Message);
            }

            cboCampo.Items.Add("Nombre");
            cboCampo.Items.Add("Descripcion");
            cboCampo.Items.Add("Marca");
            cboCampo.Items.Add("Categoria");
            cboCampo.Items.Add("Precio");
        }

        private void cargarImagen(string imagen)
        {
            try
            {
                ptbImagen.Load(imagen);
            }
            catch (Exception)
            {
                ptbImagen.Load("https://img.freepik.com/vector-premium/no-hay-foto-disponible-icono-vector-simbolo-imagen-predeterminado-imagen-proximamente-sitio-web-o-aplicacion-movil_87543-10615.jpg");
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmAltaArticulo frmAltaArticulo = new frmAltaArticulo();
            frmAltaArticulo.ShowDialog();
            cargar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            eliminar();
        }

        private void eliminar()
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
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

        private void txtBusquedaRapida_TextChanged(object sender, EventArgs e)
        {
            List<Articulo> listaFiltrada;

            string filtro = txtBusquedaRapida.Text;

            if (filtro.Length >= 3)
            {
                listaFiltrada = listaArticulos.FindAll(x => x.Nombre.ToUpper().Contains(filtro.ToUpper()) || x.Descripcion.ToUpper().Contains(filtro.ToUpper()) || x.Codigo.ToUpper().Contains(filtro.ToUpper()) || x.Marca.Descripcion.ToUpper().Contains(filtro.ToUpper()) || x.Categoria.Descripcion.ToUpper().Contains(filtro.ToUpper()));
                dgvLista.Columns["UrlImagen"].Visible = false;

            }
            else
            {
                listaFiltrada = listaArticulos;
                dgvLista.Columns["UrlImagen"].Visible = false;

            }


            dgvLista.DataSource = null;
            dgvLista.DataSource = listaFiltrada;
            dgvLista.Columns["UrlImagen"].Visible = false;

        }

        private void cboCampo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string opcion = cboCampo.SelectedItem.ToString();

            if (opcion == "Precio")
            {
                cboCriterio.Items.Clear();
                cboCriterio.Items.Add("Mayor a");
                cboCriterio.Items.Add("Menor a");
                cboCriterio.Items.Add("Igual a");
            }
            else
            {
                cboCriterio.Items.Clear();
                cboCriterio.Items.Add("Comienza con");
                cboCriterio.Items.Add("Termina con");
                cboCriterio.Items.Add("Contiene");
            }
        }


        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            if (cboCampo.SelectedItem == null || cboCriterio.SelectedItem == null)
            {
                MessageBox.Show("Por favor, selecciona tanto un campo como un criterio antes de filtrar.");
                return;
            }

            string campo = cboCampo.SelectedItem.ToString();
            string criterio = cboCriterio.SelectedItem.ToString();
            string filtro = txtFiltroAvanzado.Text;

            if (string.IsNullOrEmpty(filtro))
            {
                dgvLista.DataSource = listaArticulos;
                return;
            }

            ArticuloNegocio negocio = new ArticuloNegocio();
            try
            {
                dgvLista.DataSource = negocio.filtrar(campo, criterio, filtro);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al filtrar: " + ex.Message);
            }
        }


        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dgvLista.CurrentRow != null)
            {
                Articulo seleccionado = dgvLista.CurrentRow.DataBoundItem as Articulo;
                if (seleccionado != null)
                {
                    frmAltaArticulo modificar = new frmAltaArticulo(seleccionado);
                    if (modificar.ShowDialog() == DialogResult.OK)
                    {
                        cargar();
                    }
                }
                else
                {
                    MessageBox.Show("El artículo seleccionado no es válido.");
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un artículo para modificar.");
            }
        }
    }
}
