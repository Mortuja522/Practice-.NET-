using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using First_WebApplication.Models;

namespace First_WebApplication.Controllers
{
    public class PersonController : Controller
    {
        // GET: Person
        public ActionResult List()
        {

            List<Information> informations = new List<Information>();
            for (int i = 0; i<10; i++)
            {
                Information s = new Information()

                {

                    name = "MORTUJA" + (1 + 1),
                    id = "18-38547-2",
                    dob = "31/12/1998",
                    blood = "O+"

                };

                informations.Add(s);

            }

            return View(informations);
            

        }

        public ActionResult Create()
        {
         
            return View();
        }

        public ActionResult Createsubmit(Information s)

        {
           /* Information s = new Information();

            s.name = Request["name"];
            s.id = Request["id"];
            s.dob = Request["dob"];
            s.blood = Request["blood"];*/


            return View(s);
        }


        public ActionResult Index()

        {
            
            {
                Information s = new Information()

                {

                    name = "MORTUJA",
                    id = "18-38547-2",
                    dob = "31/12/1998",
                    blood = "O+"
  
                };

                return View(s);


            }
   

            
        }





    }
}