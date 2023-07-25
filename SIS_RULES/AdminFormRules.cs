using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SIS_UI;
using SIS_MODEL;
using SIS_DATA;
using AM_Rules;


namespace SIS_RULES
{
    public class AdminFormRules
    {
        //SqlClient sql = new SqlClient();
        public static void actionAdminFacultyWelcomePage()
        {
            SqlClient sql = new SqlClient();

            int status;
            do
            {
                status = AdminForm.adminWelcomePage();
                switch (status)
                {
                    case 0:
                        AdminForm.logOut();
                        break;

                    case 1: //admin information
                        sql.showAdminInfo(StudentForm.username);
                        actionAdminFacultyWelcomePage();
                        break;

                    case 2:

                        break;

                    case 3:

                        break;

                    case 4:

                        break;
                }
            } while (status == null);
        }
    }
}
