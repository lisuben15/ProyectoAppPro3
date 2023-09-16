﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
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

        public Articulo seleccionoUltimoRegistro(Articulo articulo)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {

                datos.setearConsulta("select top(1) Id from ARTICULOS order by Id desc");
                datos.ejecutarLectura();
                datos.Lector.Read();
                articulo.Id = (int)datos.Lector["Id"];
                return articulo;
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

        public void GuardarImagenRelacionada(Articulo articulo)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {           
                datos.setearConsulta("insert into IMAGENES values(" + articulo.Id + ", '" + articulo.UrlImagen + "')");
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
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("update articulos set Codigo = @Codigo, Nombre = @Nombre, Descripcion = @Descripcion, IdMarca = @IdMarca, IdCategoria = @IdCategoria, Precio = @Precio where id = @Id");
                datos.setearParametros("@Codigo", articulo.Codigo);
                datos.setearParametros("@Nombre", articulo.Nombre);
                datos.setearParametros("@Descripcion", articulo.Descripcion);
                datos.setearParametros("@IdMarca", articulo.Marca.Id);
                datos.setearParametros("@IdCategoria", articulo.Categoria.Id);
                datos.setearParametros("@Precio", articulo.Precio);
                datos.setearParametros("@Id", articulo.Id);

                datos.ejecutarAccion();
                
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally {
                datos.cerrarConexion();
            }

        }
        public void EliminarArticulo(int Id)
        {
            try
            {
                AccesoDatos datos = new AccesoDatos();
                datos.setearConsulta("delete from ARTICULOS WHERE Id = @id");
                datos.setearParametros("@id", Id);
                datos.ejecutarAccion();
               
            }
            catch (Exception ex)
            {
                throw ex;
            }

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
