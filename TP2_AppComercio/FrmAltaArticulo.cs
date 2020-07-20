using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;
using Dominio;
using System.Data.SqlClient;

namespace TP2_AppComercio
{
    public partial class FrmAltaArticulo : Form
    {
        private Articulo articulo = null;
        public FrmAltaArticulo()
        {
            InitializeComponent();
        }

        public FrmAltaArticulo(Articulo articulo)
        {
            InitializeComponent();
            this.articulo = articulo;
        }

        private void FrmAltaArticulo_Load(object sender, EventArgs e)
        {
            CategoriaNegocio categoriaNegocio = new CategoriaNegocio();
            MarcaNegocio marcaNegocio = new MarcaNegocio();
            try
            {
                cboCategoria.DataSource = categoriaNegocio.listar();

                cboCategoria.ValueMember = "CodigoCategoria";
                cboCategoria.DisplayMember = "NombreCategoria";
                cboCategoria.SelectedIndex = -1;

                cboMarca.DataSource = marcaNegocio.listar();

                cboMarca.ValueMember = "CodigoMarca";
                cboMarca.DisplayMember = "NombreMarca";
                cboMarca.SelectedIndex = -1;

                if (articulo!=null) { 
                    textNombre.Text = articulo.Nombre;
                    textDescrip.Text = articulo.Descripcion;
                    textImagen.Text = articulo.Imagen;
                    textCodigo.Text = articulo.CodigoArticulo;
                    textPrecio.Text = articulo.Precio.ToString();
                    cboMarca.Text = articulo.Marcas.ToString();
                    cboCategoria.Text = articulo.Categorias.ToString();

                }
                else
                {
                   
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
           


        }

        

        private void PictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    

        private void BttnAceptar_Click(object sender, EventArgs e)
        {
            ArticuloNegocio articuloNegocio = new ArticuloNegocio();

            try
            {
                if (articulo == null)
                   articulo = new Articulo();

                articulo.Nombre = textNombre.Text;
                articulo.Descripcion = textDescrip.Text;
                articulo.Imagen = textImagen.Text;
                articulo.CodigoArticulo = textCodigo.Text;
                articulo.Categorias = (Categoria)cboCategoria.SelectedItem;
                articulo.Marcas = (Marca)cboMarca.SelectedItem;

                try
                {

                    articulo.Precio = double.Parse(textPrecio.Text);

                }
                catch (Exception)
                {
                    MessageBox.Show("Valor ingresado incorrecto");
                   
                }
                Validacion validacion = new Validacion();
                if (!validacion.Validar(articulo))
                {
                    if (articulo.Id != 0)
                    {

                        articuloNegocio.modificar(articulo);

                    }
                    else
                    {
                        articuloNegocio.agregar(articulo);
                    }

                    Dispose();
                }

                else
                {
                    MessageBox.Show("Valores incorrecto en el formulario");
                   
                }
                
            }
            catch (Exception)
            {
                MessageBox.Show("Valores incorrecto en el formulario");
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog img = new OpenFileDialog();
            
            if (img.ShowDialog() == DialogResult.OK)
            {
                textImagen.Text = img.FileName;
            }

        }

        private void PicImagen_Click(object sender, EventArgs e)
        {

        }
    }
}




