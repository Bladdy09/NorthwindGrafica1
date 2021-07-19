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
    public partial class FProducto : Form
    {
        public int? id;
        Products fca = null;
        public FProducto(int? id = null)
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
                fca = db.Products.Find(id);
                //productIDTextBox.Text = Convert.ToString(fca.ProductID);
                productNameTextBox.Text = fca.ProductName;
                comboBox1.Text = Convert.ToString(fca.SupplierID);
                comboBox2.Text = Convert.ToString(fca.CategoryID);
                quantityPerUnitTextBox.Text = fca.QuantityPerUnit;                                  
                unitPriceTextBox.Text = Convert.ToString(fca.UnitPrice);
                unitsInStockTextBox.Text = Convert.ToString(fca.UnitsInStock);
                unitsOnOrderTextBox.Text = Convert.ToString(fca.UnitsOnOrder);
                reorderLevelTextBox.Text = Convert.ToString(fca.ReorderLevel);
               
            }

        }

        private void btguardarP_Click(object sender, EventArgs e)
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
                    fca = new Products();
                }

                //fca.ProductID = int.Parse(productIDTextBox.Text);
                fca.ProductName = productNameTextBox.Text;
                fca.SupplierID = Convert.ToInt32(comboBox1.Text);
                fca.CategoryID = int.Parse(comboBox2.Text);
                fca.QuantityPerUnit = quantityPerUnitTextBox.Text;
                fca.UnitPrice = Convert.ToInt32(unitPriceTextBox.Text);
                fca.UnitsInStock = Convert.ToInt16(unitsInStockTextBox.Text);
                fca.UnitsOnOrder = Convert.ToInt16(unitsOnOrderTextBox.Text);
                fca.ReorderLevel = Convert.ToInt16(reorderLevelTextBox.Text);


               
                if (id == null)
                {
                    db.Products.Add(fca);
                }
                else
                {
                    db.Entry(fca).State = System.Data.Entity.EntityState.Modified;
                }

                db.SaveChanges();
                MessageBox.Show("Los datos se guadaron con exito");
                this.Close();

            }
        }

        private void FProducto_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'northwindDataSet.Categories' Puede moverla o quitarla según sea necesario.
            this.categoriesTableAdapter.Fill(this.northwindDataSet.Categories);
            // TODO: esta línea de código carga datos en la tabla 'northwindDataSet.Suppliers' Puede moverla o quitarla según sea necesario.
            this.suppliersTableAdapter.Fill(this.northwindDataSet.Suppliers);

        }
    }
}
