﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    [Serializable]
    public class Student
    {
        public int StudentId {get;set; }
        public string StudentName { get;set; }
        public DateTime Birthday { get; set;}
        public string Gender {  get; set; }
        public string StudentIdNo { get; set; }
        public int Age { get; set; }
        public string StuImage { get; set; }
        public string PhoneNumber { get; set; }
        public string StudentAddress { get; set; }
        public string CardNo { get; set; }
        public int ClassId { get; set; }
        public string ClassName { get; set; }
    }
}
