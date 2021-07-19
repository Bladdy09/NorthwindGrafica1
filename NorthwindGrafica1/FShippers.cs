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
    public partial class FShippers : Form
    {
        public int? id;
        Shippers fca = null;
        public FShippers(int? id = null)
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
                fca = db.Shippers.Find(id);
                //shipperIDTextBox.Text = Convert.ToString(fca.ShipperID);
                companyNameTextBox.Text = fca.CompanyName;
                phoneTextBox.Text = fca.Phone;
            }

        }

        private void FShippers_Load(object sender, EventArgs e)
        {

        }

        private void btguardarS_Click(object sender, EventArgs e)
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
                    fca = new Shippers();
                }

                //fca.ShipperID = int.Parse(shipperIDTextBox.Text);
                fca.CompanyName = companyNameTextBox.Text;
                fca.Phone = phoneTextBox.Text;
                if (id == null)
                {
                    db.Shippers.Add(fca);
                }
                else
                {
                    db.Entry(fca).State = System.Data.Entity.EntityState.Modified;
                }

                db.SaveChanges();
                this.Close();

            }
        }
    }
    
}
