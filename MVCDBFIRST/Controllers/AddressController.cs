using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCDBFIRST.Controllers
{
    public class AddressController : Controller
    {
        // GET: Address
        public ActionResult GetData()
        {
            return View();
        }

        public JsonResult GetCountries()
        {
            List<String> lstcntry = new List<string>()
            {
                "USA","IND","UK"
            };

            return Json(lstcntry, JsonRequestBehavior.AllowGet);
        }

        public JsonResult GetStates(string countryName)
        {
            List<string> lstStates = new List<string>();
            switch(countryName)
            {
                case "USA":
                    {
                        lstStates.Add("NY");
                        lstStates.Add("MA");
                        lstStates.Add("CA");
                        break;
                    }
                case "IND":
                    {
                        lstStates.Add("TS");
                        lstStates.Add("AP");
                        lstStates.Add("MP");
                        break;
                    }
                case "UK":
                    {
                        lstStates.Add("Lords");
                        lstStates.Add("Oval");
                        lstStates.Add("London");
                        break;
                    }
                default:
                    {
                        break;
                    }
            }
            return Json(lstStates);
        }

    }
}