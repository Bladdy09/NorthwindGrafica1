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
    public partial class FCustomer : Form
    {
        public int? id;
        Customers fca = null;
        CustomerDemographics Demographics = null;
        
        public FCustomer(int? id = null)
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
                fca = db.Customers.Find(id);
                textBox2.Text = fca.CustomerID;
                textBox10.Text = fca.CompanyName;
                textBox11.Text = fca.ContactName;
                textBox1.Text = fca.ContactTitle;
                textBox7.Text = fca.Address;
                textBox5.Text = fca.City;
                textBox6.Text = fca.Region;
                textBox4.Text = fca.PostalCode;
                textBox8.Text = fca.Country;
                textBox3.Text = fca.Phone;
                textBox9.Text = fca.Fax;
            }

        }

        private void BTGUARDARC_Click(object sender, EventArgs e)
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
                    else
                    {
                        MessageBox.Show("Los datos se guadaron con exito");

                    }
                }
            }

            using (NorthwindEntities db = new NorthwindEntities())
            {
                if (id == null)
                {
                    fca = new Customers();
                }

                fca.CustomerID = textBox2.Text;
                fca.CompanyName = textBox10.Text;
                fca.ContactName = textBox11.Text;
                fca.Address = textBox7.Text;
                fca.City = textBox5.Text;
                fca.Region = textBox6.Text;
                fca.PostalCode = textBox4.Text;
                fca.Country = textBox8.Text;
                fca.Phone = textBox3.Text;
                fca.Fax = textBox9.Text;

                
                if (id == null)
                {
                    db.Customers.Add(fca);
                }
                else
                {
                    db.Entry(fca).State = System.Data.Entity.EntityState.Modified;
                }

                

                db.SaveChanges();
                this.Close();

            }
        }

        private void splitter1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void splitter2_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void FCustomer_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'northwindDataSet.CustomerDemographics' Puede moverla o quitarla según sea necesario.
            this.customerDemographicsTableAdapter.Fill(this.northwindDataSet.CustomerDemographics);
            // TODO: esta línea de código carga datos en la tabla 'northwindDataSet.Customers' Puede moverla o quitarla según sea necesario.
            this.customersTableAdapter.Fill(this.northwindDataSet.Customers);

        }
    }
}
