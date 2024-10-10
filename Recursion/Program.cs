namespace Recursion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Gebe deine Zahl ein");
            int valve = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Fibo(valve);
            Console.WriteLine();
            Console.WriteLine($"Sind alle Fibonacci-Zahlen bis zur {valve} stelle");
            Console.WriteLine();
            Console.WriteLine($"Die Summe von {valve} ist {Summe(valve)}");
        }

        static int Summe (int value)
        {
            if (value == 0)
                return value;
            else
                return value + Summe (value - 1);
        }

        static int Fibo(int value, int temp = 0,int fibo = 1)
        {
            if (fibo >= value)
                return value;
            else
            {
                Console.WriteLine(fibo);
                return Fibo (value, fibo, fibo += temp);
            }

        }

    }

}
