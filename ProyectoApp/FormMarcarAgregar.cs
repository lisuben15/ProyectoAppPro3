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
    public partial class FormMarcarAgregar : Form
    {
        public FormMarcarAgregar()
        {
            InitializeComponent();
        }

        private void FormMarcarAgregar_Load(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Marca obj = new Marca();

            try
            {
                obj.Id = int.Parse(txtElementoId.Text);
                obj.Descripcion = txtElementoMarca.Text;
                ServicioMarca.AgregarMarca(obj);
                MessageBox.Show("Registro Exitoso!");
                Close();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

           
    }

}
            

