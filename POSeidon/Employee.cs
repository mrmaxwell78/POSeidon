using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POSeidon
{
    public class Employee:Person
    {
        //privates
        private string  userName, password;
        private double wages;
        private bool empManager, empFullTime, empSales, empPay;

        //default constuctor
        public Employee()
        {
            wages = 0.0;
            empManager = empFullTime = empSales = empPay = false;

        }
        //overloaded constructor with all fields
        public Employee(string fn, string ln, double w, bool man, bool ftime, bool sale, bool pay)
        {
         
            wages = w;
            empManager = man;
            empFullTime = ftime;
            empSales = sale;
            empPay = pay;
        }
        //mutator functions
     
        public double Wages { get => wages; set => wages = value; }
        public bool EmpManager { get => empManager; set => empManager = value; }
        public bool EmpFullTime { get => empFullTime; set => empFullTime = value; }
        public bool EmpSales { get => empSales; set => empSales = value; }
        public bool EmpPay { get => empPay; set => empPay = value; }
        public string UserName { get => userName; set => userName = value; }
        public string Password { get => password; set => password = value; }
    }
}

