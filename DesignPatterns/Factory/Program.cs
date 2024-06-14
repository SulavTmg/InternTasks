using Factory;
class Program
{
    public static void Main()
    {
        IWaiwai veg = WaiwaiFactory.getWaiwai("veg");
        IWaiwai chicken = WaiwaiFactory.getWaiwai("chicken");
        veg.MakeWaiwai();
        chicken.MakeWaiwai();
    }
}