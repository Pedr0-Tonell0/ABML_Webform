using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Categoria
    {
        public int CodigoCategoria { get; set; }
        public string NombreCategoria { get; set; }

       

        public Categoria() { }
        public Categoria(int CodigoCategoria, string NombreCategoria)
        {
           this.CodigoCategoria= CodigoCategoria;
            this.NombreCategoria = NombreCategoria;
        }

        public override string ToString()
        {
            return NombreCategoria;
         
        }
    }
}
