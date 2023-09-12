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

        private void FormProductoAgregar_Load(object sender, EventArgs e)
        {
            //Marca selectedMarca = comboBox1Marcas.SelectedItem;
            ServicioMarca servicioMarca = new ServicioMarca();
            List<Marca> listaMarcas = servicioMarca.ListarMarcas();

            comboBox1.DataSource = listaMarcas;
            comboBox1.DisplayMember = "Descripcion";
            comboBox1.ValueMember = "Id";

            //Categoria selectedCategoria = comboBox2.SelectedItem;
            ServicioCategoria servicioCategoria = new ServicioCategoria();
            List<Categoria> listaCategoria = servicioCategoria.ListarCategorias();

            comboBox2.DataSource = listaCategoria;
            comboBox2.DisplayMember = "Descripcion";
            comboBox2.ValueMember = "Id";
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
                Marca marca = comboBox1.SelectedItem as Marca;
                obj.IdMarca = marca.Id;
                Categoria categoria = comboBox2.SelectedItem as Categoria;
                obj.IdCategoria = categoria.Id;
                obj.Precio = decimal.Parse(txtElemPrecio.Text);

                servicioArticulo.AgregarArticulo(obj);
                MessageBox.Show(" Operarcion exitosa ");
                this.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
