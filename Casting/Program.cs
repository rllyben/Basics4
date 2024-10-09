namespace Casting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int testInt = 35000;
            short testShort = 1;
            float testFloat = 3.5F;
            byte testByte = 5;
            bool testBoolean = false;
            long testLong = 132141;
            decimal testDecimal = 332.21135234M;
            double testDouble = 4123.32151236532D;
            char testChar = 'f';
            sbyte testSByte = 10;
            ushort testUShort = 1324;
            uint testUInt = 2142135;
            ulong testULong = 3215526431;

            int targetInt = 0;
            short targetShort = 0;
            float targetFloat = 0;
            byte targetByte = 0;
            bool targetBoolean = false;
            long targetLong = 0;
            decimal targetDecimal = 0;
            double targetDouble = 0;
            char targetChar;
            sbyte targetSByte = 0;
            ushort targetUShort = 0;
            uint targetUInt = 0;
            ulong targetULong = 0;    

            // Implizietes Casten
            targetInt = testShort;
            // hoeherwertigen Datentypen in kleineren schreiben nicht moeglich!
            // targetShort = testInt;
            targetFloat = testInt;
            // targetByte = testSByte;
            // targetChar = testBoolean;
            // targetChar = testByte;




            // Explizietes Casten
            targetShort = (short)testInt;
            testFloat += (0.5F);
            // Math.Round(targetFloat);
            targetInt = (int)testFloat;
            targetFloat = (float)testShort;

            Console.WriteLine(targetShort);
            Console.WriteLine(targetInt);
            for (int count = 0; count < 255;count++)
            {
                targetChar = (char)testShort;
                Console.WriteLine(targetChar);
                testShort++;
                
            }

        }

    }

}
