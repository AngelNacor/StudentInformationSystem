﻿using System;
using SIS_UI;
using SIS_MODEL;
using SIS_DATA;
using AM_Rules;

namespace SIS_RULES
{
    public class FacultyFormRules
    {
        public static void actionFacultyWelcomePage()
        {
            SqlClient sql = new SqlClient();

            int status;
            do
            {
                status = FacultyForm.facultyWelcomePage();
                switch (status)
                {
                    case 0: //log out
                        FacultyForm.logOut();
                        break;

                    case 1: //Faculty Information
                        //PrintInfos.PrintFacultyInfo(StudentForm.username);
                        sql.showFacultyInfo(StudentForm.username);
                        actionFacultyWelcomePage();
                        break;

                    case 2: //Grading System
                        FacultyForm.gradingSystem();
                        actionFacultyWelcomePage();
                        break;
                    case 3: //Attendance
                        FacultyForm.attendance();
                        actionFacultyWelcomePage();
                        break;

                    case 4://Schedule
                        sql.viewFacultySchedule(StudentForm.username);
                        actionFacultyWelcomePage();
                        break;
                    case 5://subject
                        sql.showFacultySubject(StudentForm.username);
                        actionFacultyWelcomePage();
                        break;
                    default:
                        StudentForm.invalidInput();
                        actionFacultyWelcomePage();
                        break;
                }
            } while (status == null);
        }
    }
}

