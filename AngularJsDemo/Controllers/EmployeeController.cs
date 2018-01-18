using AngularJsDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AngularJsDemo.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Index()
        {
            return View();
        }
        public JsonResult Get_AllEmployee()
        {
            using (TestAngularEntities Obj = new TestAngularEntities())
            {
                List<Employee> Emp = Obj.Employees.ToList();
                return Json(Emp, JsonRequestBehavior.AllowGet);
            }
        }
    }
}