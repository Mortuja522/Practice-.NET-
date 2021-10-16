
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.SqlClient;
using validation_WebApplication.Models.Entity;
using validation_WebApplication.Models;




namespace validation_WebApplication.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {
            DataBase db = new DataBase();
            var Students = db.Students.GetAll();
            
           
            return View(Students);
        }

        [HttpGet]
        public ActionResult Create()

        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Student s)

        {
            if(ModelState.IsValid)
            {
                DataBase db = new DataBase();
                db.Students.Add(s);
                return RedirectToAction("Index");

            }

            return View();
            
        }


    }

   
    }

