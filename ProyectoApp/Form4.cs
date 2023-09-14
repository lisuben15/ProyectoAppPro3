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
    public partial class Form4Categorias : Form
    {
        ServicioCategoria servicioCategoria;
        public Form4Categorias()
        {
            InitializeComponent();
        }

        private void Form4Categorias_Load(object sender, EventArgs e)
        {
            servicioCategoria = new ServicioCategoria();
            List<Categoria> lista = servicioCategoria.ListarCategorias();

            dataGridView1.DataSource = lista;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FormCategoriaAgregar formCategoriaAgregar = new FormCategoriaAgregar();
            formCategoriaAgregar.ShowDialog();
            Form4Categorias_Load(sender, e);
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            ServicioCategoria servicioCategoria = new ServicioCategoria();
            Categoria seleccionado;
            try
            {
                DialogResult resultado = MessageBox.Show(" ¿Seguro desea eliminar ? ", " Eliminado", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (resultado == DialogResult.Yes)
                {
                    seleccionado = (Categoria)dataGridView1.CurrentRow.DataBoundItem;
                    servicioCategoria.EliminarCategoria(seleccionado.Id);
                    Form4Categorias_Load(sender, e);
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            List<Categoria> listaFiltrada;
            string filtro = textBox1.Text;

            servicioCategoria = new ServicioCategoria();
            List<Categoria> lista = servicioCategoria.ListarCategorias();

            if (filtro != "")
            {
                listaFiltrada = lista.FindAll(x => x.Descripcion.ToUpper().Contains(filtro.ToUpper()));
            }
            else
            {
                listaFiltrada = lista;
            }

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = listaFiltrada;
        }
    }
}
