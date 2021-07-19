using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NorthwindGrafica1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listaDeOrdenesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

       

        private void modificarOrdenesToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void borrarOrdenesToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ordenesDetalleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListaOrden lista = new ListaOrden();
            lista.ShowDialog();
        }

        private void listaDeOrdenesdetalleToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void crearOrdenesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CrearOrden crear = new CrearOrden();
            crear.ShowDialog();
        }

        private void modificarOrdenToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void borrarOrdenesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
        }

        private void categoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FListaCategories fLista = new FListaCategories();
            fLista.ShowDialog();
        }

        private void regionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRegionLista fRegion = new FRegionLista();
            fRegion.ShowDialog();
        }

        private void shippersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FShippersLista lista = new FShippersLista();
            lista.ShowDialog();
        }

        private void suppliersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FSuppliersLista lista = new FSuppliersLista();
            lista.ShowDialog();
        }

        private void terrotoriesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FTerritoriesLista lista = new FTerritoriesLista();
            lista.ShowDialog();
        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FProductsLista fProducts = new FProductsLista();
            fProducts.ShowDialog();
        }

        private void customersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FCustomersLista lista = new FCustomersLista();
            lista.ShowDialog();
        }

        private void empleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FEmpleadosLista lista = new FEmpleadosLista();
            lista.ShowDialog();
        }

        private void ordersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListaOrden lista = new ListaOrden();
            lista.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
