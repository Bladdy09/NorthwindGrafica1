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
    public partial class FRegionLista : Form
    {
        public FRegionLista()
        {
            InitializeComponent();
        }

        private void FRegionLista_Load(object sender, EventArgs e)
        {
            Refresh();
        }

        private void Refresh()
        {
            using (NorthwindEntities db = new NorthwindEntities())
            {

                var list = from d in db.Region
                           select d;
                dataGridView1.DataSource = list.ToList();
                dataGridView1.Columns.Remove("Territories");

            }
        }

        private void btnuevo_Click(object sender, EventArgs e)
        {
            FRegion re = new FRegion();
            re.ShowDialog();
            Refresh();
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
                FRegion reg = new FRegion(id);
                reg.ShowDialog();
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
                    Models.Region re = db.Region.Find(id);

                    db.Region.Remove(re);
                    db.SaveChanges();
                }

                Refresh();
            }
        }
    }
}
