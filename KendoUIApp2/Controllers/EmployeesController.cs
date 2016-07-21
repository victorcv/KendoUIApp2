using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KendoUIApp2.Controllers
{
    public class EmployeesController : Controller
    {
        readonly Models.NorthwindEntities _context = new Models.NorthwindEntities();
        // GET: Employees
        public ActionResult Index()
        {
            var employees = _context.Employees.Select(e => new
            {
                Id = e.EmployeeID,
                Name = e.FirstName + " " + e.LastName
            });

            return this.Json(employees,JsonRequestBehavior.AllowGet);
        }
    }
}