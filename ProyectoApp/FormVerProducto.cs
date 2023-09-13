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
        public FormVerProducto(DetalleArticulo detalleArticulo)
        {
            InitializeComponent();
            this.lblCodigo.Text = detalleArticulo.Codigo;
            this.lblNombre.Text = detalleArticulo.Nombre;
            this.lblDescripcion.Text = detalleArticulo.Descripcion;
            this.lblMarca.Text = detalleArticulo.DescripcionMarca;
            this.lblCategoria.Text = detalleArticulo.DescripcionCategoria;
            this.lblPrecio.Text =detalleArticulo.Precio.ToString();
            cargarImagen(detalleArticulo.UrlImagen);

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
