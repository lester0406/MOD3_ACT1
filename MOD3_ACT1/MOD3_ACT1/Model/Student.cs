using System;
using System.Collections.Generic;
using System.Text;

namespace MOD3_ACT1.Model
{
    class Student
    {
        public int StudentId { get; set; }
        public string Name { get; set; }
        public string CourseCode { get; set; }
        public string CourseTitle { get; set; }
        public int NoOfUnits { get; set; }
        public DateTime DateOfAttendance { get; set; }
    }
}
