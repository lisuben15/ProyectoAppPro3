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
    public partial class FormCategoriaAgregar : Form
    {
        public FormCategoriaAgregar()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Categoria obj = new Categoria();
            ServicioCategoria servicioCategoria = new ServicioCategoria();
            try
            {

                obj.Descripcion = txtElementoCategoria.Text;
                servicioCategoria.AgregarCategoria(obj);
                MessageBox.Show("Registro Exitoso!");
                this.Close();

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void txtRegArticulo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtElementoCategoria_TextChanged(object sender, EventArgs e)
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
    }
}
