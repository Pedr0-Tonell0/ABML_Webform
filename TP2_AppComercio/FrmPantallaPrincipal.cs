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
    public partial class FrmPantallaPrincipal : Form
    {
        private List<Articulo> lista;
        public FrmPantallaPrincipal()
        {
            InitializeComponent();
        }

        private void ToolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void PictureBox7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cargarDatos()
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
           
            try
            {
                lista = negocio.listar();
                dataGridView.DataSource = lista;
                dataGridView.Columns[0].Visible = false;
                dataGridView.Columns[3].Visible = false;
                dataGridView.Columns[7].Visible = false;
                dataGridView.Columns[8].Visible = false;




            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FrmPantallaPrincipal_Load(object sender, EventArgs e)
        {
            cargarDatos();
        }

        private void BttnAgregar_Click(object sender, EventArgs e)
        {
            FrmAltaArticulo altaArticulo = new FrmAltaArticulo();
            altaArticulo.ShowDialog();
            cargarDatos();
        }

        private void DataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BttnModificar_Click(object sender, EventArgs e)
        {
          
            FrmAltaArticulo frmModificar = new FrmAltaArticulo((Articulo)dataGridView.CurrentRow.DataBoundItem);
            frmModificar.ShowDialog();
            cargarDatos();
        }

        private void BttnEliminar_Click(object sender, EventArgs e)
        {

           ArticuloNegocio negocio = new ArticuloNegocio();
            try
            {
                int id = ((Articulo)dataGridView.CurrentRow.DataBoundItem).Id;
                negocio.eliminar(id);
                cargarDatos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void TextBusqueda_TextChanged(object sender, EventArgs e)
        {
            List<Articulo> listaFiltrada;
            try
            {
                if (textBusqueda.Text == "")
                {
                    listaFiltrada = lista;
                }
                else
                {
                    listaFiltrada = lista.FindAll(k => k.CodigoArticulo.ToLower().Contains(textBusqueda.Text.ToLower()) || k.Nombre.ToLower().Contains(textBusqueda.Text.ToLower()));
                }
                dataGridView.DataSource = listaFiltrada;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

     

        private void BttnDetalles_Click_1(object sender, EventArgs e)
        {
            FrmDetalles DetalleArticulo = new FrmDetalles((Articulo)dataGridView.CurrentRow.DataBoundItem);
            DetalleArticulo.ShowDialog();
            cargarDatos();
        }

        private void BttnBaja_Click(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            try
            {
                int id = ((Articulo)dataGridView.CurrentRow.DataBoundItem).Id;
                negocio.bajaLogica(id);
                cargarDatos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
