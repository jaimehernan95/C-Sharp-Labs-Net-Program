namespace CommonData
{
    using System;

    public class Person
    {
        private string firstName;
        private string lastName;
        private DateTime? dateOfBirth;
        private string address;
        private string city;
        private string country;

        public string FirstName { 
            get {
                return firstName;
            }
            set {
                firstName = value;
            }
        }
        public string LastName {
            get {
                return lastName;
            } 
            set {
                lastName = value;
            } 
        }
        public DateTime? DateOfBirth { 
            get { 
                return dateOfBirth; 
            } 
            set {
                dateOfBirth = value;
            } 
        }
        public string Address
        {
            get
            {
                return address;
            }
            set
            {
                address = value;
            }
        }
        public string City
        {
            get
            {
                return city;
            }
            set
            {
                city = value;
            }
        }
        public string Country
        {
            get
            {
                return country;
            }
            set
            {
                country = value;
            }
        }

        public Person()
        {

        }

        public Person(string _firstName, string _lastName, DateTime? _dateOfBirth, string _address, string _city, string _country)
        {
            firstName = _firstName;
            lastName = _lastName;
            dateOfBirth = _dateOfBirth;
            address = _address;
            city = _city;
            country = _country;
        }

        public void DisplayInfo()
        {
            Console.WriteLine("Person data:");
            Console.WriteLine("First name: {0}", firstName);
            Console.WriteLine("Last name: {0}", lastName);
            Console.WriteLine("Date of birth: {0}", dateOfBirth != null ?dateOfBirth.Value.ToString("MMMM dd, yyyy"):"");
            Console.WriteLine("Address: {0}", address);
            Console.WriteLine("City: {0}", city);
            Console.WriteLine("Country: {0}", country);
        }

    }
}
