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
    public partial class CrearOrden : Form
    {
        public int? id;
        Orders fca = null;
        public CrearOrden(int? id = null)
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
                fca = db.Orders.Find(id);
                comboBox1.Text = fca.CustomerID;
                comboBox2.Text = Convert.ToString(fca.EmployeeID);
                dateTimePicker1.Value = (DateTime)fca.OrderDate;
                dateTimePicker2.Value = (DateTime)fca.RequiredDate;
                dateTimePicker2.Value = (DateTime)fca.ShippedDate;
                textBox6.Text = Convert.ToString(fca.ShipVia);
                textBox7.Text = Convert.ToString(fca.Freight);
                textBox8.Text = fca.ShipName;
                textBox9.Text = fca.ShipAddress;
                textBox10.Text = fca.ShipCity;
                textBox11.Text = fca.ShipRegion;
                textBox12.Text = fca.ShipPostalCode;
                textBox13.Text = fca.ShipCountry;
            }

        }

        private void btGuardar_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "" || comboBox2.Text == "" || textBox6.Text == "" || textBox7.Text == "" || textBox8.Text == "" || textBox9.Text == "" || textBox10.Text == "" || textBox11.Text == "" || textBox12.Text == "" || textBox13.Text == "" )
            {
                MessageBox.Show("Debe de llenar todos los campos");
            }
            else
            {
                MessageBox.Show("La informacion se guardo con exito");
            }
            using (NorthwindEntities db = new NorthwindEntities())
            {
                if (id == null)
                {
                    fca = new Orders();
                }


                fca.CustomerID = comboBox1.Text;
                fca.EmployeeID = int.Parse(comboBox2.Text);
                fca.OrderDate = dateTimePicker1.Value;
                fca.RequiredDate = dateTimePicker2.Value;
                fca.ShippedDate = dateTimePicker2.Value;
                fca.ShipVia = int.Parse(textBox6.Text);
                fca.Freight = int.Parse(textBox7.Text);
                fca.ShipName = textBox8.Text;
                fca.ShipAddress = textBox9.Text;
                fca.ShipCity = textBox10.Text;
                fca.ShipRegion = textBox11.Text;
                fca.ShipPostalCode = textBox12.Text;
                fca.ShipCountry = textBox13.Text;

                
                if (id == null)
                {
                    db.Orders.Add(fca);
                }
                else
                {
                    db.Entry(fca).State = System.Data.Entity.EntityState.Modified;
                }

                db.SaveChanges();
                this.Close();

            }
        }

        private void Limpiar_Click(object sender, EventArgs e)
        {

        }

        private void btlista_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Favor revisar si su informacion aparece en la lista");
            ListaOrden lista = new ListaOrden();
            lista.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Favor revisar si su informacion aparece en la lista");
            ListaOrden lista = new ListaOrden();
            lista.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox3.Text == "" || textBox4.Text == "")
            {
                MessageBox.Show(" Debe de completar todos los espacios");
            }
            else
            {
                MessageBox.Show("La infomacion se guardo con exito");
                
                textBox3.Clear();
                textBox4.Clear();
            }
        }

        private void CrearOrden_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'northwindDataSet.Orders' Puede moverla o quitarla según sea necesario.
            this.ordersTableAdapter.Fill(this.northwindDataSet.Orders);
            // TODO: esta línea de código carga datos en la tabla 'northwindDataSet.Employees' Puede moverla o quitarla según sea necesario.
            this.employeesTableAdapter.Fill(this.northwindDataSet.Employees);
            // TODO: esta línea de código carga datos en la tabla 'northwindDataSet.Customers' Puede moverla o quitarla según sea necesario.
            this.customersTableAdapter.Fill(this.northwindDataSet.Customers);

        }
    }
}
