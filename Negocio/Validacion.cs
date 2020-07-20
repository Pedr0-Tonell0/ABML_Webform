using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;


namespace Negocio
{
    public class Validacion
    {


        public Boolean Validar(Articulo articulo)
        {

            if (articulo.Nombre == null || articulo.CodigoArticulo == null || articulo.Descripcion == null || articulo.Categorias.NombreCategoria == null || 
                articulo.Marcas.NombreMarca == null|| articulo.Imagen == null || articulo.Precio == 0 || articulo.Precio <= 0.0)

               
            {
                return true;


            }
            else
            { return false; }
            
        }
    }
}
