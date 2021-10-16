using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using validation_WebApplication.Models.Entity;


namespace validation_WebApplication.Models.Tables
{
    public class Students
    {
        SqlConnection conn;

        public Students (SqlConnection conn)
        {
            this.conn = conn;
        }

        public void Add(Student s)
        {
            string query = string.Format("Insert into Students values ('{0}' , '{1}', '{2}', 0.0)", s.name, s.dob, s.gender);

            SqlCommand cmd = new SqlCommand(query, conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();

        }

        public Student Get(int id)

        {
            return null;

        }

        public List<Student> GetAll()
        {
            string query = "Select * from Students";

            SqlCommand cmd = new SqlCommand(query, conn);
            conn.Open();

            SqlDataReader reader = cmd.ExecuteReader();

            List<Student> students = new List<Student>();

            while (reader.Read())
            {
                Student s = new Student()

                {
                    /*id = reader.GetInt32(reader.GetOrdinal("id")),*/
                    name = reader.GetString(reader.GetOrdinal("name")),
                    dob= reader.GetString(reader.GetOrdinal("dob")),
                    gender = reader.GetString(reader.GetOrdinal("gender")),
                    cgpa = (float)reader.GetDouble(reader.GetOrdinal("cgpa"))
                };

                students.Add(s);
            }
            conn.Close();
            return students;

        }
       
        
    }
}