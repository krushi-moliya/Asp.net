using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyDatabse.Models;

namespace MyDatabse.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {
            myDBEntities1 db = new myDBEntities1();

            //---This is default data pass---
            //student std = new student();
            //std.fname = "megha";
            //std.lname = "pansala";
            //std.Program = "MCA";
            //db.students.Add(std);
            //db.SaveChanges();

            List<student> s = db.students.ToList();
            return View(s);
        }
        public ActionResult Registration()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Registration(student s)
        {
            myDBEntities1 db = new myDBEntities1();
            db.students.Add(s);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult Delete(int Id)
        {
            myDBEntities1 db = new myDBEntities1();
            student std = db.students.Find(Id);
            db.students.Remove(std);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult Edit()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Edit(int Id)
        {
            myDBEntities1 db = new myDBEntities1();
            student std = db.students.Find(Id);
            db.students.Add(std);
            db.SaveChanges();
            return View();
        }
    }
}