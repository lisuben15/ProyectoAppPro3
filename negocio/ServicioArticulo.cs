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
        public List<Articulo> ListarArticulos()
        {
            List<Articulo> lista = new List<Articulo>();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("select A.Id, Codigo, Nombre, Descripcion, IdMarca, IdCategoria, Precio, IMAGENES.ImagenUrl from ARTICULOS  A left join IMAGENES ON A.Id = IMAGENES.Id");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Articulo aux = new Articulo();   
                    aux.Id = (int)datos.Lector["Id"];  //  mapear
                    aux.Codigo = (string)datos.Lector["codigo"];
                    aux.Nombre = (string)datos.Lector["nombre"];
                    aux.Descripcion = (string)datos.Lector["Descripcion"];
                    aux.IdMarca = (int)datos.Lector["IdMarca"];
                    aux.IdCategoria = (int)datos.Lector["IdCategoria"];
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


        public Articulo ObtenerArticuloPorId(int Id)
        {
            List<Articulo> lista = ListarArticulos();
            Articulo articuloEncontrado = lista.FirstOrDefault(a => a.Id == Id);

            return articuloEncontrado;
        }


    }  
}
