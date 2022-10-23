using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace Day_2_Pro
{
    class Program
    {
        public static void show()
        {
            Console.WriteLine("HEllo");
        }
        static void Main(string[] args)
        {
            /*show();
            Console.WriteLine("Hello World!");
            
            int n;
            
            n = 12;
            Console.WriteLine(n);
            Console.WriteLine("Value of n is : "+ n);
            String name;
            name = "Jawad";
            Console.WriteLine(name.Length);
            Console.WriteLine(name.ToUpper());
            Console.WriteLine(name.ToLower());
            Console.WriteLine(name[2]);
            String str;
            Console.Write("Enter Value: ");
            str = Console.ReadLine();
            int num = Convert.ToInt32(str);
            Console.WriteLine(num);
            Console.WriteLine(str);
            Console.ReadLine();
            String[] fruits = { "Banana", "Orange", "Apple", "Mango" };
            // Sorts the elements of fruits
            Console.WriteLine(fruits);
            */

            Employee e = new Employee();
            e.serRecord(1, "Jawad", 50000);
            e.displayRecord();
            Console.ReadKey();
        }
    }
}
