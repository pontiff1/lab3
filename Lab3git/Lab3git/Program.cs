namespace Lab3git
{
    class Program
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Введите число а:");
            double? a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите число b:");
            double? b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("1. Сумма");
            Console.WriteLine("2. Вычитание");
            Console.WriteLine("3. Умножение");
            Console.WriteLine("4. Деление");
        }
    }
}