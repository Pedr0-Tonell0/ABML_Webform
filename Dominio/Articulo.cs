using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;



namespace Dominio
{
    public class Articulo
    {
        public int Id { get; set; }
        public string CodigoArticulo { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }

        public Marca Marcas { get; set; }

        public Categoria Categorias { get; set; }
        

        public double Precio { get; set; }
        public string Imagen { get; set; }

        public  int Estado { get; set; }

        public override string ToString()
        {
            return Descripcion;
        }
    }
}
