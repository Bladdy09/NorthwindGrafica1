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
    public partial class FSuppliersLista : Form
    {
        public FSuppliersLista()
        {
            InitializeComponent();
        }

        private void FSuppliersLista_Load(object sender, EventArgs e)
        {
            Refresh();
        }

        private void btnuevo_Click(object sender, EventArgs e)
        {
            FSuplidor su = new FSuplidor();
            su.ShowDialog();
            Refresh();
        }

        private void Refresh()
        {
            using (NorthwindEntities db = new NorthwindEntities())
            {

                var list = from d in db.Suppliers
                           select d;
                dataGridView1.DataSource = list.ToList();
                dataGridView1.Columns.Remove("Products");

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
                FSuplidor fsu = new FSuplidor(id);
                fsu.ShowDialog();
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
                    Suppliers sup = db.Suppliers.Find(id);

                    db.Suppliers.Remove(sup);
                    db.SaveChanges();
                }

                Refresh();
            }
        }
    }
}
