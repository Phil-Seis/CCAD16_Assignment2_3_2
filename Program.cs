//Design a tip calculator : enter the bill total, tip % and display grand total after adding tip.

namespace CCAD16_Assignment2_3_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***TIP CALCULATOR***");
            Console.WriteLine("\nWould you like to leave a tip? (Yes/No)");
            string userChoice = Console.ReadLine();
                        
            if (userChoice.ToLower() == "yes")
            {
                Console.WriteLine("\nThank you. Please choose between the following tip options:");
                Console.WriteLine("--------------");
                Console.WriteLine("1. 8%");
                Console.WriteLine("2. 10%");
                Console.WriteLine("3. 15%");
                Console.WriteLine("4. Custom tip");
                Console.WriteLine("--------------");

                double tipChoice = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("\nWhat is the total of the bill?");
                double userTotal = Convert.ToDouble(Console.ReadLine());
                double userTip = 0;

                switch (tipChoice)
                {
                    case 1:
                        Console.WriteLine("\nThank you for the 8% tip");
                        userTip = userTotal * 0.08;
                        break;
                    case 2:
                        Console.WriteLine("\nThank you for the 10% tip");
                        userTip = userTotal * 0.10;
                        break;
                    case 3:
                        Console.WriteLine("\nThank you for the 15% tip");
                        userTip = userTotal * 0.15;
                        break;
                    case 4:
                        Console.WriteLine("\nThank you for the custom tip!");
                        Console.WriteLine("Enter the tip percentage as a decimal (e.g., 0.2 for 20%):");
                        double userCustom = Convert.ToDouble(Console.ReadLine());
                        userTip = userTotal * userCustom;
                        break;
                }
                Console.WriteLine("******************");
                Console.WriteLine($"This brings the grand total of your bill to ${userTip + userTotal}");
            }

            else
            {
                Console.WriteLine("You should have left a tip");
            }
        }
    }
}
