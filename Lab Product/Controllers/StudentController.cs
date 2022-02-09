using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.SqlClient;
using Lab_Product.Models;


namespace Lab_Product.Controllers
    
{
    public class StudentController : Controller
    {
        // GET: Student
        [HttpGet]
        public ActionResult Create()
        {
            return View(new Student());
        }
        [HttpPost]
        public ActionResult Create(Student s)
        {
            if(ModelState.IsValid)
            {
                //database operation
                string connString = @"Server=DESKTOP-R1KIF9B\SQLEXPRESS;Database=A.net;Integrated Security=true;";
                SqlConnection conn = new SqlConnection(connString);
                conn.Open();
                var Id = s.Id;
                var Name = s.Name;
                var Dob = s.Dob;
                var Email = s.Email;
                string query = string.Format("insert into Student values ('{0}','{1}','{2}','{3}')", Id, Name,Dob,Email);
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                
                return RedirectToAction("List","Product"); 
            }
            return View(s);
        }
        [HttpPost]
        public ActionResult submit(Student s)
        {
            /*Student S = new Student();
            S.Name = "Tanvir";
            S.Id = 123;
            //S.Dob = DateTime;
            S.Email = "tanvir@gmail.com";*/

            return View(s);
        }
    }
}