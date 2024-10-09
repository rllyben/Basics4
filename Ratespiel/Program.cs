using System.Threading.Channels;

namespace Ratespiel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool noNumber = true;

            Random array = new Random();
            int[] moeglicheZahlen = new int[10]; 
            for (byte count = 0; count < moeglicheZahlen.Length; count++)
            {
                moeglicheZahlen[count] = array.Next(1, 11);
            }
            do
            {
                Console.Clear();
                Console.WriteLine("Zahlenraten");
                Random gesucht = new Random();
                int gesuchteZahl = gesucht.Next(1, 11);

                for (byte checkGesucht = 0; checkGesucht < moeglicheZahlen.Length; checkGesucht++)
                {
                    if (moeglicheZahlen[checkGesucht] == gesuchteZahl)
                    {
                        bool chance = true;
                        noNumber = false;
                        byte high = 0;
                        byte low = 0;

                        while (chance)
                        {
                            byte input = 0;
                            byte counter = 10;
                            for (byte count = 0; count < moeglicheZahlen.Length; count++)
                            {
                                if (moeglicheZahlen[count] <= low && gesuchteZahl > low)
                                {
                                    Console.Write(moeglicheZahlen[count] + " ");
                                }
                                else if (moeglicheZahlen[count] >= high && gesuchteZahl < high)
                                {
                                    Console.Write(moeglicheZahlen[count] + " ");
                                }
                                else
                                {
                                    Console.Write("x ");
                                    counter--;
                                }

                            }

                            Console.WriteLine();

                            Console.WriteLine("Rate eine Zahl zwischen 1 und 10");
                            input = byte.Parse(Console.ReadLine());

                            if (input < gesuchteZahl && input > low)
                                low = input;
                            else if (input > gesuchteZahl && input < high)
                                high = input;
                            if (input == gesuchteZahl)
                            {
                                Console.WriteLine($"Herzlichen Glückwunsch du hast die gesuchte Zhal erraten die Zahl war {gesuchteZahl}");
                                break;
                            }
                            
                        }

                    }

                }

            } while (noNumber);

        }

    }

}
