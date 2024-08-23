
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        List<Student> studentList = new List<Student>()
        {
            new Student() {id=1, name="krushi", subject="asp", city="rajkot"},
            new Student() {id=2, name="vishva", subject="node js", city="surat"},
            new Student() {id=3, name="megha", subject="android", city="ahm"},
            new Student() {id=4, name="shivani", subject="networking", city="amreli"},

        };
        public ActionResult Index()
        {
            Student s = new Student();
            //s.id = 1;
            //s.name = "krushi";
            //s.city = "rajkot";

            //s.id = = 2;
            //s.name = "abc";
            //s.city = "ahm";

            return View(studentList);
        }

        [HttpPost]
        public ActionResult Index(int num1, int num2)
        {
            int result = 0;
            ViewBag.Result = result;
            //ViewBag.Number = string.Format("Number: {0} {1}", num1, num2);
            return View();
        }
        public ActionResult About()
        {
            //ViewBag
            ViewBag.bag = "Country list using ViewBag";
            ViewBag.country = new List<String>() { "India, ", "USA" };
            //ViewData
            ViewData["state"] = "State list using ViewData";
            ViewData["state_list"] = new List<String>() { "Gujarat, ", "Maharasta" };

            return View();
        }
        public ActionResult Contact()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Contact(int a, int b, string btn)
        {
            int ans = 0;

            if (btn == "add")
            {
                ans = a + b;
            }
            else if (btn == "sub")
            {
                ans = a - b;
            }
            else if (btn == "mul")
            {
                ans = a * b;
            }
            else if (btn == "div")
            {
                ans = a / b;
            }
            ViewBag.Result = ans;
            return View(ans);
        }

        [HttpPost]
        public ActionResult TemplateHelper()
        {
            ViewBag.Data = "Your Data";

            Student s = new Student();
            s.id = 1;
            s.name = "krushi";
            s.subject = "MCA";
            s.city = "rajkot";
            
            return View(s);
        }

    }
}