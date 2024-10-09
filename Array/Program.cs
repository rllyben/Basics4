namespace Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Array mit Random befuellen und alles ausgeben
            Random rnd = new Random();
            int[] meinArra = new int[10];

            for (int count = 0; count < meinArra.Length; count++)
            {
                meinArra[count] = rnd.Next(1,1001);
            }

            for (int count = 0; count < meinArra.Length; count++)
            {
                Console.Write($"{meinArra[count]}-");
            }
            Console.WriteLine();


            // Array gleich mit Werten Initialisieren und spezifisch darauf zugreifen

            int stelle = 5;
            int[] fibo = new int[] { 1,2,3,5,8,13,21,34,55 };
            Console.WriteLine($"Die Stelle Nr.{stelle} ist {fibo[stelle-1]}");

            // Array Fehler

            int[] errorArra = new int[3];

            errorArra[0] = 5;
            errorArra[1] = 6;
            errorArra[2] = 7;
            // Fehler weil Index [3] existiert nicht bei einer Laenge von 3
            // errorArra[3] = 8;
            //Negative Werte fuehren zum selben Fehler
            //errorArra[-1] = 3;

            errorArra[errorArra.Length - 1] = 5;
            Console.WriteLine(errorArra[2]);


        }

    }

}
