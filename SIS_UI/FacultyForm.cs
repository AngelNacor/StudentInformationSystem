using System;
namespace SIS_UI
{
    public class FacultyForm
    {
        public static int facultyWelcomePage()
        {
            Console.WriteLine("\nPlease choose an action: ");
            Console.WriteLine("[0]Log out");
            Console.WriteLine("[1]Faculty Information");
            Console.WriteLine("[2]Grading System");
            Console.WriteLine("[3]Attendance");
            Console.WriteLine("[4]Schedule");
            Console.WriteLine("[5]Subject");
            Console.Write("Input: ");
            string input = Console.ReadLine();
            int option;

            while (!int.TryParse(input, out option))
            {
                Console.WriteLine("\nInvalid input. Please enter a valid option.");
                Console.Write("Input: ");
                input = Console.ReadLine();
            }

            return option;
        }

        //Method for log out
        public static void logOut()
        {
            Console.WriteLine("\nLog out Successfully\n");
            Environment.Exit(0);
        }

        //method for calling attendance system
        public static void attendance()
        {
            Console.WriteLine("On progress of Nico's Group");
        }

        //method for callig grading system
        public static void gradingSystem()
        {
            Console.WriteLine("\nOn Progress of Rizon's Group\n");
        }
    }
}

