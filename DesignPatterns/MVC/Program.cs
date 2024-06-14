using MVC;
class Program
{
    public static void Main()
    {
        Product product = new Product(101, "Hootwheels", 650);
        ProductView view = new ProductView();
        ProductController controller = new ProductController(product, view);
        controller.DisplayPoduct();
        controller.UpdateProductName("Bayblade");
        controller.UpdatePrice(999);
        controller.DisplayPoduct();
    }
}