using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Demo09272.Controllers
{
    public class HomeController : Controller
    {
        //För att se detta Index måste man avsluta ens sökfält med /home/index2
        public string Index2()
        {
            return "Hello from web server, åäö";
        }

        //GET: Home
        public ActionResult Index()
        {
            //Per default hamnarvi här
            //pga MS MVC Conventions

            //Vad är våran VIEW?
            //Vad heter vår VIEW?
            //Per default ska den heta INDEX
            //dvs samma som denna metod heter
            return View();
        }
    }
}