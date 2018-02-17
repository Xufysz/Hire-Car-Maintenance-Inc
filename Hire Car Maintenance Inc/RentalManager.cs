using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Hire_Car_Maintenance_Inc.Car;

namespace Hire_Car_Maintenance_Inc
{
    class RentalManager
    {
        //Allows for binding to a listbox, eliminating need for manual refreshment of items
        private static BindingList<Company> companies;
        public static BindingList<Company> Companies
        {
            get
            {
                return companies;
            }
            set
            {
                companies = value;
            }
        }

        public static bool AddCompany(int id, string name, string address, string postcode)
        {
            //Check for duplicate ID
            if (CompanyIDExists(id))
                return false;

            //Update company and update listbox
            Companies.Add(new Company(id, name, address, postcode));

            return true;
        }

        public static bool EditCompany(Company company, int id, string name, string address, string postcode)
        {
            //Check for duplicate ID
            if (CompanyIDExists(company.ID, id))
                return false;

            //Update company and update listbox
            company.UpdateInfo(id, name, address, postcode);

            return true;
        }

        public static bool CompanyIDExists(int currentID, int newID = -1)
        {
            //Check for duplicate ID
            if (GetCompany(Companies, currentID, newID) != null)
            {
                MessageBox.Show(string.Format("The company ID number {0}" + (newID >= 0 ? string.Format(" or {0} ", newID) : " ") + "aleady exists", currentID));
                return true;
            }

            return false;
        }

        public static bool AddCar(Company company, int id, string make, string model, string registration, Fuel fuelType, DateTime lastService, string comments)
        {
            //Check for duplicate ID
            if (CarIDExists(company, id))
                return false;

            //Add to list and update listbox
            company.Cars.Add(new Car(id, make, model, registration, fuelType, lastService, comments));

            //this.BindCarsToList(company.Cars);

            return true;
        }

        public static bool EditCar(Company company, Car car, int id, string make, string model, string registration, Fuel fuelType, DateTime lastService, string comments)
        {
            //Check for duplicate ID
            if (CarIDExists(company, car.ID, id))
                return false;

            //Update company and refresh listbox
            car.UpdateInfo(id, make, model, registration, fuelType, lastService, comments);
            return true;
        }

        public static bool CarIDExists(Company company, int currentID, int newID = -1)
        {
            //Check for duplicate ID
            if (GetCar(company, currentID, newID) != null)
            {
                MessageBox.Show(string.Format("The car ID number {0}" + (newID >= 0 ? string.Format(" or {0} ", newID) : " ") + "aleady exists", currentID));
                return true;
            }

            return false;
        }

        //Return company
        public static Company GetCompany(BindingList<Company> companies, int id, int newID = -1)
        {
            if (companies.Count <= 0)
                return null;

            foreach (Company company in companies)
            {
                if (company.ID == id && newID == -1) //Is current Company (Add company)
                    return company;

                else if (company.ID == newID && company.ID != id && newID >= 0) //Check for new ID (Edit company)
                    return company;
            }
            return null;
        }

        //Return car
        public static Car GetCar(Company company, int id, int newID = -1)
        {
            if (company.CarCount < 0)
                return null;

            foreach (Car car in company.Cars)
            {
                if (car.ID == id && newID == -1) //Is current car (Add car)
                    return car;

                else if (car.ID == newID && car.ID != id && newID >= 0) //Is being edited (Edit car)
                    return car;
            }
            return null;
        }
    }
}
