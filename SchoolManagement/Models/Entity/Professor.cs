using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace SchoolManagement.Models.Entity
{
    public class Professor
    {
        [Key]
        public int ProfessorID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Department { get; set; }
        public string HireDate { get; set; }
        public int Age { get; set; }
        public bool IsActive { get; set; }
        [NotMapped]
        public string ProfessorName
        {
            get
            {
                return FirstName + " " + LastName;            
            }
        }
        public List<Course> Courses { get; set; }

    }
}