using MVCBASIC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCBASIC.Controllers
{
    public class PersonController : Controller
    {
        // GET: Person
        public ActionResult GetCalForm()
        {

            return View();
        }
        public ActionResult Add(int Firstnumber, int SecondNumber)
        {
            int c = Firstnumber + SecondNumber;
            //using viewData we can pass value from controller to view...
            ViewData["result"] = c;

            return View();
        }

        public ActionResult GetCountries()
        {
            List<string> lstCountries = new List<string>()
            {
                "USA","IND","UK"
            };

            ViewData["ListCountries"] = lstCountries;

            List<SelectListItem> lstCountry = new List<SelectListItem>()
            {
                new SelectListItem(){Text="SELECT", Value ="SELECT"},
                new SelectListItem(){Text="USA", Value ="USA"},
                new SelectListItem(){Text="IND", Value ="IND"},
                new SelectListItem(){Text="UK", Value ="UK"}

            };

            ViewData["ListCountries2"] = lstCountry;
          //  SelectListItem lst1 = new SelectListItem() { Text = "USA", Value = "USA" };

          //  lstCountry.Add(lst1);

            return View();
        }

        public ActionResult GetPersons()
        {

            List<PersonViewModel> lstPersons = new List<PersonViewModel>()
            {
                new PersonViewModel(){id=10 , UserName="abc", Email="abc@gmail.com"},
                new PersonViewModel(){id=20 , UserName="bcd", Email="bcd@gmail.com"},
                new PersonViewModel(){id=30 , UserName="cde", Email="cde@gmail.com"},

            };

            ViewBag.persons = lstPersons;

            return View(lstPersons);
        }

       public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(Register r)
        {
            return View(r);
        }

        public ActionResult StudentDetails()
        {
            return View();
        }

        [HttpPost]
        public ActionResult StudentDetails(StudentDetails sd)
        {
            return View(sd);
        }
    }
}