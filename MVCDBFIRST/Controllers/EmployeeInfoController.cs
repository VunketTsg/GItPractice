using MVCDBFIRST.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCDBFIRST.Controllers
{
    public class EmployeeInfoController : Controller
    {

        EmployeeInfoContext db = new EmployeeInfoContext();

        public ActionResult Index()
        {
            return View(db.Employees.ToList());
        }

        [HttpGet]

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Employee employee)
        {
            if(ModelState.IsValid)
            {
                db.Employees.Add(employee);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(employee);
        }
    }
}