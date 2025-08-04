namespace ICE2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cars car = new Cars(1500, 850, 250, "T-34", "Aurus");

            Console.WriteLine("---------------Cars---------------\n");

            Console.WriteLine("Brand : " + car[4]);
            Console.WriteLine("Model : " + car["model"]);
            Console.WriteLine("Car Power : " + car[0] + " hp");
            Console.WriteLine("Car Weight : " + car["weight"] + " kgs");
            Console.WriteLine("Top Speed : " + car[2] + " kph");
            
        }
    }
}
