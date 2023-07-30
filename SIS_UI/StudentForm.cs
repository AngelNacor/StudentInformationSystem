using System;

namespace SIS_UI
{
    public class StudentForm
    {
        public static string username;

        //Welcome Page
        public static int studentWelcomePage()
        {
            Console.WriteLine("\nPlease choose an action: ");
            Console.WriteLine("[0]Log out");
            Console.WriteLine("[1]Student Information");
            Console.WriteLine("[2]Personal Information");
            Console.WriteLine("[3]Grading System");
            Console.WriteLine("[4]Attendance");
            Console.WriteLine("[5]Schedule");
            Console.WriteLine("[6]Subject");
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

        //Interface when clicked Personal Information 
        public static int actionStudentPersonalInfo()
        {
            Console.WriteLine("\nPlease choose an action: ");
            Console.WriteLine("[0]Go Back");
            Console.WriteLine("[1]View Student Personal Information");
            Console.WriteLine("[2]Update Student Personal Information");
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

        //Interface when updating an Personal Information
        public static int actionUpdateStudentPersonalInfo()
        {
            Console.WriteLine("\nCurrent personal information\n");

            Console.WriteLine("\nEDIT PERSONAL INFORMATION\n");
            Console.WriteLine("Please choose an action: ");
            Console.WriteLine("[0] - Cancel");
            Console.WriteLine("[1] - Name");
            Console.WriteLine("[2] - Birthday");
            Console.WriteLine("[3] - SIS Account Number");
            Console.WriteLine("[4] - Date of Birth");
            Console.WriteLine("[5] - Place of Birth");
            Console.WriteLine("[6] - Mobile Number");
            Console.WriteLine("[7] - Email Address");
            Console.WriteLine("[8] - Residential Address");
            Console.WriteLine("[9] - Permanent Address");
            Console.Write("Input: ");
            return Convert.ToInt32(Console.ReadLine());
        }

        public static string getSISAcc()
        {
            Console.WriteLine("\nEnter the SIS account number of the student to verify changes:");
            return Console.ReadLine();
        }
        public static string updatePlaceOfBirth()
        {
            Console.WriteLine("\nEnter new Place Of Birth: ");
            return Console.ReadLine();
        }

        public static string updateEmailAddress()
        {
            Console.WriteLine("Enter new Email Address: ");
            return Console.ReadLine();
        }

        public static string updateResidentialAdd()
        {
            Console.WriteLine("Enter new Residential Address: ");
            return Console.ReadLine();
        }

        public static string updatePermanentAdd()
        {
            Console.WriteLine("Enter new Permanent Address: ");
            return Console.ReadLine();
        }

        public static string updateContactNumber()
        {
            Console.WriteLine("Enter new Contact Number: ");
            return Console.ReadLine();
        }

        //method to call success update
        public static void successUpdate()
        {
            Console.WriteLine("\nStudent personal information updated successfully.");
            Console.WriteLine("Here's the updated personal information\n");

        }

        public static void nonEditable()
        {
            Console.WriteLine("\nThis information is not editable");
            Console.WriteLine("Please try again");
        }

        public static void attendance()
        {
            Console.WriteLine("\nOn progress of Nico's Group");
        }

        public static void gradingSystem()
        {
            Console.WriteLine("\nOn Progress of Rizon's Group\n");
        }

        public static int scheduleSystem()
        {
            Console.WriteLine("\nPlease Choose an Action:");
            Console.WriteLine("[1] Monday");
            Console.WriteLine("[2] Tuesday");
            Console.WriteLine("[3] Wednesday");
            Console.WriteLine("[4] Thursday");
            Console.WriteLine("[5] Friday");
            Console.WriteLine("[6] Saturday");
            Console.Write("Input: ");
            return Convert.ToInt32(Console.ReadLine());
        }

        public static void scheduleMonday()
        {
            Console.WriteLine("\nNo schedule");
        }

        public static void cancel()
        {
            Console.WriteLine("System detected: Cancel");
        }

        public static void invalidInput()
        {
            Console.WriteLine("\nInvalid input. Please enter a valid option.");
        }

    }
}

