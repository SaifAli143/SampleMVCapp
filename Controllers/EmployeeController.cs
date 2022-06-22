using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SampleMVCapp.Models;

namespace SampleMVCapp.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        [HttpGet]
        public ActionResult Employeelist()
        {
            List<Employee> Employeelist = new List<Employee>()
            {
               
            };
            ViewBag.Employeelist = Employeelist;
            return View();
        }
        [HttpPost]
        public ActionResult Employeelist(FormCollection fs)
        {
            ViewBag.EmployeeId = fs["ID"];
            ViewBag.Employeename = fs["Name"];
            ViewBag.Employeedesignation = fs["designation"];
            ViewBag.EmployeeDepartment = fs["Department"];
            ViewBag.EmployeeSalary = fs["Salary"];
            return View("EmployeeDetails");


        }
        
    }
}