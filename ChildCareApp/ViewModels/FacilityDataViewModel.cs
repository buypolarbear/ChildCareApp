using Caliburn.Micro;
using ChildCareApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChildCareApp.ViewModels
{
    public class FacilityDataViewModel : Screen
    {
        string facilityName;
        public string FacilityName
        {

            get { return facilityName; }
            set
            {
                facilityName = value;
                NotifyOfPropertyChange(() => FacilityName);
            }
        }

        string address;
        public string Address
        {

            get { return address; }
            set
            {
                address = value;
                NotifyOfPropertyChange(() => Address);
            }
        }

        string city;
        public string City
        {

            get { return city; }
            set
            {
                city = value;
                NotifyOfPropertyChange(() => City);
            }
        }

        string state;
        public string State
        {

            get { return state; }
            set
            {
                state = value;
                NotifyOfPropertyChange(() => State);
            }
        }

        int zip;
        public int Zip
        {

            get { return zip; }
            set
            {
                zip = value;
                NotifyOfPropertyChange(() => Zip);
            }
        }

        int phone;
        public int Phone
        {

            get { return phone; }
            set
            {
                phone = value;
                NotifyOfPropertyChange(() => Phone);
            }
        }

        string ownerName;
        public string OwnerName
        {

            get { return ownerName; }
            set
            {
                ownerName = value;
                NotifyOfPropertyChange(() => OwnerName);
            }
        }


        protected override void OnActivate()
        {
            base.OnActivate();

        }

        public FacilityDataViewModel()
        {
            //Facility fac = GetFacility();
            //SetFacility(fac.Name, fac.Address, fac.City, fac.State, fac.ZIP, fac.Phone, fac.Owner);
        }

        // Save current facility state 
        public void SaveChanges()
        {
            // Get the first Facility in the database and update
            //using (var context = new CCADBContext())
            //{
            //    var facility = context.Facilities.First();
            //    facility.Name = FacilityName;
            //    facility.Address = Address;
            //    facility.Address = City;
            //    facility.State = State;
            //    facility.ZIP = Zip;
            //    facility.Phone = Phone;
            //    facility.Owner = OwnerName;

            //    context.SaveChanges();
            //}
        }

        // Gets Facility from Database
        //Facility GetFacility()
        //{
        //    Facility fac;
        //    try
        //    {
        //        using (var context = new CCADBContext())
        //        {
        //            var facility = context.Facilities.First();

        //            fac = facility as Facility;
        //        }
        //    }
        //    catch (Exception)
        //    {
        //        fac = new Facility();
        //    }

        //    return fac;
        //}

        void SetFacility(string facilityName, string address, string city, string state, int zip, int phone, string ownerName)
        {
            FacilityName = facilityName;
            Address = address;
            City = city;
            State = state;
            Zip = zip;
            Phone = phone;
            OwnerName = ownerName;
        }
    }
}
