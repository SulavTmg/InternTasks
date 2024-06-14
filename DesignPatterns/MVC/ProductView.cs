namespace MVC
{
    public class ProductView
    {
        public void DisplayProductDetails(Product product)
        {
            Console.WriteLine($"Product Id: {product.Id}");
            Console.WriteLine($"Product Name: {product.Name}");
            Console.WriteLine($"Product Price: Rs. {product.Price}");
        }
    }
}
