using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_2_Pro
{
    class Employee
    {
        public int id;
        public string name;
        public float salary;
        public string color = "red";
        public void serRecord(int i,string n,float s)
        {
            id = i;
            name = n;
            salary = s;
        } 
        public void displayRecord()
        {
            Console.WriteLine(id + " " + name + " " + salary);
        }
    }
}
