using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SchoolManagement.Models.Entity
{
    public class Classroom
    {
        [Key]
        public int ClassroomID { get; set; }
        public string BuildingName { get; set; }        
        public string RoomNumber { get; set; }
        public int Capacity { get; set; }
        public bool IsActive { get; set; }

    }
}