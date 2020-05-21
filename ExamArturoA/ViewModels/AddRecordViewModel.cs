using System;
using System.Collections.Generic;
using ExamArturoA.Models.Objetcs;
using Newtonsoft.Json;

namespace ExamArturoA.ViewModels
{
    /// <summary>
    /// ViewModel for a new record
    /// </summary>
    public class AddRecordViewModel : BaseViewModel
    {

        private string userTitle;
        public string UserTitle 
        {
            get { return userTitle; }
            set { SetProperty(ref userTitle, value); OnPropertyChanged(UserTitle); }
        }

        private string first;
        public string First
        {
            get { return first; }
            set { SetProperty(ref first, value); OnPropertyChanged(First); }
        }

        private string last;
        public string Last
        {
            get { return last; }
            set { SetProperty(ref last, value); OnPropertyChanged(Last); }
        }

        private string email;
        public string Email
        {
            get { return email; }
            set { SetProperty(ref email, value); OnPropertyChanged(Email); }
        }

        private string street;
        public string Street
        {
            get { return street; }
            set { SetProperty(ref street, value); OnPropertyChanged(Street); }
        }

        private string city;
        public string City
        {
            get { return city; }
            set { SetProperty(ref city, value); OnPropertyChanged(City); }
        }

        private string country;
        public string Country
        {
            get { return country; }
            set { SetProperty(ref country, value); OnPropertyChanged(Country); }
        }

        private string zipCode;
        public string ZipCode
        {
            get { return zipCode; }
            set { SetProperty(ref zipCode, value); OnPropertyChanged(ZipCode); }
        }

        /// <summary>
        /// Const
        /// </summary>
        public AddRecordViewModel()
        {
            Title = "Nuevo usuario";
        }

        /// <summary>
        /// Validate fiels before save
        /// </summary>
        /// <returns></returns>
        public bool ValidateField()
        {
            var fields = new List<string>() { UserTitle, First, Last, Email, Street, City, Country, ZipCode };
            foreach(var field in fields)
            {
                if(String.IsNullOrEmpty(field))
                {
                    return false;
                }
            }
            return true;
        }

        /// <summary>
        /// Save record
        /// </summary>
        /// <returns></returns>
        public string SaveRecord()
        {
            var newLocation = new LocationDTO() { Street = new StreetDTO() { Name = Street }, City = City, Country = Country, Postcode = ZipCode };
            var newName = new NameDTO() { Title = UserTitle, First = First, Last = Last };
            var newResult = new ResultDTO() { Email = Email, Location = newLocation, Name = newName };
            return JsonConvert.SerializeObject(newResult);
        }
    }
}
