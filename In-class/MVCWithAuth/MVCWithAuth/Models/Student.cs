using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCWithAuth.Models
{
    public class Student
    {
        public int ID { get; set; }
        public string First_name { get; set; }
        public string Last_Name {get; set; }
        public DateTime Birthday { get; set; }
        public int year { get; set; }

    }
}
