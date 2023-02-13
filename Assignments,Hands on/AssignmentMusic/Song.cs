using System;
using System.Collections.Generic;
using System.Text;

namespace AssignmentMusic
{
    internal class Song
    {
        private string _title;
        private string _genre;
        private string _duration;
        private double _rating;

        public Song()
        {

        }
        public Song(string title, string genre, string duration, double rating)
        {
            _title = title;
            _genre = genre;
            _duration = duration;
            _rating = rating;

        }
        public string Title
        {
            get { return _title; }
            set { _title = value; }
        }
        public string Genre
        {
            get { return _genre; }
            set { _genre = value; }
        }
        public string Duration
        {
            get { return _duration; }
            set { _duration = value; }
        }
        public double Rating
        {
            get { return _rating; }
            set { _rating = value; }
        }
         public void Display()
        {
            Console.WriteLine("Titlte : " + Title);
            Console.WriteLine("Genre : " + Genre);
            Console.WriteLine("Duration : " + Duration);
            Console.WriteLine("Rating : " + Rating);
        }
    }
}
