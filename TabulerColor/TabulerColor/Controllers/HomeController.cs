using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TabulerColor.Models;

namespace TabulerColor.Controllers
{
    public class HomeController : Controller
    {
        List<Employee> employeeList = new List<Employee>()
        {
            new Employee() {id=1, name="john", age=22, city="Rajkot"},
            new Employee() {id=2, name="mike", age=25, city="Jamanagar"},
            new Employee() {id=3, name="rohan", age=16, city="Rajkot"},
            new Employee() {id=4, name="jessie", age=50, city="Surat"},
            new Employee() {id=5, name="john", age=20, city="Rajkot"},
            new Employee() {id=6, name="molly", age=17, city="Amreli"},
            new Employee() {id=7, name="ronny", age=26, city="Rajkot"},
            new Employee() {id=8, name="johnsan", age=18, city="Ahemadabad"},
            new Employee() {id=9, name="onam", age=17, city="Baroda"},
            new Employee() {id=10, name="rockiey", age=20, city="Rajkot"},
        };
        public ActionResult Index()
        {
            return View(employeeList);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}