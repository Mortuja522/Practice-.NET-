using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using validation_WebApplication.Models.Tables;


namespace validation_WebApplication.Models
{
    public class DataBase
    {

        public Students Students { get; set; }
        
        public Courses Courses { get; set; }

        public Faculties Faculties { get; set; }

        public Users Users { get; set; }



        public DataBase ()
        {

            string connString = @"Server =DESKTOP-KJ1F3KT\SQLEXPRESS03; DataBase =UMS; integrated Security = True";

            SqlConnection conn = new SqlConnection(connString);

            Students = new Students(conn);
            Courses = new Courses();
            Faculties = new Faculties();
            Users = new Users(conn);

        }


    }
}