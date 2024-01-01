using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Assignment6
{
    internal class Q3
    {
        static void Main(string[] args)
        {
           
            SortedList sl = new SortedList();
            sl.Add(221, "Ashal");
            sl.Add(222, "Sooraj");
            sl.Add(223, "Sajid");
            sl.Add(224, "Karthik");

            foreach (var item in sl.Keys)
            {
                Console.WriteLine($"Emp_Id:{item} Name:{sl[item]}");
            }
        }
    }
}