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
    public partial class Form2Productos : Form
    {
        ServicioArticulo servicioArticulo;
        public Form2Productos()
        {
            InitializeComponent();
        }

        private void Form2Productos_Load(object sender, EventArgs e)
        {
            servicioArticulo = new ServicioArticulo();
            List<Articulo> lista = servicioArticulo.ListarArticulos();

            dataGridView1.DataSource = lista;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

        }
    }
}
