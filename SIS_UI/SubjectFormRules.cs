using System;
using SIS_UI;
using SIS_MODEL;
using SIS_DATA;
using AM_Rules; 
namespace SIS_RULES
{ 
    public class SubjectCodeDescription
    {
        public static void studentSubjectCodeDescription()
        {
            int SubjectCodeDescription;

            do
            {
                SubjectCodeDescription = SubjectForm.ViewFirstYearFirstSemester() , SubjectForm.ViewFirstYearSecondSemester() , SubjectForm.ViewSecondYearFirstSemester() ,
                SubjectForm.ViewSecondYearSecondSemester();

                    switch (SubjectCodeDescription)
                    {
                        case 0: break;
                        case 1: //overall subject code description
                        SubjectForm.ViewFirstYearFirstSemester(), 
                        SubjectForm.ViewFirstYearSeconeSemester();
                        SubjectForm.ViewSecondYearFirstSemester();
                        SubjectForm.ViewSecondYearSeconrSemester();
                        break;
                        case 2: //first year first semester
                        SubjectForm.ViewFirstYearFirstSemester();
                        break;
                        case 3: //first year second semester
                        SubjectForm.ViewFirstYearSecondSemester();
                        break;
                        case 4: //second year first semester
                        SubjectForm.ViewSecondYearFirstSemester();
                        break;
                        case 5: //second year second semester
                        SubjectForm.ViewSecondYearSecondSemester();
                        break;
                        while(SubjectCodeDescription == null);

                    }
            }
        }
    }
}

