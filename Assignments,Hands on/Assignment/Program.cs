using System;

namespace Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Welcome aliens----------------
            /*Console.WriteLine("Enter your name:");
            String a=Console.ReadLine();
            Console.WriteLine("Hello " + a + " ! Welcome to our planet Earth.");*/

            //Dynamic website----------------
            /*Console.WriteLine("Enter college name"); String name = Console.ReadLine();
            Console.WriteLine("Enter college locality"); String locality = Console.ReadLine();
            Console.WriteLine("Enter college's vision"); String vision = Console.ReadLine();
            Console.WriteLine("Enter college's mission"); String mission = Console.ReadLine();
            Console.WriteLine("Enter the number of departments"); String department = Console.ReadLine();
            Console.WriteLine("Enter student strength"); String strength = Console.ReadLine();
            Console.WriteLine("Enter college rating"); String rating = Console.ReadLine();
            Console.WriteLine(name); Console.WriteLine(locality); Console.WriteLine("Vision " + vision);
            Console.WriteLine("Mission " + mission); Console.WriteLine("No of departments " + department);
            Console.WriteLine("Student Strength " + strength); Console.WriteLine("College Rating " + rating);*/

            //Gain percentage-----------------
            /*Console.Write("Price of the old scooter:");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Repair amount:");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Selling price:");
            float c = float.Parse(Console.ReadLine());
            int d = a + b;float e = c - d;float f = (e * 100)/c;
            Console.WriteLine("Gain percentage is {0:0.00}",f);*/

            //Celsius to Fahrenheit--------------
            /*Console.Write("Temperature in Celsius:");
            float a = float.Parse(Console.ReadLine());
            Console.WriteLine("Temperature in Fahrenheit is {0:0.0}F", ((a * 9 / 5) + 32));*/

            //Finding odd or even--------------
            /*int a= int.Parse(Console.ReadLine());
            if (a % 2 == 0)
            {
                Console.WriteLine(a + " is an even number");
            }
            else { Console.WriteLine(a + " is an odd number"); }*/

            //Checking divisible by 7 and 3---------
            /*int a = int.Parse(Console.ReadLine());
            if(a%7==0 && a % 3 == 0)
            {
                Console.WriteLine(a + " is divisible by both 7 and 3");
            }
            else{ Console.WriteLine(a + " is not divisible by both 7 and 3");  }*/

            //maximuum of three numbers-------------
            //int[] a = new int[];


            //Leap year----------
            /*int a = int.Parse(Console.ReadLine());
            if (a % 4 == 0) {
                if (a % 100 != 0) { Console.WriteLine(a + " is a leap year"); }
                else { Console.WriteLine(a + " is not a leap year"); }
            }
            else { Console.WriteLine(a + " is not a leap year"); }*/

            //Earthquake intensity----------------
            /*float a = float.Parse(Console.ReadLine());
            if (a >= 8.0)
            {
                Console.WriteLine("Great");
            }else if(a >= 7.0 && a <= 7.9){
                Console.WriteLine("Major");
            }else if(a>=6.1 && a <= 6.9)
            {
                Console.WriteLine("Strong");
            }else if(a>=5.5 && a <= 6.0)
            {
                Console.WriteLine("Moderate");
            }else if(a>=2.5 && a <= 5.4)
            {
                Console.WriteLine("Light");
            }
            else { Console.WriteLine("Micro"); }*/

            //Grade calculation--------------
            /*Console.Write("Enter the marks : ");
            int a = int.Parse(Console.ReadLine());
            if (a == 100)
            {
                Console.WriteLine("The student obtained a S grade");
            }else if(a<100 && a >= 90) 
            {
                Console.WriteLine("The student obtained a A grade");
            }else if(a<90 && a >= 80)
            {
                Console.WriteLine("The student obtained a B grade");
            }else if(a<80 && a >= 70)
            {
                Console.WriteLine("The student obtained a C grade");
            }else if(a<70 && a >= 60)
            {
                Console.WriteLine("The student obtained a D grade");
            }else if(a<60 && a >= 50)
            {
                Console.WriteLine("The student obtained a E grade");
            }else if (a < 50)
            {
                Console.WriteLine("The student obtained a F grade");
            }
            else if(a>100 || a < 0)
            {
                Console.WriteLine("Invalid Input");
            }*/

            //palindrome Prize------------
            /*int a = int.Parse(Console.ReadLine());
            int r = 0, re,temp;
            temp = a;
            while (a > 0)
            {
                re = a% 10;
                r = (r * 10) + re;
                a = a / 10;
            }
            if (temp == r)
            {
                Console.WriteLine("yes");
            }
            else { Console.WriteLine("no"); }*/

            //
        }
    }
}
