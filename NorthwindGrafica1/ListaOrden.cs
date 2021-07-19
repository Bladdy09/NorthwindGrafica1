using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NorthwindGrafica1.Models;


namespace NorthwindGrafica1
{
    public partial class ListaOrden : Form
    {
        public ListaOrden()
        {
            InitializeComponent();
        }

        private void ListaOrden_Load(object sender, EventArgs e)
        {
            Refresh();
        }

        private void Refresh()
        {
            using (NorthwindEntities db = new NorthwindEntities())
            {

                var list = from d in db.Orders
                           select d;
                dataGridView1.DataSource = list.ToList();
                dataGridView1.Columns.Remove("Customers");
                dataGridView1.Columns.Remove("Employees");
                dataGridView1.Columns.Remove("Order_Details");
                dataGridView1.Columns.Remove("Shippers");

            }
        }

        private int? GetId()
        {
            try
            {
                return int.Parse(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString());
            }
            catch
            {

                return null;
            }
        }

        

        private void btnuevo_Click(object sender, EventArgs e)
        {
            CrearOrden ord = new CrearOrden();
            ord.ShowDialog();
            Refresh();
        }

        private void bteditar_Click(object sender, EventArgs e)
        {
            int? id = GetId();
            if (id != null)
            {
                CrearOrden ca = new CrearOrden(id);
                ca.ShowDialog();
                Refresh();
            }
        }

        private void bteliminar_Click(object sender, EventArgs e)
        {
            int? id = GetId();
            if (id != null)
            {

                using (NorthwindEntities db = new NorthwindEntities())
                {
                    Orders orders = db.Orders.Find(id);

                    db.Orders.Remove(orders);
                    db.SaveChanges();
                }

                Refresh();
            }
        }

        private void buscar_Por_IDToolStripButton_Click(object sender, EventArgs e)
        {
           

        }
    }
}
