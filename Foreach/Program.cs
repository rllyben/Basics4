namespace Foreach
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // foreach
            int[] fibo = new int[] { 1, 2, 3, 5, 8, 13, 21, 34, 55 };

            for (int count = 0; count < fibo.Length; count++)
            {
                Console.Write(fibo[count] + " ");
            }
            Console.WriteLine();

            foreach (int item in fibo)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }

    }

}
