using System;

namespace UniversityExamination
{
    // Abstract Class
    abstract class Student
    {
        protected string RollNo;
        protected string Name;
        protected int Subjects;

        public Student(string rollNo, string name, int subjects)
        {
            RollNo = rollNo;
            Name = name;
            Subjects = subjects;
        }

        // Abstract Method (Polymorphism)
        public abstract int CalculateFee();

        public void GenerateHallTicket()
        {
            Console.WriteLine("\n----- HALL TICKET -----");
            Console.WriteLine("Roll No : " + RollNo);
            Console.WriteLine("Name    : " + Name);
            Console.WriteLine("Subjects: " + Subjects);
        }

        public void PublishResult()
        {
            Random r = new Random();
            int marks = r.Next(35, 101);

            Console.WriteLine("\n----- RESULT -----");
            Console.WriteLine("Marks  : " + marks);
            Console.WriteLine(marks >= 40 ? "Status : PASS" : "Status : FAIL");
        }

        public void NotifyStudent()
        {
            Console.WriteLine("\nNotification: Result has been declared.");
        }
    }

    class Regular : Student
    {
        public Regular(string rollNo, string name, int subjects)
            : base(rollNo, name, subjects) { }

        public override int CalculateFee()
        {
            return Subjects * 500;
        }
    }

    class ATKT : Student
    {
        public ATKT(string rollNo, string name, int subjects)
            : base(rollNo, name, subjects) { }

        public override int CalculateFee()
        {
            return Subjects * 700;
        }
    }

    class Repeater : Student
    {
        public Repeater(string rollNo, string name, int subjects)
            : base(rollNo, name, subjects) { }

        public override int CalculateFee()
        {
            return Subjects * 900;
        }
    }

    class Program
    {
        static void Main()
        {
            try
            {
                Console.Write("Enter Roll Number: ");
                string roll = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(roll))
                    throw new Exception("Invalid Registration Details!");

                Console.Write("Enter Student Name: ");
                string name = Console.ReadLine();

                Console.Write("Enter Number of Subjects: ");
                int subjects = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("\nStudent Category");
                Console.WriteLine("1. Regular");
                Console.WriteLine("2. ATKT");
                Console.WriteLine("3. Repeater");

                Console.Write("Enter Choice: ");
                int choice = Convert.ToInt32(Console.ReadLine());

                Student student;

                switch (choice)
                {
                    case 1:
                        student = new Regular(roll, name, subjects);
                        break;

                    case 2:
                        student = new ATKT(roll, name, subjects);
                        break;

                    case 3:
                        student = new Repeater(roll, name, subjects);
                        break;

                    default:
                        throw new Exception("Invalid Student Category!");
                }

                Console.WriteLine("\nExamination Fee = ₹" + student.CalculateFee());

                student.GenerateHallTicket();

                student.PublishResult();

                student.NotifyStudent();
            }
            catch (Exception ex)
            {
                Console.WriteLine("\nError: " + ex.Message);
            }

            Console.ReadKey();
        }
    }
}
