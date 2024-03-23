using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace SchoolManagement.Models.Entity
{
    public class Course
    {
        [Key]
        public int CourseID { get; set; }
        public string CourseName { get; set; }
        public DateTime CourseTime { get; set; }
        public int ProfessorID { get; set; }
        [ForeignKey("ProfessorID")]
        public Professor Professor { get; set; }
        public string CourseDay { get; set; }
        public bool IsActive { get; set; }
        public List<Attendance> Attendances { get; set; }

    }
}