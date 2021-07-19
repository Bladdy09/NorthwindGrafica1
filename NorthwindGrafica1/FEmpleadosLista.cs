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
    public partial class FEmpleadosLista : Form
    {
        public FEmpleadosLista()
        {
            InitializeComponent();
        }

        private void btnuevo_Click(object sender, EventArgs e)
        {
            FEmpleados em = new FEmpleados();
            em.ShowDialog();
            Refresh();
        }

        private void FEmpleadosLista_Load(object sender, EventArgs e)
        {
            Refresh();
        }

        private void Refresh()
        {
            using (NorthwindEntities db = new NorthwindEntities())
            {

                var list = from d in db.Employees
                           select d;
                dataGridView1.DataSource = list.ToList();
                dataGridView1.Columns.Remove("Employees1");
                dataGridView1.Columns.Remove("Territories");
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
                FEmpleados em = new FEmpleados(id);
                em.ShowDialog();
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
                    Employees emp = db.Employees.Find(id);

                    db.Employees.Remove(emp);
                    db.SaveChanges();
                }

                Refresh();
            }
        }
    }
}
