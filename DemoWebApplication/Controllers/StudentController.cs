using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DemoWebApplication.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        //public ActionResult Index()
        //{
        //    return View();
        //}


        public ActionResult sayhello()
        {
            return View("DisplayView");
        }
        public ActionResult Welcome()
        {
            return View("HelloView");
        }

        //public ActionResult Method1()
        //{
        //    return View("Hello");
        //}
        ////[HttpPost]
        ////public ActionResult Edit(StudentController std)
        ////{
        ////    // update student to the database

        ////    return RedirectToAction("Index");
        ////}

        //[HttpDelete]
        //public ActionResult Delete(int id)
        //{
        //    // delete student from the database whose id matches with specified id

        //    return RedirectToAction("Index");
        //}
    }
}