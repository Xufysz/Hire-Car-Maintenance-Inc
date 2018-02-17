using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Hire_Car_Maintenance_Inc.Car;

namespace Hire_Car_Maintenance_Inc
{
    public partial class FrmMain : Form
    {
        private InfoState companyState;
        private InfoState carState;
        private int lastCompanyIndex;
        private int lastCarIndex;

        private bool CompanyIDCorrect
        {
            get
            {
                return this.lblCompIDTick.Text.Equals("✓");
            }
        }
        private bool CompanyNameCorrect
        {
            get
            {
                return this.lblCompNameTick.Text.Equals("✓");
            }
        }
        private bool CompanyAddressCorrect
        {
            get
            {
                return this.lblCompAddressTick.Text.Equals("✓");
            }
        }
        private bool CompanyPostcodeCorrect
        {
            get
            {
                return this.lblCompPostcodeTick.Text.Equals("✓");
            }
        }
        private bool CarIDCorrect
        {
            get
            {
                return this.lblCarIDTick.Text.Equals("✓");
            }
        }
        private bool CarMakeCorrect
        {
        get
            {
                return this.lblCarMakeTick.Text.Equals("✓");
            }
        }
        private bool CarModelCorrect
        {
            get
            {
                return this.lblCarModelTick.Text.Equals("✓");
            }
        }
        private bool CarRegCorrect
        {
            get
            {
                return this.lblCarRegTick.Text.Equals("✓");
            }
        }

        private enum InfoState
        {
            None,
            Adding,
            Editing,
        }

        public FrmMain()
        {
            InitializeComponent();

            //Set style for (slight) fix for flickering in listboxes when binding lots of items
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint, true);
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            //Set up design

            //Do setup
            RentalManager.Companies = new BindingList<Company>();
            this.companyState = InfoState.None;
            this.carState = InfoState.None;
            this.lastCompanyIndex = -1;
            this.lastCarIndex = -1;

            this.dtTimeCarService.MaxDate = DateTime.Today;

            this.openFileDialog.InitialDirectory = Environment.CurrentDirectory;

            #region Debug code
//#if DEBUG
//            for (int i = 0; i < 200; i++)
//            {
//                //Random company
//                this.companies.Add(new Company(Program.RandomNumber(Int32.MaxValue), Program.RandomString(10), Program.RandomString(10), Program.RandomString(3) + " " + Program.RandomString(3)));

//                //Random car
//                for (int j = 0; j < 200; j++)
//                {
//                    this.companies[i].Cars.Add(new Car(Program.RandomNumber(Int32.MaxValue), Program.RandomString(5), Program.RandomString(5), Program.RandomString(7), Car.Fuel.Diesel, DateTime.Today, Program.RandomString(Program.RandomNumber(15, 80))));
//                }
//            }
//#endif
            #endregion

            this.BindCompaniesToList(RentalManager.Companies);
        }

        private void SetLastSelectedInList(bool companyList, Company c = null)
        {
            //Cancel other selections for company listbox
            if (RentalManager.Companies.Count > 0 && this.lastCompanyIndex >= 0 && companyList)
            {
                this.lstCompanies.ClearSelected();
                this.lstCompanies.SetSelected(this.lastCompanyIndex, true);
            }
            //Cancel selections for car listbox
            else if (this.lastCarIndex >= 0 && !companyList)
            {
                if (c != null && c.CarCount == 0) {
                    return;
                }
                this.lstCars.ClearSelected();
                this.lstCars.SetSelected(this.lastCarIndex, true);
            }
        }

        #region Company code

        private void BtnAddCompany_Click(object sender, EventArgs e)
        {
            //If the current state is none, then add new company and clear inputs
            if (this.companyState == InfoState.None)
            {
                this.txtCompanyID.Clear();
                this.txtCompanyName.Clear();
                this.txtCompanyAddress.Clear();
                this.txtCompanyPostcode.Clear();

                this.ControlsForAddCompany(true);
            }
            //Otherwise cancel add and change back to last selected info
            else
            {
                DialogResult result = MessageBox.Show(this, "Are you sure you want to cancel add?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    this.ControlsForAddCompany(false, false);
                    this.SetLastSelectedInList(true);
                }
            }

            this.CheckForCompanySave();
        }

        private void BtnEditCompany_Click(object sender, EventArgs e)
        {
            //Nothing has been selected
            if (!this.HasSelectedCompanyItem())
                return;

            //Change for edit, don't need to remove current inputs
            if (this.companyState == InfoState.None)
            {
                this.ControlsForEditCompany(true);
            }
            //Revert back to last selected company info
            else
            {
                DialogResult result = MessageBox.Show(this, "Are you sure you want to cancel edit?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    this.ControlsForEditCompany(false, false);
                    this.SetLastSelectedInList(true);
                }
            }

            this.CheckForCompanySave();
        }

        private void BtnSaveCompany_Click(object sender, EventArgs e)
        {
            //Don't need to check inputs as it's already been done
            int id = Convert.ToInt32(this.txtCompanyID.Text);
            string name = this.txtCompanyName.Text;
            string address = this.txtCompanyAddress.Text;
            string postcode = this.txtCompanyPostcode.Text;

            //Add new company
            if (this.companyState == InfoState.Adding)
            {
                if (RentalManager.AddCompany(id, name, address, postcode))
                {
                    this.ControlsForAddCompany(false);
                    this.BindCompaniesToList(RentalManager.Companies);
                }
            }
            //Edit company
            else
            {
                if (RentalManager.EditCompany((Company)this.lstCompanies.Items[this.lastCompanyIndex], id, name, address, postcode))
                    this.ControlsForEditCompany(false);
            }
        }

        private void BtnRemoveCompany_Click(object sender, EventArgs e)
        {
            //Nothing selected
            if (!this.HasSelectedCompanyItem())
                return;

            //Check they want to remove company(s)
            string question = "Are you sure you want to remove " + (this.lstCompanies.SelectedItems.Count > 1 ? "multiple items?" : "this item?");
            DialogResult result = MessageBox.Show(this, question, "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.No)
                return;

            //Remove multiple or single company
            object[] toRemove = new object[this.lstCompanies.SelectedItems.Count];
            this.lstCompanies.SelectedItems.CopyTo(toRemove, 0);

            for (int i = 0; i < toRemove.Length; i++)
            {
                RentalManager.Companies.Remove((Company)toRemove[i]);
            }

            //Bind list back to listbox
            this.BindCompaniesToList(RentalManager.Companies);
            if (RentalManager.Companies.Count == 0)
                this.BindCarsToList(null);
        }

        private void TxtSearchCompany_TextChanged(object sender, EventArgs e)
        {
            string input = this.txtSearchCompany.Text;

            //Filters the cars list within the company to only display certain companies
            BindingList<Company> filterList = new BindingList<Company>();

            foreach (Company company in RentalManager.Companies)
            {
                //Check to see if it could be an ID by checking if its an integer
                int id = 0;
                bool canCheckID = int.TryParse(this.txtSearchCompany.Text, out id);

                //Check user by ID
                if (canCheckID)
                {
                    if (company.ID.ToString().StartsWith(input))
                    {
                        filterList.Add(company);
                    }
                }

                //Checks the company name
                else if (company.Name.ToLower().StartsWith(input.ToLower()) || company.Address.ToLower().Contains(input.ToLower()) || company.Postcode.ToLower().Contains(input.ToLower()))
                {
                    filterList.Add(company);
                }
            }

            //Update binding to new BindingList
            this.BindCompaniesToList(filterList);
        }

        private void TxtCompanyID_TextChanged(object sender, EventArgs e)
        {
            //Check if the company ID is valid and if it akready exists

            int id = 0;
            bool isCorrectFormat = int.TryParse(this.txtCompanyID.Text, out id);
            Company company = (Company)this.lstCompanies.SelectedItem;

            if (id < 0)
            {
                MessageBox.Show("ID can not be less than zero");
                isCorrectFormat = false;
            }

            if (isCorrectFormat)
            {
                if (this.companyState == InfoState.Adding)
                    isCorrectFormat = !RentalManager.CompanyIDExists(id);

                else if (this.companyState == InfoState.Editing)
                    isCorrectFormat = !RentalManager.CompanyIDExists(company.ID, id);
            }

            this.lblCompIDTick.ForeColor = isCorrectFormat ? Color.Green : Color.Red;
            this.lblCompIDTick.Text = isCorrectFormat ? "✓" : "X";

            this.CheckForCompanySave();
        }

        private void TxtCompanyName_TextChanged(object sender, EventArgs e)
        {
            //Check if company name is valid

            bool isCorrectFormat = !String.IsNullOrWhiteSpace(this.txtCompanyName.Text);
            this.lblCompNameTick.ForeColor = isCorrectFormat ? Color.Green : Color.Red;
            this.lblCompNameTick.Text = isCorrectFormat ? "✓" : "X";

            this.CheckForCompanySave();
        }

        private void TxtCompanyAddress_TextChanged(object sender, EventArgs e)
        {
            //Check if company address is valid

            bool isCorrectFormat = !String.IsNullOrWhiteSpace(this.txtCompanyAddress.Text);
            this.lblCompAddressTick.ForeColor = isCorrectFormat ? Color.Green : Color.Red;
            this.lblCompAddressTick.Text = isCorrectFormat ? "✓" : "X";

            this.CheckForCompanySave();
        }

        private void TxtCompanyPostcode_TextChanged(object sender, EventArgs e)
        {
            //Check if company postcode is valid

            //bool isCorrectFormat = Utils.RegexPostcodeMatch(this.txtCompanyPostcode.Text);
            bool isCorrectFormat = this.txtCompanyPostcode.Text.Length <= 8 && this.txtCompanyPostcode.Text.Length >= 4;
            this.lblCompPostcodeTick.ForeColor = isCorrectFormat ? Color.Green : Color.Red;
            this.lblCompPostcodeTick.Text = isCorrectFormat ? "✓" : "X";

            this.CheckForCompanySave();
        }

        private void LstCompanies_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Check if selected company is null, if so, clear all inputs
            if (this.lstCompanies.SelectedItem == null)
            {
                this.grpCars.Enabled = false;
                this.BindCarsToList(null);
                this.txtCompanyID.Clear();
                this.txtCompanyName.Clear();
                this.txtCompanyAddress.Clear();
                this.txtCompanyPostcode.Clear();

                return;
            }

            if (this.companyState == InfoState.None)
            {
                Company company = (Company)this.lstCompanies.SelectedItem;

                //Index changed so update selected company
                this.txtCompanyID.Text = company.ID.ToString();
                this.txtCompanyName.Text = company.Name;
                this.txtCompanyAddress.Text = company.Address;
                this.txtCompanyPostcode.Text = company.Postcode;
                this.grpCars.Enabled = true;
                this.panelCompanyInfo.Enabled = true;

                //Change to keep this
                this.lastCompanyIndex = this.lstCompanies.SelectedIndex;

                //Update cars list
                this.BindCarsToList(company.Cars);
            }
        }

        private bool HasSelectedCompanyItem()
        {
            //Check if user has selected an item
            if (this.lstCompanies.SelectedItem == null)
            {
                MessageBox.Show("Please select a company first");
                return false;
            }
            return true;
        }

        private void ControlsForAddCompany(bool addMode, bool goToLast = true)
        {
            //Change controls on whether it's being added or cancel added
            this.companyState = (addMode ? InfoState.Adding : InfoState.None);
            this.btnAddCompany.Text = (addMode ? "Cancel add" : "Add new");
            this.btnEditCompany.Enabled = !addMode;

            this.btnSaveCompany.Enabled = addMode;
            this.btnRemoveCompany.Enabled = !addMode;

            this.lstCompanies.Enabled = !addMode;
            //this.grpCars.Enabled = !addMode;

            this.txtSearchCompany.Enabled = !addMode;

            this.txtCompanyID.ReadOnly = !addMode;
            this.txtCompanyName.ReadOnly = !addMode;
            this.txtCompanyAddress.ReadOnly = !addMode;
            this.txtCompanyPostcode.ReadOnly = !addMode;

            //Selects last company if it's been canceled
            if (!addMode && goToLast)
            {
                this.lastCompanyIndex = this.lstCompanies.Items.Count - 1;
                this.SetLastSelectedInList(true);
            }
        }

        private void ControlsForEditCompany(bool editMode, bool goToLast = true)
        {
            //Change controls based on whether it's being edited
            this.companyState = (editMode ? InfoState.Editing : InfoState.None);
            this.btnEditCompany.Text = (editMode ? "Cancel edit" : "Edit");
            this.btnAddCompany.Enabled = !editMode;

            this.btnSaveCompany.Enabled = editMode;
            this.btnRemoveCompany.Enabled = !editMode;

            this.lstCompanies.Enabled = !editMode;
            this.grpCars.Enabled = !editMode;

            this.txtSearchCompany.Enabled = !editMode;

            this.txtCompanyID.ReadOnly = !editMode;
            this.txtCompanyName.ReadOnly = !editMode;
            this.txtCompanyAddress.ReadOnly = !editMode;
            this.txtCompanyPostcode.ReadOnly = !editMode;

            //If edit is being cancelled go back to last selected company
            if (!editMode && goToLast)
            {
                this.SetLastSelectedInList(true);
            }
        }

        private void CheckForCompanySave()
        {
            //Check car state
            if (this.companyState == InfoState.Adding || this.companyState == InfoState.Editing)
            {
                if (this.CompanyIDCorrect && this.CompanyNameCorrect && this.CompanyAddressCorrect && this.CompanyPostcodeCorrect)
                    this.btnSaveCompany.Enabled = true;
                else
                    this.btnSaveCompany.Enabled = false;
            }
        }

        private void BindCompaniesToList(BindingList<Company> companyList)
        {
            //Set data source (Where the listbox items come from) and set the displaymember
            this.lstCompanies.DataSource = null;
            this.lstCompanies.DataSource = companyList;
            this.lstCompanies.DisplayMember = "FormattedInfo";

            //Change groupbox number
            this.grpCompanies.Text = "Companies: " + companyList.Count.ToString();
        }
        #endregion

        #region Car code

        private void BtnAddCar_Click(object sender, EventArgs e)
        {
            //Checks if car is being added, if so, clear inputs
            if (this.carState == InfoState.None)
            {
                this.txtCarID.Clear();
                this.txtCarMake.Clear();
                this.txtCarModel.Clear();
                this.txtCarReg.Clear();
                this.cmbxCarFuel.SelectedIndex = 0;
                this.dtTimeCarService.Value = DateTime.Today;
                this.txtCarComments.Clear();

                this.ControlsForAddCar(true);
            }
            //Cancel add
            else
            {
                DialogResult result = MessageBox.Show(this, "Are you sure you want to cancel add?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    this.ControlsForAddCar(false, false);
                    this.SetLastSelectedInList(false, (Company)this.lstCompanies.SelectedItem);
                }
            }

            this.CheckForCarSave();
        }

        private void BtnEditCar_Click(object sender, EventArgs e)
        {
            //Nothing selected
            if (!this.HasSelectedCarItem())
                return;

            //Edit car
            if (this.carState == InfoState.None)
            {
                this.ControlsForEditCar(true);
            }
            //Cancel edit car
            else
            {
                DialogResult result = MessageBox.Show(this, "Are you sure you want to cancel edit?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    this.ControlsForEditCar(false, false);
                    this.SetLastSelectedInList(false);
                }
            }

            this.CheckForCarSave();
        }

        private void BtnSaveCar_Click(object sender, EventArgs e)
        {
            //No input check is needed as it's already done
            int id = Convert.ToInt32(this.txtCarID.Text);
            string make = this.txtCarMake.Text;
            string model = this.txtCarModel.Text;
            string registration = this.txtCarReg.Text;
            Fuel fuelType = this.cmbxCarFuel.Text == "Petrol" ? Fuel.Petrol : Fuel.Diesel;
            DateTime lastService = this.dtTimeCarService.Value;
            string comments = this.txtCarComments.Text;

            Company company = (Company)this.lstCompanies.SelectedItem;

            if (this.carState == InfoState.Adding) //Add car
            {
                if (RentalManager.AddCar(company, id, make, model, registration, fuelType, lastService, comments))
                {
                    this.ControlsForAddCar(false);

                    //this.BindCarsToList(company.Cars);
                }
            }
            else //Edit car
            {
                if (RentalManager.EditCar(company, (Car)this.lstCars.Items[this.lastCarIndex], id, make, model, registration, fuelType, lastService, comments))
                    this.ControlsForEditCar(false);
            }
        }

        private void BtnRemoveCar_Click(object sender, EventArgs e)
        {
            //Nothing selected
            if (!this.HasSelectedCarItem())
                return;

            //Checks the user really wants to remove the item(s)
            string question = "Are you sure you want to remove " + (this.lstCars.SelectedItems.Count > 1 ? "multiple items?" : "this item?");

            DialogResult result = MessageBox.Show(this, question, "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.No)
                return;

            //Remove multiple or single item
            object[] toRemove = new object[this.lstCars.SelectedItems.Count];
            this.lstCars.SelectedItems.CopyTo(toRemove, 0);

            Company company = (Company)this.lstCompanies.SelectedItem;
            for (int i = 0; i < toRemove.Length; i++)
            {
                company.Cars.Remove((Car)toRemove[i]);
            }

            this.BindCarsToList(company.Cars);
        }

        private void TxtSearchCar_TextChanged(object sender, EventArgs e)
        {
            string input = this.txtSearchCar.Text;

            //Filters the cars list within the company to only display certain cars
            BindingList<Car> filterList = new BindingList<Car>();

            Company company = (Company)this.lstCompanies.SelectedItem;
            input = input.ToLower();

            foreach (Car car in company.Cars)
            {
                int id = 0;
                bool canCheckID = int.TryParse(this.txtSearchCar.Text, out id);

                if (car.Make.ToLower().StartsWith(input) || car.Model.ToLower().StartsWith(input) || car.Registration.ToLower().StartsWith(input) || car.FuelType.ToString().StartsWith(input) || car.LastService.ToLongDateString().ToLower().Contains(input))
                {
                    filterList.Add(car);
                }

                else if (canCheckID)
                {
                    if (car.ID.ToString().StartsWith(input))
                    {
                        filterList.Add(car);
                    }
                }
            }

            //Binds new list to the listbox
            this.BindCarsToList(filterList);
        }

        private void TxtCarID_TextChanged(object sender, EventArgs e)
        {
            //Checks the ID is valid and that it doesn't already exist

            int id = 0;
            bool isCorrectFormat = int.TryParse(this.txtCarID.Text, out id);
            Company company = (Company)this.lstCompanies.SelectedItem;

            if (id < 0)
            {
                MessageBox.Show("ID can not be less than zero");
                isCorrectFormat = false;
            }

            Car car = (Car)this.lstCars.SelectedItem;

            if (isCorrectFormat)
            {
                if (this.carState == InfoState.Adding)
                    isCorrectFormat = !RentalManager.CarIDExists(company, id);

                else if (this.carState == InfoState.Editing)
                    isCorrectFormat = !RentalManager.CarIDExists(company, car.ID, id);
            }

            this.lblCarIDTick.ForeColor = isCorrectFormat ? Color.Green : Color.Red;
            this.lblCarIDTick.Text = isCorrectFormat ? "✓" : "X";

            this.CheckForCarSave();
        }

        private void TxtCarMake_TextChanged(object sender, EventArgs e)
        {
            //Checks the make is valid
            bool isCorrectFormat = !String.IsNullOrWhiteSpace(this.txtCarMake.Text);

            this.lblCarMakeTick.ForeColor = isCorrectFormat ? Color.Green : Color.Red;
            this.lblCarMakeTick.Text = isCorrectFormat ? "✓" : "X";

            this.CheckForCarSave();
        }

        private void TxtCarModel_TextChanged(object sender, EventArgs e)
        {
            //Checks the model is valid
            bool isCorrectFormat = !String.IsNullOrWhiteSpace(this.txtCarModel.Text);

            this.lblCarModelTick.ForeColor = isCorrectFormat ? Color.Green : Color.Red;
            this.lblCarModelTick.Text = isCorrectFormat ? "✓" : "X";

            this.CheckForCarSave();
        }

        private void TxtCarReg_TextChanged(object sender, EventArgs e)
        {
            //Checks the reg is valid

            //Checks using DVLA regular expression
            //bool isCorrectFormat = Utils.RegexCarRegMatch(this.txtCarReg.Text);
            bool isCorrectFormat = this.txtCarReg.Text.Length <= 8 && this.txtCarReg.Text.Length >= 5;

            this.lblCarRegTick.ForeColor = isCorrectFormat ? Color.Green : Color.Red;
            this.lblCarRegTick.Text = isCorrectFormat ? "✓" : "X";

            this.CheckForCarSave();
        }

        private void LstCars_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Check the index changes we need to update the information

            if (this.lstCars.SelectedItem == null)
            {
                //This is when cars are edited or removed, the selected becomes null
                this.txtCarID.Clear();
                this.txtCarMake.Clear();
                this.txtCarModel.Clear();
                this.txtCarReg.Clear();
                this.cmbxCarFuel.SelectedIndex = 0;
                this.dtTimeCarService.Value = DateTime.Today;
                this.txtCarComments.Clear();
                return;
            }

            //Index changed so update selected car
            if (this.carState == InfoState.None)
            {
                this.panelCarInfo.Enabled = true;

                Car car = (Car)this.lstCars.SelectedItem;
                this.txtCarID.Text = car.ID.ToString();
                this.txtCarMake.Text = car.Make;
                this.txtCarModel.Text = car.Model;
                this.txtCarReg.Text = car.Registration;
                this.cmbxCarFuel.Text = car.FuelType.ToString();
                this.dtTimeCarService.Value = car.LastService;
                this.txtCarComments.Text = car.Comments;

                this.lastCarIndex = this.lstCars.SelectedIndex;
            }
        }

        private bool HasSelectedCarItem()
        {
            //Check if user has selected an item
            if (this.lstCars.SelectedItem == null)
            {
                MessageBox.Show("Please select a car first");
                return false;
            }
            return true;
        }

        private void ControlsForAddCar(bool addMode, bool goToLast = true)
        {
            //Changes controls based on adding a car or not

            this.carState = (addMode ? InfoState.Adding : InfoState.None);
            this.btnAddCar.Text = (addMode ? "Cancel add" : "Add new");
            this.btnEditCar.Enabled = !addMode;

            this.btnSaveCar.Enabled = addMode;
            this.btnRemoveCar.Enabled = !addMode;

            this.lstCars.Enabled = !addMode;
            this.grpCompanies.Enabled = !addMode;

            this.txtSearchCar.Enabled = !addMode;

            this.txtCarID.ReadOnly = !addMode;
            this.txtCarMake.ReadOnly = !addMode;
            this.txtCarModel.ReadOnly = !addMode;
            this.txtCarReg.ReadOnly = !addMode;
            this.cmbxCarFuel.Enabled = addMode;
            this.dtTimeCarService.Enabled = addMode;
            this.txtCarComments.ReadOnly = !addMode;

            //If it's not adding, reset the selected car to the last selected one
            if (!addMode && goToLast)
            {
                this.lastCarIndex = this.lstCars.Items.Count - 1;
                this.SetLastSelectedInList(false, (Company)this.lstCompanies.SelectedItem);
            }
        }

        private void ControlsForEditCar(bool editMode, bool goToLast = true)
        {
            //Changes controls based on whether editing a car or not

            this.carState = (editMode ? InfoState.Editing : InfoState.None);
            this.btnEditCar.Text = (editMode ? "Cancel edit" : "Edit");
            this.btnAddCar.Enabled = !editMode;

            this.btnSaveCar.Enabled = editMode;
            this.btnRemoveCar.Enabled = !editMode;

            this.lstCars.Enabled = !editMode;
            this.grpCompanies.Enabled = !editMode;

            this.txtSearchCar.Enabled = !editMode;

            this.txtCarID.ReadOnly = !editMode;
            this.txtCarMake.ReadOnly = !editMode;
            this.txtCarModel.ReadOnly = !editMode;
            this.txtCarReg.ReadOnly = !editMode;
            this.cmbxCarFuel.Enabled = editMode;
            this.dtTimeCarService.Enabled = editMode;
            this.txtCarComments.ReadOnly = !editMode;

            //if isn't editing, select last car selected
            if (!editMode && goToLast)
            {
                this.SetLastSelectedInList(false, (Company)this.lstCompanies.SelectedItem);
            }
        }

        private void CheckForCarSave()
        {
            //Checks to see if the save button should be enabled
            if (this.carState == InfoState.Adding || this.carState == InfoState.Editing)
            {
                if (this.CarIDCorrect && this.CarMakeCorrect && this.CarModelCorrect && this.CarRegCorrect)
                    this.btnSaveCar.Enabled = true;  
                else
                    this.btnSaveCar.Enabled = false;
            }
        }

        private void BindCarsToList(BindingList<Car> carList)
        {
            //Set data source (Where the listbox items come from) and set the displaymember
            this.lstCars.DataSource = null;
            this.lstCars.DataSource = carList;
            this.lstCars.DisplayMember = "FormattedInfo";

            //Change groupbox number
            this.grpCars.Text = "Cars: " + (carList != null ? carList.Count.ToString() : "0");
        }
        #endregion

        #region File code
        private void BtnLoadFile_Click(object sender, EventArgs e)
        {
            //Open dialog for opening a file and wait for a response
            if (this.openFileDialog.ShowDialog() == DialogResult.OK)
            {
                //If user clicks ok then proceed to read the file
                BindingList<Company> companies = FileMethods.OpenFile(this.openFileDialog.FileName);
                if (companies == null)
                    return;

                //Set companies to the new opened file and bind to listbox
                RentalManager.Companies = companies;
                this.BindCompaniesToList(RentalManager.Companies);

                //Update inital open directory
                this.UpdateIntitalDirectory();

                //Update filename in program header and change file options
                this.UpdateFileName(true);
            }
        }

        private void BtnSaveCurrentFile_Click(object sender, EventArgs e)
        {
            //Save file quickly
            FileMethods.SaveFile(FileMethods.CurrentFileLocation, RentalManager.Companies);
        }

        private void BtnSaveFileAs_Click(object sender, EventArgs e)
        {
            //Save file with dialog
            if (this.saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                FileMethods.SaveFile(this.saveFileDialog.FileName, RentalManager.Companies);

                //Update inital save & open directory
                this.UpdateIntitalDirectory();

                //Update filename in program title and change file options
                this.UpdateFileName(true);
            }
        }

        private void BtnCloseFile_Click(object sender, EventArgs e)
        {
            //Check they want to close file
            DialogResult result = MessageBox.Show(this, string.Format("Are you sure you want to close file {0}?", FileMethods.FileName), "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.No)
                return;

            //Clear companies and bind it to update amount
            RentalManager.Companies.Clear();
            this.BindCompaniesToList(RentalManager.Companies);

            //Clear cars
            this.BindCarsToList(null);

            //Update name at top of form and change file options
            FileMethods.CloseFile();
            this.UpdateFileName(false);
        }

        private void UpdateIntitalDirectory()
        {
            //Updates the location when save and open file dialog opens
            this.saveFileDialog.InitialDirectory = FileMethods.CurrentFileLocation;
            this.openFileDialog.InitialDirectory = FileMethods.CurrentFileLocation;
        }

        private void UpdateFileName(bool allowSave)
        {
            //Update filename at top of form
            this.Text = "Hire Car Maintenance Inc: " + FileMethods.FileName;
            this.saveFileDialog.FileName = FileMethods.FileName;

            //Change buttons enabled options
            this.btnSaveCurrentFile.Enabled = allowSave;
            this.btnCloseFile.Enabled = allowSave;
        }
        #endregion
    }
}

