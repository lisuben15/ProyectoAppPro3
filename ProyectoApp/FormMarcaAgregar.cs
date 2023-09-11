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
    public partial class FormMarcaAgregar : Form
    {
        public FormMarcaAgregar()
        {
            InitializeComponent();
        }

        private void FormMarcarAgregar_Load(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Marca obj = new Marca();
            ServicioMarca servicioMarca = new ServicioMarca();
            try
            {
               
                obj.Descripcion = txtElementoMarca.Text;
                servicioMarca.AgregarMarca(obj);
                MessageBox.Show("Registro Exitoso!");
                
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

           
    }

}
            

