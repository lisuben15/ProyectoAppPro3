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

        }
    }
}
