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
    public partial class FEmpleados : Form
    {
        public int? id;
        Employees fca = null;
        
        public FEmpleados(int? id = null)
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
                fca = db.Employees.Find(id);
                //employeeIDTextBox.Text = Convert.ToString(fca.EmployeeID);
                lastNameTextBox.Text = fca.LastName;
                firstNameTextBox.Text = fca.FirstName;
                titleTextBox.Text = fca.Title;
                titleOfCourtesyTextBox.Text = fca.TitleOfCourtesy;
                birthDateDateTimePicker.Value = (DateTime)fca.BirthDate;
                hireDateDateTimePicker.Value = (DateTime)fca.HireDate;
                addressTextBox.Text = fca.Address;
                cityTextBox.Text = fca.City;
                regionTextBox.Text = fca.Region;
                postalCodeTextBox.Text = fca.PostalCode;
                countryTextBox.Text = fca.Country;
                homePhoneTextBox.Text = fca.HomePhone;
                extensionTextBox.Text = fca.Extension;
                photoPathTextBox.Text = Convert.ToString(fca.Photo);
                notesTextBox.Text = fca.Notes;
                reportsToTextBox.Text = Convert.ToString(fca.ReportsTo);
                photoPathTextBox.Text = fca.PhotoPath;
                comboBox1.Text = Convert.ToString(fca.Employees2);
                comboBox2.Text = Convert.ToString(fca.Territories);

            }

        }



        private void FEmpleados_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'northwindDataSet.Territories' Puede moverla o quitarla según sea necesario.
            this.territoriesTableAdapter.Fill(this.northwindDataSet.Territories);

        }

        private void btguardarE_Click(object sender, EventArgs e)
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
                    fca = new Employees();
                }

                //fca.EmployeeID = Convert.ToInt32(employeeIDTextBox);
                fca.LastName = lastNameTextBox.Text;
                fca.FirstName = firstNameTextBox.Text;
                fca.Title = titleTextBox.Text = fca.Title;
                fca.TitleOfCourtesy = titleOfCourtesyTextBox.Text;
                fca.BirthDate = birthDateDateTimePicker.Value;
                fca.HireDate = hireDateDateTimePicker.Value;
                fca.Address = addressTextBox.Text;
                fca.City = cityTextBox.Text;
                fca.Region = regionTextBox.Text;
                fca.PostalCode = postalCodeTextBox.Text;
                fca.Country = countryTextBox.Text;
                fca.HomePhone = homePhoneTextBox.Text;
                fca.Extension = extensionTextBox.Text;
                //fca.Photo = Convert.FromBase64String(photoPathTextBox.Text);
                fca.Notes = notesTextBox.Text;
                fca.ReportsTo = Convert.ToInt32(reportsToTextBox.Text);
                fca.PhotoPath = photoPathTextBox.Text;
                fca.Territories = (ICollection<Territories>)comboBox2.SelectedValue;
                fca.Employees2 = (Employees)comboBox1.SelectedValue;

                if (id == null)
                {
                    db.Employees.Add(fca);
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
