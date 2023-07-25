﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Net.NetworkInformation;
using SIS_MODEL;
using System.Diagnostics;
using SIS_UI;
using System.Net.Mail;

namespace SIS_DATA
{
    public class SqlClient 
    {
        private string connectionString
        = "Data Source=LAPTOP-EKPAGTRE\\SQLEXPRESS;Initial Catalog=PUPStudentInformationSytem;Integrated Security=True;";
        //= "Server=tcp://,1433;Database=PUPPoints;User Id=sa;Password=indaleenq727!;";
        private SqlConnection sqlConnection;

        public SqlClient()
        {
            sqlConnection = new SqlConnection(connectionString);
        }

        //instantiating classes
        StudentPersonalInfo student = new StudentPersonalInfo();
        StudentInfo studentInfo = new StudentInfo();
        FacultyInfo facultyInfo = new FacultyInfo();
        AdminInfo adminInfo = new AdminInfo();
        Schedule sched = new Schedule();
        Subject subj = new Subject();

        //method for viewing student personal information
        public void showStudentPersonalInfo(string sisAccountNumber)
        {
            string sqlQuery = "SELECT * FROM StudentPersonalInfo where SISAccountNumber = @SISAccountNumber";
            SqlCommand command = new SqlCommand(sqlQuery, sqlConnection);
            sqlConnection.Open();
            command.Parameters.AddWithValue("@SISAccountNumber", sisAccountNumber);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                //StudentPersonalInfo student = new StudentPersonalInfo();
                student.SISAccountNumber = reader.GetString(1);
                student.fullname = reader.GetString(2);
                student.Gender = reader.GetString(3);
                student.DateofBirth = reader.GetDateTime(4);
                student.placeofBirth = reader.GetString(5);
                student.mobileNo = reader.GetString(6);
                student.emailAddress = reader.GetString(7);
                student.residentialAddress = reader.GetString(8);
                student.permanentAdress = reader.GetString(9);

                //SIS_UI
                ShowInformation.ShowStudentPersonalInfo(student);
            }
            sqlConnection.Close();
        }

        //method to view Student Information
        public void showStudentInfo(string sisAccountNumber)
        {
            string sqlQuery = "SELECT * FROM StudentInfo where SISAccountNumber = @SISAccountNumber";
            SqlCommand command = new SqlCommand(sqlQuery, sqlConnection);
            sqlConnection.Open();
            command.Parameters.AddWithValue("@SISAccountNumber", sisAccountNumber);
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                studentInfo.SISAccountNumber = reader.GetString(1);
                studentInfo.fullName = reader.GetString(2);
                studentInfo.course = reader.GetString(3);
                studentInfo.year = reader.GetInt32(4);
                studentInfo.section = reader.GetInt32(5);

                //SIS_UI
                ShowInformation.ShowStudentInfo(studentInfo);
            }
            sqlConnection.Close();
        }

        //method to view faculty info
        public void showFacultyInfo(string facultyNumber)
        {
            string sqlQuery = "SELECT * FROM FacultyInfo where FacultyNumber = @FacultyNumber";
            SqlCommand command = new SqlCommand(sqlQuery, sqlConnection);
            sqlConnection.Open();
            command.Parameters.AddWithValue("@FacultyNumber", facultyNumber);
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                facultyInfo.facultyNumber = reader.GetString(1);
                facultyInfo.facultyName = reader.GetString(2);
                facultyInfo.subjectHeld = reader.GetString(3);
                facultyInfo.email = reader.GetString(4);

                //SIS_UI
                ShowInformation.showFacultyInfo(facultyInfo);
            }
            sqlConnection.Close();
        }

        //method to view admin info
        public void showAdminInfo(string adminNumber)
        {
            string sqlQuery = "SELECT * FROM AdminInfo where AdminNumber = @AdminNumber";
            SqlCommand command = new SqlCommand(sqlQuery, sqlConnection);
            sqlConnection.Open();
            command.Parameters.AddWithValue("@AdminNumber", adminNumber);
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                adminInfo.adminNumber = reader.GetString(1);
                adminInfo.adminName = reader.GetString(2);
                adminInfo.emailAddress = reader.GetString(3);

                ShowInformation.showAdminInfo(adminInfo);
            }
            sqlConnection.Close();
        }

        //method to call monday schedule
        public void viewMondaySchedule()
        {
            String Day = "Monday";
            string sqlQuery = "SELECT * FROM Schedule where Day = @Day";
            SqlCommand command = new SqlCommand(sqlQuery,sqlConnection);
            sqlConnection.Open();
            command.Parameters.AddWithValue("@Day", Day);
            SqlDataReader reader = command.ExecuteReader();

           
            
                if (reader.HasRows)
                {
                while (reader.Read())
                {
                    sched.subjectCode = reader.GetString(1);
                    sched.description = reader.GetString(2);
                    sched.lecture = reader.GetInt32(3);
                    sched.laboratory = reader.GetInt32(4);
                    sched.unit = reader.GetInt32(5);
                    sched.time = reader.GetString(6);
                    sched.day = reader.GetString(7);
                    sched.instructor = reader.GetString(8);

                    ShowInformation.showSchedule(sched);
                }
                }
                else
                {
                    StudentForm.scheduleMonday();
                }
            
            sqlConnection.Close();

        }

        public void viewTuesdaySchedule()
        {
            String Day = "Tuesday";
            string sqlQuery = "SELECT * FROM Schedule where Day = @Day";
            SqlCommand command = new SqlCommand(sqlQuery, sqlConnection);
            sqlConnection.Open();
            command.Parameters.AddWithValue("@Day", Day);
            SqlDataReader reader = command.ExecuteReader();



            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    sched.subjectCode = reader.GetString(1);
                    sched.description = reader.GetString(2);
                    sched.lecture = reader.GetInt32(3);
                    sched.laboratory = reader.GetInt32(4);
                    sched.unit = reader.GetInt32(5);
                    sched.time = reader.GetString(6);
                    sched.day = reader.GetString(7);
                    sched.instructor = reader.GetString(8);

                    ShowInformation.showSchedule(sched);
                }
            }
            else
            {
                StudentForm.scheduleMonday();
            }

            sqlConnection.Close();

        }

        public void viewThursdaySchedule()
        {
            String Day = "Thursday";
            string sqlQuery = "SELECT * FROM Schedule where Day = @Day";
            SqlCommand command = new SqlCommand(sqlQuery, sqlConnection);
            sqlConnection.Open();
            command.Parameters.AddWithValue("@Day", Day);
            SqlDataReader reader = command.ExecuteReader();



            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    sched.subjectCode = reader.GetString(1);
                    sched.description = reader.GetString(2);
                    sched.lecture = reader.GetInt32(3);
                    sched.laboratory = reader.GetInt32(4);
                    sched.unit = reader.GetInt32(5);
                    sched.time = reader.GetString(6);
                    sched.day = reader.GetString(7);
                    sched.instructor = reader.GetString(8);

                    ShowInformation.showSchedule(sched);
                }
            }
            else
            {
                StudentForm.scheduleMonday();
            }

            sqlConnection.Close();

        }

        public void viewSaturdaySchedule()
        {
            String Day = "Saturday";
            string sqlQuery = "SELECT * FROM Schedule where Day = @Day";
            SqlCommand command = new SqlCommand(sqlQuery, sqlConnection);
            sqlConnection.Open();
            command.Parameters.AddWithValue("@Day", Day);
            SqlDataReader reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    sched.subjectCode = reader.GetString(1);
                    sched.description = reader.GetString(2);
                    sched.lecture = reader.GetInt32(3);
                    sched.laboratory = reader.GetInt32(4);
                    sched.unit = reader.GetInt32(5);
                    sched.time = reader.GetString(6);
                    sched.day = reader.GetString(7);
                    sched.instructor = reader.GetString(8);

                    ShowInformation.showSchedule(sched);
                }
            }
            else
            {
                StudentForm.scheduleMonday();
            }

            sqlConnection.Close();

        }

        //method for showing schedule for faculty
        public void viewFacultySchedule(string facultyNumber)
        {
            string sqlQuery = "SELECT SubjectCode, Description, Schedule, day, instructor " +
                              "FROM Schedule " +
                              "WHERE instructor IN (SELECT FullName FROM FacultyInfo WHERE FacultyNumber = @FacultyNumber);"; // Add a semicolon here

            SqlCommand command = new SqlCommand(sqlQuery, sqlConnection);
            sqlConnection.Open();
            command.Parameters.AddWithValue("@FacultyNumber", facultyNumber);
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                sched.subjectCode = reader.GetString(0);
                sched.description = reader.GetString(1);
                sched.time = reader.GetString(2);
                sched.day = reader.GetString(3);
                sched.instructor = reader.GetString(4);

                ShowInformation.showFacultySched(sched);
            }

            sqlConnection.Close();
        }


        //method for viewing all subject for students
        public void viewSubject(string Course)
        {
            Course = "BSIT";
            string sqlQuery = "SELECT * FROM Subject WHERE Course = @Course";
            SqlCommand command = new SqlCommand (sqlQuery, sqlConnection);
            sqlConnection.Open ();
            command.Parameters.AddWithValue("@Course", Course);
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                subj.subjectCode = reader.GetString(1);
                subj.prereq = reader.GetString(2);
                subj.description = reader.GetString(3);
                subj.unit = reader.GetInt32(4);
                subj.course = reader.GetString(5);
                subj.year = reader.GetInt32(6);
                subj.semester = reader.GetString(7);

                ShowInformation.showSubject(subj);
            }
            sqlConnection.Close();
        }

        //method for updating personal information
        public void updatePlaceOfBirth(string sisAccountNumber)
        {
            sqlConnection.Open();

            string placeOfBirth = StudentForm.updatePlaceOfBirth();

            string sqlQuery = "UPDATE StudentPersonalInfo Set PlaceOfBirth = @PlaceOfBirth where SISAccountNumber = @SISAccountNumber";
            SqlCommand command = new SqlCommand(sqlQuery, sqlConnection);
            command.Parameters.AddWithValue("@PlaceOfBirth", placeOfBirth);
            command.Parameters.AddWithValue("@SISAccountNumber", sisAccountNumber);
            command.ExecuteNonQuery();

            //Console.WriteLine("\nPersonal information updated successfully!");
            String message = "Place of birth updated successfully";
            Debug.Print(message);

            sqlConnection.Close();
        }

        //method for updating 
        public void updateMobileNumber(string sisAccountNumber)
        {
            sqlConnection.Open();

            string mobileNumber = StudentForm.updateContactNumber();

            string sqlQuery = "UPDATE StudentPersonalInfo Set MobileNo = @MobileNo where SISAccountNumber = @SISAccountNumber";
            SqlCommand command = new SqlCommand(sqlQuery, sqlConnection);
            command.Parameters.AddWithValue("@MobileNo", mobileNumber);
            command.Parameters.AddWithValue("@SISAccountNumber", sisAccountNumber);
            command.ExecuteNonQuery();

            String message = "Mobile Number updated successfully";
            Debug.Print(message);

            sqlConnection.Close();
        }

        //updating email address
        public void updateEmailAddress(string sisAccountNumber)
        {
            sqlConnection.Open();

            string emailAddress = StudentForm.updateEmailAddress();

            string sqlQuery = "UPDATE StudentPersonalInfo Set EmailAddress = @EmailAddress where SISAccountNumber = @SISAccountNumber";
            SqlCommand command = new SqlCommand(sqlQuery, sqlConnection);
            command.Parameters.AddWithValue("@EmailAddress", emailAddress);
            command.Parameters.AddWithValue("@SISAccountNumber", sisAccountNumber);
            command.ExecuteNonQuery();

            String message = "Email Address updated successfully";
            Debug.Print(message);

            sqlConnection.Close();
        }

        //updating residential address
        public void updateResidentialAddress(string sisAccountNumber)
        {
            sqlConnection.Open();

            string resAddress = StudentForm.updateResidentialAdd();

            string sqlQuery = "UPDATE StudentPersonalInfo Set ResidentialAddress = @ResidentialAddress where SISAccountNumber = @SISAccountNumber";
            SqlCommand command = new SqlCommand(sqlQuery, sqlConnection);
            command.Parameters.AddWithValue("@ResidentialAddress", resAddress);
            command.Parameters.AddWithValue("@SISAccountNumber", sisAccountNumber);
            command.ExecuteNonQuery();

            String message = "Residential Address updated successfully";
            Debug.Print(message);

            sqlConnection.Close();
        }

        //updating permanent address
        public void updatePermanentAddress(string sisAccountNumber)
        {
            sqlConnection.Open();

            string permAddress = StudentForm.updatePermanentAdd();

            string sqlQuery = "UPDATE StudentPersonalInfo Set PermanentAddress = @PermanentAddress where SISAccountNumber = @SISAccountNumber";
            SqlCommand command = new SqlCommand(sqlQuery, sqlConnection);
            command.Parameters.AddWithValue("@PermanentAddress", permAddress);
            command.Parameters.AddWithValue("@SISAccountNumber", sisAccountNumber);
            command.ExecuteNonQuery();

            String message = "Permanent Address updated successfully";
            Debug.Print(message);

            sqlConnection.Close();
        }

    }
}
