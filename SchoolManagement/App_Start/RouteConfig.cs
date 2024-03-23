﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace SchoolManagement
{

    

    public class RouteConfig
    {

        
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
            routes.MapRoute(
                name: "Courses",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Course", action = "Detail", id = UrlParameter.Optional }
            );
            routes.MapRoute(
                name: "Classrooms",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Classroom", action = "Detail", id = UrlParameter.Optional }
            );
        }
    }
}
