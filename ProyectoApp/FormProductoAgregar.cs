﻿using dominio;
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
    public partial class FormProductoAgregar : Form
    {
        private Articulo articulo = null;
        public FormProductoAgregar()
        {
            InitializeComponent();
        }
        public FormProductoAgregar(Articulo articulo)
        {
            InitializeComponent();
            this.articulo = articulo;
            Text = "Modificar Producto";
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            
            ServicioArticulo servicioArticulo = new ServicioArticulo();
            try
            {
                decimal verificadorNumero;

                if (!(decimal.TryParse((txtElemPrecio.Text), out verificadorNumero)))
                {
                    MessageBox.Show("Precio no válido!");
                    return;
                }
                if (servicioArticulo.BUscarCodigoDuplicado(txtElemCodigo.Text) == true)
                {
                    MessageBox.Show("El codigo ya existe. Ingrese otro");
                    return;
                }

                if (string.IsNullOrEmpty(txtElemCodigo.Text))
                {
                    MessageBox.Show("Ingrese un código por favor!");
                    return;
                }

                if (string.IsNullOrEmpty(txtElemNombre.Text))
                {
                    MessageBox.Show("Ingrese un nombre por favor!");
                    return;
                }

                

                if (articulo == null)
                articulo = new Articulo();

                articulo.Codigo = txtElemCodigo.Text;
                articulo.Nombre = txtElemNombre.Text;
                articulo.Descripcion = txtElemDescripcion.Text;
                articulo.Marca = new Marca();// se debe instanciar para que nazca el objeto
                articulo.Marca.Id = Convert.ToInt32(cboIdMarca.SelectedValue.ToString());
                articulo.Categoria = new Categoria();
                articulo.Categoria.Id = Convert.ToInt32(cboIdCategoria.SelectedValue.ToString());
                articulo.Precio = decimal.Parse(txtElemPrecio.Text);
                articulo.UrlImagen = txtImagen.Text;
             
                
                if(articulo.Id != 0)
                {
                servicioArticulo.ModificarArticulo(articulo);
                MessageBox.Show(" Modificacion exitosa");
                }
                else
                {
                 
                servicioArticulo.AgregarArticulo(articulo);
                
                int idArticulo = servicioArticulo.seleccionoUltimoRegistro(articulo);
                servicioArticulo.GuardarImagenRelacionada(idArticulo, articulo.UrlImagen);

                MessageBox.Show(" Operacion exitosa ");
                }





                this.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void FormProductoAgregar_Load(object sender, EventArgs e)
        {
            ServicioCategoria servicioCategoria = new ServicioCategoria();
            ServicioMarca servicioMarca = new ServicioMarca();
    
            try 
            {
                cboIdMarca.DisplayMember = "Descripcion"; // indica que campo de la identidad Marca se muestra
                cboIdCategoria.DisplayMember = "Descripcion";
                cboIdMarca.ValueMember = "Id";
                cboIdCategoria.ValueMember = "Id";

                cboIdMarca.DataSource = servicioMarca.ListarMarcas();
                cboIdCategoria.DataSource = servicioCategoria.ListarCategorias();

                if(articulo != null)
                {
                    txtElemCodigo.Text = articulo.Codigo;
                    txtElemNombre.Text = articulo.Nombre;
                    txtElemDescripcion.Text = articulo.Descripcion;
                    txtElemPrecio.Text = articulo.Precio.ToString();
                    cboIdMarca.SelectedValue = articulo.Marca.Id;  
                    cboIdCategoria.SelectedValue = articulo.Marca.Id;   
                }
                
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void lblTitulo_Click(object sender, EventArgs e)
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

        private void txtElemNombre_TextChanged(object sender, EventArgs e)
        {

        }
    }
        
}
