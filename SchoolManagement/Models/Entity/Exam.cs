using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace SchoolManagement.Models.Entity
{
    public class Exam
    {
        [Key]
        public int ExamID { get; set; }
        public string ExamName { get; set; }
        public DateTime ExamDate { get; set; }
        public int ProfessorID { get; set; }
        public int CourseID { get; set; }
        public bool IsActive { get; set; }
        [ForeignKey("CourseID")]
        public Course Course { get; set; }
        [ForeignKey("ProfessorID")]
        public Professor Professor { get; set; }
        //public List<Student> Students { get; set; }

    }
}