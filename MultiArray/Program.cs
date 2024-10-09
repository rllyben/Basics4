namespace MultiArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            // zweidimensionales Array

            int[,] multiIntArr = new int[4, 4];

            for(int outer = 0; outer < multiIntArr.GetLength(0); outer++)
            {
                for (int inner = 0; inner < multiIntArr.GetLength(1); inner++)
                {
                    multiIntArr[outer, inner] = rnd.Next(1, 100);
                }

            }

            foreach(int item in multiIntArr)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
            Console.WriteLine();

            for (int outer = 0; outer < multiIntArr.GetLength(0); outer++)
            {
                for (int inner = 0; inner < multiIntArr.GetLength(1); inner++)
                {
                    Console.Write(multiIntArr[outer, inner] + " ");
                }
                Console.WriteLine();
            }

        }

    }

}
