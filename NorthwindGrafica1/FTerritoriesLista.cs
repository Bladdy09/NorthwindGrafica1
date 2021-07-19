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
    public partial class FTerritoriesLista : Form
    {
        public FTerritoriesLista()
        {
            InitializeComponent();

        }

        private void btnuevo_Click(object sender, EventArgs e)
        {
            FTerritorio te = new FTerritorio();
            te.ShowDialog();
            Refresh();
        }

        private void FTerritoriesLista_Load(object sender, EventArgs e)
        {
            Refresh();
        }

        private void Refresh()
        {
            using (NorthwindEntities db = new NorthwindEntities())
            {

                var list = from d in db.Territories
                           select d;
                dataGridView1.DataSource = list.ToList();
                dataGridView1.Columns.Remove("Employees");
                dataGridView1.Columns.Remove("Region");

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
                FTerritorio te = new FTerritorio(id);
                te.ShowDialog();
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
                    Territories terri = db.Territories.Find(id);

                    db.Territories.Remove(terri);
                    db.SaveChanges();
                }

                Refresh();
            }
        }
    }
}
