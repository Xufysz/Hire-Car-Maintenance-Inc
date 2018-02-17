namespace Hire_Car_Maintenance_Inc
{
    partial class FrmShowCompany
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
            this.lblHeader = new System.Windows.Forms.Label();
            this.grpCars = new System.Windows.Forms.GroupBox();
            this.grpCarInfo = new System.Windows.Forms.GroupBox();
            this.lblCarRegistration = new System.Windows.Forms.Label();
            this.richCarInfo = new System.Windows.Forms.RichTextBox();
            this.lblCarComments = new System.Windows.Forms.Label();
            this.lblCarLastService = new System.Windows.Forms.Label();
            this.lblCarFuelType = new System.Windows.Forms.Label();
            this.lblCarModel = new System.Windows.Forms.Label();
            this.lblCarMake = new System.Windows.Forms.Label();
            this.lblCarID = new System.Windows.Forms.Label();
            this.lstCars = new System.Windows.Forms.ListBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.grpBoxInfo = new System.Windows.Forms.GroupBox();
            this.lblCompPostcode = new System.Windows.Forms.Label();
            this.lblCompAddress = new System.Windows.Forms.Label();
            this.lblCompName = new System.Windows.Forms.Label();
            this.lblCompID = new System.Windows.Forms.Label();
            this.grpCars.SuspendLayout();
            this.grpCarInfo.SuspendLayout();
            this.grpBoxInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblHeader
            // 
            this.lblHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblHeader.Location = new System.Drawing.Point(0, 0);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(863, 72);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "Company: ";
            this.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grpCars
            // 
            this.grpCars.Controls.Add(this.grpCarInfo);
            this.grpCars.Controls.Add(this.lstCars);
            this.grpCars.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpCars.Location = new System.Drawing.Point(172, 191);
            this.grpCars.Name = "grpCars";
            this.grpCars.Size = new System.Drawing.Size(679, 372);
            this.grpCars.TabIndex = 0;
            this.grpCars.TabStop = false;
            this.grpCars.Text = "Cars: 0";
            // 
            // grpCarInfo
            // 
            this.grpCarInfo.Controls.Add(this.lblCarRegistration);
            this.grpCarInfo.Controls.Add(this.richCarInfo);
            this.grpCarInfo.Controls.Add(this.lblCarComments);
            this.grpCarInfo.Controls.Add(this.lblCarLastService);
            this.grpCarInfo.Controls.Add(this.lblCarFuelType);
            this.grpCarInfo.Controls.Add(this.lblCarModel);
            this.grpCarInfo.Controls.Add(this.lblCarMake);
            this.grpCarInfo.Controls.Add(this.lblCarID);
            this.grpCarInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpCarInfo.Location = new System.Drawing.Point(445, 0);
            this.grpCarInfo.Name = "grpCarInfo";
            this.grpCarInfo.Size = new System.Drawing.Size(234, 366);
            this.grpCarInfo.TabIndex = 0;
            this.grpCarInfo.TabStop = false;
            this.grpCarInfo.Text = "Selected car info:";
            // 
            // lblCarRegistration
            // 
            this.lblCarRegistration.AutoSize = true;
            this.lblCarRegistration.Location = new System.Drawing.Point(6, 77);
            this.lblCarRegistration.Name = "lblCarRegistration";
            this.lblCarRegistration.Size = new System.Drawing.Size(91, 18);
            this.lblCarRegistration.TabIndex = 0;
            this.lblCarRegistration.Text = "Registration:";
            // 
            // richCarInfo
            // 
            this.richCarInfo.Location = new System.Drawing.Point(6, 152);
            this.richCarInfo.Name = "richCarInfo";
            this.richCarInfo.ReadOnly = true;
            this.richCarInfo.Size = new System.Drawing.Size(222, 208);
            this.richCarInfo.TabIndex = 0;
            this.richCarInfo.Text = "";
            // 
            // lblCarComments
            // 
            this.lblCarComments.AutoSize = true;
            this.lblCarComments.Location = new System.Drawing.Point(6, 131);
            this.lblCarComments.Name = "lblCarComments";
            this.lblCarComments.Size = new System.Drawing.Size(82, 18);
            this.lblCarComments.TabIndex = 0;
            this.lblCarComments.Text = "Comments";
            // 
            // lblCarLastService
            // 
            this.lblCarLastService.AutoSize = true;
            this.lblCarLastService.Location = new System.Drawing.Point(6, 113);
            this.lblCarLastService.Name = "lblCarLastService";
            this.lblCarLastService.Size = new System.Drawing.Size(91, 18);
            this.lblCarLastService.TabIndex = 0;
            this.lblCarLastService.Text = "Last service:";
            // 
            // lblCarFuelType
            // 
            this.lblCarFuelType.AutoSize = true;
            this.lblCarFuelType.Location = new System.Drawing.Point(6, 95);
            this.lblCarFuelType.Name = "lblCarFuelType";
            this.lblCarFuelType.Size = new System.Drawing.Size(76, 18);
            this.lblCarFuelType.TabIndex = 0;
            this.lblCarFuelType.Text = "Fuel Type:";
            // 
            // lblCarModel
            // 
            this.lblCarModel.AutoSize = true;
            this.lblCarModel.Location = new System.Drawing.Point(6, 59);
            this.lblCarModel.Name = "lblCarModel";
            this.lblCarModel.Size = new System.Drawing.Size(53, 18);
            this.lblCarModel.TabIndex = 0;
            this.lblCarModel.Text = "Model:";
            // 
            // lblCarMake
            // 
            this.lblCarMake.AutoSize = true;
            this.lblCarMake.Location = new System.Drawing.Point(6, 41);
            this.lblCarMake.Name = "lblCarMake";
            this.lblCarMake.Size = new System.Drawing.Size(49, 18);
            this.lblCarMake.TabIndex = 0;
            this.lblCarMake.Text = "Make:";
            // 
            // lblCarID
            // 
            this.lblCarID.AutoSize = true;
            this.lblCarID.Location = new System.Drawing.Point(6, 20);
            this.lblCarID.Name = "lblCarID";
            this.lblCarID.Size = new System.Drawing.Size(30, 18);
            this.lblCarID.TabIndex = 0;
            this.lblCarID.Text = "ID: ";
            // 
            // lstCars
            // 
            this.lstCars.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstCars.FormattingEnabled = true;
            this.lstCars.HorizontalScrollbar = true;
            this.lstCars.ItemHeight = 18;
            this.lstCars.Location = new System.Drawing.Point(6, 20);
            this.lstCars.Name = "lstCars";
            this.lstCars.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstCars.Size = new System.Drawing.Size(433, 328);
            this.lstCars.TabIndex = 6;
            this.lstCars.SelectedIndexChanged += new System.EventHandler(this.lstCars_SelectedIndexChanged);
            this.lstCars.DoubleClick += new System.EventHandler(this.btnEdit_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(178, 159);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(433, 26);
            this.txtSearch.TabIndex = 5;
            this.txtSearch.TextChanged += new System.EventHandler(this.inputSearch_TextChanged);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 162);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Search car";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnRemove
            // 
            this.btnRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.Location = new System.Drawing.Point(7, 273);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(159, 35);
            this.btnRemove.TabIndex = 3;
            this.btnRemove.Text = "Remove selected";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(7, 232);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(159, 35);
            this.btnEdit.TabIndex = 2;
            this.btnEdit.Text = "Edit selected";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(7, 191);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(159, 35);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add new";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(7, 314);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(159, 35);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // grpBoxInfo
            // 
            this.grpBoxInfo.Controls.Add(this.lblCompPostcode);
            this.grpBoxInfo.Controls.Add(this.lblCompAddress);
            this.grpBoxInfo.Controls.Add(this.lblCompName);
            this.grpBoxInfo.Controls.Add(this.lblCompID);
            this.grpBoxInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBoxInfo.Location = new System.Drawing.Point(178, 75);
            this.grpBoxInfo.Name = "grpBoxInfo";
            this.grpBoxInfo.Size = new System.Drawing.Size(370, 78);
            this.grpBoxInfo.TabIndex = 6;
            this.grpBoxInfo.TabStop = false;
            this.grpBoxInfo.Text = "Company Information";
            // 
            // lblCompPostcode
            // 
            this.lblCompPostcode.AutoSize = true;
            this.lblCompPostcode.Location = new System.Drawing.Point(168, 47);
            this.lblCompPostcode.Name = "lblCompPostcode";
            this.lblCompPostcode.Size = new System.Drawing.Size(80, 18);
            this.lblCompPostcode.TabIndex = 10;
            this.lblCompPostcode.Text = "Postcode: ";
            // 
            // lblCompAddress
            // 
            this.lblCompAddress.AutoSize = true;
            this.lblCompAddress.Location = new System.Drawing.Point(168, 20);
            this.lblCompAddress.Name = "lblCompAddress";
            this.lblCompAddress.Size = new System.Drawing.Size(70, 18);
            this.lblCompAddress.TabIndex = 0;
            this.lblCompAddress.Text = "Address: ";
            // 
            // lblCompName
            // 
            this.lblCompName.AutoSize = true;
            this.lblCompName.Location = new System.Drawing.Point(6, 47);
            this.lblCompName.Name = "lblCompName";
            this.lblCompName.Size = new System.Drawing.Size(56, 18);
            this.lblCompName.TabIndex = 0;
            this.lblCompName.Text = "Name: ";
            // 
            // lblCompID
            // 
            this.lblCompID.AutoSize = true;
            this.lblCompID.Location = new System.Drawing.Point(6, 20);
            this.lblCompID.Name = "lblCompID";
            this.lblCompID.Size = new System.Drawing.Size(30, 18);
            this.lblCompID.TabIndex = 0;
            this.lblCompID.Text = "ID: ";
            // 
            // FrmShowCompany
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(863, 559);
            this.Controls.Add(this.grpBoxInfo);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.grpCars);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmShowCompany";
            this.Text = "Company";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmClosed);
            this.Load += new System.EventHandler(this.FrmShowCompany_Load);
            this.grpCars.ResumeLayout(false);
            this.grpCarInfo.ResumeLayout(false);
            this.grpCarInfo.PerformLayout();
            this.grpBoxInfo.ResumeLayout(false);
            this.grpBoxInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.GroupBox grpCars;
        private System.Windows.Forms.ListBox lstCars;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.GroupBox grpBoxInfo;
        private System.Windows.Forms.Label lblCompName;
        private System.Windows.Forms.Label lblCompID;
        private System.Windows.Forms.Label lblCompPostcode;
        private System.Windows.Forms.Label lblCompAddress;
        private System.Windows.Forms.GroupBox grpCarInfo;
        private System.Windows.Forms.Label lblCarModel;
        private System.Windows.Forms.Label lblCarMake;
        private System.Windows.Forms.Label lblCarID;
        private System.Windows.Forms.Label lblCarLastService;
        private System.Windows.Forms.Label lblCarFuelType;
        private System.Windows.Forms.Label lblCarComments;
        private System.Windows.Forms.RichTextBox richCarInfo;
        private System.Windows.Forms.Label lblCarRegistration;
    }
}