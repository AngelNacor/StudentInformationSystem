using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIS_MODEL
{
    public class Subject
    {
        public string subjectCode { get; set; }
        public string prereq { get; set; }
        public string description { get; set; }
        public int unit { get; set; }
        public string course { get; set; }
        public int year { get; set; }
        public string semester { get; set; }
    }
}
