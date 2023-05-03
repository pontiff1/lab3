namespace Lab3git
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Результат: ");
            int? c = Convert.ToInt16(Console.ReadLine());
            switch (c)
            {
                case 1: plus(a, b); break;
                case 2: minus(a, b); break;
                case 3: multiply(a, b); break;
                case 4: divide(a, b); break;
            }
        }
        static void plus(double? x, double? y)
        {
            Console.WriteLine(x + y);
        }
        static void minus(double? x, double? y)
        {
            Console.WriteLine(x - y);
        }
        static void multiply(double? x, double? y)
        {
            Console.WriteLine(x * y);
        }
        static void divide(double? x, double? y)
        {
            Console.WriteLine(x / y);
        }
    }
}