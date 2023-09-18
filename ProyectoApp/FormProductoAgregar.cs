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
        private OpenFileDialog archivo = null;
        List<string> UrlsImagenes = new List<string>();
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
                
                int idArticulo = servicioArticulo.seleccionoUltimoRegistro(articulo);
                    if (UrlsImagenes.Count == 0)
                    {
                        servicioArticulo.GuardarImagenRelacionada(idArticulo, articulo.UrlImagen);
                    }
                    else {
                        servicioArticulo.AgregarImagenes(idArticulo, UrlsImagenes);
                    }

                MessageBox.Show(" Operacion exitosa ");
                }
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Por favor verifique los campos ingresados");
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

                if (articulo != null)
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

        private void lblTitulo_Click(object sender, EventArgs e)
        {

        }


        private void btnAgregar_MouseEnter(object sender, EventArgs e)
        {
            btnAgregar.Width += 5;
            btnAgregar.Height += 5;
        }
        private void btnAgregar_MouseLeave(object sender, EventArgs e)
        {
            btnAgregar.Width -= 5;
            btnAgregar.Height -= 5;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!txtImagen.Text.ToUpper().Contains("HTTP") || !txtImagen.Text.ToUpper().Contains("JPG")) {
                MessageBox.Show("Por favor verifique la URL de la imagen.");
            }
            else
            {
                UrlsImagenes.Add(txtImagen.Text);
                label1.Text = UrlsImagenes.Count.ToString();
                txtImagen.Text = "";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            archivo = new OpenFileDialog();
            archivo.Filter = "jpg|*.jpg;|png|*.png";
            if (archivo.ShowDialog() == DialogResult.OK)
            {
                UrlsImagenes.Add(archivo.FileName);
                label1.Text = UrlsImagenes.Count.ToString();
            }
        }
    }
        
}
