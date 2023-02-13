using System;
using System.Collections.Generic;

namespace AssignmentMusic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Song s1 = new Song();
            List<Song> sss = new List<Song>();
            Console.WriteLine("Enter song 1 details");
            string a = Console.ReadLine();
            //string[] b = a.Split(',');
            s1.Title = a.Split(',')[0];
            s1.Genre = a.Split(',')[1];
            s1.Duration = a.Split(',')[2];
            s1.Rating = Convert.ToDouble(a.Split(',')[3]);
            sss.Add(s1);

            Song s2=new Song();
            Console.WriteLine("Enter song 2 details");
            string a1 = Console.ReadLine();
            //string[] b1 = a1.Split(',');
            s2.Title = a.Split(',')[0];
            s2.Genre = a.Split(',')[1];
            s2.Duration = a.Split(',')[2];
            s2.Rating = Convert.ToDouble(a.Split(',')[3]);
            sss.Add(s2);
            Console.WriteLine();
            foreach (Song item in sss)
            {
                Console.WriteLine("Titlte : " + item.Title);
                Console.WriteLine("Genre : " + item.Genre);
                Console.WriteLine("Duration : " + item.Duration);
                Console.WriteLine("Rating : " + item.Rating);
            }
            //Console.WriteLine("Song 1");
            //s1.Display();
            //Console.WriteLine("Song 2");
            //s2.Display();
        }
    }
}
