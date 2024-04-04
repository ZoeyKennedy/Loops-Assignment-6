using System.Numerics;

namespace Loops_Assignment_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int min;
            int max;
            int between;
            string choice = "";
            int over70;
            int testScore;
            while (choice != "q")
            {
                Console.Clear(); // Optional
                Console.WriteLine("Welcome to my loops program assignments. Please select an option:");
                Console.WriteLine();
                Console.WriteLine("1 - Prompter ");
                Console.WriteLine("2 - Percent Passing");
                Console.WriteLine("...");
                Console.WriteLine("x - Menu Option x");
                Console.WriteLine("Q - Quit");
                Console.WriteLine();
                choice = Console.ReadLine().ToLower().Trim();
                Console.WriteLine();

                if (choice == "1")
                {
                    //Do option 1
                    Console.WriteLine("You chose option 1");
                    Console.WriteLine("Hit ENTER to continue.");
                    Console.ReadLine();
                    

                    Console.WriteLine("Enter a minimum value");
                    while (!int.TryParse(Console.ReadLine(), out min))
                        Console.WriteLine("Input needs to be an integer, try again.");

                    Console.WriteLine("Enter a maximum value");
                    while (!int.TryParse(Console.ReadLine(), out max))
                        Console.WriteLine("Input needs to be an integer, try again."); //you don't need brackets if it's only one line of code

                    while (min > max)
                    {
                        Console.WriteLine("The maximum value needs to be an integer higher than the mimimum value");
                        Console.WriteLine("Your minimum value is " + min);
                        int.TryParse(Console.ReadLine(), out max);
                    }

                    Console.WriteLine("Enter an integer between " + min + " and " + max);
                    while (!int.TryParse(Console.ReadLine(), out between) || between > max || between < min)
                        Console.WriteLine("Input needs to be an integer between the numbers " + min + " and " + max + " , try again.");

                }
                else if (choice == "2")
                {
                    // Do option 2
                    Console.WriteLine("You chose option 2");
                    Console.WriteLine("Hit ENTER to continue.");
                    Console.ReadLine();

                    Console.WriteLine("Enter as many test scores as you like, seperate each one by pressing ENTER.");
                    Console.WriteLine("When you're done entering the test scores type '500' ");

                    while (!int.TryParse(Console.ReadLine(), out testScore))
                            Console.WriteLine("Input needs to be an integer, try again.");
                    while (testScore != 500)
                    {
                       
                        
                    }




                }
                // Add an else if for each valid choice...

                else
                {
                    Console.WriteLine("Invalid choice, press ENTER to continue.");
                    Console.ReadLine();
                    
                }
            }
           




        }
    }
}
