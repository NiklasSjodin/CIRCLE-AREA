namespace Circle2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ange radien på cirkeln vi ska beräkna: ");
            int radius = int.Parse(Console.ReadLine());

            var myCircle = new Circle(radius);

            double cArea = myCircle.GetArea();
            double cCircumference = myCircle.GetCircumference();
            double cVolume = myCircle.GetVolume();

            Console.WriteLine("\nArean är " + Math.Round(cArea, 2) + " cm.");
            Console.WriteLine("Omkretsen är " + Math.Round(cCircumference, 2) + " cm.");
            Console.WriteLine("Volymen är " + Math.Round(cVolume, 2) + " kubik cm.");
        }
    }
}