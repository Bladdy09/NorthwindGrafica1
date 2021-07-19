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
    public partial class FShippersLista : Form
    {
        public FShippersLista()
        {
            InitializeComponent();
        }

        private void btnuevo_Click(object sender, EventArgs e)
        {
            FShippers shippers = new FShippers();
            shippers.ShowDialog();
            Refresh();
        }

        private void FShippersLista_Load(object sender, EventArgs e)
        {
            Refresh();
        }

        private void Refresh()
        {
            using (NorthwindEntities db = new NorthwindEntities())
            {

                var list = from d in db.Shippers
                           select d;
                dataGridView1.DataSource = list.ToList();
                dataGridView1.Columns.Remove("Orders");

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
                FShippers shi = new FShippers(id);
                shi.ShowDialog();
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
                    Shippers ship = db.Shippers.Find(id);

                    db.Shippers.Remove(ship);
                    db.SaveChanges();
                }

                Refresh();
            }
        }
    }
}
