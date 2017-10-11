using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3_Day2_Lists
{
    class Program
    {
        static void Main(string[] args)
        {

            //List<int> testScores = new List<int>() { 98, 100, 76, 84, 93 };

            //testScores.Add(80);
            //testScores.Add(99);// adds an object to the end of the list, linking it in

            //List<int> luckyNumbers = new List<int>();
            //luckyNumbers.Add(2);
            //luckyNumbers.Add(3);
            //luckyNumbers.Add(5);
            //luckyNumbers.Add(7);

            //Console.WriteLine(luckyNumbers.Count);

            //List<string> faveFoods = new List<string>() { "steak", "chicken", "fish", "ice cream" };
            //faveFoods.Add("Oreos");
            //Console.WriteLine(faveFoods[0]);
            //Console.WriteLine(faveFoods[1]);
            //Console.WriteLine(faveFoods[faveFoods.Count - 1]);

            //List<string> leastFaveFoods = new List<string>();
            //leastFaveFoods.Add("stinky cheese");
            //leastFaveFoods.Add("raw onions");
            //leastFaveFoods.Add("anchovies");

            //Console.WriteLine(leastFaveFoods[0]);

            //leastFaveFoods[0] = "Pizza";
            //Console.WriteLine(leastFaveFoods[0]);

            List<string> faveFilms = new List<string>() { "LOTR", "The Matrix", "Iron Sky", "The Iron Giant" };
            faveFilms.Add("Twilight");
            faveFilms.Add("Dr. Strange");

            for (int i = 0; i < faveFilms.Count; i++)
            {
                Console.WriteLine(faveFilms[i]);
            }

            Console.WriteLine();

            faveFilms.Insert(0, "AVATAR");
            faveFilms.Insert(1, "Godzilla");
            faveFilms.Insert(2, "Pan's Labyrinth");

            foreach (string film in faveFilms)
            {
                Console.WriteLine(film);
            }

            Console.WriteLine();

            faveFilms.Remove("Iron Sky");
            // this will remove the first element that's specified in the paratheses
            faveFilms.Remove("Atlantis");

            foreach (string film in faveFilms)
            {
                Console.WriteLine(film);
            }

            List<string> faveAnimals = new List<string>();
            faveAnimals.Add("Lion");
            faveAnimals.Add("Tiger");
            faveAnimals.Add("Bear");
            faveAnimals.Add("Crocodile");
            faveAnimals.Add("Eagle");

            foreach (string animal in faveAnimals)
            {
                Console.WriteLine(animal);
            }

            List<bool> rainForcast = new List<bool>() { true, false, false, true, false };

            for(int i = 0; i < rainForcast.Count; i++)
            {

                if (rainForcast[i] == true)
                {
                    Console.WriteLine("Better bring an umbrella");
                    
                }
                else
                    Console.WriteLine("No rain today, enjoy the sun!");
            }

            List<int> numbers = new List<int>() { 1, 23, 9, 77, 922, 6, 32, 63, 14, 5 };
            Console.WriteLine(numbers.Contains(23));
            Console.WriteLine(numbers.Contains(77));
            Console.WriteLine(numbers.Contains(15));

            numbers.Remove(27);
            numbers.Remove(77);
            numbers.Remove(32);
            numbers.Remove(6);

            Console.WriteLine(numbers.Contains(23));
            Console.WriteLine(numbers.Contains(77));
            Console.WriteLine(numbers.Contains(15));

                
                       

        }

    }
}
