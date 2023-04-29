using LearningMVC.Models;
using Microsoft.AspNetCore.Mvc;
using static System.Net.Mime.MediaTypeNames;
using System.Drawing;
using System;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;

namespace LearningMVC.Models
{
    public class StudentInfoController : Controller
    {
        public IActionResult AddStudent()
        {
            StudentInfoController stdInfo = new StudentInfoController();
            return View();
        }
        [HttpPost]
        public IActionResult AddStudent(StudentInfoModel std)
        {
            string ConnectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=BMC;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";
            SqlConnection Connection = new SqlConnection(ConnectionString);
            Connection.Open();
            String Command = "Insert into StudentInfo values(2,'melina','csit','china')";
            SqlCommand cmd = new SqlCommand(Command, Connection);
            cmd.ExecuteNonQuery();
            Connection.Close();
            return View();
        }
    }
}
