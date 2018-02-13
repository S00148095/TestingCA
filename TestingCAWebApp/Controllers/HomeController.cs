using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TestingCAWebApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
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

        [HttpPost]
        public ActionResult InputForm(string gender, int age)
        {
            CalcPremium(age,gender);
            return View();
        }

        public float CalcPremium(int age, string gender)
        {
            float premium;

            if (gender == "female")
                if ((age >= 18) && (age <= 30))
                    premium = (float)5.0;
                else if (age >= 31)
                    premium = (float)2.50;
                else
                    premium = (float)0.0;
            else if (gender == "male")
                if ((age >= 18) && (age <= 35))
                    premium = (float)6.0;
                else if (age >= 36)
                    premium = (float)5.0;
                else
                    premium = (float)0.0;
            else
                premium = (float)0.0;

            if (age >= 50)
                premium = premium * (float)0.15;
            return premium;
        }
    }
}