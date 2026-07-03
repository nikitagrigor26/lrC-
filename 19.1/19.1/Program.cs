namespace _19._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Работает завод Toyota ");
            ICarFactory toyotaFactory = new ToyotaFactory();
            ISedan myToyotaSedan = toyotaFactory.CreateSedan();
            ISUV myToyotaSUV = toyotaFactory.CreateSUV();

            myToyotaSedan.Drive();
            myToyotaSUV.Drive();

            Console.WriteLine("\nРаботает завод Ford ");
            ICarFactory fordFactory = new FordFactory();
            ISedan myFordSedan = fordFactory.CreateSedan();
            ISUV myFordSUV = fordFactory.CreateSUV();

            myFordSedan.Drive();
            myFordSUV.Drive();
        }
    }
}
