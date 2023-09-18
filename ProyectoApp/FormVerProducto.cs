using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dominio;
using negocio;

namespace ProyectoApp
{
    public partial class FormVerProducto : Form
    {
        List<string> UrlsImagenes = new List<string>();
        int index = 0;
        public FormVerProducto()
        {
            InitializeComponent();
        }
        public FormVerProducto(Articulo articulo)
        {
            InitializeComponent();
            this.lblCodigo.Text = articulo.Codigo;
            this.lblNombre.Text = articulo.Nombre;
            this.lblDescripcion.Text = articulo.Descripcion;
            this.lblMarca.Text = articulo.Marca.Descripcion; 
            this.lblCategoria.Text = articulo.Categoria.Descripcion; 
            this.lblPrecio.Text =articulo.Precio.ToString();
            ServicioArticulo servicioArticulo = new ServicioArticulo();
            UrlsImagenes = servicioArticulo.ListarImagenes(articulo.Id);
            cargarImagen(articulo.UrlImagen);
            if (UrlsImagenes.Count > 0) { button1.Enabled = true; button2.Enabled = true; }
        }

        private void cargarImagen(string imagen)
        {
            try
            {
                this.pbImagen.Load(imagen);
            }
            catch (Exception ex)
            {
                this.pbImagen.Load("https://img.freepik.com/vector-premium/vector-icono-imagen-predeterminado-pagina-imagen-faltante-diseno-sitio-web-o-aplicacion-movil-no-hay-foto-disponible_87543-11093.jpg?size=626&ext=jpg&ga=GA1.1.567537646.1689895045&semt=ais");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (index == 0) { index = UrlsImagenes.Count-1; cargarImagen(UrlsImagenes[index]); }
            else { index--; cargarImagen(UrlsImagenes[index]); }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (index == UrlsImagenes.Count-1) { index = 0; cargarImagen(UrlsImagenes[index]); }
            else { index++; cargarImagen(UrlsImagenes[index]); }
        }
    }
}
