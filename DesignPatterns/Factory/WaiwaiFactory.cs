namespace Factory
{
    public class WaiwaiFactory
    {
        public static IWaiwai getWaiwai(string name) {

            IWaiwai waiwai = null;

            if(name == "veg")
            {
                waiwai = new VegWaiwai();
            }
            else if(name == "chicken")
            {
                waiwai = new ChickenWaiwai();
            }

            return waiwai;
        }
    }
}
