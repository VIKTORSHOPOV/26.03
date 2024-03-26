using System;

namespace _7._4
{
    internal class Student
    {
        private string firstName = "???";
        private string middleName = "???";
        private string lastName = "???";
        private int id = int.MaxValue;
        private string specialty = "???";
        private int course = int.MaxValue;

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public string MiddleName
        {
            get { return middleName; }
            set { middleName = value; }
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Specialty
        {
            get { return specialty; }
            set { specialty = value; }
        }

        public int Course
        {
            get { return course; }
            set { course = value; }
        }

        public Student()
        {

        }

        public Student(string firstName, string middleName, string lastName, int id, string specialty, int course)
        {
            this.firstName = firstName;
            this.middleName = middleName;
            this.lastName = lastName;
            this.id = id;
            this.specialty = specialty;
            this.course = course;
        }

        public Student(string firstName, string middleName, string lastName)
        {
            this.firstName = firstName;
            this.middleName = middleName;
            this.lastName = lastName;
        }

        public Student(string firstName, string middleName, string lastName, int course)
        {
            this.firstName = firstName;
            this.middleName = middleName;
            this.lastName = lastName;
            this.course = course;
        }

        public static void Info(Student student)
        {
            Console.WriteLine(student.FirstName);
            Console.WriteLine(student.MiddleName);
            Console.WriteLine(student.LastName);
            Console.WriteLine(student.Id);
            Console.WriteLine(student.Specialty);
            Console.WriteLine(student.Course);
            Console.WriteLine();
        }
    }
}
