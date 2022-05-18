using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace set_and_get
{
    class Movie
    {
        public string title;
        public string director;
        private string rating = "";
        public Movie(string aTitle, string aDirector, string aRating)
        {
            this.title = aTitle;
            this.director = aDirector;
            Rating = aRating;
        }

        //method setter and getter
        public string Rating
        {
            get { return rating; }
            set
            {
                if (value == "G" || value == "PG")
                {
                    rating = value;
                }
                else
                {
                    rating = "NR";
                }
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Movie vida = new Movie("La vita e bella", "Roberto", "PG");
            Movie devoluciones = new Movie("No se aceptan devoluciones", "Eugenio", "Dog");

            //rating = PG,G,PG-13

            Console.WriteLine(devoluciones.Rating);
            Console.ReadKey();
        }
    }
}
