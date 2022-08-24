using System;
using System.Collections.Generic;
using System.Text;

namespace Methods
{
    class Smovie
    {
        string movie;
        string actorname;
        float rating;
        string release;

        public string Movie
        {
            set { movie = value; }
            get { return movie; }
        }
        public string Actorname
        {
            set { actorname = value; }
            get { return actorname; }
        }
        public float Rating
        {
            set { rating = value; }
            get { return rating; }
        }
        public string Release
        {
            set { release = value; }
            get { return release; }
        }

        public string ToString()
        {
            return "Movie :" + movie + " Actorname :" + actorname + " Rating :" + rating + " Realese :" + release;
        }

        static void Main(string[] args)
        {
            Smovie m1 = new Smovie();
            m1.movie = "singham";
            m1.actorname = "ajay devgan";
            m1.rating = 5;
            m1.release = "20-12-2021";

            Console.WriteLine("Movie :" + m1.movie);
            Console.WriteLine("Actorname :" + m1.actorname);
            Console.WriteLine("Rating :" + m1.rating);
            Console.WriteLine("Realese :" + m1.release);


        }
    }
}

    