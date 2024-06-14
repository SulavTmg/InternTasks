
namespace Encapsulation
{
    public class Car
    {
        private string model;
        private int year;

        public Car(string model, int year)
        {
            this.model = model;
            this.year = year;
        }

        public string Model
        {
            get{return model;}
            set{model = value;}
        }

       public int Year
        {
            get{return year; }
            set{year = value;}
        }
        public void DisplayInfo()
        {
            Console.WriteLine($"Car Model: {model}, Year: {year}");
        }
    }
}
