using System;
using System.Collections.Generic;
using System.Text;

namespace CommonData
{
    public class Employee : Person
    {
        private int employeeId;
        private string title;
        private double salary;
        public int EmployeeId
        {
            get
            {
                return employeeId;
            }
            set
            {
                employeeId = value;
            }
        }

        public string Title
        {
            get
            {
                return title;
            }
            set
            {
                title = value;
            }
        }

        public double Salary
        {
            get
            {
                return salary;
            }
            set
            {
                salary = value;
            }
        }

        public Employee() : base()
        {

        }

        public Employee(string _firstName, string _lastName, DateTime? _dateOfBirth,
            string _address, string _city, string _country,
            int _employeeId, string _title, double _salary) : base(_firstName, _lastName, _dateOfBirth, _address, _city, _country)
        {
            employeeId = _employeeId;
            title = _title;
            salary = _salary;
        }

        public new void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine("Employee Extra data:");
            Console.WriteLine("Employee Id: {0}", employeeId);
            Console.WriteLine("Employee title: {0}", title);
            Console.WriteLine("Employee salary: {0}", salary);
        }


    }
}
