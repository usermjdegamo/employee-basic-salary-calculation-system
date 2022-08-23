using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmployeeSalaryCalculationSystem.Models
{
    public class Salary
    {
        public string empName { get; set; }
        public double empSal { get; set; }
        public double empTax { get; set; }
        public double empNetPay { get; set; }
    }
}