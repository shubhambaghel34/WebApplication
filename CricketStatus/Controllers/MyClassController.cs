using CricketStatus.DatabaseLayer;
using CricketStatus.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CricketStatus.Controllers
{
    public class MyClassController : Controller
    {
        private MydatabaseEntities db = new MydatabaseEntities();
        // GET: MyClass
        public ActionResult Index()
        {
            List<Myclas> outlist = new List<Myclas>(); 
            var list = db.Cricketers.ToList();
            foreach(var item in list)
            {
                Myclas myClas = new Myclas();
                myClas.Name = item.Name;
                myClas.ID = item.ID;
                myClas.ODI = item.ODI;
                myClas.Test = item.Test;
                myClas.Runs = 2000;
                outlist.Add(myClas);
            }
            return View(outlist);
        }

        // GET: MyClass/Details/5
        public ActionResult Details(int id)
        {
            var item = db.Cricketers.Where(q=>q.ID== id).FirstOrDefault();
            Myclas myClas = new Myclas();
            myClas.Name = item.Name;
            myClas.ID = item.ID;
            myClas.ODI = item.ODI;
            myClas.Test = item.Test;
            myClas.Runs = 2000;
            return View(myClas);
        }

        // GET: MyClass/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MyClass/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: MyClass/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: MyClass/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: MyClass/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: MyClass/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
