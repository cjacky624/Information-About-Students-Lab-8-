﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_8_Final
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] studentNames = { "Andrea", "Anthony", "Brian", "Camille", "Clayton", "Damacious", "David", "Evan", "Heather", "Jacky", "Johnathan", "Katie", "Levi", "Mauricio", "Nicholas", "Rudy", "SeanO", "Steve", "Ty" };
            string[] homeTown = { "Rochester", "Saginaw", "Flint", "Pontiac", "Greenville", "Detroit", "Sterling Heights", "Madison Heights", "Grand Rapids", "Detroit", "Lansing", "Traverse City", "Mackinac City", "Ann Arbor", "Dearborn", "Warren", "Muskegon", "Livonia", "Southfield" };
            string[] favoriteFood = { "Alfredo", "Cheeseburger", "Pie", "Chicken", "Goldfish", "Pizza", "Apple pie", "Frosted Flakes", "French fries", "Chicken tenders", "Pancakes", "Sushi", "Rice", "Pasta", "Cake", "Brownies", "Pho", "Ramen", "Sushi" };

            while (true)
            {
                try
                {
                    Console.WriteLine("Enter a number between 1 to 19.");
                    int userInput = int.Parse(Console.ReadLine());
                    if (userInput <= 19 && userInput >= 1)
                    {
                        for (int i = 0; i < studentNames.Length; i++)
                        {

                            if (userInput - 1 == i)
                            {
                                Console.WriteLine($"Student {i + 1} is {studentNames[userInput - 1]}");
                                while (true)
                                {
                                    Console.WriteLine($"Would you like to know about {studentNames[userInput - 1]}'s hometown or favorite food? (Type hometown or favorite food)");
                                    string userInput2 = Console.ReadLine().ToLower();

                                    if (userInput2 == "hometown") //move down
                                    {
                                        Console.WriteLine($"{studentNames[userInput - 1]}'s hometown is {homeTown[userInput - 1]}");
                                        break;

                                    }

                                    else if (userInput2 == "favorite food")
                                    {

                                        Console.WriteLine($"{studentNames[userInput - 1]}'s favorite food is {favoriteFood[userInput - 1]}");
                                        break;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Invalid input, please try again.");
                                    }
                                }
                                //else do 40

                            }

                        }
                    }

                    else
                    {
                        Console.WriteLine("Sorry, that is not a valid input. Please enter an integer between 1 to 19.");
                    }

                    Console.WriteLine("Would you like to continue?(y/n)");
                    string userInput3 = Console.ReadLine().ToLower();
                    if (userInput3 == "n")
                    {
                        break;
                    }
                }
                catch (IndexOutOfRangeException)
                {
                    Console.WriteLine("The number you entered is out of range. Please enter an integer between 1 to 19.");
                    
                }
                catch (FormatException)
                {
                    Console.WriteLine("Please enter an integer between 1 to 19");
                }
            }




        }
    }
}