using SchoolManagement.Data;
using SchoolManagement.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SchoolManagement.Controllers
{
    public class CourseController : Controller
    {
        // GET: Course
        public ActionResult Index()
        {
            SchoolDBContext sc = new SchoolDBContext();
            var courseList = sc.Courses.Include("Professor").ToList();
            return View(courseList);
        }

        public ActionResult Detail(int Id)
        {
            SchoolDBContext sc = new SchoolDBContext();
            var course = sc.Courses.FirstOrDefault(i => i.CourseID == Id);
            return View(course);
        }

        public ActionResult Edit(int Id)
        {
            SchoolDBContext sc = new SchoolDBContext();
            var course = sc.Courses.FirstOrDefault(i => i.CourseID == Id);
            return View(course);
        }

        [HttpPost]
        public ActionResult Edit(Course model)
        {
            SchoolDBContext sc = new SchoolDBContext();
            var course = sc.Courses.FirstOrDefault(i => i.CourseID == model.CourseID);
            course.CourseName = model.CourseName;
            course.CourseDay = model.CourseDay;
            
            sc.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Create()
        {
            SchoolDBContext sc = new SchoolDBContext();
            var professors = sc.Professors.ToList();
            var selectList = new SelectList(professors, "ProfessorID", "ProfessorName", "Please select an option");
            ViewBag.myProfessors = selectList;
            return View();
        }

        [HttpPost]
        public ActionResult Create(Course model)
        {
            SchoolDBContext sc = new SchoolDBContext();
            Course course = new Course();
            course.CourseName = model.CourseName;
            course.CourseDay = model.CourseDay;
            course.CourseTime = model.CourseTime;
            course.ProfessorID = model.ProfessorID;
            
            sc.Courses.Add(course);
            sc.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Delete(int Id)
        {
            SchoolDBContext sc = new SchoolDBContext();
            var course = sc.Courses.FirstOrDefault(i => i.CourseID == Id);
            sc.Courses.Remove(course);
            sc.SaveChanges();
            return RedirectToAction("Index");

        }

    }
}