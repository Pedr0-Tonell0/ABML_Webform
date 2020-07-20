using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using System.Data.SqlClient;

namespace Negocio
{
   public  class CategoriaNegocio
    {
            public List<Categoria> listar()
            {
                
                Categoria aux;
                List<Categoria> lista = new List<Categoria>();
            AccesoDatos datos = new AccesoDatos();
                try
                {
                    
                    datos.setearQuery("Select categoria.id,categoria.nombre from [negocio0].[dbo].[Categoria]");
                datos.ejecutarLector();

                    while (datos.lector.Read())
                    {
                 
                    aux  = new Categoria();

                    aux = new Categoria((int)datos.lector["Id"], (string)datos.lector["Nombre"]);
                    
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
        }
    }


