using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Hire_Car_Maintenance_Inc.Car;

namespace Hire_Car_Maintenance_Inc
{
    public partial class FrmShowCompany : Form
    {
        private Company company;
        public FrmShowCompany(Company company)
        {
            InitializeComponent();

            this.company = company;
            this.lblHeader.Text += company.Name;

            this.lblCompID.Text += company.ID.ToString();
            this.lblCompName.Text += company.Name;
            this.lblCompAddress.Text += company.Address;
            this.lblCompPostcode.Text += company.Postcode;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            //Closes form
            this.Close();
        }

        private void frmClosed(object sender, FormClosedEventArgs e)
        {
            //Changes form
            FrmMain main = (FrmMain)this.Owner;
            main.Show();
        }

        public bool AddCar(int id, string make, string model, string registration, Fuel fuelType, DateTime lastService, string comments)
        {
            //Check for duplicate ID
            if (SearchMethods.SearchCar(this.company, id) != null)
            {
                MessageBox.Show(string.Format("The car ID number {0} aleady exists", id));
                return false;
            }

            //Add to list and update listbox
            this.company.Cars.Add(new Car(id, make, model, registration, fuelType, lastService, comments));

            this.bindCarsToList(this.company.Cars);

            return true;
        }

        public bool EditCar(Car car, int id, string make, string model, string registration, Fuel fuelType, DateTime lastService, string comments)
        {
            //Check for duplicate ID
            if (SearchMethods.SearchCar(this.company, car.ID, id) != null)
            {
                MessageBox.Show(string.Format("The car ID number {0} aleady exists", id));
                return false;
            }

            //Update company and refresh listbox
            car.UpdateInfo(id, make, model, registration, fuelType, lastService, comments);
            return true;
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            //Nothing selected
            if (!this.hasSelectedItem())
                return;

            //Checks the user really wants to remove the item(s)
            string question = "Are you sure you want to remove " + (this.lstCars.SelectedItems.Count > 1 ? "multiple items?" : "this item?");

            DialogResult result = MessageBox.Show(this, question, "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.No)
                return;

            //Remove multiple or single item
            object[] toRemove = new object[this.lstCars.SelectedItems.Count];
            this.lstCars.SelectedItems.CopyTo(toRemove, 0);

            for (int i = 0; i < toRemove.Length; i++)
            {
                this.company.Cars.Remove((Car)toRemove[i]);
            }

            this.bindCarsToList(this.company.Cars);
        }

        private bool hasSelectedItem()
        {
            //Check if user has selected an item
            if (this.lstCars.SelectedItem == null)
            {
                MessageBox.Show("Please select a car first");
                return false;
            }
            return true;
        }

        private void bindCarsToList(BindingList<Car> carList)
        {
            //Set data source (Where the listbox items come from) and set the displaymember
            this.lstCars.DataSource = null;
            this.lstCars.DataSource = carList;
            this.lstCars.DisplayMember = "GetFormattedInfo()";

            //Change groupbox number
            this.grpCars.Text = "Cars: " + this.company.CarCount.ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (FrmManipulateCar frm = new FrmManipulateCar())
            {
                //Open FrmManipulateCar as child
                frm.ShowDialog(this);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            //Nothing selected
            if (!this.hasSelectedItem())
                return;

            using (FrmManipulateCar frm = new FrmManipulateCar((Car)this.lstCars.SelectedItem))
            {
                //Open FrmManipulateCompany as child
                frm.ShowDialog(this);
            }
        }

        private void inputSearch_TextChanged(object sender, EventArgs e)
        {
            string input = this.txtSearch.Text;

            //Filters the cars list within the company to only display certain cars
            BindingList<Car> filterList = new BindingList<Car>();

            foreach (Car car in this.company.Cars)
            {
                //Checks the cars make and model
                if (car.Make.ToLower().StartsWith(input.ToLower()) || car.Model.ToLower().StartsWith(input.ToLower()))
                {
                    filterList.Add(car);
                }

                int id = 0;
                bool canCheckID = int.TryParse(this.txtSearch.Text, out id);

                //Check by ID
                if (canCheckID)
                {
                    if (car.ID.ToString().StartsWith(input))
                    {
                        filterList.Add(car);
                    }
                }
            }

            //Binds new list to the listbox
            this.bindCarsToList(filterList);
        }

        private void FrmShowCompany_Load(object sender, EventArgs e)
        {
            //Binds original list to the listbox
            this.bindCarsToList(this.company.Cars);
        }

        private void lstCars_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.lstCars.SelectedItem == null)
            {

                //This is when cars are edited or removed, the selected becomes null
                this.lblCarID.Text = "ID: ";
                this.lblCarMake.Text = "Make: ";
                this.lblCarModel.Text = "Model: ";
                this.lblCarRegistration.Text = "Registration: ";
                this.lblCarFuelType.Text = "Fuel type: ";
                this.lblCarLastService.Text = "Last service: ";
                this.richCarInfo.Clear();
                return;
            }

            //Index changed so update selected car
            Car car = (Car)this.lstCars.SelectedItem;
            this.lblCarID.Text = "ID: " + car.ID.ToString();
            this.lblCarMake.Text = "Make: " + car.Make;
            this.lblCarModel.Text = "Model: " + car.Model;
            this.lblCarRegistration.Text = "Registration: " + car.Registration;
            this.lblCarFuelType.Text = "Fuel type: " + car.FuelType.ToString();
            this.lblCarLastService.Text = "Last service: " + car.LastService.Date.ToShortDateString();
            this.richCarInfo.Text = car.Comments;
        }
    }
}
