using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIS_MODEL
{
    public class Schedule
    {
        public string subjectCode { get; set; }
        public string description { get; set; }
        public int lecture { get; set; }
        public int laboratory { get; set; }
        public int unit { get; set; }
        public string time { get; set; }
        public string day { get; set; }
        public string instructor { get; set; }
    }
}
