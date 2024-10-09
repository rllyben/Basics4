using System.Text;

namespace Minesweeper_v0._1
{
    internal class Program
    {
        static ushort hight = 0;
        static ushort length = 0;
        static ushort mines = 0;
        static ushort guessHight = 0;
        static ushort guessLength = 0;
        static short[,] guessArr;
        static short[,] multiIntArr;
        static bool innerTest = false;

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Header();
            FieldInput();

        }

        // Writes the Header of the Game
        static void Header()
        {
            /// Writes the Header "Minesweeper v0.1
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Minesweeper v0.1");
            Console.ResetColor();
            Console.WriteLine();
        }
        
        // Asks for the User input for the Field size and sets it
        static void FieldInput()
        {
            /// Asks for the Userinput in the Format [Number]x[Number], saves it and splits it in hight; and length;. Than casts MineInput()
            Console.Clear();
            Header();

            Console.WriteLine("please enter the size of the field in the following Format: [Number]x[Number]");
            Console.WriteLine();
            string input = Console.ReadLine();
            string[] parts = input.Split('x');
            try
            {
                hight = ushort.Parse(parts[0]);
                length = ushort.Parse(parts[1]);
            }
            catch
            {
                Console.Clear();
                Header();
                Console.WriteLine("Wrong Format! Please try again!");
                Thread.Sleep(500);
                FieldInput();
            }
            Console.WriteLine($"your field will be {hight} x {length} big");
            Thread.Sleep(1000);

            MineInput();
        }

        // Asks for the Mineinput and saves it
        static void MineInput()
        {
            /// Asks for the Mineinput and saves it in mines; also casts PlayField()
            Console.Clear();
            Header();

            Console.WriteLine();
            Console.WriteLine("How many Mines do you want to have in the field?");
            Console.WriteLine();
            try
            {
                mines = ushort.Parse(Console.ReadLine());
            }
            catch
            {
                Console.Clear();
                Header();
                Console.WriteLine("Wrong input! Please try again!");
                Thread.Sleep(500);
                MineInput();
            }
            if (mines >= length * hight / 2)
            {
                Console.Clear();
                Header();
                Console.WriteLine("Too many Mines! Please try again!");
                Thread.Sleep(1000);
                MineInput();
            }

            FieldCreation();
        }

        // Creates and prints the Playfield with the given values
        static void FieldCreation()
        {
            /// Creates and prints the Playfield with the hight and lenght values and sets the Mines with the mine Value randomly;
            Console.Clear();
            Header();

            Random rnd = new Random();

            // creates the Playfield
            multiIntArr = new short[hight, length];
            guessArr = new short[hight, length];
            for (short outer = 0; outer < multiIntArr.GetLength(0); outer++)
            {
                for (short inner = 0; inner < multiIntArr.GetLength(1); inner++)
                {
                    multiIntArr[outer, inner] = 0;
                    guessArr[outer, inner] = 0;
                }

            }

            // Sets the Mines randomly in empty places
            for (short count = 0; count < mines; count++)
            {
                short randomHight = (short)rnd.Next(0, hight);
                short randomLenght = (short)rnd.Next(0, length);
                if (multiIntArr[randomHight, randomLenght] != 9)
                    multiIntArr[randomHight, randomLenght] = 9;
            }
            PlayField();
        }

        static void PlayField()
        {
            Console.Clear();
            Header();
            /// Prints the Playfield
            for (short outer = -1; outer < multiIntArr.GetLength(0); outer++)
            {
                
                if (innerTest)
                {
                    Console.Write(outer + 1 + " ");
                }
                else Console.Write("  ");

                for (short inner = -1; inner < multiIntArr.GetLength(1); inner++)
                {
                    if (inner == -1 && outer == -1);
                    else if (outer == -1 && inner != -1)
                    {
                        Console.Write(inner + 1 + " ");
                        innerTest = true;
                    }
                    else if (inner == -1);
                    else if (guessArr[outer, inner] == 0) Console.Write("\u25A0 ");
                    else if (multiIntArr[outer, inner] == 9) Console.Write("▣ ");
                    else if (guessArr[outer, inner] == 1) Console.Write("□ ");
                    else
                    {
                        Console.WriteLine("something went wront! Sorry recreating the field...");
                        Thread.Sleep(1000);
                        PlayField();
                    }

                }
                Console.WriteLine("");
                Console.WriteLine("");
            }
            Guess();
        }

        static void Guess()
        {
            guessHight = 0;
            guessLength = 0;


            Console.WriteLine("please enter your guess in the field in the following Format: [Number]x[Number]");
            Console.WriteLine();
            string input = Console.ReadLine();
            string[] parts = input.Split('x');
            try
            {
                guessHight = ushort.Parse(parts[0]);
                guessLength = ushort.Parse(parts[1]);
            }
            catch
            {
                Console.Clear();
                Header();
                Console.WriteLine("Wrong Format! Please try again!");
                Thread.Sleep(500);
                Console.Clear();
                Guess();
            }
            if (guessHight > hight || guessLength > length)
            {
                Console.Clear();
                Header();
                Console.WriteLine("Your guess was out of range, please try again!");
                Thread.Sleep(500);
                Console.Clear();
                Guess();
            }
            Thread.Sleep(1000);
            guessArr[guessHight-1, guessLength-1] = 1;

            PlayField();
        }

    }

}
