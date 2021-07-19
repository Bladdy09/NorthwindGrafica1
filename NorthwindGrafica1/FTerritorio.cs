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
    public partial class FTerritorio : Form
    {
        public int? id;
        Territories fca = null;
        public FTerritorio(int? id = null)
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
                fca = db.Territories.Find(id);
                territoryIDTextBox.Text = Convert.ToString(fca.TerritoryID);
                territoryDescriptionTextBox.Text = fca.TerritoryDescription;
                regionIDTextBox.Text = Convert.ToString(fca.RegionID);

            }

        }



        private void btguardarT_Click(object sender, EventArgs e)
        {
            using (NorthwindEntities db = new NorthwindEntities())
            {
                if (id == null)
                {
                    fca = new Territories();
                }

                fca.TerritoryID = territoryIDTextBox.Text;
                fca.TerritoryDescription = territoryDescriptionTextBox.Text;
                fca.RegionID = Convert.ToInt32( regionIDTextBox.Text);
                if (id == null)
                {
                    db.Territories.Add(fca);


                }
                else
                {
                    db.Entry(fca).State = System.Data.Entity.EntityState.Modified;
                }

                db.SaveChanges();
                this.Close();

            }
        }

        private void FTerritorio_Load(object sender, EventArgs e)
        {

        }
    }
}
