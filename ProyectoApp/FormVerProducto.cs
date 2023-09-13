using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dominio;
using negocio;

namespace ProyectoApp
{
    public partial class FormVerProducto : Form
    {
        public FormVerProducto()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void  btnBuscarProducto_Click(object sender, EventArgs e)
        {
            Articulo art = new Articulo();
            int Id = int.Parse(txtElemId.Text);
            ServicioArticulo servicioArticulo = new ServicioArticulo();
            art = servicioArticulo.ObtenerArticuloPorId(Id);
            dgvVerProducto.DataSource = art;
            
        }

        
    }
}
