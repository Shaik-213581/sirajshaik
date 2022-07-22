using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCFirstProject.Models
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult EmployeeInfo()
        {
            Employee employee = new Employee()
            {
                EmployeeId = 1001,
                EmployeeName = "Azeem",
                EmployeeLocation = "Hyderabad"
            };

            return View(employee);
        }
    }
}