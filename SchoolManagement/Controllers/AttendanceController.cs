using SchoolManagement.Data;
using SchoolManagement.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SchoolManagement.Controllers
{
    public class AttendanceController : Controller
    {
        // GET: Attendance
        public ActionResult Index()

        {
            SchoolDBContext sc = new SchoolDBContext();
            var attendanceList = sc.Attendances.Include("Course").ToList();
            return View(attendanceList);
        }

        public ActionResult Detail(int Id)
        {
            SchoolDBContext sc = new SchoolDBContext();
            var attendance = sc.Attendances.FirstOrDefault(i => i.AttendanceID == Id);
            return View(attendance);
        }

        public ActionResult Edit(int Id)
        {
            SchoolDBContext sc = new SchoolDBContext();
            var attendance = sc.Attendances.Include("Course").FirstOrDefault(i => i.AttendanceID == Id);
            var courses = sc.Courses.ToList();
            var selectList = new SelectList(courses, "CourseID", "CourseName", "Please select an option");
            ViewBag.myCourses = selectList;
            return View(attendance);
        }

        [HttpPost]
        public ActionResult Edit(Attendance model)
        {
            SchoolDBContext sc = new SchoolDBContext();
            var attendance = sc.Attendances.FirstOrDefault(i => i.AttendanceID == model.AttendanceID);
            attendance.AttendanceDate = model.AttendanceDate;
            attendance.AttendanceName = model.AttendanceName;
            attendance.AttendanceID = model.AttendanceID;

            sc.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Create()
        {
            SchoolDBContext sc = new SchoolDBContext();
            var courses = sc.Courses.ToList();
            //List<SelectListItem> myCourses = new List<SelectListItem>();
            //for (var i = 0; i < courses.Count; i++)
            //{
            //    myCourses.Add(new SelectListItem() { Text = courses[i].CourseName, Value = courses[i].CourseID.ToString() });
            //}
            var selectList = new SelectList(courses, "CourseID", "CourseName", "Please select an option");
            ViewBag.myCourses = selectList;
            //ViewBag.myCourses = courses;
            return View();
        }

        [HttpPost]
        public ActionResult Create(Attendance model)
        {
            SchoolDBContext sc = new SchoolDBContext();
            Attendance attendance = new Attendance();
            attendance.AttendanceDate = model.AttendanceDate;
            attendance.AttendanceName = model.AttendanceName;
            attendance.CourseID = model.Course.CourseID;

            sc.Attendances.Add(attendance);
            sc.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Delete(int Id)
        {
            SchoolDBContext sc = new SchoolDBContext();
            var attendance = sc.Attendances.FirstOrDefault(i => i.AttendanceID == Id);
            sc.Attendances.Remove(attendance);
            
            
            sc.SaveChanges();
            return RedirectToAction("Index");

        }

    }
}
