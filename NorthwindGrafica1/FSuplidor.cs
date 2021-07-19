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
    public partial class FSuplidor : Form
    {
        public int? id;
        Suppliers fca = null;
        public FSuplidor(int? id = null)
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
                fca = db.Suppliers.Find(id);
                //supplierIDTextBox.Text = Convert.ToString(fca.SupplierID);
                companyNameTextBox.Text = fca.CompanyName;
                contactNameTextBox.Text = fca.ContactName;
                contactTitleTextBox.Text = fca.ContactTitle;
                addressTextBox.Text = fca.Address;
                cityTextBox.Text = fca.City;
                regionTextBox.Text = fca.Region;
                postalCodeTextBox.Text = fca.PostalCode;
                countryTextBox.Text = fca.Country;
                phoneTextBox.Text = fca.Phone;
                faxTextBox.Text = fca.Fax;
                homePageTextBox.Text = fca.HomePage;
            }

        }


        private void btguardarSU_Click(object sender, EventArgs e)
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
                    fca = new Suppliers();
                }

                //fca.SupplierID = int.Parse(supplierIDTextBox.Text);
                fca.CompanyName = companyNameTextBox.Text;
                fca.ContactName = contactNameTextBox.Text;
                fca.ContactTitle = contactTitleTextBox.Text;
                fca.Address = addressTextBox.Text;
                fca.City = cityTextBox.Text;
                fca.Region = regionTextBox.Text;
                fca.PostalCode = postalCodeTextBox.Text;
                fca.Country = countryTextBox.Text;
                fca.Phone = phoneTextBox.Text;
                fca.Fax = faxTextBox.Text;
                fca.HomePage = homePageTextBox.Text;

                
                if (id == null)
                {
                    db.Suppliers.Add(fca);
                }
                else
                {
                    db.Entry(fca).State = System.Data.Entity.EntityState.Modified;
                }

                db.SaveChanges();
                this.Close();

            }
        }

        private void FSuplidor_Load(object sender, EventArgs e)
        {

        }
    }
}
