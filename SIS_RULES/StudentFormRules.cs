using System;
using SIS_UI;
using SIS_MODEL;
using SIS_DATA;
using AM_Rules;

namespace SIS_RULES
{
    public class StudentFormRules
    {
        public static string sisAccoutNumber;
        public static InMemoryStudentPersonalInfo personalinfo = new InMemoryStudentPersonalInfo();

        public static void actionStudentWelcomePage()
        {
            SqlClient sql = new SqlClient();

            int status;
            int action;
            do
            {
                status = StudentForm.studentWelcomePage();
                switch (status)
                {
                    case 0:
                        FacultyForm.logOut();
                        break;
                    case 1: //student information
                        sql.showStudentInfo(StudentForm.username);
                        actionStudentWelcomePage();
                        break;

                    case 2: //personal information
                        status = StudentForm.actionStudentPersonalInfo();
                        switch (status)
                        {
                            case 0:
                                StudentForm.cancel();
                                actionStudentWelcomePage(); break;
                            case 1:
                                sql.showStudentPersonalInfo(StudentForm.username);
                                actionStudentWelcomePage();
                                break;
                            case 2:
                                //doUpdate();
                                action = StudentForm.actionUpdateStudentPersonalInfo();
                                switch (action)
                                {
                                    //cancel
                                    case 0:
                                        StudentForm.cancel();
                                        actionStudentWelcomePage(); break;
                                    //SIS Account
                                    case 1: StudentForm.nonEditable(); break;
                                    //Name
                                    case 2: StudentForm.nonEditable(); break;
                                    //Gender
                                    case 3: StudentForm.nonEditable(); break;
                                    //Date Of Birth
                                    case 4: StudentForm.nonEditable(); break;
                                    //Place Of Birth
                                    case 5:
                                        //doUpdatePOB(); 
                                        sql.updatePlaceOfBirth(StudentForm.username);
                                        break;
                                    //Mobile Number
                                    case 6:
                                        //doUpdateMobile(); 
                                        sql.updateMobileNumber(StudentForm.username);
                                        break;
                                    //Email Address
                                    case 7: 
                                        //doUpdateEmailAddress(); 
                                        sql.updateEmailAddress(StudentForm.username);
                                        break;
                                    //Residential Add
                                    case 8:
                                        //doUpdateResidentialAddress(); 
                                        sql.updateResidentialAddress(StudentForm.username);
                                        break;
                                    //Permanent Add
                                    case 9:
                                        //doUpdatePermanentAddress(); 
                                        sql.updatePermanentAddress(StudentForm.username);
                                        break;

                                }
                                actionStudentWelcomePage();
                                break;
                        }

                        break;

                    case 3: 
                        StudentForm.gradingSystem();
                        actionStudentWelcomePage();
                        break;

                    case 4: 
                        StudentForm.attendance();
                        actionStudentWelcomePage(); 
                        break;

                    case 5:
                        //Schedule
                        action = StudentForm.scheduleSystem();
                        switch (action)
                        {
                            case 0:
                                actionStudentWelcomePage(); 
                                break;
                            case 1:
                                sql.viewMondaySchedule();
                                
                                break;
                            case 2:
                                sql.viewTuesdaySchedule();
                                
                                break;
                            case 3:
                                sql.viewMondaySchedule();
                                
                                break;
                            case 4:
                                sql.viewThursdaySchedule();
                                
                                break;
                            case 5:
                                sql.viewMondaySchedule();
                                
                                break;
                            case 6:
                                sql.viewSaturdaySchedule();
                               
                                break;
                        }
                        actionStudentWelcomePage();
                        break;

                    case 6:
                        //Subject
                        Subject subj = new Subject();
                        sql.viewSubject(subj.course);
                        actionStudentWelcomePage();
                        break;

                    default:
                        StudentForm.invalidInput();
                        actionStudentWelcomePage();
                        break;
                }
            } while (status == null);
        }

    }
}

