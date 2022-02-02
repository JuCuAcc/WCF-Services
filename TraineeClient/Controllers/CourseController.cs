using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using TraineeClient.TraineeServiceReference;
using System.Net;

namespace TraineeClient.Controllers
{
    public class CourseController : Controller
    {
        Service1Client Service1Client = new Service1Client();

        // GET: Course
        public ActionResult Index()
        {
           Course[] courses =Service1Client.GetCourses();
            return View(courses);
        }
    }
}