namespace _19._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CalorieFacade calculator = new CalorieFacade();

            double weight = 75.0;
            double height = 180.0;
            int age = 20;
            string gender = "м";
            string activity = "средняя";
            IBodyType myBody = new Normosthenic();

            double dailyKcal = calculator.CalculateDailyCalories(weight, height, age, gender, activity, myBody);

            Console.WriteLine("Расчет калорий ");
            Console.WriteLine($"Параметры: Рост {height}см, Вес {weight}кг, Возраст {age}, Пол '{gender}', Активность '{activity}'");
            Console.WriteLine($"Тип телосложения: {myBody.GetType().Name}");
            Console.WriteLine($"\nВаша норма: {Math.Round(dailyKcal)} ккал в день.");

        }
    }
}
