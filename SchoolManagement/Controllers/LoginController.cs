using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SchoolManagement.Data;
using SchoolManagement.Models;

namespace SchoolManagement.Controllers
{
    //public class LoginController : Controller
    //{
    //    SchoolDBContext sc = new SchoolDBContext();

    //    // GET: Login
    //    public ActionResult Index()
    //    {
    //        return View();
    //    }

    //    public ActionResult SignUp()
    //    {
    //        return View();
    //    }

    //    [HttpPost]

    //    public ActionResult SignUp(UserInfo userInfo)
    //    {
    //        if (sc.UserInfoes.Any(x=>x.UsernameUs == UserInfo.UsernameUs))
    //        {
    //            ViewBag.Notification = "This account is existed";
    //            return View();
    //        }
    //        else
    //        {
    //            sc.UserInfoes.Add(UserInfo);
    //            sc.SaveChanges();

    //            Session["IdUsSS"] = UserInfo.IdUs.ToString();
    //            Session["UsernameSS"] = UserInfo.UsernameSS.ToString();
    //            return RedirectToAction("Index", "Home");

    //        }
    //    }

    //}
}