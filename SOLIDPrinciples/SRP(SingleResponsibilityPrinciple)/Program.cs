class Program
{
	public static void Main()
	{
		const double VAT_RATE = 0.13;
		const double EXCISE_DUTY_RATE = 0.05;

		Product laptop = new Product("Apple MacBook Air 13.6-inch M2 256GB", 135000);
		double TotalAmount = laptop._Price + TaxCalculator.calculateVAT(laptop, VAT_RATE) + TaxCalculator.calculateExciseDuty(laptop, EXCISE_DUTY_RATE);
		Console.WriteLine($"Apple MacBook Air 13.6-inch M2 256GB \nPrice including TAX = {TotalAmount}");

	}
}