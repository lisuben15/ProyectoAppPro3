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
    }
}
