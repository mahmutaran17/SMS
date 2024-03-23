using SchoolManagement.Data;
using SchoolManagement.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SchoolManagement.Controllers
{
    public class ClassroomController : Controller
    {
        // GET: Classroom
        public ActionResult Index()
        {
            SchoolDBContext sc = new SchoolDBContext();
            var classroomList = sc.Classrooms.Where(i => i.IsActive).ToList();
            
            return View(classroomList);
        }

        public ActionResult Detail(int Id)
        {
            SchoolDBContext sc = new SchoolDBContext();
            var classroom = sc.Classrooms.FirstOrDefault(i => i.ClassroomID == Id);
            return View(classroom);
        }

        public ActionResult Edit(int Id)
        {
            SchoolDBContext sc = new SchoolDBContext();
            var classroom = sc.Classrooms.FirstOrDefault(i => i.ClassroomID == Id);
            
            return View(classroom);
        }

        [HttpPost]
        public ActionResult Edit(Classroom model)
        {
            SchoolDBContext sc = new SchoolDBContext();
            var classroom = sc.Classrooms.FirstOrDefault(i => i.ClassroomID == model.ClassroomID);
            classroom.BuildingName = model.BuildingName;
            classroom.Capacity = model.Capacity;
            classroom.RoomNumber = model.RoomNumber;
            classroom.IsActive = true;
            sc.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Classroom model)
        {
            SchoolDBContext sc = new SchoolDBContext();
            Classroom classroom = new Classroom();
            classroom.BuildingName = model.BuildingName;
            classroom.Capacity = model.Capacity;
            classroom.RoomNumber = model.RoomNumber;
            classroom.IsActive = true;
            sc.Classrooms.Add(classroom);
            sc.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Delete(int Id)
        {
            SchoolDBContext sc = new SchoolDBContext();
            var classroom = sc.Classrooms.FirstOrDefault(i => i.ClassroomID == Id);
            sc.Classrooms.Remove(classroom);
            
            sc.SaveChanges();
            return RedirectToAction("Index");

        }
    }
}