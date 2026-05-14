{
    Console.WriteLine("Hello World");
    Console.WriteLine("this is a simple bill calculator");

	string continueChoice = "";
	do
	{
		try
		{
			//QUANTITY OF ITEMS
			Console.Write("enter quantity: ");
			string userQuantity = Console.ReadLine();
			int finalQuantity = 0;
			if (int.TryParse(userQuantity, out finalQuantity) && finalQuantity > 0)
			{
				
			}
			else if (finalQuantity <= 0)
			{
				Console.WriteLine("Please enter valid quantity");
				continue;
			}
			//================================================
			
			//TOTAL PRICE OF ITEMS
			Console.Write("enter item price: ");
			string userPrice = Console.ReadLine();
			double price = 0;
			if (double.TryParse(userPrice, out price) && price > 0)
			{
				
			}
			else if (price <= 0)
			{
				Console.WriteLine("Please enter valid price");
				continue;
			}
			double subTotal = price * finalQuantity;
			//================================================
			
			//TAX PERCENTAGE TO BE IMPOSED
			Console.Write("enter tax percentage: ");
			string userTax = Console.ReadLine();
			double amount = 0;
			if (double.TryParse(userTax, out amount) && amount > 0)
			{
				
			}
			else if (amount <= 0)
			{
				Console.WriteLine("Please enter valid Tax Percentage");
				continue;
			}
			//================================================
			
			double taxAmount = (double)subTotal * (amount / 100);
			double finalPrice = (double)subTotal + taxAmount;
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
		}
		catch (FormatException)
		{
			Console.WriteLine("Please Enter Valid Numbers");
		}
		
		Console.Write("Do you want to calculate again? (y/n): ");
		continueChoice = Console.ReadLine();
	} while (continueChoice == "y");
}
