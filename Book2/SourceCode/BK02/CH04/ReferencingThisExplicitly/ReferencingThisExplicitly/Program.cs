using System;

// ReferencingThisExplicitly -- Demonstrates how to explicitly use
//    the reference to 'this'.
namespace ReferencingThisExplicitly
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a student.
            Student student = new Student();
            student.Init("Stephen Davis", 1234);

            // Now enroll the student in a course.
            Console.WriteLine
                   ("Enrolling Stephen Davis in Biology 101");
            student.Enroll("Biology 101");

            // Display student course.
            Console.WriteLine("Resulting student record:");
            student.DisplayCourse();

            // Wait for user to acknowledge the results.
            Console.WriteLine("Press Enter to terminate...");
            Console.Read();
        }
    }

    // Student -- The class for university students.
    public class Student
    {
        // All students have a name and an id.
        public string _name;
        public int _id;

        // The course in which the student is enrolled
        CourseInstance _courseInstance;

        // Init -- Initialize the student object.
        public void Init(string name, int id)
        {
            this._name = name;
            this._id = id;
            _courseInstance = null;
        }

        // Enroll -- Enroll the current student in a course.
        public void Enroll(string courseID)
        {
            _courseInstance = new CourseInstance();
            _courseInstance.Init(this, courseID); // The explicit reference.
        }

        // Display the name of the student and the course.
        public void DisplayCourse()
        {
            Console.WriteLine(_name);
            _courseInstance.Display();
        }
    }

    // CourseInstance -- A combination of a student with
    //    a university course.
    public class CourseInstance
    {
        public Student _student;
        public string _courseID;

        // Init -- Tie the student to the course.
        public void Init(Student student, string courseID)
        {
            this._student = student;
            this._courseID = courseID;
        }

        // Display -- Output the name of the course.
        public void Display()
        {
            Console.WriteLine(_courseID);
        }
    }
}
