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

namespace ProyectoApp
{
    public partial class Form2Productos : Form
    {
        ServicioArticulo servicioArticulo;
        private List<Articulo> lista;
        public Form2Productos()
        {
            InitializeComponent();
        }

        private void Form2Productos_Load(object sender, EventArgs e)   // <-- este Form lo uso para el obj de ver prod.
        {
            servicioArticulo = new ServicioArticulo();
            lista = servicioArticulo.ListarArticulos();//esto lo llevo arriba como private

            dgvProductos.DataSource = lista;
            dgvProductos.Columns["UrlImagen"].Visible = false;
            cargarImagen(lista[0].UrlImagen);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
           FormProductoAgregar formProductoAgregar = new FormProductoAgregar();
            formProductoAgregar.ShowDialog();
            Form2Productos_Load(sender, e);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            ServicioArticulo servicioArticulo=new ServicioArticulo();
            Articulo seleccionado;
            try
            {
                DialogResult resultado = MessageBox.Show(" ¿Seguro desea eliminar ? ", " Eliminado", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (resultado == DialogResult.Yes)
                {
                    seleccionado = (Articulo)dgvProductos.CurrentRow.DataBoundItem;
                    servicioArticulo.EliminarArticulo(seleccionado.Id);
                    //Cargar();
                    Form2Productos_Load(sender, e);
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            //Articulo seleccionado;
            //seleccionado = (Articulo)dgvProductos.CurrentRow.DataBoundItem;// <<-- con esto tenemos el articulo seleccionado
            //FormProductoAgregar formProductoModificar = new FormProductoAgregar(seleccionado);
            //formProductoModificar.ShowDialog();
        }

        private void dgvProductos_SelectionChanged(object sender, EventArgs e)
        {
            Articulo seleccionado = (Articulo)dgvProductos.CurrentRow.DataBoundItem;
            cargarImagen(seleccionado.UrlImagen);
        }

        private void cargarImagen(string imagen)
        {
            try
            {
                pictureBoxImagenArt.Load(imagen);
            }
            catch (Exception ex)
            {
                pictureBoxImagenArt.Load("https://img.freepik.com/vector-premium/vector-icono-imagen-predeterminado-pagina-imagen-faltante-diseno-sitio-web-o-aplicacion-movil-no-hay-foto-disponible_87543-11093.jpg?size=626&ext=jpg&ga=GA1.1.567537646.1689895045&semt=ais");
            }
        }

        private void btnVerProducto_Click(object sender, EventArgs e)
        {
            Articulo articuloSeleccionado = new Articulo();

            articuloSeleccionado = (Articulo)dgvProductos.CurrentRow.DataBoundItem;

            FormVerProducto formVerProducto = new FormVerProducto(articuloSeleccionado);
            formVerProducto.ShowDialog();
            
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            List<Articulo> listaFiltrada;
            string filtro = textBox1.Text;

            servicioArticulo = new ServicioArticulo();
            lista = servicioArticulo.ListarArticulos();

            if (filtro != "")
            {
                listaFiltrada = lista.FindAll(x => x.Codigo.ToUpper().Contains(filtro.ToUpper()) || x.Nombre.ToUpper().Contains(filtro.ToUpper()) || x.Descripcion.ToUpper().Contains(filtro.ToUpper()) || x.Marca.Descripcion.ToUpper().Contains(filtro.ToUpper()) || x.Categoria.Descripcion.ToUpper().Contains(filtro.ToUpper()));
            }
            else
            {
                listaFiltrada = lista;
            }

            dgvProductos.DataSource = null;
            dgvProductos.DataSource = listaFiltrada;
        }
    }
}
