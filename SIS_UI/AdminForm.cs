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
        public static int adminWelcomePage()
        {
            Console.WriteLine("\nPlease choose an action: ");
            Console.WriteLine("[0]Log out");
            Console.WriteLine("[1]Admin Information");
            //Console.WriteLine("[2]Personal Information");
            Console.WriteLine("[2]TBA");
            Console.WriteLine("[3]TBA");
            Console.WriteLine("[4]TBA");
            Console.Write("Input: ");
            return Convert.ToInt32(Console.ReadLine());
        }

        public static void logOut()
        {
            Console.WriteLine("\nLog out Successfully\n");
            Environment.Exit(0);
            //Console.ReadKey();
        }


    }
}
