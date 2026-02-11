{
    Console.WriteLine("Hello World");
    Console.WriteLine("this is a simple bill calculator");

	string continueChoice;
	do{
    Console.Write("enter quantity: ");
    string userQuantity = Console.ReadLine();
    int finalQuantity = Convert.ToInt32(userQuantity);

    Console.Write("enter item price: ");
    string userPrice = Console.ReadLine();
    double subTotal = Convert.ToDouble(userPrice)*finalQuantity;

    Console.Write("enter tax percentage: ");
    string userTax = Console.ReadLine();
    double amount = Convert.ToDouble(userTax);
    double taxAmount = (double) subTotal*(amount/100);
    double finalPrice = (double) subTotal + taxAmount;
		
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

		Console.WriteLine("y/n");
	}while (continueChoice == "y");
}
