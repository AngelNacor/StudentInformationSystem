using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SIS_UI
{
    public class AdminForm
    {
        //SqlClient sql = new SqlClient();
        public static string subjcode;
        public static int adminWelcomePage()
        {
            Console.WriteLine("\nPlease choose an action: ");
            Console.WriteLine("[0]Log out");
            Console.WriteLine("[1]Admin Information");
            //Console.WriteLine("[2]Personal Information");
            Console.WriteLine("[2]Schedule");
            Console.WriteLine("[3]Subject");
            //Console.WriteLine("[4]TBA");
            Console.Write("Input: ");
            return Convert.ToInt32(Console.ReadLine());
        }

        public static int adminSchedule()
        {
            Console.WriteLine("\nPlease choose an action: ");
            Console.WriteLine("[0]Cancel");
            Console.WriteLine("[1]View Schedule");
            Console.WriteLine("[2]Add Schedule");
            Console.WriteLine("[3]Update Schedule");
            Console.WriteLine("[4]Delete Schedule");
            Console.Write("Input: ");
            return Convert.ToInt32(Console.ReadLine());


        }

        public static int updateSchedule()
        {
            Console.WriteLine("\nPlease choose an action: ");
            Console.WriteLine("[0]Cancel");
            Console.WriteLine("[1]Update Time");
            Console.WriteLine("[2]Update Day");
            Console.WriteLine("[3]Update Instructor");
            Console.Write("Input: ");
            return Convert.ToInt32(Console.ReadLine());
        }

        public static int adminSubject()
        {
            Console.WriteLine("\nPlease choose an action: ");
            Console.WriteLine("[0]Cancel");
            Console.WriteLine("[1]View Subject");
            Console.WriteLine("[2]Add Subject");
            Console.WriteLine("[3]Delete Schedule");
            Console.Write("Input: ");
            return Convert.ToInt32(Console.ReadLine());
        }

        public static string updateTime()
        {
            //Console.ReadKey();

            Console.WriteLine("\nEnter new time: ");
            return Console.ReadLine();
        }

        public static string updateDay()
        {
            Console.WriteLine("\nEnter new Day: ");
            return Console.ReadLine();
        }

        public static string updateInstructor()
        {
            Console.WriteLine("\nEnter new Instructor: ");
            return Console.ReadLine();
        }

        public static string verifySubjCode()
        {
            Console.WriteLine("\nEnter Subject Code you want to Edit/Delete");
            return Console.ReadLine();
        }

        public static string addSubjectCode()
        {
            Console.WriteLine("\nEnter a Subject Code: ");
            return Console.ReadLine();
        }

        public static string addDescription()
        {
            Console.WriteLine("\nEnter Description: ");
            return Console.ReadLine();
        }

        public static int addLecture()
        {
            Console.WriteLine("\nEnter lecture: ");
            //return Convert.ToInt32(Console.ReadLine());
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

        public static int addLaboratory()
        {
            Console.WriteLine("\nEnter laboratory: ");
            //return Convert.ToInt32(Console.ReadLine());
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

        public static int addUnit()
        {
            Console.WriteLine("\nEnter unit: ");
            //return Convert.ToInt32(Console.ReadLine());
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

        public static string addSchedule()
        {
            Console.WriteLine("\nEnter Schedule: ");
            return Console.ReadLine();
        }

        public static string addDay()
        {
            Console.WriteLine("\nEnter Day: ");
            return Console.ReadLine();
        }

        public static string addInstructor()
        {
            Console.WriteLine("\nEnter Instructor: ");
            return Console.ReadLine();
        }

        public static int addNo()
        {
            Console.WriteLine("\nEnter number: ");
            //return Convert.ToInt32(Console.ReadLine());
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

        public static string prereq()
        {
            Console.WriteLine("\nEnter prerequisite: ");
            return Console.ReadLine();
        }

        public static string addCourse()
        {
            Console.WriteLine("\nEnter course: ");
            return Console.ReadLine();
        }

        public static int addYear()
        {
            Console.WriteLine("\nEnter year: ");
            //return Convert.ToInt32(Console.ReadLine());
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

        public static string addSemester()
        {
            Console.WriteLine("\nEnter semester: ");
            return Console.ReadLine();
        }

        public static void logOut()
        {
            Console.WriteLine("\nLog out Successfully\n");
            Environment.Exit(0);
            //Console.ReadKey();
        }

        public static void addSuccess()
        {
            Console.WriteLine("\nsuccessfully added");
        }

        public static void updateSuccess()
        {
            Console.WriteLine("\nSchedule successfully updated");
        }

        public static void updatedError()
        {
            Console.WriteLine("\nERROR: Cannot find Subject Code");
        }

        public static void DeleteSuccess()
        {
            Console.WriteLine("\nDelete successfully");
        }
    }
}
