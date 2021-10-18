using System;
using System.Collections.Generic;

namespace Student_Database_with_Objects
{
    class Program
    {
        static void Main(string[] args)


        {
            //NOTE - USE either a list OR an array in your program

            //Program has to recognize invalid user inputs when the user requests information about students in a class. 

            //The app provides info about students in a class

            //Prompts the user to ask about a particular student

            //The app gives proper responses according to user-submitted info

            //the app asks if the user would like to learn about another student


            bool keepGoing = true;
            while (keepGoing == true)
            {

            //Declaring the arrays and their elements

            string[] names = { "Andy Beer", "Cortez Christian", "Phillip Conrad", "Cordero Ebberhart", "Cullin Flynn", "Ese Jackson", "Calyn Greene", "Ramone Lynch", "Rick Magdaleno", "Antonio Manzari", "James Mitchell", "Richard Moss", "Marjorie Patton", "Huy Phan", "Anurag Reddy", "Zachary Parr", "Cassly Sullen", "Madalina Varasteanu", "Tommy Waalkes", "Erin Walter" };
            string[] hometown = { "Berkley, Mi", "Detroit, Mi", "Canton, Mi", "Berkley, Mi", "Fowlerville, Mi", "Florida", "Portage, Mi", "Fort Lauderdale, FL", "Gilbert, AZ", "Beverly Hills, Mi", "Yap, FSM", "Canton, Mi", "Detroit, Mi", "Lansing, Mi", "Rochester Hills, Mi", "Wyandotte, Mi", "Detroit, Mi", "Saint Clair Shores, Mi", "Raleigh, NC", "Troy, Mi" };
            string[] favoriteFood = { "French fries", "Chicken Fettuccine Alfredo", "Fried Chicken", "BBQ", "Pad Thai", "Shrimp", "Mac and Cheese", "Chicken Soup", "Hamburger", "Focaccia Barese", "Katsu", "Sushi", "Lasagna", "Koren BBQ", "Tacos", "Sushi", "Steak", "Fries", "Curry", "Tacos" };

            Console.WriteLine("Hello! Welcome to our C# Class!");

            //Creating an array of objects
            Student[] classMates = new Student[20];

            //Initializing objects. then passing the 0th element in the declared array of strings above.
            classMates[0] = new Student (names[0], hometown[0], favoriteFood[0]);
            classMates[1] = new Student(names[1], hometown[1], favoriteFood[1]);
            classMates[2] = new Student(names[2], hometown[2], favoriteFood[2]);
            classMates[3] = new Student(names[3], hometown[3], favoriteFood[3]);
            classMates[4] = new Student(names[4], hometown[4], favoriteFood[4]);
            classMates[5] = new Student(names[5], hometown[5], favoriteFood[5]);
            classMates[6] = new Student(names[6], hometown[6], favoriteFood[6]);
            classMates[7] = new Student(names[7], hometown[7], favoriteFood[7]);
            classMates[8] = new Student(names[8], hometown[8], favoriteFood[8]);
            classMates[9] = new Student(names[9], hometown[9], favoriteFood[9]);
            classMates[10] = new Student(names[10], hometown[10], favoriteFood[10]);
            classMates[11] = new Student(names[11], hometown[11], favoriteFood[11]);
            classMates[12] = new Student(names[12], hometown[12], favoriteFood[12]);
            classMates[13] = new Student(names[13], hometown[13], favoriteFood[13]);
            classMates[14] = new Student(names[14], hometown[14], favoriteFood[14]);
            classMates[15] = new Student(names[15], hometown[15], favoriteFood[15]);
            classMates[16] = new Student(names[16], hometown[16], favoriteFood[16]);
            classMates[17] = new Student(names[17], hometown[17], favoriteFood[17]);
            classMates[18] = new Student(names[18], hometown[18], favoriteFood[18]);
            classMates[19] = new Student(names[19], hometown[19], favoriteFood[19]);

            List<Student> School = new List<Student>(classMates);



            Console.WriteLine("Which student would you like to learn more about ? Please enter a number from 1 to 20: ");
            int studentNo = int.Parse(Console.ReadLine()); // Getting user input for which student # they would like to learn about.

            if (!(studentNo >= 1 && studentNo <= 20)) // if the number is not between 1 and 20 then it will tell the user the input was invalid.
            {
                Console.WriteLine("That student does not exist. Please try again.");
            }
            else
            {
                Console.WriteLine("Student number " + studentNo + " is " + School[studentNo - 1].Names); //Displaying the number and name of the student then calling an array that has been declared above.
                                                                                                  //between square brackets declaring the number of the element (-1 because computers start counting from 0
                Console.WriteLine("What would you like to know about " + School[studentNo - 1].Names + " ? Please enter 'hometown' or 'favorite food': ");
                string userInput = Console.ReadLine().ToLower();
                string userAnswer;

                if (userInput == "hometown")
                {
                    Console.WriteLine(School[studentNo - 1].Names + " is from " + School[studentNo - 1].HomeTown + ". Would you like to know more? y/n");
                    userAnswer = Console.ReadLine();
                    if (userAnswer == "y")
                    {
                        Console.WriteLine(School[studentNo - 1].Names + "'s favorite food is " + School[studentNo - 1].FavoriteFood);
                    }
                }
                else if (userInput == "favorite food")
                {
                    Console.WriteLine(School[studentNo - 1].Names + "'s favorite food is " + School[studentNo - 1].FavoriteFood+ ". Would you like to know more? y/n");
                    userAnswer = Console.ReadLine();
                    if (userAnswer == "y")
                    {
                        Console.WriteLine(School[studentNo - 1].Names + " is from " + School[studentNo - 1].HomeTown);
                    }
                }
                else
                {
                    Console.WriteLine("That data does not exist. Please try again.");
                }

                keepGoing = Continue();
            }
        }
    }

    public static string GetInput(string prompt)
    {
        Console.WriteLine(prompt);
        string output = Console.ReadLine().ToLower();

        return output;
    }
    public static bool Continue()
    {
        string userInput = GetInput("Would you like to continue learning about another student? y/n ");


        if (userInput == "y")
        {
            return true;
        }
        else if (userInput == "n")
        {
            Console.WriteLine("Thanks");
            return false;
        }
        else
        {
            Console.WriteLine("Invalid input.");
            return Continue();
        }

    }
}
    }

   
