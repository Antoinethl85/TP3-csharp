using System;
using System.Linq;
import "C:\Antoine\M1-2021-2022\MovieCollection.cs";

namespace Test
{
    class TP3
    {
        public static void Main(){
            
            //Count all Movies.
            var filmCounter = 0;
            foreach (var film in Movies)
            {
                filmCounter += 1;
            }
            Console.WriteLine(filmCounter);

            //Count all Movies with letter e.
            foreach (var film in Movies)
            {
                Console.WriteLine(film.Count(x => x.Title.Contains("e")));
            }
            
            //Count how many time the letter f is in all the titles from this list.
            foreach (var film in Movies)
            {
                Console.WriteLine(film.Count(x => x == "f"));
            }

            //Display the title of the film with the higher budget.
            foreach (var film in Movies)
            {
                Console.WriteLine(film.Max(x => x.Budget));
            }

            //Display the title of the movie with the lowest box office.
            foreach (var film in Movies)
            {
                Console.WriteLine(film.Min(x => x.BoxOffice));
            }

            //Order the movies by reversed alphabetical order and print the first 11 of the list.
            Movies.Reverse();
            Console.WriteLine(Movies.Take(11));

            //Count all the movies made before 1980
            foreach (var film in Movies)
            {
                Console.WriteLine(film.Count(x => x.ReleaseDate.Year < 1980));
            }

            //Display the average running time of movies having a vowel as the first letter.
            foreach (var film in Movies)
            {
                Console.WriteLine(film.Average(x => x.Title.Contains("a","e","i","o","u","y")));
            }

            //Group all films by the number of characters in the title screen and print the count of movies by letter in the film.
            foreach (var film in Movies.Where(x => x.Title != "").GroupBy(x => x.Title.Length))
            {
                Console.WriteLine(film.Count(x => x.Title.Length == x.Title.Length));
            }

            //Calculate the mean of all Budget / Box Office of every movie ever.
            foreach (var film in Movies)
            {
                Console.WriteLine(film.Average(x => x.Budget));
                Console.WriteLine(film.Average(x => x.BoxOffice));
            }

            //Calculate the mean of all Budget / Box Office of every movie grouped by yearly release date.
            foreach (var film in Movies.Where(x => x.BoxOffice != 0).GroupBy(x => x.ReleaseDate.Year))
            {
                Console.WriteLine(film.Average(x => x.Budget));
                Console.WriteLine(film.Average(x => x.BoxOffice));
            }

            //Print all movies with the letter H or W in the title, but not the letter I or T.
            foreach (var film in Movies)
            {
                var notContain = film.Select(x => x.Title.Contains("i","t"));
                var newList = film.Where(x => !notContain).
                Console.WriteLine(newList.Title.Contains("h","w"));
            }

            // Group all movies made before 1997 by their director, then display the title of the
            // worst movies (ranked by their box office revenue) for each director.
            foreach (var film in Movies.Where(x => x.ReleaseDate.Year < 1997).GroupBy(x => x.DirectedBy))
            {
                Console.WriteLine(film.Title.Min(x => x.BoxOffice));
            }
        }
    }
}

    
