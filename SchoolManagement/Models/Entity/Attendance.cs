 using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace SchoolManagement.Models.Entity
{
    public class Attendance
    {
        [Key]
        public int AttendanceID { get; set; }
        public string AttendanceName { get; set; }
        public DateTime AttendanceDate { get; set; }
        public bool IsActive { get; set; }

        //Relationship
        public List<Student_Attendance> Student_Attendance { get; set; }


        public int CourseID { get; set; }
        [ForeignKey("CourseID")]
        public Course Course { get; set; }
    }
}