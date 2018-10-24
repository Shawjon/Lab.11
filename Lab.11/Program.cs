using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Lab._11
{
    class Program
    {
        static void Main(string[] args)
        {
            Movie JamesBond = new Movie("Casino Royale", "Action");
            Movie HarryPotter = new Movie("Harry Potter", "Fantasy");
            Movie WaynesWorld = new Movie("Wayne's World", "Comedy");
            Movie LOTR = new Movie("Lord of the Rings", "Fantasy");
            Movie StarWars = new Movie("Star Wars", "Scifi");
            Movie Departed = new Movie("Departed", "Crime");
            Movie SuperTroopers = new Movie("Super Troopers", "Comedy");
            Movie GodFather = new Movie("The Godfather", "Crime");
            Movie Moana = new Movie("Moana", "Family");
            Movie ToyStory = new Movie("Toy Story", "Family");

            List<Movie> movieList = new List<Movie> {JamesBond,HarryPotter,WaynesWorld,LOTR,StarWars,Departed,SuperTroopers,GodFather,Moana,ToyStory };

            getMainMenu(movieList);
            Console.WriteLine(JamesBond.ReturnTitle(JamesBond));
            Console.WriteLine(movieList[1].ReturnTitle(movieList[1]));
            Console.WriteLine(movieList[1].ReturnCategory(movieList[1]));

            printList(movieList);
            
            searchCategory(movieList,"What Category are you looking for?");








        }
        static void getMainMenu(List<Movie> list)
        {
            Console.Clear();
            
            Console.WriteLine("Welcome to the Movie List Application!");
            Console.WriteLine();
            Console.WriteLine();
            
            Console.WriteLine($"There are {list.Count} Movies in this list.");
        }
        static void printList(List<Movie> list)

        {
            
            Console.WriteLine("-----------------------------------------------------------\n" +
                              "|     Title                  Category                     |\n" +
                              "-----------------------------------------------------------");
            for (int i = 0; i < list.Count; i++)
            {
                 Console.WriteLine("  {0,-20} {1,-1}     {2,-8}",  list[i].ReturnTitle(list[i]),"|", list[i].ReturnCategory(list[i])  );
            }
        }
        
  
        public static void searchCategory(List<Movie> list, string message)
        {
            bool found = false;
            while (found != true)
            {
                Console.WriteLine(message);
                string choice = Console.ReadLine();
                for (int i = 0; i < list.Count; i++)
                {    
                    if (choice.ToLower() == (list[i].ReturnCategory(list[i])).ToLower())
                    {
                        Console.WriteLine("Match");
                        Console.WriteLine(list[i].ReturnTitle(list[i]));
                        break;
                    }
                    else
                    {
                        message = "We could not find that one. PLease try a different word: ";
                    }
                }
            }
            
        
        
            }
        }
    }





