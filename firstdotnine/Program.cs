using firstdotnine;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Введите вес продукта (г): ");
        double Weight = double.Parse(Console.ReadLine());
        
        Console.Write("Введите калорийность на 100г продукта: ");
        double CaloriesPer100g = double.Parse(Console.ReadLine());

        Product product = new(Weight, CaloriesPer100g);
        Console.WriteLine("Общая калорийность продукта: " + product.GetAllCalories());
    }
}