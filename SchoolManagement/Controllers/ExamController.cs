using SchoolManagement.Data;
using SchoolManagement.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SchoolManagement.Controllers
{
    public class ExamController : Controller
    {
        // GET: Exam
        public ActionResult Index()
        {
            SchoolDBContext sc = new SchoolDBContext();
            var examList = sc.Exams.Include("Professor").Include("Course").ToList();
            return View(examList);
        }

        public ActionResult Detail(int Id)
        {
            SchoolDBContext sc = new SchoolDBContext();
            var exam = sc.Exams.FirstOrDefault(i => i.ExamID == Id);
            return View(exam);
        }

        public ActionResult Edit(int Id)
        {
            SchoolDBContext sc = new SchoolDBContext();
            var exam = sc.Exams.FirstOrDefault(i => i.ExamID == Id);
            return View(exam);
        }

        [HttpPost]
        public ActionResult Edit(Exam model)
        {
            SchoolDBContext sc = new SchoolDBContext();
            var exam = sc.Exams.FirstOrDefault(i => i.ExamID == model.ExamID);
            exam.ExamDate = model.ExamDate;
            exam.ExamName = model.ExamName;
            exam.ProfessorID = model.ProfessorID;
            exam.IsActive = true;
            sc.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Create()
        {
            SchoolDBContext sc = new SchoolDBContext();
            var courses = sc.Courses.ToList();
            var courseList = new SelectList(courses, "CourseID", "CourseName", "Please select an option");
            ViewBag.myCourses = courseList;

            var professors = sc.Professors.ToList();
            var professorList = new SelectList(professors, "ProfessorID", "ProfessorName", "Please select an option");
            ViewBag.myProfessors = professorList;
            return View();


        }

        [HttpPost]
        public ActionResult Create(Exam model)
        {
            SchoolDBContext sc = new SchoolDBContext();
            Exam exam = new Exam();
            exam.ExamDate = model.ExamDate;
            exam.ExamName = model.ExamName;
            exam.ProfessorID = model.ProfessorID;
            exam.CourseID = model.CourseID;
            exam.IsActive = true;
            sc.Exams.Add(exam);

            sc.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Delete(int Id)
        {
            SchoolDBContext sc = new SchoolDBContext();
            var exam = sc.Exams.FirstOrDefault(i => i.ExamID == Id);
            sc.Exams.Remove(exam);
            sc.SaveChanges();
            return RedirectToAction("Index");

        }

    }
}
