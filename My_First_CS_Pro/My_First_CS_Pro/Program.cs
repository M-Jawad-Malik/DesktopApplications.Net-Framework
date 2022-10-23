using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace My_First_CS_Pro
{
    
    
    class Program
    {
        
        
        static void Main(string[] args)
        {
            int choice;
            double radius;
            Console.WriteLine("Enter Radius of Circle: ");
            radius = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter your Choice: ");
            choice = Convert.ToInt32(Console.ReadLine());
            double area = 3.14 * radius * radius;
            double circum = 2 * 3.14 * radius;
            if(choice==1)
            {
                Console.WriteLine("Area of Circle: " + area);
            }
            else if(choice==2)
            {

                Console.WriteLine("Circumference of Circle: " +circum);
            }    
            else
            {
                Console.WriteLine("Invalid Choice");
            }



            Console.ReadLine();


        }
    }
}
