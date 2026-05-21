using System;
namespace Practice2new
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BillingApplication app = new BillingApplication();
            app.Run();
        }
    }

    class BillingApplication
    {
        public void Run()
        {
            string continueChoice = "";
            do
            {
                int finalQuantity = GetQuantity();
                double price = GetValidatedDouble("enter valid price", "please enter valid price");
                double subTotal = price * finalQuantity;
                double amount = GetValidatedDouble("enter tax percentage", "please enter valid tax percentage");
                //================================================
                double taxAmount = subTotal * (amount / 100);
                double finalPrice = subTotal + taxAmount;

                if ((subTotal >= 2000) && (taxAmount >= (subTotal * 0.18)))
                {
                    finalPrice += 100;
                    Console.WriteLine("Surcharge of Rs 100/- is added to your purchase");
                }
                else
                {
                    Console.WriteLine("No Surcharge will be added to your purchase");
                }
                Console.WriteLine($"your final is {subTotal}, and your tax is {taxAmount}, and your final price is {finalPrice}");
                Console.Write("Do you want to calculate again? (y/n): ");
                continueChoice = Console.ReadLine();
            } while (continueChoice == "y");
        }
        //=================================================================================================
        //QUANTITY OF ITEMS
        public int GetQuantity()
        {
            while (true)
            {
                Console.Write("enter quantity: ");
                string userQuantity = Console.ReadLine();
                int finalQuantity = 0;
                if (int.TryParse(userQuantity, out finalQuantity) && finalQuantity > 0)
                {
                    return finalQuantity;
                }
                else if (finalQuantity <= 0)
                {
                    Console.WriteLine("Please enter valid quantity");
                }
            }
        }

        //===============================================================================
        //TOTAL PRICE OF ITEMS AND TAX PERCENTAGE
        public double GetValidatedDouble(string promptMessage, string errorMessage)
        {
            while (true)
            {
                Console.Write(promptMessage);
                string userInput = Console.ReadLine();
                double validatedValue = 0;
                if (double.TryParse(userInput, out validatedValue) && validatedValue > 0)
                {
                    return validatedValue;
                }
                else if (validatedValue <= 0)
                {
                    Console.WriteLine(errorMessage);
                }
            }
        }
    }
}