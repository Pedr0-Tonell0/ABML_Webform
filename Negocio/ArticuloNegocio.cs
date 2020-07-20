using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using System.Data.SqlClient;

namespace Negocio
{
    public class ArticuloNegocio
    {
        public List<Articulo> listar()
        {
            List<Articulo> lista = new List<Articulo>();
            Articulo aux;

            AccesoDatos datos = new AccesoDatos();

            try
            {
                

                datos.setearQuery("select articulos.Id,Articulos.Nombre,Articulos.CodigoArticulo,Articulos.Descripcion,Marca.Nombre,Categoria.Nombre,Articulos.Imagen,Articulos.Precio FROM[negocio0].[dbo].[Articulos] left join [negocio0].[dbo].[Marca] on marca.Id=Articulos.IdMarca left join [negocio0].[dbo].[Categoria] on Categoria.Id=Articulos.IdCategoria where Articulos.Estado = 0");

                datos.ejecutarLector();


                while (datos.lector.Read())
                {
                    aux = new Articulo();
                    aux.Id = datos.lector.GetInt32(0);
                    aux.Nombre = datos.lector.GetString(1);
                    aux.CodigoArticulo = datos.lector.GetString(2);
                    aux.Descripcion = datos.lector.GetString(3);
                    aux.Imagen = datos.lector.GetString(6);
                    aux.Precio = datos.lector.GetDouble(7);
                    aux.Marcas = new Marca();
                    aux.Marcas.NombreMarca = datos.lector.GetString(4);
                    aux.Categorias = new Categoria();
                    aux.Categorias.NombreCategoria = datos.lector.GetString(5);

                    lista.Add(aux);
                }

                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
                datos = null;
            }

        }




        public void agregar(Articulo articulo)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
               
                datos.setearQuery("Insert into Articulos(CodigoArticulo,Nombre,Descripcion, IdMarca,IdCategoria,Precio,Imagen,Estado) values (@CodigoArticulo,@Nombre,@Descripcion, @IdMarca,@IdCategoria,@Precio,@Imagen,@Estado)");
                datos.agregarParametro("@CodigoArticulo", articulo.CodigoArticulo);
                datos.agregarParametro("@Nombre", articulo.Nombre);
                datos.agregarParametro("@Descripcion", articulo.Descripcion);
                datos.agregarParametro("@IdMarca", articulo.Marcas.CodigoMarca);
                datos.agregarParametro("@IdCategoria", articulo.Categorias.CodigoCategoria);
                datos.agregarParametro("@Precio", articulo.Precio);
                datos.agregarParametro("@Imagen", articulo.Imagen);
                datos.agregarParametro("@Estado",0);
                datos.ejecutarAccion();
                

            }
            catch (Exception ex)
            {
                throw ex;
            }
            

        }

     
        public void modificar(Articulo articulo)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearQuery("update Articulos set Nombre=@Nombre,CodigoArticulo=@CodigoArticulo,Descripcion = @Descripcion, IdMarca = @IdMarca, IdCategoria = @IdCategoria, Imagen = @Imagen, Precio = @Precio where Id=@Id");         
                
                datos.agregarParametro("@Nombre", articulo.Nombre);
                datos.agregarParametro("@CodigoArticulo", articulo.CodigoArticulo);
                datos.agregarParametro("@Id", articulo.Id);
                datos.agregarParametro("@Descripcion", articulo.Descripcion);
                datos.agregarParametro("@IdMarca", articulo.Marcas.CodigoMarca);
                datos.agregarParametro("@IdCategoria", articulo.Categorias.CodigoCategoria);
                datos.agregarParametro("@Imagen", articulo.Imagen);
                datos.agregarParametro("@Precio", articulo.Precio);



                datos.ejecutarAccion();

            }
            catch (Exception ex)
            {
                throw ex;
            }
            
        }

        public void eliminar( int id)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                
                datos.setearQuery("delete from Articulos where id =" + id);

                datos.ejecutarAccion();

            }
            catch (Exception ex)
            {
                throw ex;
            }
           
        }
        public void bajaLogica(int Id)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearQuery("update Articulos set Estado = 1 where Id =" + Id);
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



    }

}







