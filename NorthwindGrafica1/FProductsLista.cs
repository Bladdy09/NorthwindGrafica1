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
    public partial class FProductsLista : Form
    {
        public FProductsLista()
        {
            InitializeComponent();
        }

        private void btnuevo_Click(object sender, EventArgs e)
        {
            FProducto pro = new FProducto();
            pro.ShowDialog();
            Refresh();
        }

        private void FProductsLista_Load(object sender, EventArgs e)
        {
            
            Refresh();
        }

        private void Refresh()
        {
            using (NorthwindEntities db = new NorthwindEntities())
            {

                var list = from d in db.Products
                           select d;
                dataGridView1.DataSource = list.ToList();
                dataGridView1.Columns.Remove("Order_Details");
                dataGridView1.Columns.Remove("Suppliers");
                dataGridView1.Columns.Remove("Categories");

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

        private void bteditar_Click(object sender, EventArgs e)
        {
            int? id = GetId();
            if (id != null)
            {
                FProducto prod = new FProducto(id);
                prod.ShowDialog();
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
                    Products prod = db.Products.Find(id);

                    db.Products.Remove(prod);
                    db.SaveChanges();
                }

                Refresh();
            }
        }
    }
}
