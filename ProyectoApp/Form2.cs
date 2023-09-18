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
using System.Xml.Linq;

namespace ProyectoApp
{
    public partial class Form2Productos : Form
    {
        ServicioArticulo servicioArticulo;
        private List<Articulo> lista;
        public Form2Productos()
        {
            InitializeComponent();
            servicioArticulo = new ServicioArticulo();
        }

        private void Form2Productos_Load(object sender, EventArgs e)   // <-- este Form lo uso para el obj de ver prod.
        {
            lista = servicioArticulo.ListarArticulos();//esto lo llevo arriba como private

            dgvProductos.DataSource = lista;
            dgvProductos.Columns["UrlImagen"].Visible = false;
            cargarImagen(lista[0].UrlImagen);

            comboBox2.Enabled = false;
            textBox1.Enabled = false;

            comboBox1.Items.Clear();
            comboBox1.Items.Add("Codigo");
            comboBox1.Items.Add("Nombre");
            comboBox1.Items.Add("Descripcion");
            comboBox1.Items.Add("Precio");
            comboBox1.Items.Add("UrlImagen");
            comboBox1.Items.Add("Marca");
            comboBox1.Items.Add("Categoria");


        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
           FormProductoAgregar formProductoAgregar = new FormProductoAgregar();
            formProductoAgregar.ShowDialog();
            Form2Productos_Load(sender, e);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
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
            Articulo seleccionado;
            seleccionado = (Articulo)dgvProductos.CurrentRow.DataBoundItem;// <<-- con esto tenemos el articulo seleccionado
            FormProductoAgregar formProductoModificar = new FormProductoAgregar(seleccionado);
            formProductoModificar.ShowDialog();
            Form2Productos_Load(sender, e);


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
        
        private void comboBox2_DropDown(object sender, EventArgs e)
        {
            string opcion = "";
            try { opcion = comboBox1.SelectedItem.ToString(); }
            catch (NullReferenceException ex) { MessageBox.Show("Seleccione un campo de busqueda antes para poder elegir el criterio");  }
            if (opcion == "Precio")
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("Mayor a");
                comboBox2.Items.Add("Menor a");
                comboBox2.Items.Add("Igual a");
            }
            else
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("Comienza con");
                comboBox2.Items.Add("Termina con");
                comboBox2.Items.Add("Contiene");
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            List<Articulo> listaFiltrada;
            string filter = txtBusqueda.Text;

            lista = servicioArticulo.ListarArticulos();

            if (filter != "")
            {
                listaFiltrada = lista.FindAll(x => x.Codigo.ToUpper().Contains(filter.ToUpper()) || x.Nombre.ToUpper().Contains(filter.ToUpper()) || x.Descripcion.ToUpper().Contains(filter.ToUpper()) || x.Marca.Descripcion.ToUpper().Contains(filter.ToUpper()) || x.Categoria.Descripcion.ToUpper().Contains(filter.ToUpper()));
            }
            else
            {
                listaFiltrada = lista;
            }

            dgvProductos.DataSource = null;
            dgvProductos.DataSource = listaFiltrada;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            List<Articulo> listaFiltrada;

            string filtro = textBox1.Text;
            
            if (comboBox1.SelectedIndex != -1 && comboBox2.SelectedIndex != -1 )
            {
                string criterio = comboBox2.SelectedItem.ToString();
                string campo = comboBox1.SelectedItem.ToString();
                string consulta = "SELECT a.Id, Codigo, Nombre, a.Descripcion, m.Id as IdMarca, m.Descripcion AS Marca, c.Id as IdCategoria, c.Descripcion AS Categoria, Precio, i.ImagenUrl FROM ARTICULOS a INNER JOIN MARCAS m ON  a.IdMarca = m.Id INNER JOIN CATEGORIAS c ON a.IdCategoria = c.Id LEFT JOIN IMAGENES i ON a.Id = i.IdArticulo WHERE  ";
                if (campo == "Precio")
                {
                    decimal verificadorNumero;

                    if (!(decimal.TryParse((textBox1.Text), out verificadorNumero)))
                    {
                        MessageBox.Show("Ingresar sólo números en el precio por favor");
                        return;
                    }


                    switch (criterio)
                    {
                        case "Mayor a":
                            consulta += "a.\"Precio\" > " + filtro;
                            break;
                        case "Menor a":
                            consulta += "a.\"Precio\" < " + filtro;
                            break;
                        default:
                            consulta += "a.\"Precio\" = " + filtro;
                            break;
                    }
                }
                else if (campo == "Codigo" || campo == "Nombre" || campo == "Descripcion" || campo == "Marca" || campo == "Categoria")
                {
                    if (campo == "Marca") { campo = "Descripcion"; consulta += "m."; }
                    else if (campo == "Categoria") { campo = "Descripcion"; consulta += "c."; }
                    else { consulta += "a."; }
                    switch (criterio)
                    {
                        case "Comienza con":
                            consulta += "\"" + campo + "\" like '" + filtro + "%' ";
                            break;
                        case "Termina con":
                            consulta += "\"" + campo + "\" like '%" + filtro + "'";
                            break;
                        default:
                            consulta += "\"" + campo + "\" like '%" + filtro + "%'";
                            break;
                    }
                }

                if (filtro != "")
                {
                    listaFiltrada = servicioArticulo.FiltrarArticulos(consulta);
                }
                else
                {
                    listaFiltrada = servicioArticulo.ListarArticulos();
                }

                dgvProductos.DataSource = null;
                dgvProductos.DataSource = listaFiltrada;
                dgvProductos.Columns["UrlImagen"].Visible = false;
                cargarImagen(lista[0].UrlImagen);
            }
            
        }


        //Button Animations
        private void btnVerProducto_MouseEnter(object sender, EventArgs e)
        {
            btnVerProducto.Width += 5;
            btnVerProducto.Height += 5;
        }
        private void btnVerProducto_MouseLeave(object sender, EventArgs e)
        {
            btnVerProducto.Width -= 5;
            btnVerProducto.Height -= 5;
        }
        private void btnModificar_MouseEnter(object sender, EventArgs e)
        {
            btnModificar.Width += 5;
            btnModificar.Height += 5;
        }
        private void btnModificar_MouseLeave(object sender, EventArgs e)
        {
            btnModificar.Width -= 5;
            btnModificar.Height -= 5;
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
        private void btnEliminar_MouseEnter(object sender, EventArgs e)
        {
            btnEliminar.Width += 5;
            btnEliminar.Height += 5;
        }
        private void btnEliminar_MouseLeave(object sender, EventArgs e)
        {
            btnEliminar.Width -= 5;
            btnEliminar.Height -= 5;
        }
        private void btnBuscar_MouseEnter(object sender, EventArgs e)
        {
            btnBuscar.Width += 1;
            btnBuscar.Height += 1;
        }
        private void btnBuscar_MouseLeave(object sender, EventArgs e)
        {
            btnBuscar.Width -= 1;
            btnBuscar.Height -= 1;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex != -1)
            {
                comboBox2.Enabled = true;
                textBox1.Enabled = true;
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
