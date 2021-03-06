﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POSeidon
{
    public class Employee
    {
        //privates
        private string firstName, lastName;
        private double wages;
        private bool empManager, empFullTime, empSales, empPay;

        //default constuctor
        public Employee()
        {
            firstName = lastName = "";
            wages = 0.0;
            empManager = empFullTime = empSales = empPay = false;

        }
        //overloaded constructor with all fields
        public Employee(string fn, string ln, double w, bool man, bool ftime, bool sale, bool pay)
        {
            firstName = fn;
            lastName = ln;
            wages = w;
            empManager = man;
            empFullTime = ftime;
            empSales = sale;
            empPay = pay;
        }
        //mutator functions
        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public double Wages { get => wages; set => wages = value; }
        public bool EmpManager { get => empManager; set => empManager = value; }
        public bool EmpFullTime { get => empFullTime; set => empFullTime = value; }
        public bool EmpSales { get => empSales; set => empSales = value; }
        public bool EmpPay { get => empPay; set => empPay = value; }

    }
}

