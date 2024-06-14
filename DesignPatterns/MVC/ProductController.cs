namespace MVC
{
    public class ProductController
    {
        private readonly Product _model;
        private readonly ProductView _view;

        public ProductController(Product model, ProductView view) {

            _model = model;
            _view = view;
        }

        public void UpdateProductName(string name)
        {
            _model.Name = name;
        }

        public void UpdatePrice(decimal price)
        {
            _model.Price = price;   
        }

        public void DisplayPoduct()
        {
            _view.DisplayProductDetails(_model);
        }
    }
}
