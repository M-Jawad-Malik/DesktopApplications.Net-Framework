using Microsoft.VisualBasic.CompilerServices;
using System;

namespace S_Day_Pro
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //C# Data Types, numbers, string, Date time,
            string name = "Jawad";
            int age = 21;
            double height = 5.9;
            char firstLetofNm = 'J';
            bool isBoy = true;
            float weight = 65.0F;
            DateTime dttime = DateTime.Now;
            Console.WriteLine(String.Format("Name: {0}, age: {1}, height: {2}, first Letter of Name: {3}, isBoy: {4}, weight: {5}, Current Date Time: {6}", name, age, height, firstLetofNm, isBoy, weight, dttime));


          //Structure
            PerSonalInfo perinfo;
            perinfo.name = "Jawad";
            perinfo.age = 21;
            perinfo.height = 5.9;
            perinfo.weight = 65;
            Console.WriteLine(perinfo);
           
            
            //Dynamic Types
            dynamic MyDynamicVar = 100;
            Console.WriteLine(String.Format("Value: {0}, Type: {1}", MyDynamicVar, MyDynamicVar.GetType()));

            //Enum
            Temperature t = Temperature.High;
            Console.WriteLine(t);

            //Operters
            int a = 5;
            int b = 4;

            //Arithmetic Operators
            Console.WriteLine(String.Format("Addition: {0}, Subtraction: {1}, Division: {2}, Multiplication: {3}", a + b, a - b, a / b, a * b));

            //Some Other Operators
            a++;
            Console.WriteLine(a);
            a--;
            Console.WriteLine(a);
            a += 1;
            Console.WriteLine(a);
            a -= 1;
            Console.WriteLine(a);

            //Conditional Statement
            int num = 10;
            if (num % 2 == 0)
            {
                Console.WriteLine("It is even number");
            }

            //Switch Statement
            Console.WriteLine("Enter a number:");
            int val = Convert.ToInt32(Console.ReadLine());

            switch (val)
            {
                case 10: Console.WriteLine("It is 10"); break;
                case 20: Console.WriteLine("It is 20"); break;
                case 30: Console.WriteLine("It is 30"); break;
                default: Console.WriteLine("Not 10, 20 or 30"); break;
            }

            //For Loop
            for (int i = 1; i <= num; i++)
            {
                Console.WriteLine(i);
            }

            //For Each Loop
            String[] myArray = {"Ali","JAwad","Ahmad","Bilal","Awais" };

            foreach(string i in myArray)
            {
                Console.WriteLine(i);
            }
            
            //Break
            for (int i = 1; i <= num; i++)
            {
                if (i == 5)
                {
                    break;
                }
                Console.WriteLine(i);
            }

            //Goto Statement
            a:
            Console.WriteLine("You are not eligible to vote!");

            Console.WriteLine("Enter your age:\n");
            int ageofVotee = Convert.ToInt32(Console.ReadLine());
            if (ageofVotee < 18)
            {
                goto a;
            }
            else
            {
                Console.WriteLine("You are eligible to vote!");
            }


            //Public access Specifier
            Show(perinfo);


            //Private Access Specifier
            //t is varialbe defined above
            Program p = new Program();
            p.ShowTempEnum(t);

            //protected Access Specifier
            p.PerInfo((String.Format("Name: {0}, age: {1}, height: {2}, first Letter of Name: {3}, isBoy: {4}, weight: {5}, Current Date Time: {6}", name, age, height, firstLetofNm, isBoy, weight, dttime).ToString()));

            //this key word and internal specifier
            Employee Emp = new Employee(142,name,20000);
            Emp.display();

            Console.ReadKey();


        }
        //Structure Definition
       public struct PerSonalInfo
        {
            public string name;
            public int age;
            public double height;
            public float weight;
        };
    
        //Enum
        public enum Temperature
        {
            Low,
            High,
            Medium
        }


        //Access Specifiers
        public static void Show(PerSonalInfo Per)
        {
            Console.WriteLine(Per);
        }
        private void ShowTempEnum(Temperature T)
        {
            Console.WriteLine(T);
        }
        protected void PerInfo(String s)
        {
            Console.WriteLine(s);
        }


        //this Keyword and internal class
        internal class Employee
        {
            public int id;
            public String name;
            public float salary;
            public Employee(int id, String name, float salary)
            {
                this.id = id;
                this.name = name;
                this.salary = salary;
            }
            public void display()
            {
                Console.WriteLine(id + " " + name + " " + salary);
            }
        }
    }
}
