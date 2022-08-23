using EmployeeSalaryCalculationSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EmployeeSalaryCalculationSystem.Controllers
{
    public class SalaryController : Controller
    {
        // GET: Salary
        public ActionResult Index()
        {
            return View(new Salary());
        }

        [HttpPost]
        public ActionResult Index(Salary s)
        {
            if (s.empSal > 50000)
                s.empTax = s.empSal * 10 / 100;
            else if (s.empSal > 30000)
                s.empTax = s.empSal * 5 / 100;
            else s.empTax = 0;

            s.empNetPay = s.empSal - s.empTax;

            return View(s);
        }
    }
}