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
                        status = AdminForm.adminSchedule();
                        switch (status)
                        {
                            case 0://cancel
                                actionAdminFacultyWelcomePage();
                                break;

                            case 1://view all schedule
                                sql.viewAdminSchedule();
                                break;

                            case 2://add
                                sql.addSchedule();
                                break;

                            case 3://update
                                status = AdminForm.updateSchedule();
                                switch (status)
                                {
                                    case 0://cancel

                                        break;

                                    case 1://time
                                        sql.updateTime();
                                        break;

                                    case 2://day
                                        sql.updateDay();
                                        break;

                                    case 3://instructor
                                        sql.updateInstructor();
                                        break;

                                }
                                break;

                            case 4://delete
                                sql.deleteSchedule();
                                break;
                        }
                        actionAdminFacultyWelcomePage();
                        break;

                    case 3:

                        actionAdminFacultyWelcomePage();
                        break;

                    case 4:

                        actionAdminFacultyWelcomePage();
                        break;
                }
            } while (status == null);
        }
    }
}
