
namespace NorthwindGrafica1
{
    partial class FTerritorio
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label territoryIDLabel;
            System.Windows.Forms.Label territoryDescriptionLabel;
            System.Windows.Forms.Label regionIDLabel;
            this.northwindDataSet = new NorthwindGrafica1.NorthwindDataSet();
            this.territoriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.territoriesTableAdapter = new NorthwindGrafica1.NorthwindDataSetTableAdapters.TerritoriesTableAdapter();
            this.tableAdapterManager = new NorthwindGrafica1.NorthwindDataSetTableAdapters.TableAdapterManager();
            this.territoryIDTextBox = new System.Windows.Forms.TextBox();
            this.territoryDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.regionIDTextBox = new System.Windows.Forms.TextBox();
            this.btguardarT = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            territoryIDLabel = new System.Windows.Forms.Label();
            territoryDescriptionLabel = new System.Windows.Forms.Label();
            regionIDLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.northwindDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.territoriesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // territoryIDLabel
            // 
            territoryIDLabel.AutoSize = true;
            territoryIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            territoryIDLabel.Location = new System.Drawing.Point(76, 81);
            territoryIDLabel.Name = "territoryIDLabel";
            territoryIDLabel.Size = new System.Drawing.Size(90, 16);
            territoryIDLabel.TabIndex = 1;
            territoryIDLabel.Text = "Territory ID:";
            // 
            // territoryDescriptionLabel
            // 
            territoryDescriptionLabel.AutoSize = true;
            territoryDescriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            territoryDescriptionLabel.Location = new System.Drawing.Point(12, 107);
            territoryDescriptionLabel.Name = "territoryDescriptionLabel";
            territoryDescriptionLabel.Size = new System.Drawing.Size(154, 16);
            territoryDescriptionLabel.TabIndex = 3;
            territoryDescriptionLabel.Text = "Territory Description:";
            // 
            // regionIDLabel
            // 
            regionIDLabel.AutoSize = true;
            regionIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            regionIDLabel.Location = new System.Drawing.Point(85, 133);
            regionIDLabel.Name = "regionIDLabel";
            regionIDLabel.Size = new System.Drawing.Size(81, 16);
            regionIDLabel.TabIndex = 5;
            regionIDLabel.Text = "Region ID:";
            // 
            // northwindDataSet
            // 
            this.northwindDataSet.DataSetName = "NorthwindDataSet";
            this.northwindDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // territoriesBindingSource
            // 
            this.territoriesBindingSource.DataMember = "Territories";
            this.territoriesBindingSource.DataSource = this.northwindDataSet;
            // 
            // territoriesTableAdapter
            // 
            this.territoriesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CategoriesTableAdapter = null;
            this.tableAdapterManager.CustomerCustomerDemoTableAdapter = null;
            this.tableAdapterManager.CustomerDemographicsTableAdapter = null;
            this.tableAdapterManager.CustomersTableAdapter = null;
            this.tableAdapterManager.EmployeesTableAdapter = null;
            this.tableAdapterManager.EmployeeTerritoriesTableAdapter = null;
            this.tableAdapterManager.Order_DetailsTableAdapter = null;
            this.tableAdapterManager.OrdersTableAdapter = null;
            this.tableAdapterManager.ProductsTableAdapter = null;
            this.tableAdapterManager.RegionTableAdapter = null;
            this.tableAdapterManager.ShippersTableAdapter = null;
            this.tableAdapterManager.SuppliersTableAdapter = null;
            this.tableAdapterManager.TerritoriesTableAdapter = this.territoriesTableAdapter;
            this.tableAdapterManager.UpdateOrder = NorthwindGrafica1.NorthwindDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // territoryIDTextBox
            // 
            this.territoryIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.territoriesBindingSource, "TerritoryID", true));
            this.territoryIDTextBox.Location = new System.Drawing.Point(172, 77);
            this.territoryIDTextBox.Name = "territoryIDTextBox";
            this.territoryIDTextBox.Size = new System.Drawing.Size(100, 20);
            this.territoryIDTextBox.TabIndex = 2;
            // 
            // territoryDescriptionTextBox
            // 
            this.territoryDescriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.territoriesBindingSource, "TerritoryDescription", true));
            this.territoryDescriptionTextBox.Location = new System.Drawing.Point(172, 103);
            this.territoryDescriptionTextBox.Name = "territoryDescriptionTextBox";
            this.territoryDescriptionTextBox.Size = new System.Drawing.Size(100, 20);
            this.territoryDescriptionTextBox.TabIndex = 4;
            // 
            // regionIDTextBox
            // 
            this.regionIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.territoriesBindingSource, "RegionID", true));
            this.regionIDTextBox.Location = new System.Drawing.Point(172, 129);
            this.regionIDTextBox.Name = "regionIDTextBox";
            this.regionIDTextBox.Size = new System.Drawing.Size(100, 20);
            this.regionIDTextBox.TabIndex = 6;
            // 
            // btguardarT
            // 
            this.btguardarT.BackColor = System.Drawing.Color.DodgerBlue;
            this.btguardarT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btguardarT.Location = new System.Drawing.Point(129, 178);
            this.btguardarT.Name = "btguardarT";
            this.btguardarT.Size = new System.Drawing.Size(77, 37);
            this.btguardarT.TabIndex = 54;
            this.btguardarT.Text = "Guardar";
            this.btguardarT.UseVisualStyleBackColor = false;
            this.btguardarT.Click += new System.EventHandler(this.btguardarT_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 26);
            this.label1.TabIndex = 58;
            this.label1.Text = "Territorios";
            // 
            // FTerritorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(307, 227);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btguardarT);
            this.Controls.Add(territoryIDLabel);
            this.Controls.Add(this.territoryIDTextBox);
            this.Controls.Add(territoryDescriptionLabel);
            this.Controls.Add(this.territoryDescriptionTextBox);
            this.Controls.Add(regionIDLabel);
            this.Controls.Add(this.regionIDTextBox);
            this.Name = "FTerritorio";
            this.Text = "FTerritorio";
            this.Load += new System.EventHandler(this.FTerritorio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.northwindDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.territoriesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private NorthwindDataSet northwindDataSet;
        private System.Windows.Forms.BindingSource territoriesBindingSource;
        private NorthwindDataSetTableAdapters.TerritoriesTableAdapter territoriesTableAdapter;
        private NorthwindDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox territoryIDTextBox;
        private System.Windows.Forms.TextBox territoryDescriptionTextBox;
        private System.Windows.Forms.TextBox regionIDTextBox;
        private System.Windows.Forms.Button btguardarT;
        private System.Windows.Forms.Label label1;
    }
}