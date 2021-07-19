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
    
    public partial class FRegion : Form
    {
        public int? id;
        Models.Region fca = null;
        public FRegion(int? id = null)
        {
            InitializeComponent();
            this.id = id;
            if (id != null)
            {
                CargarDatos();
            }
        }

        private void CargarDatos()
        {
            using (NorthwindEntities db = new NorthwindEntities())
            {
                fca = db.Region.Find(id);
                regionDescriptionTextBox.Text = fca.RegionDescription;
                textBox1.Text = Convert.ToString(fca.RegionID);
            }

        }

        private void btguardarR_Click(object sender, EventArgs e)
        {
            foreach (Control c in this.Controls)
            {
                if (c is TextBox)
                {
                    TextBox textBox = c as TextBox;
                    if (textBox.Text == string.Empty)
                    {
                        MessageBox.Show("Favor de llenar todos los campos");
                        return;
                    }
                }
            }

            using (NorthwindEntities db = new NorthwindEntities())
            {
                if (id == null)
                {
                    fca = new Models.Region();
                }

                fca.RegionDescription = regionDescriptionTextBox.Text;
                fca.RegionID = int.Parse(textBox1.Text);
                if (id == null)
                {
                    db.Region.Add(fca);
                }
                else
                {
                    db.Entry(fca).State = System.Data.Entity.EntityState.Modified;
                }
                db.SaveChanges();
                this.Close();

            }
        }

        private void FRegion_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'northwindDataSet.Products' Puede moverla o quitarla según sea necesario.
            this.productsTableAdapter.Fill(this.northwindDataSet.Products);

        }
    }
}
