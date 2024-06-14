public class Product
{
	public string _Title { get; set; }
	public double _Price { get; set; }

	public Product(String Title, double Price)
	{
		_Title = Title;
		_Price = Price;
	}

	public double getPrice()
	{
		return _Price;
	}

}