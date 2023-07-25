using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SIS_MODEL;

namespace SIS_UI
{
    public class ShowInformation
    {
        
        public static void ShowStudentPersonalInfo(StudentPersonalInfo student)
        {
            //StudentPersonalInfo student = new StudentPersonalInfo();

            Console.WriteLine($"\nSIS Account Number: {student.SISAccountNumber}\n" +
                    $"Full Name: {student.fullname}\n" +
                    $"Gender: {student.Gender}\n" +
                    $"Date Of Birth: {student.DateofBirth}\n" +
                    $"Place Of Birth: {student.placeofBirth}\n" +
                    $"Mobile Number: {student.mobileNo}\n" +
                    $"Email Address: {student.emailAddress}\n" +
                    $"Residential Address: {student.residentialAddress}\n" +
                    $"Permanent Address: {student.permanentAdress}");
        }

        public static void ShowStudentInfo(StudentInfo studentInfo)
        {
            Console.WriteLine($"\nSIS Account Number: {studentInfo.SISAccountNumber}\n" +
                    $"Full Name: {studentInfo.fullName}\n" +
                    $"Course: {studentInfo.course}\n" +
                    $"Year: {studentInfo.year}\n" +
                    $"Section: {studentInfo.section}\n");
        }

        public static void showFacultyInfo(FacultyInfo facultyInfo)
        {
            Console.WriteLine($"\nFaculty Number: {facultyInfo.facultyNumber}\n" +
                    $"Faculty Name: {facultyInfo.facultyName}\n" +
                    $"Subject Held: {facultyInfo.subjectHeld}\n" +
                    $"Email Address: {facultyInfo.email}\n");
        }

        public static void showAdminInfo(AdminInfo adminInfo)
        {
            Console.WriteLine($"\nAdmin Number: {adminInfo.adminNumber}\n" +
                    $"Admin Name: {adminInfo.adminName}\n" +
                    $"Email Address: {adminInfo.emailAddress}\n");
        }

        public static void showSchedule(Schedule sched)
        {
            Console.WriteLine($"\nSubject Code: {sched.subjectCode}\n"+
                $"Description: {sched.description}\n" +
                $"Lecture : {sched.lecture}\n"+
                $"Laboratory: {sched.laboratory}\n"+
                $"Unit: {sched.unit}\n"+
                $"Time: {sched.time}\n"+
                $"Day: {sched.day}\n"+
                $"Instructor: {sched.instructor}\n");
        }

        public static void showSubject(Subject subj)
        {
            Console.WriteLine($"\nSubject Code: {subj.subjectCode}\n"+
                $"Prerequisite: {subj.prereq}\n"+
                $"Description: {subj.description}\n+" +
                $"Unit: {subj.unit}\n" +
                $"Course: {subj.course}\n" +
                $"Year: {subj.year}\n" +
                $"Semester: {subj.semester}\n");
        }

        public static void showFacultySched(Schedule sched)
        {
            Console.WriteLine($"\nSubject Code: {sched.subjectCode}\n"+
                $"Description: {sched.description}\n" +
                $"Time: {sched.time}\n" +
                $"Day: {sched.day}\n" +
                $"Instructor: {sched.instructor}\n");
        }

        public static void showFacultySubject(Schedule sched)
        {
            Console.WriteLine($"\nSubject Code: {sched.subjectCode}\n" +
               $"Description: {sched.description}\n" +
               $"Instructor: {sched.instructor}\n");
        }

        public static void showStudentEnrolled(StudentInfo student)
        {
            Console.WriteLine($"\nSIS Account Number: {student.SISAccountNumber}\t"+
                $"Student Name: {student.fullName}\t" +
                $"Course: {student.course}\t");
        }

    }
}
