using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using validation_WebApplication.Models.Entity;

namespace validation_WebApplication.Models.Tables
{
    public class Users
    {

        SqlConnection conn;

        public Users(SqlConnection conn)
        {
            this.conn = conn;
        }

        public User Authenticate (string username ,string password)
        {
            User User = null;
            conn.Open();
            string query = String.Format("select * from Users where username='{0}' and password='{1}'", username, password);

            SqlCommand cmd = new SqlCommand( query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while(reader.Read())
            {
                User = new User()
                {
                    /*id = reader.GetInt32(reader.GetOrdinal("id")),*/
                    name= reader.GetString(reader.GetOrdinal("name")),
                    username= reader.GetString(reader.GetOrdinal("username")),
                    

                };

               
                
            }
            conn.Close();
            return User;


        }




    }
}