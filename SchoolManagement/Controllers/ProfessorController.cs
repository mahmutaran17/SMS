using SchoolManagement.Data;
using SchoolManagement.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SchoolManagement.Controllers
{
    public class ProfessorController : Controller
    {
        // GET: Professor
        public ActionResult Index()
        {
            SchoolDBContext sc = new SchoolDBContext();
            var professorList = sc.Professors.Where(i => i.IsActive).ToList();

            return View(professorList);
        }

        public ActionResult Detail(int Id)
        {
            SchoolDBContext sc = new SchoolDBContext();
            var professor = sc.Professors.FirstOrDefault(i => i.ProfessorID == Id);
            return View(professor);
        }

        public ActionResult Edit(int Id)
        {
            SchoolDBContext sc = new SchoolDBContext();
            var professor = sc.Professors.FirstOrDefault(i => i.ProfessorID == Id);
            return View(professor);
        }

        [HttpPost]
        public ActionResult Edit(Professor model)
        {
            SchoolDBContext sc = new SchoolDBContext();
            var professor = sc.Professors.FirstOrDefault(i => i.ProfessorID == model.ProfessorID);
            professor.FirstName = model.FirstName;
            professor.LastName = model.LastName;
            professor.HireDate = model.HireDate;
            professor.PhoneNumber = model.PhoneNumber;
            professor.Age = model.Age;
            professor.Department = model.Department;
            professor.Email = model.Email;
            professor.IsActive = model.IsActive;
            sc.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Professor model)
        {
            SchoolDBContext sc = new SchoolDBContext();
            Professor professor = new Professor();
            professor.FirstName = model.FirstName;
            professor.LastName = model.LastName;
            professor.HireDate = model.HireDate;
            professor.PhoneNumber = model.PhoneNumber;
            professor.Age = model.Age;
            professor.Department = model.Department;
            professor.Email = model.Email;
            sc.Professors.Add(professor);
            sc.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Delete(int Id)
        {
            using (SchoolDBContext sc = new SchoolDBContext())
            {
                var courses = sc.Courses.Where(i => i.ProfessorID == Id).ToList();

                foreach (var course in courses)
                {
                    course.IsActive = false;

                    var exams = sc.Exams.Where(i => i.CourseID == course.CourseID);
                    foreach (var exam in exams)
                    {
                        exam.IsActive = false;
                        var studentExams = sc.StudentExams.Where(i => i.ExamID == exam.ExamID).ToList();
                        foreach (var item in studentExams)
                        {
                            item.IsActive = false;
                        }

                    }

                }
                    sc.SaveChanges();
            }



            using (SchoolDBContext sc = new SchoolDBContext())
            {
                var professor = sc.Professors.FirstOrDefault(i => i.ProfessorID == Id);
                professor.IsActive = false;
                sc.SaveChanges();
            }
            
            return RedirectToAction("Index");

        }
    }
}