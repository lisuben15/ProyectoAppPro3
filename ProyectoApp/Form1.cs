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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblGestionComercial_Click(object sender, EventArgs e)
        {

        }

        private void Form1ProyectoApp_Load(object sender, EventArgs e)
        {

        }

        private void msArchivo_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            Form2Productos form2Productos = new Form2Productos();
            form2Productos.ShowDialog();

        }

        private void btnMarcas_Click(object sender, EventArgs e)
        {
            Form3Marcas form3Marcas = new Form3Marcas();
            form3Marcas.ShowDialog();
        }

        private void btnCategorias_Click(object sender, EventArgs e)
        {
            Form4Categorias form4Categorias = new Form4Categorias();
            form4Categorias.ShowDialog();
        }



        //BUTTON ANIMATIONS
        private void btnProductos_MouseEnter(object sender, EventArgs e)
        {
            btnProductos.Width = btnProductos.Width + 5;
            btnProductos.Height = btnProductos.Height + 5;
        }

        private void btnProductos_MouseLeave(object sender, EventArgs e)
        {
            btnProductos.Width = btnProductos.Width - 5;
            btnProductos.Height = btnProductos.Height - 5;
        }

        private void btnCategorias_MouseEnter(object sender, EventArgs e)
        {
            btnCategorias.Width = btnProductos.Width + 5;
            btnCategorias.Height = btnProductos.Height + 5;
        }

        private void btnCategorias_MouseLeave(object sender, EventArgs e)
        {
            btnCategorias.Width = btnProductos.Width - 5;
            btnCategorias.Height = btnProductos.Height - 5;
        }

        private void btnMarcas_MouseEnter(object sender, EventArgs e)
        {
            btnMarcas.Width = btnProductos.Width + 5;
            btnMarcas.Height = btnProductos.Height + 5;
        }

        private void btnMarcas_MouseLeave(object sender, EventArgs e)
        {
            btnMarcas.Width = btnProductos.Width - 5;
            btnMarcas.Height = btnProductos.Height - 5;
        }

    }
}
