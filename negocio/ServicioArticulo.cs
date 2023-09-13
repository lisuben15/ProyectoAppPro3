using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
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
               
                datos.setearConsulta("insert into ARTICULOS values('"+articulo.Codigo+"', '"+articulo.Nombre+"', '"+ articulo.Descripcion+"',"+articulo.IdMarca+" ,"+articulo.IdCategoria+","+articulo.Precio+")");
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
        public List<DetalleArticulo> ListarArticulos()
        {
            List<DetalleArticulo> lista = new List<DetalleArticulo>();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("SELECT Codigo, Nombre, a.Descripcion, m.Descripcion AS Marca, c.Descripcion AS Categoria, Precio , i.ImagenUrl " +
                                     "FROM ARTICULOS a " +
                                     "INNER JOIN MARCAS m ON  a.IdMarca = m.Id " +
                                     "INNER JOIN CATEGORIAS c ON a.IdCategoria = c.Id " +
                                     "LEFT JOIN IMAGENES i ON a.Id = i.IdArticulo");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    DetalleArticulo aux = new DetalleArticulo();   
                    
                    aux.Codigo = (string)datos.Lector["Codigo"];// mapaer
                    aux.Nombre = (string)datos.Lector["Nombre"];
                    aux.Descripcion = (string)datos.Lector["Descripcion"];
                    aux.DescripcionMarca = (string)datos.Lector["Marca"];
                    aux.DescripcionCategoria = (string)datos.Lector["Categoria"];
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

        /*   public Articulo DevolverArticulo(int Id)
        {
            Articulo art = new Articulo();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("select * from articulos where id =@Id");
                datos.setearParametros("@Id", Id);
                datos.ejecutarLectura();

                datos.Lector.Read();
                    Articulo aux = new Articulo();
                    aux.Id = (int)datos.Lector["Id"];  //  mapear
                    aux.Codigo = (string)datos.Lector["codigo"];
                    aux.Nombre = (string)datos.Lector["nombre"];
                    aux.Descripcion = (string)datos.Lector["Descripcion"];
                    aux.IdMarca = (int)datos.Lector["IdMarca"];
                    aux.IdCategoria = (int)datos.Lector["IdCategoria"];
                    aux.Precio = (decimal)datos.Lector["Precio"];
                    aux.UrlImagen = datos.Lector["ImagenUrl"] != DBNull.Value ? datos.Lector["ImagenUrl"].ToString() : null;

                    return aux;               

            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }

        }*/


        //public Articulo ObtenerArticuloPorId(int Id)
        //{
        //    List<DetalleArticulo> lista = ListarArticulos();
        //    Articulo articuloEncontrado = lista.FirstOrDefault(a => a.Id == Id);

        //    return articuloEncontrado;
        //}


    }  
}
