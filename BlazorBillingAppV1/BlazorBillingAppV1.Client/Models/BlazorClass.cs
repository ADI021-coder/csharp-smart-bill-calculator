namespace BlazorBillingAppV1.Client.Models
{
    public class BillingInvoice
    {
        public int Quantity { get; set; }
        public double Price { get; set; }
        public double Tax { get; set; }
        public bool Surcharge { get; private set; }

        public double CalculateSubTotal()
        {
            return Quantity * Price;
        }

        public double CalculateTaxAmount()
        {
            return CalculateSubTotal() * (Tax / 100);
        }

        public double FinalPrice()
        {
            return CalculateSubTotal() + CalculateTaxAmount();
        }

        public double FinalDisplay()
        {
            double finalPrice = FinalPrice();

            if ((CalculateSubTotal() >= 2000) && (CalculateTaxAmount() >= (CalculateSubTotal() * 0.18)))
            {
                finalPrice += 100;
                Surcharge = true;
            }
            else
            {
                Surcharge = false;
            }
            return finalPrice;
        }
    }
}
