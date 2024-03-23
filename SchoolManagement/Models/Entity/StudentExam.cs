using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SchoolManagement.Models.Entity
{
    public class StudentExam
    {
        public int Id { get; set; }
        public int ExamID { get; set; }
        public int StudentID { get; set; }
        public int ExamGrade { get; set; }
        public bool IsActive { get; set; }
    }
}