using dominio;
using negocio;
using System;
using System.Collections;
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
            Form3Marcas_Load(sender, e);
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            List<Marca> listaFiltrada;
            string filtro = textBox1.Text;

            servicioMarca = new ServicioMarca();
            List<Marca> lista = servicioMarca.ListarMarcas();

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

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            ServicioMarca servicioMarca = new ServicioMarca();
            Marca seleccionado;
            try
            {
                DialogResult resultado = MessageBox.Show(" ¿Seguro desea eliminar ? ", " Eliminado", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (resultado == DialogResult.Yes)
                {
                    seleccionado = (Marca)dataGridView1.CurrentRow.DataBoundItem;
                    servicioMarca.EliminarMarca(seleccionado.Id);
                    Form3Marcas_Load(sender, e);
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

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

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Marca seleccionado = (Marca)dataGridView1.CurrentRow.DataBoundItem;
            FormMarcaAgregar formMarcasModificar = new FormMarcaAgregar(seleccionado);
            formMarcasModificar.ShowDialog();
            Form3Marcas_Load(sender, e);
        }
    }
}
