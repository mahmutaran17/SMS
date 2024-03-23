using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SchoolManagement.Models.Entity
{
    public class Student_Attendance
        
    {
        [Key]
        public int StudentID { get; set; }
        public Student Students { get; set; }

        public int AttendanceID { get; set; }
        public Attendance Attendances { get; set; }
    }
}