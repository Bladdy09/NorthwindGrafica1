
namespace NorthwindGrafica1
{
    partial class FEmpleados
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
            System.Windows.Forms.Label lastNameLabel;
            System.Windows.Forms.Label firstNameLabel;
            System.Windows.Forms.Label titleLabel;
            System.Windows.Forms.Label titleOfCourtesyLabel;
            System.Windows.Forms.Label birthDateLabel;
            System.Windows.Forms.Label hireDateLabel;
            System.Windows.Forms.Label addressLabel;
            System.Windows.Forms.Label cityLabel;
            System.Windows.Forms.Label regionLabel;
            System.Windows.Forms.Label postalCodeLabel;
            System.Windows.Forms.Label countryLabel;
            System.Windows.Forms.Label homePhoneLabel;
            System.Windows.Forms.Label extensionLabel;
            System.Windows.Forms.Label notesLabel;
            System.Windows.Forms.Label reportsToLabel;
            System.Windows.Forms.Label photoPathLabel;
            System.Windows.Forms.Label employeeIDLabel1;
            System.Windows.Forms.Label territoryIDLabel;
            this.northwindDataSet = new NorthwindGrafica1.NorthwindDataSet();
            this.employeesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeesTableAdapter = new NorthwindGrafica1.NorthwindDataSetTableAdapters.EmployeesTableAdapter();
            this.tableAdapterManager = new NorthwindGrafica1.NorthwindDataSetTableAdapters.TableAdapterManager();
            this.employeeTerritoriesTableAdapter = new NorthwindGrafica1.NorthwindDataSetTableAdapters.EmployeeTerritoriesTableAdapter();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.titleOfCourtesyTextBox = new System.Windows.Forms.TextBox();
            this.birthDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.hireDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.cityTextBox = new System.Windows.Forms.TextBox();
            this.regionTextBox = new System.Windows.Forms.TextBox();
            this.postalCodeTextBox = new System.Windows.Forms.TextBox();
            this.countryTextBox = new System.Windows.Forms.TextBox();
            this.homePhoneTextBox = new System.Windows.Forms.TextBox();
            this.extensionTextBox = new System.Windows.Forms.TextBox();
            this.notesTextBox = new System.Windows.Forms.TextBox();
            this.reportsToTextBox = new System.Windows.Forms.TextBox();
            this.photoPathTextBox = new System.Windows.Forms.TextBox();
            this.employeeTerritoriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btguardarE = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.employeesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.employeesBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.territoriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.territoriesTableAdapter = new NorthwindGrafica1.NorthwindDataSetTableAdapters.TerritoriesTableAdapter();
            this.territoriesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            lastNameLabel = new System.Windows.Forms.Label();
            firstNameLabel = new System.Windows.Forms.Label();
            titleLabel = new System.Windows.Forms.Label();
            titleOfCourtesyLabel = new System.Windows.Forms.Label();
            birthDateLabel = new System.Windows.Forms.Label();
            hireDateLabel = new System.Windows.Forms.Label();
            addressLabel = new System.Windows.Forms.Label();
            cityLabel = new System.Windows.Forms.Label();
            regionLabel = new System.Windows.Forms.Label();
            postalCodeLabel = new System.Windows.Forms.Label();
            countryLabel = new System.Windows.Forms.Label();
            homePhoneLabel = new System.Windows.Forms.Label();
            extensionLabel = new System.Windows.Forms.Label();
            notesLabel = new System.Windows.Forms.Label();
            reportsToLabel = new System.Windows.Forms.Label();
            photoPathLabel = new System.Windows.Forms.Label();
            employeeIDLabel1 = new System.Windows.Forms.Label();
            territoryIDLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.northwindDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeTerritoriesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.territoriesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.territoriesBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lastNameLabel.Location = new System.Drawing.Point(59, 68);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new System.Drawing.Size(83, 19);
            lastNameLabel.TabIndex = 3;
            lastNameLabel.Text = "Last Name:";
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            firstNameLabel.Location = new System.Drawing.Point(57, 94);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new System.Drawing.Size(85, 19);
            firstNameLabel.TabIndex = 5;
            firstNameLabel.Text = "First Name:";
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            titleLabel.Location = new System.Drawing.Point(100, 120);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new System.Drawing.Size(42, 19);
            titleLabel.TabIndex = 7;
            titleLabel.Text = "Title:";
            // 
            // titleOfCourtesyLabel
            // 
            titleOfCourtesyLabel.AutoSize = true;
            titleOfCourtesyLabel.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            titleOfCourtesyLabel.Location = new System.Drawing.Point(18, 146);
            titleOfCourtesyLabel.Name = "titleOfCourtesyLabel";
            titleOfCourtesyLabel.Size = new System.Drawing.Size(124, 19);
            titleOfCourtesyLabel.TabIndex = 9;
            titleOfCourtesyLabel.Text = "Title Of Courtesy:";
            // 
            // birthDateLabel
            // 
            birthDateLabel.AutoSize = true;
            birthDateLabel.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            birthDateLabel.Location = new System.Drawing.Point(62, 173);
            birthDateLabel.Name = "birthDateLabel";
            birthDateLabel.Size = new System.Drawing.Size(80, 19);
            birthDateLabel.TabIndex = 11;
            birthDateLabel.Text = "Birth Date:";
            // 
            // hireDateLabel
            // 
            hireDateLabel.AutoSize = true;
            hireDateLabel.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            hireDateLabel.Location = new System.Drawing.Point(65, 199);
            hireDateLabel.Name = "hireDateLabel";
            hireDateLabel.Size = new System.Drawing.Size(77, 19);
            hireDateLabel.TabIndex = 13;
            hireDateLabel.Text = "Hire Date:";
            // 
            // addressLabel
            // 
            addressLabel.AutoSize = true;
            addressLabel.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            addressLabel.Location = new System.Drawing.Point(75, 224);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new System.Drawing.Size(67, 19);
            addressLabel.TabIndex = 15;
            addressLabel.Text = "Address:";
            // 
            // cityLabel
            // 
            cityLabel.AutoSize = true;
            cityLabel.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cityLabel.Location = new System.Drawing.Point(104, 250);
            cityLabel.Name = "cityLabel";
            cityLabel.Size = new System.Drawing.Size(38, 19);
            cityLabel.TabIndex = 17;
            cityLabel.Text = "City:";
            // 
            // regionLabel
            // 
            regionLabel.AutoSize = true;
            regionLabel.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            regionLabel.Location = new System.Drawing.Point(82, 276);
            regionLabel.Name = "regionLabel";
            regionLabel.Size = new System.Drawing.Size(60, 19);
            regionLabel.TabIndex = 19;
            regionLabel.Text = "Region:";
            // 
            // postalCodeLabel
            // 
            postalCodeLabel.AutoSize = true;
            postalCodeLabel.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            postalCodeLabel.Location = new System.Drawing.Point(49, 302);
            postalCodeLabel.Name = "postalCodeLabel";
            postalCodeLabel.Size = new System.Drawing.Size(93, 19);
            postalCodeLabel.TabIndex = 21;
            postalCodeLabel.Text = "Postal Code:";
            // 
            // countryLabel
            // 
            countryLabel.AutoSize = true;
            countryLabel.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            countryLabel.Location = new System.Drawing.Point(77, 328);
            countryLabel.Name = "countryLabel";
            countryLabel.Size = new System.Drawing.Size(65, 19);
            countryLabel.TabIndex = 23;
            countryLabel.Text = "Country:";
            // 
            // homePhoneLabel
            // 
            homePhoneLabel.AutoSize = true;
            homePhoneLabel.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            homePhoneLabel.Location = new System.Drawing.Point(42, 354);
            homePhoneLabel.Name = "homePhoneLabel";
            homePhoneLabel.Size = new System.Drawing.Size(100, 19);
            homePhoneLabel.TabIndex = 25;
            homePhoneLabel.Text = "Home Phone:";
            // 
            // extensionLabel
            // 
            extensionLabel.AutoSize = true;
            extensionLabel.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            extensionLabel.Location = new System.Drawing.Point(66, 380);
            extensionLabel.Name = "extensionLabel";
            extensionLabel.Size = new System.Drawing.Size(76, 19);
            extensionLabel.TabIndex = 27;
            extensionLabel.Text = "Extension:";
            // 
            // notesLabel
            // 
            notesLabel.AutoSize = true;
            notesLabel.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            notesLabel.Location = new System.Drawing.Point(90, 406);
            notesLabel.Name = "notesLabel";
            notesLabel.Size = new System.Drawing.Size(52, 19);
            notesLabel.TabIndex = 29;
            notesLabel.Text = "Notes:";
            // 
            // reportsToLabel
            // 
            reportsToLabel.AutoSize = true;
            reportsToLabel.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            reportsToLabel.Location = new System.Drawing.Point(56, 432);
            reportsToLabel.Name = "reportsToLabel";
            reportsToLabel.Size = new System.Drawing.Size(86, 19);
            reportsToLabel.TabIndex = 31;
            reportsToLabel.Text = "Reports To:";
            // 
            // photoPathLabel
            // 
            photoPathLabel.AutoSize = true;
            photoPathLabel.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            photoPathLabel.Location = new System.Drawing.Point(55, 458);
            photoPathLabel.Name = "photoPathLabel";
            photoPathLabel.Size = new System.Drawing.Size(87, 19);
            photoPathLabel.TabIndex = 33;
            photoPathLabel.Text = "Photo Path:";
            // 
            // employeeIDLabel1
            // 
            employeeIDLabel1.AutoSize = true;
            employeeIDLabel1.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            employeeIDLabel1.Location = new System.Drawing.Point(448, 61);
            employeeIDLabel1.Name = "employeeIDLabel1";
            employeeIDLabel1.Size = new System.Drawing.Size(96, 19);
            employeeIDLabel1.TabIndex = 35;
            employeeIDLabel1.Text = "Employee ID:";
            // 
            // territoryIDLabel
            // 
            territoryIDLabel.AutoSize = true;
            territoryIDLabel.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            territoryIDLabel.Location = new System.Drawing.Point(448, 87);
            territoryIDLabel.Name = "territoryIDLabel";
            territoryIDLabel.Size = new System.Drawing.Size(90, 19);
            territoryIDLabel.TabIndex = 37;
            territoryIDLabel.Text = "Territory ID:";
            // 
            // northwindDataSet
            // 
            this.northwindDataSet.DataSetName = "NorthwindDataSet";
            this.northwindDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // employeesBindingSource
            // 
            this.employeesBindingSource.DataMember = "Employees";
            this.employeesBindingSource.DataSource = this.northwindDataSet;
            // 
            // employeesTableAdapter
            // 
            this.employeesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CategoriesTableAdapter = null;
            this.tableAdapterManager.CustomerCustomerDemoTableAdapter = null;
            this.tableAdapterManager.CustomerDemographicsTableAdapter = null;
            this.tableAdapterManager.CustomersTableAdapter = null;
            this.tableAdapterManager.EmployeesTableAdapter = this.employeesTableAdapter;
            this.tableAdapterManager.EmployeeTerritoriesTableAdapter = this.employeeTerritoriesTableAdapter;
            this.tableAdapterManager.Order_DetailsTableAdapter = null;
            this.tableAdapterManager.OrdersTableAdapter = null;
            this.tableAdapterManager.ProductsTableAdapter = null;
            this.tableAdapterManager.RegionTableAdapter = null;
            this.tableAdapterManager.ShippersTableAdapter = null;
            this.tableAdapterManager.SuppliersTableAdapter = null;
            this.tableAdapterManager.TerritoriesTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = NorthwindGrafica1.NorthwindDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // employeeTerritoriesTableAdapter
            // 
            this.employeeTerritoriesTableAdapter.ClearBeforeFill = true;
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeesBindingSource, "LastName", true));
            this.lastNameTextBox.Location = new System.Drawing.Point(159, 67);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(200, 20);
            this.lastNameTextBox.TabIndex = 4;
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeesBindingSource, "FirstName", true));
            this.firstNameTextBox.Location = new System.Drawing.Point(159, 93);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(200, 20);
            this.firstNameTextBox.TabIndex = 6;
            // 
            // titleTextBox
            // 
            this.titleTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeesBindingSource, "Title", true));
            this.titleTextBox.Location = new System.Drawing.Point(159, 119);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(200, 20);
            this.titleTextBox.TabIndex = 8;
            // 
            // titleOfCourtesyTextBox
            // 
            this.titleOfCourtesyTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeesBindingSource, "TitleOfCourtesy", true));
            this.titleOfCourtesyTextBox.Location = new System.Drawing.Point(159, 145);
            this.titleOfCourtesyTextBox.Name = "titleOfCourtesyTextBox";
            this.titleOfCourtesyTextBox.Size = new System.Drawing.Size(200, 20);
            this.titleOfCourtesyTextBox.TabIndex = 10;
            // 
            // birthDateDateTimePicker
            // 
            this.birthDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.employeesBindingSource, "BirthDate", true));
            this.birthDateDateTimePicker.Location = new System.Drawing.Point(159, 171);
            this.birthDateDateTimePicker.Name = "birthDateDateTimePicker";
            this.birthDateDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.birthDateDateTimePicker.TabIndex = 12;
            // 
            // hireDateDateTimePicker
            // 
            this.hireDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.employeesBindingSource, "HireDate", true));
            this.hireDateDateTimePicker.Location = new System.Drawing.Point(159, 197);
            this.hireDateDateTimePicker.Name = "hireDateDateTimePicker";
            this.hireDateDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.hireDateDateTimePicker.TabIndex = 14;
            // 
            // addressTextBox
            // 
            this.addressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeesBindingSource, "Address", true));
            this.addressTextBox.Location = new System.Drawing.Point(159, 223);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(200, 20);
            this.addressTextBox.TabIndex = 16;
            // 
            // cityTextBox
            // 
            this.cityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeesBindingSource, "City", true));
            this.cityTextBox.Location = new System.Drawing.Point(159, 249);
            this.cityTextBox.Name = "cityTextBox";
            this.cityTextBox.Size = new System.Drawing.Size(200, 20);
            this.cityTextBox.TabIndex = 18;
            // 
            // regionTextBox
            // 
            this.regionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeesBindingSource, "Region", true));
            this.regionTextBox.Location = new System.Drawing.Point(159, 275);
            this.regionTextBox.Name = "regionTextBox";
            this.regionTextBox.Size = new System.Drawing.Size(200, 20);
            this.regionTextBox.TabIndex = 20;
            // 
            // postalCodeTextBox
            // 
            this.postalCodeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeesBindingSource, "PostalCode", true));
            this.postalCodeTextBox.Location = new System.Drawing.Point(159, 301);
            this.postalCodeTextBox.Name = "postalCodeTextBox";
            this.postalCodeTextBox.Size = new System.Drawing.Size(200, 20);
            this.postalCodeTextBox.TabIndex = 22;
            // 
            // countryTextBox
            // 
            this.countryTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeesBindingSource, "Country", true));
            this.countryTextBox.Location = new System.Drawing.Point(159, 327);
            this.countryTextBox.Name = "countryTextBox";
            this.countryTextBox.Size = new System.Drawing.Size(200, 20);
            this.countryTextBox.TabIndex = 24;
            // 
            // homePhoneTextBox
            // 
            this.homePhoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeesBindingSource, "HomePhone", true));
            this.homePhoneTextBox.Location = new System.Drawing.Point(159, 353);
            this.homePhoneTextBox.Name = "homePhoneTextBox";
            this.homePhoneTextBox.Size = new System.Drawing.Size(200, 20);
            this.homePhoneTextBox.TabIndex = 26;
            // 
            // extensionTextBox
            // 
            this.extensionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeesBindingSource, "Extension", true));
            this.extensionTextBox.Location = new System.Drawing.Point(159, 379);
            this.extensionTextBox.Name = "extensionTextBox";
            this.extensionTextBox.Size = new System.Drawing.Size(200, 20);
            this.extensionTextBox.TabIndex = 28;
            // 
            // notesTextBox
            // 
            this.notesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeesBindingSource, "Notes", true));
            this.notesTextBox.Location = new System.Drawing.Point(159, 405);
            this.notesTextBox.Name = "notesTextBox";
            this.notesTextBox.Size = new System.Drawing.Size(200, 20);
            this.notesTextBox.TabIndex = 30;
            // 
            // reportsToTextBox
            // 
            this.reportsToTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeesBindingSource, "ReportsTo", true));
            this.reportsToTextBox.Location = new System.Drawing.Point(159, 431);
            this.reportsToTextBox.Name = "reportsToTextBox";
            this.reportsToTextBox.Size = new System.Drawing.Size(200, 20);
            this.reportsToTextBox.TabIndex = 32;
            // 
            // photoPathTextBox
            // 
            this.photoPathTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeesBindingSource, "PhotoPath", true));
            this.photoPathTextBox.Location = new System.Drawing.Point(159, 457);
            this.photoPathTextBox.Name = "photoPathTextBox";
            this.photoPathTextBox.Size = new System.Drawing.Size(200, 20);
            this.photoPathTextBox.TabIndex = 34;
            // 
            // employeeTerritoriesBindingSource
            // 
            this.employeeTerritoriesBindingSource.DataMember = "EmployeeTerritories";
            this.employeeTerritoriesBindingSource.DataSource = this.northwindDataSet;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(418, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(10, 565);
            this.panel1.TabIndex = 40;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 26);
            this.label1.TabIndex = 41;
            this.label1.Text = "Empleados";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(437, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(277, 26);
            this.label2.TabIndex = 42;
            this.label2.Text = "Territorio de los empleados";
            // 
            // btguardarE
            // 
            this.btguardarE.BackColor = System.Drawing.Color.DodgerBlue;
            this.btguardarE.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btguardarE.Location = new System.Drawing.Point(530, 137);
            this.btguardarE.Name = "btguardarE";
            this.btguardarE.Size = new System.Drawing.Size(77, 37);
            this.btguardarE.TabIndex = 46;
            this.btguardarE.Text = "Guardar";
            this.btguardarE.UseVisualStyleBackColor = false;
            this.btguardarE.Click += new System.EventHandler(this.btguardarE_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.employeesBindingSource2, "EmployeeID", true));
            this.comboBox1.DataSource = this.employeesBindingSource1;
            this.comboBox1.DisplayMember = "FirstName";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(577, 62);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 47;
            this.comboBox1.ValueMember = "EmployeeID";
            // 
            // comboBox2
            // 
            this.comboBox2.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.territoriesBindingSource1, "TerritoryID", true));
            this.comboBox2.DataSource = this.territoriesBindingSource;
            this.comboBox2.DisplayMember = "TerritoryDescription";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(577, 89);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 48;
            this.comboBox2.ValueMember = "TerritoryID";
            // 
            // employeesBindingSource1
            // 
            this.employeesBindingSource1.DataMember = "Employees";
            this.employeesBindingSource1.DataSource = this.northwindDataSet;
            // 
            // employeesBindingSource2
            // 
            this.employeesBindingSource2.DataMember = "Employees";
            this.employeesBindingSource2.DataSource = this.northwindDataSet;
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
            // territoriesBindingSource1
            // 
            this.territoriesBindingSource1.DataMember = "Territories";
            this.territoriesBindingSource1.DataSource = this.northwindDataSet;
            // 
            // FEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(722, 486);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btguardarE);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(employeeIDLabel1);
            this.Controls.Add(territoryIDLabel);
            this.Controls.Add(lastNameLabel);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(firstNameLabel);
            this.Controls.Add(this.firstNameTextBox);
            this.Controls.Add(titleLabel);
            this.Controls.Add(this.titleTextBox);
            this.Controls.Add(titleOfCourtesyLabel);
            this.Controls.Add(this.titleOfCourtesyTextBox);
            this.Controls.Add(birthDateLabel);
            this.Controls.Add(this.birthDateDateTimePicker);
            this.Controls.Add(hireDateLabel);
            this.Controls.Add(this.hireDateDateTimePicker);
            this.Controls.Add(addressLabel);
            this.Controls.Add(this.addressTextBox);
            this.Controls.Add(cityLabel);
            this.Controls.Add(this.cityTextBox);
            this.Controls.Add(regionLabel);
            this.Controls.Add(this.regionTextBox);
            this.Controls.Add(postalCodeLabel);
            this.Controls.Add(this.postalCodeTextBox);
            this.Controls.Add(countryLabel);
            this.Controls.Add(this.countryTextBox);
            this.Controls.Add(homePhoneLabel);
            this.Controls.Add(this.homePhoneTextBox);
            this.Controls.Add(extensionLabel);
            this.Controls.Add(this.extensionTextBox);
            this.Controls.Add(notesLabel);
            this.Controls.Add(this.notesTextBox);
            this.Controls.Add(reportsToLabel);
            this.Controls.Add(this.reportsToTextBox);
            this.Controls.Add(photoPathLabel);
            this.Controls.Add(this.photoPathTextBox);
            this.Name = "FEmpleados";
            this.Text = "FEmpleados";
            this.Load += new System.EventHandler(this.FEmpleados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.northwindDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeTerritoriesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.territoriesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.territoriesBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private NorthwindDataSet northwindDataSet;
        private System.Windows.Forms.BindingSource employeesBindingSource;
        private NorthwindDataSetTableAdapters.EmployeesTableAdapter employeesTableAdapter;
        private NorthwindDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.TextBox titleOfCourtesyTextBox;
        private System.Windows.Forms.DateTimePicker birthDateDateTimePicker;
        private System.Windows.Forms.DateTimePicker hireDateDateTimePicker;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.TextBox cityTextBox;
        private System.Windows.Forms.TextBox regionTextBox;
        private System.Windows.Forms.TextBox postalCodeTextBox;
        private System.Windows.Forms.TextBox countryTextBox;
        private System.Windows.Forms.TextBox homePhoneTextBox;
        private System.Windows.Forms.TextBox extensionTextBox;
        private System.Windows.Forms.TextBox notesTextBox;
        private System.Windows.Forms.TextBox reportsToTextBox;
        private System.Windows.Forms.TextBox photoPathTextBox;
        private NorthwindDataSetTableAdapters.EmployeeTerritoriesTableAdapter employeeTerritoriesTableAdapter;
        private System.Windows.Forms.BindingSource employeeTerritoriesBindingSource;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btguardarE;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource employeesBindingSource2;
        private System.Windows.Forms.BindingSource employeesBindingSource1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.BindingSource territoriesBindingSource;
        private NorthwindDataSetTableAdapters.TerritoriesTableAdapter territoriesTableAdapter;
        private System.Windows.Forms.BindingSource territoriesBindingSource1;
    }
}