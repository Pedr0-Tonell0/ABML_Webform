using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using Negocio;

namespace TP2_AppComercio
{
    public partial class FrmDetalles : Form
    {
        public FrmDetalles()
        {
            InitializeComponent();
        }

        public FrmDetalles(Articulo articuloAuxiliar)
        {

            InitializeComponent();
            CargarDetalles(articuloAuxiliar);

        }
          

        private void CargarDetalles(Articulo articulo)
        {
          
            try
        {
                    textMarca.Text = articulo.Marcas.ToString();
                    textCategoria.Text = articulo.Categorias.ToString();
                    textNombre.Text = articulo.Nombre;
                    textDescrip.Text = articulo.Descripcion;
                    textCodigo.Text = articulo.CodigoArticulo;
                    textPrecio.Text = articulo.Precio.ToString();
                    picImagen.ImageLocation = articulo.Imagen.ToString();
                }
            
            catch (Exception excepcion)
            {

                MessageBox.Show(excepcion.Message);
            }

        }

        private void BttnAceptar_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
