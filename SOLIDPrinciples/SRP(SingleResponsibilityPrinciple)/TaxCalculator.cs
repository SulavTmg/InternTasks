public static class TaxCalculator
{
	public static double calculateVAT(Product product, double rate)
	{
		return product.getPrice() * rate;
	}
	public static double calculateExciseDuty(Product product, double rate)
	{
		return product.getPrice() * rate;
	}
}