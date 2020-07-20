using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using System.Data.SqlClient;

namespace Negocio
{
    public class MarcaNegocio
    {
            public List<Marca> listar()
            {
               
                Marca aux;
                List<Marca> lista = new List<Marca>();
            AccesoDatos datos = new AccesoDatos();
                try
                { 
                   
                    datos.setearQuery("Select marca.id,marca.nombre from [negocio0].[dbo].[Marca]");
                datos.ejecutarLector();

                    while (datos.lector.Read())
                    {
                    aux  = new Marca();
                    aux = new Marca((int)datos.lector["Id"], (string)datos.lector["Nombre"]);

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

