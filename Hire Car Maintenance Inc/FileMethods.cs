using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Hire_Car_Maintenance_Inc.Car;

namespace Hire_Car_Maintenance_Inc
{
    class FileMethods
    {
        private static string currentFileLocation;
        public static string CurrentFileLocation
        {
            get
            {
                return currentFileLocation;
            }
            set
            {
                currentFileLocation = value;
            }
        }

        private static string fileName;
        public static string FileName
        {
            get
            {
                return fileName;
            }
            set
            {
                fileName = value;
            }
        }

        public static BindingList<Company> OpenFile(string file)
        {
            BindingList<Company> companies = new BindingList<Company>();

            //Load file into StreamReader
            using (StreamReader sr = new StreamReader(file))
            {
                try
                {
                    //Peek to see if the next char isn't null
                    while (!sr.EndOfStream)
                    {
                        //Read company information
                        Company company = GetCompanyFromFile(companies, sr);
                        if (company == null)
                            return null;

                        //Check car count
                        int carCount = 0;
                        bool validCarAmount = int.TryParse(sr.ReadLine(), out carCount) && carCount >= 0;
                        if (!validCarAmount)
                        {
                            MessageBox.Show("Car count isn't valid\nCompany ID: " + company.ID);
                            return null;
                        }

                        //Load cars into company
                        for (int i = 0; i < carCount; i++)
                        {
                            //Read car information
                            Car car = GetCarFromFile(company, sr);
                            if (car == null)
                                continue;

                            company.Cars.Add(car);
                        }

                        companies.Add(company);
                    }
                }
                catch (IndexOutOfRangeException ex)
                {
                    MessageBox.Show("File is corrupt and not in the correct format so it was not loaded.\nMore Info:\n" + ex.StackTrace);
                    return null;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error reading file.\nStacktrace:\n" + ex.StackTrace);
                    return null;
                }
            }

            CurrentFileLocation = file;
            FileName = GetNameFromPath(file);

            return companies;
        }

        private static Company GetCompanyFromFile(BindingList<Company> companies, StreamReader sr)
        {

            //Check ID for tampering
            int companyID = 0;
            bool validCompanyID = int.TryParse(sr.ReadLine(), out companyID) && companyID >= 0;
            if (!validCompanyID && RentalManager.GetCompany(companies, companyID) != null)
            {
                MessageBox.Show("Company ID isn't valid or already exists\nCompany ID: " + companyID);
                return null;
            }

            string companyName = sr.ReadLine();
            string companyAddress = sr.ReadLine();
            string companyPostcode = sr.ReadLine();

            //Create new company
            return new Company(companyID, companyName, companyAddress, companyPostcode);
        }

        private static Car GetCarFromFile(Company company, StreamReader sr)
        {
            int carID = 0;
            bool validCarID = int.TryParse(sr.ReadLine(), out carID) && carID >= 0;
            if (!validCarID && RentalManager.GetCar(company, carID) != null)
            {
                //Skip current car as invalid ID or already exits
                for (int lines = 0; lines < 6; lines++)
                    sr.ReadLine();

                MessageBox.Show("Skipping car due to ID error");

                return null;
            }

            //Split make model
            string[] makeModel = sr.ReadLine().Split(new string[] { " ", }, StringSplitOptions.None);
            string carMake = makeModel[0];
            string carModel = makeModel[1];
            string carRegistration = sr.ReadLine();
            Fuel carFuelType = sr.ReadLine() == "Petrol" ? Fuel.Petrol : Fuel.Diesel;

            DateTime carLastService;
            bool validCarService = DateTime.TryParse(sr.ReadLine(), out carLastService);
            if (!validCarService && carLastService.Date > DateTime.Now.Date)
            {
                //Skip current car as invalid service
                sr.ReadLine();
                MessageBox.Show("Skipping car due to service error");
                return null;
            }

            string carComments = sr.ReadLine();

            return new Car(carID, carMake, carModel, carRegistration, carFuelType, carLastService, carComments);
        }

        public static void SaveFile(string path, BindingList<Company> companies)
        {
            //Create a StreamWriter and write to the file with the companies
            using (StreamWriter sw = new StreamWriter(path))
            {
                foreach (Company company in companies)
                {
                    sw.WriteLine(company.ID);
                    sw.WriteLine(company.Name);
                    sw.WriteLine(company.Address);
                    sw.WriteLine(company.Postcode);
                    sw.WriteLine(company.CarCount);
                    foreach (Car car in company.Cars)
                    {
                        sw.WriteLine(car.ID);
                        sw.WriteLine(car.Make + " " + car.Model);
                        sw.WriteLine(car.Registration);
                        sw.WriteLine(car.FuelType.ToString());
                        sw.WriteLine(car.LastService.ToShortDateString());
                        sw.WriteLine(car.Comments);
                    }
                }
            }

            CurrentFileLocation = path;
            FileName = GetNameFromPath(path);

            MessageBox.Show(string.Format("Saved {0} successfully", FileName));
        }

        public static void CloseFile()
        {
            //Clear current file
            CurrentFileLocation = "Untitled.txt";
            FileName = "Untitled.txt";
        }

        private static string GetNameFromPath(string filePath)
        {
            //Get the filename from filePath
            string[] parts = filePath.Split('\\');
            string fileName = parts[parts.Length - 1];
            return fileName;
        }
    }
}
