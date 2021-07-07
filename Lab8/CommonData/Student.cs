namespace CommonData
{
    using System;
    using System.Text;

    public class Student: Person
    {
        private int studentId;
        private int[] grade;
        public int StudentId
        {
            get
            {
                return studentId;
            }
            set
            {
                studentId = value;
            }
        }

        public int[] Grade
        {
            get
            {
                return grade;
            }
            set
            {
                grade = value;
            }
        }

        public Student():base()
        {

        }

        public Student(string _firstName, string _lastName, DateTime? _dateOfBirth, 
            string _address, string _city, string _country,
            int _studentId, int[] _grade):base(_firstName, _lastName, _dateOfBirth, _address, _city, _country)
        {
            studentId = _studentId;
            grade = _grade;
        }

        public new void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine("Student Extra data:");
            Console.WriteLine("Student Id: {0}", studentId);
            StringBuilder strGrades = new StringBuilder("[");
            foreach (int i in grade)
                strGrades.Append(i.ToString() + ", ");
            strGrades.Remove(strGrades.Length -2,2);
            strGrades.Append("]");

            Console.WriteLine("Grades: {0}", strGrades.ToString());
        }


    }
}
