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
        private Articulo articulo = null;
        public FormProductoAgregar()
        {
            InitializeComponent();
        }
        public FormProductoAgregar(Articulo articulo)
        {
            InitializeComponent();
            this.articulo = articulo;
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
                obj.Marca = new Marca();// se debe instanciar para que nazca el objeto
                obj.Marca.Id = Convert.ToInt32(cboIdMarca.SelectedValue.ToString());
                obj.Categoria = new Categoria();
                obj.Categoria.Id = Convert.ToInt32(cboIdCategoria.SelectedValue.ToString());
                obj.Precio = decimal.Parse(txtElemPrecio.Text);
                
                servicioArticulo.AgregarArticulo(obj);
                MessageBox.Show(" Operarcion exitosa ");

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void FormProductoAgregar_Load(object sender, EventArgs e)
        {
            ServicioCategoria servicioCategoria = new ServicioCategoria();
            ServicioMarca servicioMarca = new ServicioMarca();
             
            try 
            {
                cboIdMarca.DisplayMember = "Descripcion"; // indica que campo de la identidad Marca se muestra
                cboIdCategoria.DisplayMember = "Descripcion";
                cboIdMarca.ValueMember = "Id";
                cboIdCategoria.ValueMember = "Id";

                cboIdMarca.DataSource = servicioMarca.ListarMarcas();
                cboIdCategoria.DataSource = servicioCategoria.ListarCategorias();
                
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
