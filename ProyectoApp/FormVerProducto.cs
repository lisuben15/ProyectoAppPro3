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
            this.lblMarca.Text = 
            this.lblCategoria.Text = 
            this.lblPrecio.Text =articulo.Precio.ToString();
            cargarImagen(articulo.UrlImagen);

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
    }
}
