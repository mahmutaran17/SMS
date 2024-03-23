using SchoolManagement.Data;
using SchoolManagement.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SchoolManagement.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {
            SchoolDBContext sc = new SchoolDBContext();
            var studentList = sc.Students.ToList();
            return View(studentList);
        }
        public ActionResult Detail(int Id)
        {
            SchoolDBContext sc = new SchoolDBContext();
            var student = sc.Students.FirstOrDefault(i => i.StudentID == Id);
            return View(student);
        }

        public ActionResult Edit(int Id)
        {
            SchoolDBContext sc = new SchoolDBContext();
            var student = sc.Students.FirstOrDefault(i => i.StudentID == Id);
            return View(student);
        }
        [HttpPost]
        public ActionResult Edit(Student model)
        {
            SchoolDBContext sc = new SchoolDBContext();
            var student = sc.Students.FirstOrDefault(i => i.StudentID == model.StudentID);
            student.FirstName = model.FirstName;
            student.LastName = model.LastName;
            student.Major = model.Major;
            student.Age = model.Age;
            student.Email = model.Email;
            student.GraduationYear = model.GraduationYear;
            student.PhoneNumber = model.PhoneNumber;
            sc.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Create()
        {
            SchoolDBContext sc = new SchoolDBContext();
            //var student = sc.Students.FirstOrDefault(i => i.StudentID == model.StudentID);
            //var student = sc.Students.ToList();
            //var selectList = new SelectList(students, "StudentID", "Major", "Please select an option");
            //ViewBag.myMajor = selectList;

            return View();
        }

        [HttpPost]
        public ActionResult Create(Student model)
        {
            SchoolDBContext sc = new SchoolDBContext();
            Student student = new Student();
            student.FirstName = model.FirstName;
            student.LastName = model.LastName;
            student.Major = model.Major;
            student.Age = model.Age;
            student.Email = model.Email;
            student.GraduationYear = model.GraduationYear;
            student.PhoneNumber = model.PhoneNumber;
            sc.Students.Add(student);
            sc.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Delete(int Id)
        {
            SchoolDBContext sc = new SchoolDBContext();
            var student = sc.Students.FirstOrDefault(i => i.StudentID == Id);
            sc.Students.Remove(student); 
            sc.SaveChanges();
            return RedirectToAction("Index");

        }
    }
}