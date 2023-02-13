using System;

namespace AssignmentStrings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Lower case--------
            Console.WriteLine("Enter the input string");
            string s1 = Console.ReadLine();
            Console.WriteLine("The output string is " + s1.ToLower());

            //splitng string
            Console.WriteLine("Enter the string");
            string s1 = Console.ReadLine();
            string[] s2 = s1.Split(' ');
            foreach(string s3 in s2)
            {
                Console.WriteLine(s3);
            }

            //String operation
            string s1=Console.ReadLine();
            string s2 = Console.ReadLine();
            Console.WriteLine("The length of the first string is " + s1.Length);
            Console.WriteLine("The length of the second string is " + s2.Length);
            Console.WriteLine("The uppercase of the first string is " + s1.ToUpper());
            Console.WriteLine("The uppercase of the second string is " + s2.ToUpper());
            Console.WriteLine("The concatenated string is " + s1 + s2);
            if (string.Compare(s1, s2) == 0)
            {
                Console.WriteLine("Both the input strings are the same");
            }else if(string.Compare(s1, s2) == -1)
            {
                Console.WriteLine(s1+" appears before "+s2);
            }else
            {
                Console.WriteLine(s2 + " appears before " + s1);
            }

            //sms language
            string s1 = Console.ReadLine();
            if (s1.Contains("yes"))
            {
                s1 = s1.Replace("yes", "s");
            }
            if (s1.Contains("why"))
            {
                s1 = s1.Replace("why", "y");
            }
            if (s1.Contains("you"))
            {
                s1 = s1.Replace("you", "u");
            }
            if (s1.Contains("to"))
            {
                s1 = s1.Replace("to", "2");
            }
            Console.WriteLine(s1);

        }
    }
}
