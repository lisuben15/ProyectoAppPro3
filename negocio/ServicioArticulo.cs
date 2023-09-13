using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

using dominio;
namespace negocio

{
    public class ServicioArticulo 
    {
            public void AgregarArticulo(Articulo articulo)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
               
                datos.setearConsulta("insert into ARTICULOS values('"+articulo.Codigo+"', '"+articulo.Nombre+"', '"+ articulo.Descripcion+"',"+articulo.Marca.Id+" ,"+articulo.Categoria.Id+","+articulo.Precio+")");
                datos.ejecutarAccion();
            }


            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }

        }
        public void ModificarArticulo(Articulo articulo)
        {

        }
        public void EliminarArticulo(int Id)
        {
           
        }
        public List<Articulo> ListarArticulos()
        {
            List<Articulo> lista = new List<Articulo>();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("SELECT a.Id, Codigo, Nombre, a.Descripcion, m.Id as IdMarca, m.Descripcion AS Marca, c.Id as IdCategoria, c.Descripcion AS Categoria, Precio, i.ImagenUrl FROM ARTICULOS a INNER JOIN MARCAS m ON  a.IdMarca = m.Id INNER JOIN CATEGORIAS c ON a.IdCategoria = c.Id LEFT JOIN IMAGENES i ON a.Id = i.IdArticulo");
                datos.ejecutarLectura();
                while (datos.Lector.Read())
                {
                    Articulo aux = new Articulo();
                    aux.Id = (int)datos.Lector["Id"];
                    aux.Codigo = (string)datos.Lector["Codigo"];// mapaer
                    aux.Nombre = (string)datos.Lector["Nombre"];
                    aux.Descripcion = (string)datos.Lector["Descripcion"];

                    aux.Marca = new Marca();
                    aux.Marca.Id = (int)datos.Lector["IdMarca"];
                    aux.Marca.Descripcion = (string)datos.Lector["Marca"];

                    aux.Categoria = new Categoria();
                    aux.Categoria.Descripcion = (string)datos.Lector["Categoria"];
                    aux.Categoria.Id = (int)datos.Lector["IdCategoria"];
                    aux.Precio = (decimal)datos.Lector["Precio"];
                    aux.UrlImagen = datos.Lector["ImagenUrl"] != DBNull.Value ? datos.Lector["ImagenUrl"].ToString() : null;

                    lista.Add(aux);
                }
                return lista;
            }
            catch(Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }

    }  
}
