using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hire_Car_Maintenance_Inc
{
    public class Car : INotifyPropertyChanged
    {
        private int id;
        public int ID
        {
            get
            {
                return this.id;
            }
            private set
            {
                this.id = value;
            }
        }

        private string make;
        public string Make
        {
            get
            {
                return this.make;
            }
            private set
            {
                this.make = value;
            }
        }

        private string model;
        public string Model
        {
            get
            {
                return this.model;
            }
            set
            {
                this.model = value;
            }
        }

        private string registration;
        public string Registration
        {
            get
            {
                return this.registration;
            }
            set
            {
                this.registration = value;
            }
        }

        private Fuel fuelType;
        public Fuel FuelType
        {
            get
            {
                return this.fuelType;
            }
            set
            {
                this.fuelType = value;
            }
        }

        private DateTime lastService;
        public DateTime LastService
        {
            get
            {
                return this.lastService;
            }
            set
            {
                this.lastService = value;
            }
        }

        private string comments;
        public string Comments
        {
            get
            {
                return this.comments;
            }
            set
            {
                this.comments = value;
            }
        }

        //Implements the INotifyPropertyChanged interface which allows for BindingList to update
        private event PropertyChangedEventHandler propertyChanged;
        public event PropertyChangedEventHandler PropertyChanged
        {
            add
            {
                this.propertyChanged += value;
            }
            remove
            {

                this.propertyChanged -= value;
            }
        }

        public string FormattedInfo
        {
            get
            {
                return string.Format("Make: {0} - Model: {1} - ID: {2} - Reg: {3}", this.Make, this.Model, this.ID, this.Registration);
            }
        }

        public enum Fuel
        {
            Petrol,
            Diesel,
        }

        public Car(int id, string make, string model, string registration, 
            Fuel fuelType, DateTime lastService, string comments)
        {
            //Set info
            this.UpdateInfo(id, make, model, registration, fuelType, lastService, comments);
        }

        public void UpdateInfo(int id, string make, string model, string registration,
            Fuel fuelType, DateTime lastService, string comments)
        {
            //Update info
            this.ID = id;
            this.Make = make;
            this.Model = model;
            this.Registration = registration;
            this.FuelType = fuelType;
            this.LastService = lastService;
            this.Comments = comments; 

            //Raises the event PropertyChanged allowing for the listbox to redraw the items rather than add new ones
            if (this.propertyChanged != null)
            {
                this.propertyChanged(this, new PropertyChangedEventArgs("ID"));
                this.propertyChanged(this, new PropertyChangedEventArgs("Make"));
                this.propertyChanged(this, new PropertyChangedEventArgs("Model"));
                this.propertyChanged(this, new PropertyChangedEventArgs("Registration"));
                this.propertyChanged(this, new PropertyChangedEventArgs("FuelType"));
                this.propertyChanged(this, new PropertyChangedEventArgs("LastService"));
                this.propertyChanged(this, new PropertyChangedEventArgs("Comments"));
            }
        }
    }
}
