using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;


namespace SchoolManagement.Models.Entity
{
    public class Student
    {
        [Key]
        public int StudentID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Major { get; set; }
        public int GraduationYear { get; set; }
        public int Age { get; set; }
        public bool IsActive { get; set; }
       

        //Relationship
        public List<Student_Attendance> Student_Attendance { get; set; }

    }
}