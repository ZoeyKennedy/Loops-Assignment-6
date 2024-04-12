using _5._5_Lesson;
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
            int minNum;
            int maxNum;
            string choice = "";
            int over70;
            int under70;
            over70 = 0;
            under70 = 0;
            int testScore;
            double balance;
            double bet;
            string type;
            double amountWon; 
            while (choice != "q")
            {
                Console.Clear(); // Optional
                Console.WriteLine("Welcome to my loops program assignments. Please select an option:");
                Console.WriteLine();
                Console.WriteLine("1 - Prompter ");
                Console.WriteLine("2 - Percent Passing");
                Console.WriteLine("3 - OddSum");
                Console.WriteLine("4 - Random Numbers");
                Console.WriteLine("5 - Dice Game");
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


                    bool done = false;
                    while (testScore != 500 && testScore > 0 && testScore <= 100) //valid input 0-100 and 500
                    {
                        Console.WriteLine("Enter a test score");
                        testScore = Convert.ToInt32(Console.ReadLine());
                       

                        if (testScore >= 70)
                        {
                            over70 = (over70 + 1);
                        }
                        else
                        {
                            under70 = (under70 + 1);    
                        }
                    }

                    
                    while (!done)
                    {
                        Console.WriteLine("Please enter a valid test score. (0-100 or 500 to stop entering test scores)");
                        testScore = Convert.ToInt32(Console.ReadLine());
                        if (testScore == 500)
                        {
                            Console.WriteLine(over70 + " test scores were 70% or higher");
                            Console.WriteLine(under70 + " test scores were under 70%");
                            Console.WriteLine("Press ENTER to clear");
                            Console.ReadLine();
                            done = true;
                        }

                        else if (testScore >= 70)
                        {
                            over70 = (over70 + 1);
                        }
                        else
                        {
                            under70 = (under70 + 1);
                        }
                    }
                   

                }
                // Add an else if for each valid choice...
                else if ( choice == "3")
                {
                    int number;

                    Console.WriteLine("Enter a number between 1 and 50");
                    number = Convert.ToInt32(Console.ReadLine());
                    while (number > 50 || number < 1)
                    {
                        Console.WriteLine("Choose a number between 1 and 50.");
                        number = Convert.ToInt32(Console.ReadLine());
                    }
                    if (number > 0 && number <= 50)
                    {
                        for (int i = 1; i <= number; i += 2)
                        {
                            Console.WriteLine($"{i}");
                        }
                        Console.WriteLine("Press ENTER to finish");
                        Console.ReadLine();
                    }

                    


                }
                else if (choice == "4")//Random Numbers

                {
                    Console.WriteLine("Enter a minimum number (number must be positive)");
                    minNum = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter a maximum number (25 or under)");
                    maxNum = Convert.ToInt32(Console.ReadLine());
                    while (maxNum > 25 || minNum <1)
                    {
                        Console.WriteLine("Invalid input.");
                        Console.WriteLine("Enter a minimum number (number must be positive)");
                        minNum = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter a maximum number (25 or under)");
                        maxNum = Convert.ToInt32(Console.ReadLine());
                    }
                        for (int i = minNum; i <= maxNum; i++)
                        {
                            Console.WriteLine(new Random().Next(minNum, maxNum));
                        }
                    Console.ReadLine();
                }
                else if (choice == "5") // no negative numbers, bet less than bank balance 
                {

                    



                    balance = 100;


                    Die die1, die2;

                    die1 = new Die();
                    die2 = new Die();

                    while (balance > 0)
                    {
                        Console.WriteLine("Bank balance: " + balance);
                        Console.WriteLine("How much money would you like to bet on the dice game?");
                        bet = Convert.ToDouble(Console.ReadLine());

                        while (bet > balance || bet <= 0)
                        {
                            Console.WriteLine("Invalid bet. Please enter a positive amount lower than your bank balance.");
                            bet = Convert.ToDouble(Console.ReadLine());

                        }

                        Console.WriteLine("Would you like to bet on doubles, not doubles, an even sum or an odd sum? ");
                        Console.WriteLine("Type the name of the type of bet");
                        type = Console.ReadLine();
                        type = type.ToUpper();



                        switch (type)
                        {
                            case "DOUBLES" or "DOUBLE":
                                die1 = new Die();
                                die2 = new Die();

                                Console.WriteLine(die1);
                                die1.DrawRoll();
                                Console.WriteLine(die2);
                                die2.DrawRoll();

                                if (die1 == die2)
                                {
                                    amountWon = bet * 2;
                                    balance = amountWon + bet;
                                    Console.WriteLine("You won " + amountWon + "!");
                                    balance = balance + amountWon;
                                    Console.WriteLine("Your new balance is " + (balance));
                                }
                                else
                                {
                                    balance = balance - bet;
                                    Console.WriteLine("Sorry! You lost your bet.");
                                    Console.WriteLine("Your new balance is " + (balance));
                                    //bet again?
                                }
                                break;
                            case "NOT DOUBLES" or "NOT DOUBLE":
                                die1 = new Die();
                                die2 = new Die();

                                Console.WriteLine(die1);
                                die1.DrawRoll();
                                Console.WriteLine(die2);
                                die2.DrawRoll();

                                if (die1 != die2)
                                {
                                    amountWon = bet / 2;
                                    balance = balance + amountWon;
                                    Console.WriteLine("You won " + (amountWon) + "!");
                                    Console.WriteLine("Your new balance is " + balance);

                                }
                                else
                                {
                                    balance = balance - bet;
                                    Console.WriteLine("Sorry! You lost your bet.");
                                    Console.WriteLine("Your new balance is " + balance);

                                }
                                break;
                            case "EVEN SUM":
                                die1 = new Die();
                                die2 = new Die();

                                Console.WriteLine(die1);
                                die1.DrawRoll();
                                Console.WriteLine(die2);
                                die2.DrawRoll();

                                if ((die1.roll + die2.roll) % 2 == 1)
                                {
                                    balance = balance - bet;
                                    Console.WriteLine("Sorry! You lost your bet. ");
                                    Console.WriteLine("Your new balance is " + balance);
                                }
                                else
                                {
                                    balance = balance + bet;
                                    Console.WriteLine("You won " + (bet) + "!");
                                    Console.WriteLine("Your new balance is " + balance);
                                }

                                break;
                            case "ODD SUM":
                                die1 = new Die();
                                die2 = new Die();

                                Console.WriteLine(die1);
                                die1.DrawRoll();
                                Console.WriteLine(die2);
                                die2.DrawRoll();

                                if ((die1.roll + die2.roll) % 2 == 1)
                                {
                                    balance = balance + bet;
                                    Console.WriteLine("You won " + (bet) + "!");
                                    Console.WriteLine("Your new balance is " + balance);
                                }
                                else
                                {
                                    balance = balance - bet;
                                    Console.WriteLine("Sorry! You lost your bet. ");
                                    Console.WriteLine("Your new balance is " + balance);

                                }
                                break;

                        }
                    }
                    while (balance == 0 || balance < 0)
                    {
                        Console.WriteLine("Sorry! You can no longer bet, your bank balance is 0.");
                        Console.ReadLine();
                        break;
                    }



            }

                else
                {
                    Console.WriteLine("Invalid choice, press ENTER to continue.");
                    Console.ReadLine();
                    
                }
            }
           




        }
    }
}
