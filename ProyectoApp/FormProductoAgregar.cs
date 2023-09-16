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
            Text = "Modificar Producto";
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            
            ServicioArticulo servicioArticulo = new ServicioArticulo();
            try
            {
                if(articulo == null)
                articulo = new Articulo();

                articulo.Codigo = txtElemCodigo.Text;
                articulo.Nombre = txtElemNombre.Text;
                articulo.Descripcion = txtElemDescripcion.Text;
                articulo.Marca = new Marca();// se debe instanciar para que nazca el objeto
                articulo.Marca.Id = Convert.ToInt32(cboIdMarca.SelectedValue.ToString());
                articulo.Categoria = new Categoria();
                articulo.Categoria.Id = Convert.ToInt32(cboIdCategoria.SelectedValue.ToString());
                articulo.Precio = decimal.Parse(txtElemPrecio.Text);
                articulo.UrlImagen = txtImagen.Text;
             
                
                if(articulo.Id != 0)
                {
                servicioArticulo.ModificarArticulo(articulo);
                MessageBox.Show(" Modificacion exitosa");
                }
                else
                {
                 
                servicioArticulo.AgregarArticulo(articulo);
                 Articulo articulo1 = new Articulo();
                 articulo1 = servicioArticulo.seleccionoUltimoRegistro(articulo);
                servicioArticulo.GuardarImagenRelacionada(articulo1);

                MessageBox.Show(" Operarcion exitosa ");
                }





                this.Close();
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

                if(articulo != null)
                {
                    txtElemCodigo.Text = articulo.Codigo;
                    txtElemNombre.Text = articulo.Nombre;
                    txtElemDescripcion.Text = articulo.Descripcion;
                    txtElemPrecio.Text = articulo.Precio.ToString();
                    cboIdMarca.SelectedValue = articulo.Marca.Id;  
                    cboIdCategoria.SelectedValue = articulo.Marca.Id;   
                }
                
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.ToString());
            }
        }

    }
        
}
