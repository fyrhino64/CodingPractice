using System;

namespace BekahHomeworkStuff
{
    class Program
    {
        static void Main(string[] args)
        {
            string mainChoice;
            while (true)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("What would you like to do?");
                Console.ResetColor();
                Console.WriteLine("1. Class SignUp");
                Console.WriteLine("2. Shopping");
                Console.WriteLine("3. Loops!");
                Console.WriteLine("4. Pricing!");
                Console.WriteLine("5. Indexed Shopping");
                Console.WriteLine("6. Quit");
                mainChoice = Console.ReadLine();

                if (mainChoice == "1")
                {
                    ClassSchedule();
                }
                else if (mainChoice == "2")
                {
                    Shopping();
                }
                else if (mainChoice == "3")
                {
                    Loops();
                }
                else if (mainChoice == "4")
                {
                    Pricing();
                }
                else if (mainChoice == "5")
                {
                    indexShopping();
                }
                else if (mainChoice == "6")
                {
                    break;
                }
            }
        }//End MainChoices
        static void ClassSchedule()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            int totalClasses = 0;
            string classChoiceCheck;
            string[] classChoice = new string[6];

            Console.WriteLine("Class Signup");
            Console.WriteLine("---------------------------");
            Console.WriteLine("It's time to sign up for next semesters classes. Please follow the below prompts to enter your desired class schedule!");

            Console.ResetColor();
            int classMax = 6;
            Console.WriteLine("\n");
            for (int i = 0; i < classMax; i++)
            {
                Console.WriteLine("Enter the class of your choice (" + (i + 1) + " of 6) or Type STOP");
                classChoiceCheck = Console.ReadLine();
                if (checkIfStop(classChoiceCheck))
                {
                    classChoice[i] = classChoiceCheck;
                    totalClasses++;
                    Console.WriteLine("You chose " + classChoiceCheck);
                }
                else
                {

                    break;
                }
            }
            Console.WriteLine("\n");
            Console.WriteLine("Your new Class Schedule is: ");
            foreach (string choice in classChoice)
            {
                Console.WriteLine(choice);
            }

            //hit any key to return to main menu
            Console.WriteLine("\n");
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();

        }//End Class Schedules

        static void Shopping()
        {
            Console.Clear();
            Console.ResetColor();
            int i = 0;
            double cartTotal = 0;
            string classChoice;
            double numberToAdd;
            string[,] productPrices = new string[5, 2] { { "Pencils", "1.09" }, { "Notebook", "1.59" }, { "Eraser", "0.55" }, { "Planner", "5.00" }, { "School Shirt", "12.62" } };
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Let's do some School Shopping!");
            Console.WriteLine("---------------------------");
            Console.WriteLine("Review the items available for sale below and follow the prompts to add themt o your cart!");
            Console.ResetColor();
            Console.WriteLine("\n");
            while (true)
            {
                //while i is less than or equal to the array length will display the below
                for (int j = 0; j <= 4; j++)
                {
                    //display products and their associate prices until user quits
                    Console.WriteLine("\n");
                    Console.WriteLine(productPrices[i, 0] + ": " + productPrices[i, 1]);
                    Console.WriteLine("Would you like to add " + productPrices[i, 0] + " to your cart? y or n or STOP to checkout");
                    classChoice = Console.ReadLine();
                    //check if user wants to checkout, if not checks if they are adding to cart or not
                    if (checkIfStop(classChoice))
                    {
                        if (classChoice == "y")
                        {
                            Console.WriteLine("How many would you like to add?");
                            numberToAdd = Convert.ToDouble(Console.ReadLine());
                            //take current item's price, multiply by number of items added, and add to cart total
                            cartTotal = cartTotal + (Convert.ToDouble(productPrices[i, 1]) * numberToAdd);
                            Console.WriteLine("Current Cart Total is: $" + Math.Round(cartTotal, 2));
                            i++;
                        }
                        else if (classChoice == "n")
                        {
                            Console.WriteLine("Thank you for your input.");
                            i++;
                        }
                    }
                    else
                    {
                        break;
                    }
                }
                Console.WriteLine("Are you ready to checkout? type STOP to checkout or n to continue shopping");
                classChoice = Console.ReadLine();
                //checks if user types stop
                if (checkIfStop(classChoice))
                {
                    // sets variable back to 0 to send user back through shopping options
                    i = 0;
                }
                else
                {
                    //breaks loop and sends to total screen
                    break;
                }
            }

            Console.WriteLine("\n");
            Console.WriteLine("Your total today will be: $" + Math.Round(cartTotal, 2));

            //hit any key to return to main menu
            Console.WriteLine("\n");
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();

        }//End Shopping

        static void Loops()
        {
            Console.Clear();
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Counting!");
            Console.WriteLine("---------------------------");
            Console.ResetColor();
            int add;
            int sum = 0;

            for (int i = 1; i <= 10; i++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine("\n");
            for (int j = 0; j <= 9; j++)
            {
                Console.Write(10 - j + " ");
            }
            Console.WriteLine("\n");
            for (int k = 1; k <= 20; k++)
            {
                if (k % 2 == 0)
                {
                    Console.Write(k + " ");
                }
            }

            Console.WriteLine("\n");
            Console.WriteLine("----------------------");
            Console.WriteLine("Adding Program");
            for (int r = 0; r <= 4; r++)
            {
                Console.WriteLine("Enter a number: ");
                add = Convert.ToInt32(Console.ReadLine());
                sum = sum + add;
            }
            Console.WriteLine("The sum of all entered numbers is " + sum);

            //hit any key to return to main menu
            Console.WriteLine("\n");
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
        }//End Loops

        static void Pricing()
        {
            double price;
            double taxRate;
            double quarters;
            double dimes;
            double nickels;
            double pennies;

            // Take input for price and tax rate
            Console.Clear();
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Price Calculator");
            Console.WriteLine("------------------");
            Console.WriteLine("\n");
            Console.ResetColor();
            Console.WriteLine("Please enter a price: ");
            price = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please enter a tax rate: ");
            taxRate = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Price: " + price);
            Console.WriteLine("Tax Rate: " + taxRate);
            //Call Calculation method to calculate and display total from input
            PricePlusTax(price, taxRate);

            // Take input amount of coins and store in appropriate variables
            Console.WriteLine("\n");
            Console.WriteLine("---------------------");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("How much money do you have in your pocket?");
            Console.WriteLine("\n");
            Console.WriteLine("---------------------");
            Console.ResetColor();
            Console.Write("Enter the amount of quarters you have in your pocket: ");
            quarters = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the amount of dimes you have in your pocket: ");
            dimes = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the amount of nickels in your pocket: ");
            nickels = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the amount of pennies in your pocket: ");
            pennies = Convert.ToDouble(Console.ReadLine());
            //call calculation method to convert coin amonts into money value
            CountChange(quarters, dimes, nickels, pennies);

            //hit any key to return to main menu
            Console.WriteLine("\n");
            Console.WriteLine("Hit any key to continue...");
            Console.ReadKey();

        }//End Pricing

        //The below is essentially the same as the Shopping program. But below, we are calling indexes in addition to the use of a multidimensional array
        static void indexShopping()
        {
            string classChoice;
            double quantity;
            double cartTotal = 0;
            int i = 0;
            //intializes/gets data store in IndexStoreProducts class array
            indexDataStoreProducts ic = new indexDataStoreProducts();
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Let's do some school shopping!");
            Console.WriteLine("Review the items available for sale below and follow the prompts to add themt o your cart!");
            Console.ResetColor();
            while (true)
            {
                for (int j=0; j<=2; j++)
                {
                    Console.WriteLine("\n");
                    Console.WriteLine(ic[i, 0] + ": " + ic[i, 1]);
                    Console.WriteLine("Would you like to add " + ic[i,0] + " to your cart? y or n or STOP to checkout");
                    classChoice = Console.ReadLine();
                    if (checkIfStop(classChoice))
                    {
                        if (classChoice == "y")
                        {
                            Console.WriteLine("How many would you like to add?");
                            quantity = Convert.ToDouble(Console.ReadLine());
                            cartTotal = cartTotal + (Convert.ToDouble(ic[i,1]) * quantity);
                            Console.WriteLine("Current Cart Total is: $" + Math.Round(cartTotal, 2));
                            i++;
                        }
                        else if (classChoice == "n")
                        {
                            Console.WriteLine("Thank you for your input");
                            i++;
                        }
                    }
                    else
                    {
                        break;
                    }
                   
                }
                Console.WriteLine("Are you ready to checkout? Type STOP to checkout or 'n' to continue shopping");
                classChoice = Console.ReadLine();
                if (checkIfStop(classChoice))
                {
                    i = 0;
                }
                else
                {
                    break;
                }
            }
            Console.WriteLine("\n");
            Console.WriteLine("Your total today will be: $" + Math.Round(cartTotal, 2));

            Console.WriteLine("Hit any key to continue...");
            Console.ReadKey();

        }//End IndexShopping



        //Check if the string entered is "STOP"
        static bool checkIfStop(string classChoice)
        {
            if (classChoice != "STOP")
            {
                return true;
            }
            else
            {
                return false;
            }
        }//End Check if stop


        //calculate total price from input price and tax values
        static double PricePlusTax(double Price, double taxRate)
        {
            double taxToAdd = (Price * taxRate);
            double totalPrice = (Price + taxToAdd);
            //displays the total calculated price up to 2 decimal places
            Console.WriteLine("Total price with tax is: " + Math.Round(totalPrice, 2));
            return totalPrice;
        }//End Calculating total price

        //convert amount of coins into the total value of the coins
        static double CountChange(double quarters, double dimes, double nickels, double pennies)
        {
            double ratioQ = .25;
            double ratioD = .10;
            double ratioN = .05;
            double ratioP = .01;
            double totalChange;
            double quarterWorth;
            double dimeWorth;
            double nickelWorth;
            double pennyWorth;

            //convert amount of coins into the associated value of the coins
            quarterWorth = quarters * ratioQ;
            dimeWorth = dimes * ratioD;
            nickelWorth = nickels * ratioN;
            pennyWorth = pennies * ratioP;

            //add total of each coin's value together
            totalChange = quarterWorth + dimeWorth + nickelWorth + pennyWorth;

            //display total and return total to main method
            Console.WriteLine("You have: $" + Math.Round(totalChange, 2) + " in your pocket.");
            return totalChange;
        }
    }
    class indexDataStoreProducts
    {
        //Arrays of products and prices
        string[,] products = new string[3, 2] { { "Pencils", "1.09" }, { "Notebook", "1.59" }, {"Eraser", "0.55" } };

        public string this[int index1, int index2]
        {
            get
            {
                //get the values of the associated multidimensional array
                return products[index1, index2];
            }
            set
            {
                //set the values of the associated multidimensional array
                products[index1, index2] = value;
            }
        }

    }
}
