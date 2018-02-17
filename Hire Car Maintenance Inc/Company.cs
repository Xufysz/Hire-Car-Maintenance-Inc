using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hire_Car_Maintenance_Inc
{
    public class Company : INotifyPropertyChanged
    {
        private int id;
        public int ID
        {
            get
            {
                return this.id;
            }
            set
            {
                this.id = value;
            }
        }

        private string name;
        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }

        private string address;
        public string Address
        {
            get
            {
                return this.address;
            }
            set
            {
                this.address = value;
            }
        }

        private string postcode;
        public string Postcode
        {
            get
            {
                return this.postcode;
            }
            set
            {
                this.postcode = value;
            }
        }

        //Allows for binding to a listbox, eliminating need for manual refreshment of items. Binding list wraps
        //The generic List<T> meaning it TypeSafe compared to ArrayList, thus reducing chances of errors and exceptions
        private BindingList<Car> cars;
        public BindingList<Car> Cars
        {
            get
            {
                return this.cars;
            }
            set
            {
                this.cars = value;
            }
        }

        public int CarCount
        {
            get
            {
                return this.Cars.Count;
            }
        }

        //Implements the INotifyPropertyChanged interface which allows for BindingList to update
        private event PropertyChangedEventHandler PropertyChangedEvent;
        public event PropertyChangedEventHandler PropertyChanged
        {
            add
            {
                this.PropertyChangedEvent += value;
            }
            remove
            {

                this.PropertyChangedEvent -= value;
            }
        }

        //Formatted car info
        public string FormattedInfo
        {
            get
            {
                return string.Format("Name: {0} - ID: {1} - Postcode: {2}", this.Name, this.ID, this.Postcode);
            }
        }

        public Company(int id, string name, string address, string postcode)
        {
            //Set info
            this.UpdateInfo(id, name, address, postcode);

            //Create new arraylist of cars
            this.Cars = new BindingList<Car>();
        }

        public void UpdateInfo(int id, string name, string address, string postcode)
        {
            //Update car info
            this.ID = id;
            this.Name = name;
            this.Address = address;
            this.Postcode = postcode;

            //Raises the event PropertyChanged allowing for the listbox to redraw the items rather than add new ones
            if (this.PropertyChangedEvent != null)
            {
                this.PropertyChangedEvent(this, new PropertyChangedEventArgs("ID"));
                this.PropertyChangedEvent(this, new PropertyChangedEventArgs("Name"));
                this.PropertyChangedEvent(this, new PropertyChangedEventArgs("Address"));
                this.PropertyChangedEvent(this, new PropertyChangedEventArgs("Postcode"));
            }
        }
    }
}
