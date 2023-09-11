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
    public partial class FormProductoAgregar : Form
    {
        public FormProductoAgregar()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Articulo obj = new Articulo();
            ServicioArticulo servicioArticulo = new ServicioArticulo();
            try
            {

                obj.Codigo = txtElemCodigo.Text;
                obj.Nombre = txtElemNombre.Text;
                obj.Descripcion = txtElemDescripcion.Text;
                obj.IdMarca = int.Parse(txtElemIdMarca.Text);
                obj.IdCategoria = int.Parse( txtElemIdCategoria.Text);
                obj.Precio = decimal.Parse(txtElemPrecio.Text);

                servicioArticulo.AgregarArticulo(obj);
                MessageBox.Show(" Operarcion exitosa ");

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
