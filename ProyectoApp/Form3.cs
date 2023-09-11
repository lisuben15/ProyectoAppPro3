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
    public partial class Form3Marcas : Form
    {
        ServicioMarca servicioMarca;
        public Form3Marcas()
        {
            InitializeComponent();
        }

        private void Form3Marcas_Load(object sender, EventArgs e)
        {
            servicioMarca = new ServicioMarca();
            List<Marca> lista = servicioMarca.ListarMarcas();

            dataGridView1.DataSource = lista;
        }

     

        private void btnAgregar_Click_1(object sender, EventArgs e)
        {
            FormMarcaAgregar formMarcasAgregar = new FormMarcaAgregar();
            formMarcasAgregar.ShowDialog();
        }
    }
}
