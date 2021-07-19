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
    public partial class FCaterories : Form
    {
        public int? id;
        Categories fca = null;
        public FCaterories(int? id = null)
        {
            InitializeComponent();
            this.id = id;
            if(id != null)
            {
                CargarDatos();
            }
        }

        private void CargarDatos()
        {
            using (NorthwindEntities db = new NorthwindEntities())
            {
                fca = db.Categories.Find(id);
                textBox2.Text = fca.CategoryName;
                textBox3.Text = fca.Description;
            }

        }

        private void btguardar_Click(object sender, EventArgs e)
        {
            if (textBox2.Text != "" && textBox3.Text != "")
            {
                MessageBox.Show("Guardado con exito");
                
            }
            else
            {
                MessageBox.Show("Favor de llenar todos los campos ");
                return;

            }
            using (NorthwindEntities db = new NorthwindEntities())
            {
                if(id == null)
                {
                    fca = new Categories();
                }
                
                fca.CategoryName = textBox2.Text;
                fca.Description = textBox3.Text;
                if (id == null)
                {
                    db.Categories.Add(fca);
                }
                else
                {
                    db.Entry(fca).State = System.Data.Entity.EntityState.Modified;
                }
                
                db.SaveChanges();
                this.Close();

            }
        }

        private void FCaterories_Load(object sender, EventArgs e)
        {

        }
    }
}
