using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// InvokeMethod -- Invoke a member method through the object.
namespace InvokeMethod
{
    class Student
    {
        // The name information to describe a student
        public string firstName;
        public string lastName;

        // SetName -- Save name information. (Nonstatic.)
        public void SetName(string fName, string lName)
        {
            firstName = fName;
            lastName = lName;
        }

        // ToNameString -- Convert the student object into a
        //    string for display. (Nonstatic.)
        public string ToNameString()
        {
            string s = firstName + " " + lastName;
            return s;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            student.SetName("Stephen", "Davis"); // Call instance method.
            Console.WriteLine("Student's name is "
                             + student.ToNameString());

            // Wait for user to acknowledge.
            Console.WriteLine("Press Enter to terminate...");
            Console.Read();
        }
    }
}
