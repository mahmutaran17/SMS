using SchoolManagement.Models;
using SchoolManagement.Models.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace SchoolManagement.Data
{
    public class SchoolDBContext:DbContext
    {
        public SchoolDBContext() : base("SchoolDBContext") { }
        public DbSet<Professor> Professors { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Exam> Exams { get; set; }
        public DbSet<Attendance> Attendances { get; set; }
        public DbSet<Classroom> Classrooms { get; set; }
        public DbSet<StudentExam> StudentExams { get; set; }
        //public DbSet<UserInfo> UserInfo { get; set; }

       
    }
}