using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Marca
    {
        public int CodigoMarca { get; set; }
        public string NombreMarca { get; set; }
        public Marca() { }
        public Marca(int CodigoMarcaInput, string NombreMarcaInput)
        {
            CodigoMarca = CodigoMarcaInput;
            NombreMarca = NombreMarcaInput;
        }

        public override string ToString()
        {
            return NombreMarca;
           
        }
    }
}
