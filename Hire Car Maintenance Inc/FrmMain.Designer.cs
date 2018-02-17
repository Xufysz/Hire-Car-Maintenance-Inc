namespace Hire_Car_Maintenance_Inc
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.lblHeader = new System.Windows.Forms.Label();
            this.txtSearchCompany = new System.Windows.Forms.TextBox();
            this.lblSearchCompany = new System.Windows.Forms.Label();
            this.menuDropDwn = new System.Windows.Forms.ToolStrip();
            this.menuDropDown = new System.Windows.Forms.ToolStripDropDownButton();
            this.btnLoadFile = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSaveCurrentFile = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSaveFileAs = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCloseFile = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.grpCompanies = new System.Windows.Forms.GroupBox();
            this.panelCompanyInfo = new System.Windows.Forms.Panel();
            this.lblCompPostcodeTick = new System.Windows.Forms.Label();
            this.lblCompAddressTick = new System.Windows.Forms.Label();
            this.lblCompNameTick = new System.Windows.Forms.Label();
            this.lblCompIDTick = new System.Windows.Forms.Label();
            this.btnEditCompany = new System.Windows.Forms.Button();
            this.btnRemoveCompany = new System.Windows.Forms.Button();
            this.txtCompanyPostcode = new System.Windows.Forms.TextBox();
            this.lblCompPostcode = new System.Windows.Forms.Label();
            this.lblCompAddress = new System.Windows.Forms.Label();
            this.txtCompanyAddress = new System.Windows.Forms.TextBox();
            this.btnAddCompany = new System.Windows.Forms.Button();
            this.lblCompName = new System.Windows.Forms.Label();
            this.btnSaveCompany = new System.Windows.Forms.Button();
            this.txtCompanyID = new System.Windows.Forms.TextBox();
            this.txtCompanyName = new System.Windows.Forms.TextBox();
            this.lblCompID = new System.Windows.Forms.Label();
            this.lstCompanies = new System.Windows.Forms.ListBox();
            this.grpCars = new System.Windows.Forms.GroupBox();
            this.panelCarInfo = new System.Windows.Forms.Panel();
            this.lblCarRegTick = new System.Windows.Forms.Label();
            this.lblCarModelTick = new System.Windows.Forms.Label();
            this.lblCarMakeTick = new System.Windows.Forms.Label();
            this.lblCarIDTick = new System.Windows.Forms.Label();
            this.txtCarMake = new System.Windows.Forms.TextBox();
            this.btnSaveCar = new System.Windows.Forms.Button();
            this.lblCarComments = new System.Windows.Forms.Label();
            this.txtCarComments = new System.Windows.Forms.TextBox();
            this.btnEditCar = new System.Windows.Forms.Button();
            this.dtTimeCarService = new System.Windows.Forms.DateTimePicker();
            this.btnAddCar = new System.Windows.Forms.Button();
            this.lblCarLastService = new System.Windows.Forms.Label();
            this.cmbxCarFuel = new System.Windows.Forms.ComboBox();
            this.lblCarRegistration = new System.Windows.Forms.Label();
            this.lblCarFuelType = new System.Windows.Forms.Label();
            this.btnRemoveCar = new System.Windows.Forms.Button();
            this.txtCarID = new System.Windows.Forms.TextBox();
            this.txtCarReg = new System.Windows.Forms.TextBox();
            this.lblCarModel = new System.Windows.Forms.Label();
            this.lblCarID = new System.Windows.Forms.Label();
            this.lblCarMake = new System.Windows.Forms.Label();
            this.txtCarModel = new System.Windows.Forms.TextBox();
            this.txtSearchCar = new System.Windows.Forms.TextBox();
            this.lblSearchCar = new System.Windows.Forms.Label();
            this.lstCars = new System.Windows.Forms.ListBox();
            this.menuDropDwn.SuspendLayout();
            this.grpCompanies.SuspendLayout();
            this.panelCompanyInfo.SuspendLayout();
            this.grpCars.SuspendLayout();
            this.panelCarInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblHeader
            // 
            this.lblHeader.BackColor = System.Drawing.SystemColors.Control;
            this.lblHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblHeader.Location = new System.Drawing.Point(0, 37);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.lblHeader.Size = new System.Drawing.Size(987, 47);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "Hire Car Maintenance Inc";
            this.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSearchCompany
            // 
            this.txtSearchCompany.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchCompany.Location = new System.Drawing.Point(149, 38);
            this.txtSearchCompany.MaxLength = 1024;
            this.txtSearchCompany.Name = "txtSearchCompany";
            this.txtSearchCompany.Size = new System.Drawing.Size(402, 26);
            this.txtSearchCompany.TabIndex = 4;
            this.txtSearchCompany.TextChanged += new System.EventHandler(this.TxtSearchCompany_TextChanged);
            // 
            // lblSearchCompany
            // 
            this.lblSearchCompany.AutoSize = true;
            this.lblSearchCompany.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchCompany.Location = new System.Drawing.Point(12, 41);
            this.lblSearchCompany.Name = "lblSearchCompany";
            this.lblSearchCompany.Size = new System.Drawing.Size(131, 20);
            this.lblSearchCompany.TabIndex = 0;
            this.lblSearchCompany.Text = "Search Company";
            this.lblSearchCompany.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // menuDropDwn
            // 
            this.menuDropDwn.AllowMerge = false;
            this.menuDropDwn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.menuDropDwn.CanOverflow = false;
            this.menuDropDwn.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuDropDwn.GripMargin = new System.Windows.Forms.Padding(0);
            this.menuDropDwn.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.menuDropDwn.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuDropDown});
            this.menuDropDwn.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.menuDropDwn.Location = new System.Drawing.Point(0, 0);
            this.menuDropDwn.Name = "menuDropDwn";
            this.menuDropDwn.Padding = new System.Windows.Forms.Padding(0);
            this.menuDropDwn.Size = new System.Drawing.Size(987, 37);
            this.menuDropDwn.TabIndex = 0;
            this.menuDropDwn.Text = "toolStrip1";
            // 
            // menuDropDown
            // 
            this.menuDropDown.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.menuDropDown.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnLoadFile,
            this.btnSaveCurrentFile,
            this.btnSaveFileAs,
            this.btnCloseFile});
            this.menuDropDown.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuDropDown.Image = ((System.Drawing.Image)(resources.GetObject("menuDropDown.Image")));
            this.menuDropDown.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.menuDropDown.Name = "menuDropDown";
            this.menuDropDown.Size = new System.Drawing.Size(57, 34);
            this.menuDropDown.Text = "File";
            // 
            // btnLoadFile
            // 
            this.btnLoadFile.Name = "btnLoadFile";
            this.btnLoadFile.Size = new System.Drawing.Size(170, 34);
            this.btnLoadFile.Text = "Load";
            this.btnLoadFile.Click += new System.EventHandler(this.BtnLoadFile_Click);
            // 
            // btnSaveCurrentFile
            // 
            this.btnSaveCurrentFile.Enabled = false;
            this.btnSaveCurrentFile.Name = "btnSaveCurrentFile";
            this.btnSaveCurrentFile.Size = new System.Drawing.Size(170, 34);
            this.btnSaveCurrentFile.Text = "Save";
            this.btnSaveCurrentFile.Click += new System.EventHandler(this.BtnSaveCurrentFile_Click);
            // 
            // btnSaveFileAs
            // 
            this.btnSaveFileAs.Name = "btnSaveFileAs";
            this.btnSaveFileAs.Size = new System.Drawing.Size(170, 34);
            this.btnSaveFileAs.Text = "Save as...";
            this.btnSaveFileAs.Click += new System.EventHandler(this.BtnSaveFileAs_Click);
            // 
            // btnCloseFile
            // 
            this.btnCloseFile.Enabled = false;
            this.btnCloseFile.Name = "btnCloseFile";
            this.btnCloseFile.Size = new System.Drawing.Size(170, 34);
            this.btnCloseFile.Text = "Close";
            this.btnCloseFile.Click += new System.EventHandler(this.BtnCloseFile_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "Text|*.txt*.*";
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.DefaultExt = "txt";
            this.saveFileDialog.FileName = "Untitled.txt";
            this.saveFileDialog.Filter = "Text File (*.txt)|*.txt";
            // 
            // grpCompanies
            // 
            this.grpCompanies.BackColor = System.Drawing.SystemColors.Control;
            this.grpCompanies.Controls.Add(this.panelCompanyInfo);
            this.grpCompanies.Controls.Add(this.txtSearchCompany);
            this.grpCompanies.Controls.Add(this.lblSearchCompany);
            this.grpCompanies.Controls.Add(this.lstCompanies);
            this.grpCompanies.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpCompanies.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpCompanies.Location = new System.Drawing.Point(0, 84);
            this.grpCompanies.Name = "grpCompanies";
            this.grpCompanies.Size = new System.Drawing.Size(987, 451);
            this.grpCompanies.TabIndex = 0;
            this.grpCompanies.TabStop = false;
            this.grpCompanies.Text = "Companies: ";
            // 
            // panelCompanyInfo
            // 
            this.panelCompanyInfo.Controls.Add(this.lblCompPostcodeTick);
            this.panelCompanyInfo.Controls.Add(this.lblCompAddressTick);
            this.panelCompanyInfo.Controls.Add(this.lblCompNameTick);
            this.panelCompanyInfo.Controls.Add(this.lblCompIDTick);
            this.panelCompanyInfo.Controls.Add(this.btnEditCompany);
            this.panelCompanyInfo.Controls.Add(this.btnRemoveCompany);
            this.panelCompanyInfo.Controls.Add(this.txtCompanyPostcode);
            this.panelCompanyInfo.Controls.Add(this.lblCompPostcode);
            this.panelCompanyInfo.Controls.Add(this.lblCompAddress);
            this.panelCompanyInfo.Controls.Add(this.txtCompanyAddress);
            this.panelCompanyInfo.Controls.Add(this.btnAddCompany);
            this.panelCompanyInfo.Controls.Add(this.lblCompName);
            this.panelCompanyInfo.Controls.Add(this.btnSaveCompany);
            this.panelCompanyInfo.Controls.Add(this.txtCompanyID);
            this.panelCompanyInfo.Controls.Add(this.txtCompanyName);
            this.panelCompanyInfo.Controls.Add(this.lblCompID);
            this.panelCompanyInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelCompanyInfo.Location = new System.Drawing.Point(557, 38);
            this.panelCompanyInfo.Name = "panelCompanyInfo";
            this.panelCompanyInfo.Size = new System.Drawing.Size(418, 396);
            this.panelCompanyInfo.TabIndex = 18;
            // 
            // lblCompPostcodeTick
            // 
            this.lblCompPostcodeTick.AutoSize = true;
            this.lblCompPostcodeTick.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompPostcodeTick.Location = new System.Drawing.Point(362, 100);
            this.lblCompPostcodeTick.Name = "lblCompPostcodeTick";
            this.lblCompPostcodeTick.Size = new System.Drawing.Size(33, 25);
            this.lblCompPostcodeTick.TabIndex = 21;
            this.lblCompPostcodeTick.Text = "✓";
            // 
            // lblCompAddressTick
            // 
            this.lblCompAddressTick.AutoSize = true;
            this.lblCompAddressTick.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompAddressTick.Location = new System.Drawing.Point(362, 68);
            this.lblCompAddressTick.Name = "lblCompAddressTick";
            this.lblCompAddressTick.Size = new System.Drawing.Size(33, 25);
            this.lblCompAddressTick.TabIndex = 20;
            this.lblCompAddressTick.Text = "✓";
            // 
            // lblCompNameTick
            // 
            this.lblCompNameTick.AutoSize = true;
            this.lblCompNameTick.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompNameTick.Location = new System.Drawing.Point(362, 36);
            this.lblCompNameTick.Name = "lblCompNameTick";
            this.lblCompNameTick.Size = new System.Drawing.Size(33, 25);
            this.lblCompNameTick.TabIndex = 19;
            this.lblCompNameTick.Text = "✓";
            // 
            // lblCompIDTick
            // 
            this.lblCompIDTick.AutoSize = true;
            this.lblCompIDTick.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompIDTick.Location = new System.Drawing.Point(362, 5);
            this.lblCompIDTick.Name = "lblCompIDTick";
            this.lblCompIDTick.Size = new System.Drawing.Size(33, 25);
            this.lblCompIDTick.TabIndex = 18;
            this.lblCompIDTick.Text = "✓";
            // 
            // btnEditCompany
            // 
            this.btnEditCompany.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditCompany.Location = new System.Drawing.Point(15, 174);
            this.btnEditCompany.Name = "btnEditCompany";
            this.btnEditCompany.Size = new System.Drawing.Size(386, 35);
            this.btnEditCompany.TabIndex = 9;
            this.btnEditCompany.Text = "Edit";
            this.btnEditCompany.UseVisualStyleBackColor = true;
            this.btnEditCompany.Click += new System.EventHandler(this.BtnEditCompany_Click);
            // 
            // btnRemoveCompany
            // 
            this.btnRemoveCompany.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveCompany.Location = new System.Drawing.Point(15, 256);
            this.btnRemoveCompany.Name = "btnRemoveCompany";
            this.btnRemoveCompany.Size = new System.Drawing.Size(386, 35);
            this.btnRemoveCompany.TabIndex = 3;
            this.btnRemoveCompany.Text = "Remove selected";
            this.btnRemoveCompany.UseVisualStyleBackColor = true;
            this.btnRemoveCompany.Click += new System.EventHandler(this.BtnRemoveCompany_Click);
            // 
            // txtCompanyPostcode
            // 
            this.txtCompanyPostcode.Location = new System.Drawing.Point(101, 101);
            this.txtCompanyPostcode.MaxLength = 8;
            this.txtCompanyPostcode.Name = "txtCompanyPostcode";
            this.txtCompanyPostcode.ReadOnly = true;
            this.txtCompanyPostcode.Size = new System.Drawing.Size(110, 26);
            this.txtCompanyPostcode.TabIndex = 8;
            this.txtCompanyPostcode.TextChanged += new System.EventHandler(this.TxtCompanyPostcode_TextChanged);
            // 
            // lblCompPostcode
            // 
            this.lblCompPostcode.AutoSize = true;
            this.lblCompPostcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompPostcode.Location = new System.Drawing.Point(11, 104);
            this.lblCompPostcode.Name = "lblCompPostcode";
            this.lblCompPostcode.Size = new System.Drawing.Size(80, 20);
            this.lblCompPostcode.TabIndex = 0;
            this.lblCompPostcode.Text = "Postcode:";
            // 
            // lblCompAddress
            // 
            this.lblCompAddress.AutoSize = true;
            this.lblCompAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompAddress.Location = new System.Drawing.Point(19, 72);
            this.lblCompAddress.Name = "lblCompAddress";
            this.lblCompAddress.Size = new System.Drawing.Size(72, 20);
            this.lblCompAddress.TabIndex = 0;
            this.lblCompAddress.Text = "Address:";
            // 
            // txtCompanyAddress
            // 
            this.txtCompanyAddress.Location = new System.Drawing.Point(101, 69);
            this.txtCompanyAddress.MaxLength = 1024;
            this.txtCompanyAddress.Name = "txtCompanyAddress";
            this.txtCompanyAddress.ReadOnly = true;
            this.txtCompanyAddress.Size = new System.Drawing.Size(243, 26);
            this.txtCompanyAddress.TabIndex = 6;
            this.txtCompanyAddress.TextChanged += new System.EventHandler(this.TxtCompanyAddress_TextChanged);
            // 
            // btnAddCompany
            // 
            this.btnAddCompany.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCompany.Location = new System.Drawing.Point(15, 133);
            this.btnAddCompany.Name = "btnAddCompany";
            this.btnAddCompany.Size = new System.Drawing.Size(386, 35);
            this.btnAddCompany.TabIndex = 1;
            this.btnAddCompany.Text = "Add new";
            this.btnAddCompany.UseVisualStyleBackColor = true;
            this.btnAddCompany.Click += new System.EventHandler(this.BtnAddCompany_Click);
            // 
            // lblCompName
            // 
            this.lblCompName.AutoSize = true;
            this.lblCompName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompName.Location = new System.Drawing.Point(36, 40);
            this.lblCompName.Name = "lblCompName";
            this.lblCompName.Size = new System.Drawing.Size(55, 20);
            this.lblCompName.TabIndex = 0;
            this.lblCompName.Text = "Name:";
            // 
            // btnSaveCompany
            // 
            this.btnSaveCompany.Enabled = false;
            this.btnSaveCompany.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveCompany.Location = new System.Drawing.Point(15, 215);
            this.btnSaveCompany.Name = "btnSaveCompany";
            this.btnSaveCompany.Size = new System.Drawing.Size(386, 35);
            this.btnSaveCompany.TabIndex = 2;
            this.btnSaveCompany.Text = "Save";
            this.btnSaveCompany.UseVisualStyleBackColor = true;
            this.btnSaveCompany.Click += new System.EventHandler(this.BtnSaveCompany_Click);
            // 
            // txtCompanyID
            // 
            this.txtCompanyID.Location = new System.Drawing.Point(102, 6);
            this.txtCompanyID.MaxLength = 1024;
            this.txtCompanyID.Name = "txtCompanyID";
            this.txtCompanyID.ReadOnly = true;
            this.txtCompanyID.Size = new System.Drawing.Size(242, 26);
            this.txtCompanyID.TabIndex = 4;
            this.txtCompanyID.TextChanged += new System.EventHandler(this.TxtCompanyID_TextChanged);
            // 
            // txtCompanyName
            // 
            this.txtCompanyName.Location = new System.Drawing.Point(101, 37);
            this.txtCompanyName.MaxLength = 1024;
            this.txtCompanyName.Name = "txtCompanyName";
            this.txtCompanyName.ReadOnly = true;
            this.txtCompanyName.Size = new System.Drawing.Size(243, 26);
            this.txtCompanyName.TabIndex = 5;
            this.txtCompanyName.TextChanged += new System.EventHandler(this.TxtCompanyName_TextChanged);
            // 
            // lblCompID
            // 
            this.lblCompID.AutoSize = true;
            this.lblCompID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompID.Location = new System.Drawing.Point(63, 9);
            this.lblCompID.Name = "lblCompID";
            this.lblCompID.Size = new System.Drawing.Size(30, 20);
            this.lblCompID.TabIndex = 0;
            this.lblCompID.Text = "ID:";
            // 
            // lstCompanies
            // 
            this.lstCompanies.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstCompanies.FormattingEnabled = true;
            this.lstCompanies.ItemHeight = 20;
            this.lstCompanies.Location = new System.Drawing.Point(9, 70);
            this.lstCompanies.Name = "lstCompanies";
            this.lstCompanies.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstCompanies.Size = new System.Drawing.Size(542, 364);
            this.lstCompanies.TabIndex = 5;
            this.lstCompanies.SelectedIndexChanged += new System.EventHandler(this.LstCompanies_SelectedIndexChanged);
            this.lstCompanies.DoubleClick += new System.EventHandler(this.BtnEditCompany_Click);
            // 
            // grpCars
            // 
            this.grpCars.BackColor = System.Drawing.SystemColors.Control;
            this.grpCars.Controls.Add(this.panelCarInfo);
            this.grpCars.Controls.Add(this.txtSearchCar);
            this.grpCars.Controls.Add(this.lblSearchCar);
            this.grpCars.Controls.Add(this.lstCars);
            this.grpCars.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpCars.Enabled = false;
            this.grpCars.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpCars.Location = new System.Drawing.Point(0, 535);
            this.grpCars.Name = "grpCars";
            this.grpCars.Size = new System.Drawing.Size(987, 468);
            this.grpCars.TabIndex = 0;
            this.grpCars.TabStop = false;
            this.grpCars.Text = "Cars: ";
            // 
            // panelCarInfo
            // 
            this.panelCarInfo.Controls.Add(this.lblCarRegTick);
            this.panelCarInfo.Controls.Add(this.lblCarModelTick);
            this.panelCarInfo.Controls.Add(this.lblCarMakeTick);
            this.panelCarInfo.Controls.Add(this.lblCarIDTick);
            this.panelCarInfo.Controls.Add(this.txtCarMake);
            this.panelCarInfo.Controls.Add(this.btnSaveCar);
            this.panelCarInfo.Controls.Add(this.lblCarComments);
            this.panelCarInfo.Controls.Add(this.txtCarComments);
            this.panelCarInfo.Controls.Add(this.btnEditCar);
            this.panelCarInfo.Controls.Add(this.dtTimeCarService);
            this.panelCarInfo.Controls.Add(this.btnAddCar);
            this.panelCarInfo.Controls.Add(this.lblCarLastService);
            this.panelCarInfo.Controls.Add(this.cmbxCarFuel);
            this.panelCarInfo.Controls.Add(this.lblCarRegistration);
            this.panelCarInfo.Controls.Add(this.lblCarFuelType);
            this.panelCarInfo.Controls.Add(this.btnRemoveCar);
            this.panelCarInfo.Controls.Add(this.txtCarID);
            this.panelCarInfo.Controls.Add(this.txtCarReg);
            this.panelCarInfo.Controls.Add(this.lblCarModel);
            this.panelCarInfo.Controls.Add(this.lblCarID);
            this.panelCarInfo.Controls.Add(this.lblCarMake);
            this.panelCarInfo.Controls.Add(this.txtCarModel);
            this.panelCarInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelCarInfo.Location = new System.Drawing.Point(564, 47);
            this.panelCarInfo.Name = "panelCarInfo";
            this.panelCarInfo.Size = new System.Drawing.Size(411, 413);
            this.panelCarInfo.TabIndex = 17;
            // 
            // lblCarRegTick
            // 
            this.lblCarRegTick.AutoSize = true;
            this.lblCarRegTick.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarRegTick.Location = new System.Drawing.Point(355, 103);
            this.lblCarRegTick.Name = "lblCarRegTick";
            this.lblCarRegTick.Size = new System.Drawing.Size(33, 25);
            this.lblCarRegTick.TabIndex = 22;
            this.lblCarRegTick.Text = "✓";
            // 
            // lblCarModelTick
            // 
            this.lblCarModelTick.AutoSize = true;
            this.lblCarModelTick.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarModelTick.Location = new System.Drawing.Point(355, 71);
            this.lblCarModelTick.Name = "lblCarModelTick";
            this.lblCarModelTick.Size = new System.Drawing.Size(33, 25);
            this.lblCarModelTick.TabIndex = 21;
            this.lblCarModelTick.Text = "✓";
            // 
            // lblCarMakeTick
            // 
            this.lblCarMakeTick.AutoSize = true;
            this.lblCarMakeTick.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarMakeTick.Location = new System.Drawing.Point(355, 39);
            this.lblCarMakeTick.Name = "lblCarMakeTick";
            this.lblCarMakeTick.Size = new System.Drawing.Size(33, 25);
            this.lblCarMakeTick.TabIndex = 20;
            this.lblCarMakeTick.Text = "✓";
            // 
            // lblCarIDTick
            // 
            this.lblCarIDTick.AutoSize = true;
            this.lblCarIDTick.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarIDTick.Location = new System.Drawing.Point(355, 7);
            this.lblCarIDTick.Name = "lblCarIDTick";
            this.lblCarIDTick.Size = new System.Drawing.Size(33, 25);
            this.lblCarIDTick.TabIndex = 19;
            this.lblCarIDTick.Text = "✓";
            // 
            // txtCarMake
            // 
            this.txtCarMake.Location = new System.Drawing.Point(117, 40);
            this.txtCarMake.MaxLength = 1024;
            this.txtCarMake.Name = "txtCarMake";
            this.txtCarMake.ReadOnly = true;
            this.txtCarMake.Size = new System.Drawing.Size(220, 26);
            this.txtCarMake.TabIndex = 10;
            this.txtCarMake.TextChanged += new System.EventHandler(this.TxtCarMake_TextChanged);
            // 
            // btnSaveCar
            // 
            this.btnSaveCar.Enabled = false;
            this.btnSaveCar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveCar.Location = new System.Drawing.Point(12, 320);
            this.btnSaveCar.Name = "btnSaveCar";
            this.btnSaveCar.Size = new System.Drawing.Size(390, 35);
            this.btnSaveCar.TabIndex = 16;
            this.btnSaveCar.Text = "Save";
            this.btnSaveCar.UseVisualStyleBackColor = true;
            this.btnSaveCar.Click += new System.EventHandler(this.BtnSaveCar_Click);
            // 
            // lblCarComments
            // 
            this.lblCarComments.AutoSize = true;
            this.lblCarComments.Location = new System.Drawing.Point(12, 209);
            this.lblCarComments.Name = "lblCarComments";
            this.lblCarComments.Size = new System.Drawing.Size(90, 20);
            this.lblCarComments.TabIndex = 0;
            this.lblCarComments.Text = "Comments:";
            // 
            // txtCarComments
            // 
            this.txtCarComments.Location = new System.Drawing.Point(117, 206);
            this.txtCarComments.MaxLength = 1024;
            this.txtCarComments.Name = "txtCarComments";
            this.txtCarComments.ReadOnly = true;
            this.txtCarComments.Size = new System.Drawing.Size(271, 26);
            this.txtCarComments.TabIndex = 15;
            // 
            // btnEditCar
            // 
            this.btnEditCar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditCar.Location = new System.Drawing.Point(12, 279);
            this.btnEditCar.Name = "btnEditCar";
            this.btnEditCar.Size = new System.Drawing.Size(390, 35);
            this.btnEditCar.TabIndex = 7;
            this.btnEditCar.Text = "Edit";
            this.btnEditCar.UseVisualStyleBackColor = true;
            this.btnEditCar.Click += new System.EventHandler(this.BtnEditCar_Click);
            // 
            // dtTimeCarService
            // 
            this.dtTimeCarService.Enabled = false;
            this.dtTimeCarService.Location = new System.Drawing.Point(117, 170);
            this.dtTimeCarService.MaxDate = new System.DateTime(2017, 12, 2, 0, 0, 0, 0);
            this.dtTimeCarService.Name = "dtTimeCarService";
            this.dtTimeCarService.Size = new System.Drawing.Size(170, 26);
            this.dtTimeCarService.TabIndex = 14;
            this.dtTimeCarService.Value = new System.DateTime(2017, 12, 2, 0, 0, 0, 0);
            // 
            // btnAddCar
            // 
            this.btnAddCar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCar.Location = new System.Drawing.Point(12, 238);
            this.btnAddCar.Name = "btnAddCar";
            this.btnAddCar.Size = new System.Drawing.Size(390, 35);
            this.btnAddCar.TabIndex = 6;
            this.btnAddCar.Text = "Add new";
            this.btnAddCar.UseVisualStyleBackColor = true;
            this.btnAddCar.Click += new System.EventHandler(this.BtnAddCar_Click);
            // 
            // lblCarLastService
            // 
            this.lblCarLastService.AutoSize = true;
            this.lblCarLastService.Location = new System.Drawing.Point(5, 175);
            this.lblCarLastService.Name = "lblCarLastService";
            this.lblCarLastService.Size = new System.Drawing.Size(97, 20);
            this.lblCarLastService.TabIndex = 0;
            this.lblCarLastService.Text = "Last service:";
            // 
            // cmbxCarFuel
            // 
            this.cmbxCarFuel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxCarFuel.Enabled = false;
            this.cmbxCarFuel.FormattingEnabled = true;
            this.cmbxCarFuel.Items.AddRange(new object[] {
            "Petrol",
            "Diesel"});
            this.cmbxCarFuel.Location = new System.Drawing.Point(117, 136);
            this.cmbxCarFuel.Name = "cmbxCarFuel";
            this.cmbxCarFuel.Size = new System.Drawing.Size(170, 28);
            this.cmbxCarFuel.TabIndex = 13;
            // 
            // lblCarRegistration
            // 
            this.lblCarRegistration.AutoSize = true;
            this.lblCarRegistration.Location = new System.Drawing.Point(3, 107);
            this.lblCarRegistration.Name = "lblCarRegistration";
            this.lblCarRegistration.Size = new System.Drawing.Size(99, 20);
            this.lblCarRegistration.TabIndex = 0;
            this.lblCarRegistration.Text = "Registration:";
            // 
            // lblCarFuelType
            // 
            this.lblCarFuelType.AutoSize = true;
            this.lblCarFuelType.Location = new System.Drawing.Point(20, 139);
            this.lblCarFuelType.Name = "lblCarFuelType";
            this.lblCarFuelType.Size = new System.Drawing.Size(82, 20);
            this.lblCarFuelType.TabIndex = 0;
            this.lblCarFuelType.Text = "Fuel Type:";
            // 
            // btnRemoveCar
            // 
            this.btnRemoveCar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveCar.Location = new System.Drawing.Point(12, 361);
            this.btnRemoveCar.Name = "btnRemoveCar";
            this.btnRemoveCar.Size = new System.Drawing.Size(390, 35);
            this.btnRemoveCar.TabIndex = 8;
            this.btnRemoveCar.Text = "Remove selected";
            this.btnRemoveCar.UseVisualStyleBackColor = true;
            this.btnRemoveCar.Click += new System.EventHandler(this.BtnRemoveCar_Click);
            // 
            // txtCarID
            // 
            this.txtCarID.Location = new System.Drawing.Point(117, 8);
            this.txtCarID.MaxLength = 1024;
            this.txtCarID.Name = "txtCarID";
            this.txtCarID.ReadOnly = true;
            this.txtCarID.Size = new System.Drawing.Size(220, 26);
            this.txtCarID.TabIndex = 9;
            this.txtCarID.TextChanged += new System.EventHandler(this.TxtCarID_TextChanged);
            // 
            // txtCarReg
            // 
            this.txtCarReg.Location = new System.Drawing.Point(117, 104);
            this.txtCarReg.MaxLength = 1024;
            this.txtCarReg.Name = "txtCarReg";
            this.txtCarReg.ReadOnly = true;
            this.txtCarReg.Size = new System.Drawing.Size(170, 26);
            this.txtCarReg.TabIndex = 12;
            this.txtCarReg.TextChanged += new System.EventHandler(this.TxtCarReg_TextChanged);
            // 
            // lblCarModel
            // 
            this.lblCarModel.AutoSize = true;
            this.lblCarModel.Location = new System.Drawing.Point(46, 75);
            this.lblCarModel.Name = "lblCarModel";
            this.lblCarModel.Size = new System.Drawing.Size(56, 20);
            this.lblCarModel.TabIndex = 0;
            this.lblCarModel.Text = "Model:";
            // 
            // lblCarID
            // 
            this.lblCarID.AutoSize = true;
            this.lblCarID.Location = new System.Drawing.Point(72, 11);
            this.lblCarID.Name = "lblCarID";
            this.lblCarID.Size = new System.Drawing.Size(30, 20);
            this.lblCarID.TabIndex = 0;
            this.lblCarID.Text = "ID:";
            // 
            // lblCarMake
            // 
            this.lblCarMake.AutoSize = true;
            this.lblCarMake.Location = new System.Drawing.Point(50, 43);
            this.lblCarMake.Name = "lblCarMake";
            this.lblCarMake.Size = new System.Drawing.Size(52, 20);
            this.lblCarMake.TabIndex = 0;
            this.lblCarMake.Text = "Make:";
            // 
            // txtCarModel
            // 
            this.txtCarModel.Location = new System.Drawing.Point(117, 72);
            this.txtCarModel.MaxLength = 1024;
            this.txtCarModel.Name = "txtCarModel";
            this.txtCarModel.ReadOnly = true;
            this.txtCarModel.Size = new System.Drawing.Size(220, 26);
            this.txtCarModel.TabIndex = 11;
            this.txtCarModel.TextChanged += new System.EventHandler(this.TxtCarModel_TextChanged);
            // 
            // txtSearchCar
            // 
            this.txtSearchCar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchCar.Location = new System.Drawing.Point(107, 47);
            this.txtSearchCar.Name = "txtSearchCar";
            this.txtSearchCar.Size = new System.Drawing.Size(444, 26);
            this.txtSearchCar.TabIndex = 9;
            this.txtSearchCar.TextChanged += new System.EventHandler(this.TxtSearchCar_TextChanged);
            // 
            // lblSearchCar
            // 
            this.lblSearchCar.AutoSize = true;
            this.lblSearchCar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchCar.Location = new System.Drawing.Point(12, 50);
            this.lblSearchCar.Name = "lblSearchCar";
            this.lblSearchCar.Size = new System.Drawing.Size(89, 20);
            this.lblSearchCar.TabIndex = 0;
            this.lblSearchCar.Text = "Search Car";
            this.lblSearchCar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lstCars
            // 
            this.lstCars.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstCars.FormattingEnabled = true;
            this.lstCars.ItemHeight = 20;
            this.lstCars.Location = new System.Drawing.Point(7, 76);
            this.lstCars.Name = "lstCars";
            this.lstCars.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstCars.Size = new System.Drawing.Size(544, 384);
            this.lstCars.TabIndex = 10;
            this.lstCars.SelectedIndexChanged += new System.EventHandler(this.LstCars_SelectedIndexChanged);
            this.lstCars.DoubleClick += new System.EventHandler(this.BtnEditCar_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(987, 1003);
            this.Controls.Add(this.grpCars);
            this.Controls.Add(this.grpCompanies);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.menuDropDwn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hire Car Maintenance Inc: Untitled.txt";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.menuDropDwn.ResumeLayout(false);
            this.menuDropDwn.PerformLayout();
            this.grpCompanies.ResumeLayout(false);
            this.grpCompanies.PerformLayout();
            this.panelCompanyInfo.ResumeLayout(false);
            this.panelCompanyInfo.PerformLayout();
            this.grpCars.ResumeLayout(false);
            this.grpCars.PerformLayout();
            this.panelCarInfo.ResumeLayout(false);
            this.panelCarInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.TextBox txtSearchCompany;
        private System.Windows.Forms.Label lblSearchCompany;
        private System.Windows.Forms.ToolStrip menuDropDwn;
        private System.Windows.Forms.ToolStripDropDownButton menuDropDown;
        private System.Windows.Forms.ToolStripMenuItem btnLoadFile;
        private System.Windows.Forms.ToolStripMenuItem btnSaveCurrentFile;
        private System.Windows.Forms.ToolStripMenuItem btnSaveFileAs;
        private System.Windows.Forms.ToolStripMenuItem btnCloseFile;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.GroupBox grpCompanies;
        private System.Windows.Forms.ListBox lstCompanies;
        private System.Windows.Forms.GroupBox grpCars;
        private System.Windows.Forms.ListBox lstCars;
        private System.Windows.Forms.Button btnAddCar;
        private System.Windows.Forms.Button btnEditCar;
        private System.Windows.Forms.TextBox txtSearchCar;
        private System.Windows.Forms.Button btnRemoveCar;
        private System.Windows.Forms.Label lblSearchCar;
        private System.Windows.Forms.Label lblCarRegistration;
        private System.Windows.Forms.Label lblCarComments;
        private System.Windows.Forms.Label lblCarLastService;
        private System.Windows.Forms.Label lblCarFuelType;
        private System.Windows.Forms.Label lblCarModel;
        private System.Windows.Forms.Label lblCarMake;
        private System.Windows.Forms.Label lblCarID;
        private System.Windows.Forms.TextBox txtCarComments;
        private System.Windows.Forms.DateTimePicker dtTimeCarService;
        private System.Windows.Forms.ComboBox cmbxCarFuel;
        private System.Windows.Forms.TextBox txtCarReg;
        private System.Windows.Forms.TextBox txtCarModel;
        private System.Windows.Forms.TextBox txtCarMake;
        private System.Windows.Forms.TextBox txtCarID;
        private System.Windows.Forms.Button btnSaveCar;
        private System.Windows.Forms.Panel panelCompanyInfo;
        private System.Windows.Forms.Button btnEditCompany;
        private System.Windows.Forms.Button btnRemoveCompany;
        private System.Windows.Forms.TextBox txtCompanyPostcode;
        private System.Windows.Forms.Label lblCompPostcode;
        private System.Windows.Forms.Label lblCompAddress;
        private System.Windows.Forms.TextBox txtCompanyAddress;
        private System.Windows.Forms.Button btnAddCompany;
        private System.Windows.Forms.Label lblCompName;
        private System.Windows.Forms.Button btnSaveCompany;
        private System.Windows.Forms.TextBox txtCompanyID;
        private System.Windows.Forms.TextBox txtCompanyName;
        private System.Windows.Forms.Label lblCompID;
        private System.Windows.Forms.Label lblCompIDTick;
        private System.Windows.Forms.Label lblCompNameTick;
        private System.Windows.Forms.Label lblCompAddressTick;
        private System.Windows.Forms.Label lblCompPostcodeTick;
        private System.Windows.Forms.Panel panelCarInfo;
        private System.Windows.Forms.Label lblCarIDTick;
        private System.Windows.Forms.Label lblCarRegTick;
        private System.Windows.Forms.Label lblCarModelTick;
        private System.Windows.Forms.Label lblCarMakeTick;
    }
}

