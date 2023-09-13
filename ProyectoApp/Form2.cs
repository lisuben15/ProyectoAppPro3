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
        private List<DetalleArticulo> lista;
        public Form2Productos()
        {
            InitializeComponent();
        }

        private void Form2Productos_Load(object sender, EventArgs e)   // <-- este Form lo uso para el obj de ver prod.
        {
            servicioArticulo = new ServicioArticulo();
            lista = servicioArticulo.ListarArticulos();//esto lo llevo arriba como private

            dgvProductos.DataSource = lista;
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
            ServicioArticulo servicioArticulo = new ServicioArticulo();
            Articulo seleccionado;
            try 
            {
              //seleccionado = (Articulo)dgvArticulo.curren
            }
            catch(Exception ex)
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
            DetalleArticulo seleccionado = (DetalleArticulo)dgvProductos.CurrentRow.DataBoundItem;
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
            DetalleArticulo articuloSeleccionado = new DetalleArticulo();

            articuloSeleccionado = (DetalleArticulo)dgvProductos.CurrentRow.DataBoundItem;

            FormVerProducto formVerProducto = new FormVerProducto(articuloSeleccionado);
            formVerProducto.ShowDialog();
            
        }
    }
}
