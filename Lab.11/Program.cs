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


            int x;
            bool yesNo = true;
            while (yesNo == true)
            {

                try
                {
                    getMainMenu(movieList);
                    x = Convert.ToInt32(Console.ReadLine());
                    if (x == 1)
                    {
                        Console.Clear();
                        printList(movieList);
                        Console.ReadKey();
                        continue;
                    }
                    else if (x == 2)
                    {
                        searchCategory(movieList,"What Category are you looking for?");
                        continue;
                    }
                    else if (x == 3)
                    {
                        Console.WriteLine("Have a good day!");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("That is not a valid option, try again");
                        continue;
                    }

                }
                catch (FormatException)
                {
                    Console.WriteLine("That is not a valid input");
                }
            }

        }
        static void getMainMenu(List<Movie> list)
        {
            Console.Clear();
            
            Console.WriteLine("Welcome to the Movie List Application!");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine($"There are {list.Count} Movies in this list.");
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("1. Print list. ");
            Console.WriteLine("2. Search for Movie(s).");
            Console.WriteLine("3. Exit.");
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
            int count = 0;
            while (found != true)
            {
                Console.WriteLine(message);
                string choice = Console.ReadLine();
                for (int i = 0; i < list.Count; i++)
                {
                    for (int j = 0; j < list.Count; j++)
                    {
                       
                        if (choice.ToLower() == (list[i].ReturnCategory(list[i])).ToLower())
                        {
                            Console.WriteLine(list[i].ReturnTitle(list[i]));
                            Console.ReadKey();
                            count++;
                            found = true;
                            break;
                            
                        }
                        else
                        {
                            if (count<0)
                            {
                                found = true;
                            }
                            message = "We could not find that one. Please try a different word: ";
                        }
                        
                    }
                    
                }
            }
            
        
        
            }
        }
    }





