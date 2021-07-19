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
    public partial class FListaCategories : Form
    {
        public FListaCategories()
        {
            InitializeComponent();
        }

        private void btnuevo_Click(object sender, EventArgs e)
        {
            FCaterories caterories = new FCaterories();
            caterories.ShowDialog();
            Refresh();
        }

        private void FListaCategories_Load(object sender, EventArgs e)
        {

            Refresh();

        }

       // #region HELPER
        private void Refresh()
        {
            using (NorthwindEntities db = new NorthwindEntities())
            {

                var list = from d in db.Categories
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
            if (id!= null)
            {
                FCaterories ca = new FCaterories(id);
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
                    Categories Categories = db.Categories.Find(id);

                    db.Categories.Remove(Categories);
                    db.SaveChanges();
                }

                Refresh();
            }
        }
    }
}
