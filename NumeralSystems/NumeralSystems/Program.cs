using System;


namespace NumeralSystems
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.Write("Enter :");
            string userInput = Console.ReadLine(); // take user input

            switch (BaseDetector(userInput))
            {

                case 1: // decimal
                    {


                        if (userInput.Contains('.') && userInput.Length == 7)
                        {
                            Console.WriteLine("you entering decimal fraction");
                            string lastThree = userInput.Substring(userInput.Length - 3);
                            string firstThree = userInput.Substring(0, 3);
                            float last = Convert.ToInt32(lastThree);
                            int first = Convert.ToInt32(firstThree);
                            Console.WriteLine("Decimal :" + userInput);
                            Console.Write("Binary :" + Convert.ToString(first, 2) + ".");
                            last /= 1000;

                            for (int i = 0; i < 10; i++) // decimal fraction to binary fraction
                            {

                                if (last >= 1)

                                {
                                    string s = Convert.ToString(last);
                                    string lenght = Convert.ToString(last);
                                    int digitNumber = lenght.Length;
                                    digitNumber -= 2;
                                    if (last > 9) { digitNumber -= 1; }
                                    string s1 = s.Substring(s.Length - digitNumber, digitNumber);
                                    float floatLastDigit = Convert.ToInt32(s1);
                                    int[] zeros = new int[digitNumber];

                                    string arrayToString = string.Join("", zeros);
                                    string addOneToString = 1 + arrayToString;
                                    int stringToInt = int.Parse(addOneToString);

                                    last = floatLastDigit / stringToInt;

                                }

                                last *= 2;

                                Console.Write(Math.Truncate(last));
                            }

                            Console.WriteLine();
                            Console.Write("Octal :0" + Convert.ToString(first, 8) + ".");
                            float last2 = Convert.ToInt32(lastThree);
                            last2 /= 1000;

                            for (int i = 0; i < 10; i++)// decimal fraction to octal fraction
                            {

                                string s1 = Convert.ToString(last2);
                                string lenght2 = Convert.ToString(last2);
                                int digitNumber2 = lenght2.Length;
                                digitNumber2 -= 2;
                                if (last2 > 9) { digitNumber2 -= 1; }
                                string s2 = s1.Substring(s1.Length - digitNumber2, digitNumber2);
                                float floatLastDigit2 = Convert.ToInt32(s2);
                                int[] zeros = new int[digitNumber2];

                                string arrayToString = string.Join("", zeros);
                                string addOneToString = 1 + arrayToString;
                                int stringToInt = int.Parse(addOneToString);

                                last2 = floatLastDigit2 / stringToInt;
                                last2 *= 8;
                                Console.Write(Math.Truncate(last2));

                            }
                            Console.WriteLine();

                            Console.Write("Hexadecimal: 0x" + Convert.ToString(first, 16) + ".");
                            float last3 = Convert.ToInt32(lastThree);
                            last3 /= 1000;

                            for (int i = 0; i < 10; i++) // decimal fraction to hex fraction
                            {

                                string s2 = Convert.ToString(last3);
                                string lenght3 = Convert.ToString(last3);
                                int digitNumber3 = lenght3.Length;

                                digitNumber3 -= 2;
                                if (last3 > 9) { digitNumber3 -= 1; }

                                string s3 = s2.Substring(s2.Length - digitNumber3, digitNumber3);
                                float floatLastDigit3 = Convert.ToInt32(s3);
                                int[] zeros = new int[digitNumber3];

                                string arrayToString = string.Join("", zeros);
                                string addOneToString = 1 + arrayToString;
                                int stringToInt = int.Parse(addOneToString);

                                last3 = floatLastDigit3 / stringToInt;
                                last3 *= 16;

                                double justInt = Math.Truncate(last3);
                                int toHex = Convert.ToInt32(justInt);
                                Console.Write(Convert.ToString(toHex, 16));

                            }
                            Console.WriteLine();

                            return;
                        }
                        Console.WriteLine("you entering decimal ");
                        int value = Convert.ToInt32(userInput);
                        Console.WriteLine("Decimal: " + value);
                        Console.WriteLine("Binary: " + Convert.ToString(value, 2));
                        Console.WriteLine("Octal: 0" + Convert.ToString(value, 8));
                        Console.WriteLine("Hexadecimal: 0x" + Convert.ToString(value, 16));
                        Console.WriteLine("");
                        break;
                    }
                case 2: // octal

                    {

                        if (userInput.Contains('.') && userInput.Length == 8)
                        {
                            Console.WriteLine("you entering octal fraction");
                            string firstThree = userInput.Substring(1, 3); // octal fraction to decimal fraction
                            int toInt = Convert.ToInt32(firstThree, 8);
                            double lastFirst = double.Parse(userInput.Substring(userInput.Length - 3, 1));
                            double lastSecond = double.Parse(userInput.Substring(userInput.Length - 2, 1));
                            double lastThird = double.Parse(userInput.Substring(userInput.Length - 1, 1));

                            lastFirst = lastFirst * 1 / 8;
                            lastSecond = lastSecond * 1 / 64;
                            lastThird = lastThird * 1 / 512;

                            double sum = lastFirst + lastSecond + lastThird;
                            if (sum >= 1) { Console.WriteLine("Number is not Octal ?"); return; }
                            double sum2 = lastFirst + lastSecond + lastThird;
                            double allSum = Convert.ToInt32(firstThree, 8) + sum;
                            Console.WriteLine("Decimal :" + allSum);
                            Console.Write("Binary :" + Convert.ToString(toInt, 2) + ".");

                            for (int i = 0; i < 10; i++) // octal fraction to binary fraction

                            {
                                if (sum >= 1)
                                {
                                    string s = Convert.ToString(sum);
                                    string lenght = Convert.ToString(sum);
                                    int digitNumber = lenght.Length;
                                    if (digitNumber == 1) { sum = 0; }
                                    else
                                    {

                                        digitNumber -= 2;

                                        string s1 = s.Substring(s.Length - digitNumber, digitNumber);
                                        float floatLastDigit = Convert.ToInt32(s1);
                                        int[] zeros = new int[digitNumber];

                                        string arrayToString = string.Join("", zeros);
                                        string addOneToString = 1 + arrayToString;
                                        int stringToInt = int.Parse(addOneToString);

                                        sum = floatLastDigit / stringToInt;
                                    }
                                }
                                sum *= 2;
                                Console.Write(Math.Truncate(sum));

                            }
                            Console.WriteLine();
                            Console.WriteLine("Octal: " + userInput);
                            Console.Write("Hex: 0x" + Convert.ToString(toInt, 16) + ".");

                            for (int i = 0; i < 10; i++) // octal fraction to hex fraction
                            {

                                string s2 = Convert.ToString(sum2);
                                string lenght3 = Convert.ToString(sum2);
                                int digitNumber3 = lenght3.Length;
                                if (digitNumber3 == 1 || digitNumber3 == 2 && sum2 >= 10) { Console.Write(0); }
                                else
                                {
                                    digitNumber3 -= 2;

                                    if (sum2 >= 10) { digitNumber3 -= 1; }
                                    string s3 = s2.Substring(s2.Length - digitNumber3, digitNumber3);
                                    float floatLastDigit3 = Convert.ToInt32(s3);
                                    int[] zeros = new int[digitNumber3];

                                    string arrayToString = string.Join("", zeros);
                                    string addOneToString = 1 + arrayToString;
                                    int stringToInt = int.Parse(addOneToString);

                                    sum2 = floatLastDigit3 / stringToInt;
                                    sum2 *= 16;

                                    double justInt = Math.Truncate(sum2);
                                    int toHex = Convert.ToInt32(justInt);
                                    Console.Write(Convert.ToString(toHex, 16));
                                }
                            }
                            Console.WriteLine();
                            return;
                        }
                        Console.WriteLine("you entering octal");
                        int value = Convert.ToInt32(userInput, 8);
                        Console.WriteLine("Decimal: " + value);
                        Console.WriteLine("Binary : " + Convert.ToString(value, 2));
                        Console.WriteLine("Octal : " + userInput);
                        Console.WriteLine("Hexadecimal : 0x" + Convert.ToString(value, 16));
                        break;
                    }
                case 3: // hex

                    {

                        if (userInput.Contains('.') && userInput.Length == 9)
                        {
                            Console.WriteLine("you entering hex fraction");
                            string firstThree = userInput.Substring(2, 3); // hex fraction to decimal fraction
                            int toInt = Convert.ToInt32(firstThree, 16);
                            double lastFirst = double.Parse(userInput.Substring(userInput.Length - 3, 1));
                            double lastSecond = double.Parse(userInput.Substring(userInput.Length - 2, 1));
                            double lastThird = double.Parse(userInput.Substring(userInput.Length - 1, 1));

                            lastFirst = lastFirst * 1 / 16;
                            lastSecond = lastSecond * 1 / 256;
                            lastThird = lastThird * 1 / 4096;

                            double sum = lastFirst + lastSecond + lastThird;
                            if (sum >= 1) { Console.WriteLine("Number is not Octal ?"); return; }
                            double sum2 = lastFirst + lastSecond + lastThird;
                            double allSum = Convert.ToInt32(firstThree, 16) + sum;
                            Console.WriteLine("Decimal :" + allSum);
                            Console.Write("Binary :" + Convert.ToString(toInt, 2) + ".");

                            for (int i = 0; i < 15; i++) // hex fraction to binary fraction

                            {
                                if (sum >= 1)
                                {
                                    string s = Convert.ToString(sum);
                                    string lenght = Convert.ToString(sum);
                                    int digitNumber = lenght.Length;
                                    if (digitNumber == 1) { sum = 0; }
                                    else
                                    {

                                        digitNumber -= 2;

                                        string s1 = s.Substring(s.Length - digitNumber, digitNumber);
                                        float floatLastDigit = Convert.ToInt64(s1);
                                        int[] zeros = new int[digitNumber];

                                        string arrayToString = string.Join("", zeros);
                                        string addOneToString = 1 + arrayToString;
                                        long stringToInt = Int64.Parse(addOneToString);

                                        sum = floatLastDigit / stringToInt;
                                    }
                                }
                                sum *= 2;
                                Console.Write(Math.Truncate(sum));

                            }
                            Console.WriteLine();
                            Console.Write("Octal :0" + Convert.ToString(toInt, 8) + ".");
                            //Console.WriteLine(sum2);
                            for (int i = 0; i < 10; i++) // hex fraction to octal fraction
                            {

                                string s1 = Convert.ToString(sum2);
                                string lenght2 = Convert.ToString(sum2);
                                int digitNumber2 = lenght2.Length;
                                if (digitNumber2 == 1) { Console.Write(0); }
                                else
                                {
                                    digitNumber2 -= 2;
                                    if (sum2 > 9) { digitNumber2 -= 1; }
                                    //Console.WriteLine( "digit ---> "+digitNumber2+ "sum2 --->"+sum2);
                                    string s2 = s1.Substring(s1.Length - digitNumber2, digitNumber2);
                                    float floatLastDigit2 = Convert.ToInt64(s2);
                                    int[] zeros = new int[digitNumber2];

                                    string arrayToString = string.Join("", zeros);
                                    string addOneToString = 1 + arrayToString;
                                    long stringToInt = Int64.Parse(addOneToString);

                                    sum2 = floatLastDigit2 / stringToInt;
                                    sum2 *= 8;
                                    Console.Write(Math.Truncate(sum2));
                                }

                            }
                            Console.WriteLine();
                            Console.WriteLine("Hex :" + userInput);


                            return;
                        }

                        Console.WriteLine("you entering hex");
                        int value = Convert.ToInt32(userInput, 16);
                        Console.WriteLine("Decimal :" + value);
                        Console.WriteLine("Binary : " + Convert.ToString(value, 2));
                        Console.WriteLine("Octal : 0" + Convert.ToString(value, 8));
                        Console.WriteLine("Hexadecimal: " + userInput);
                        break;
                    }
            }

        }

        public static int BaseDetector(string userinput)
        {
            char[] userinputArray = userinput.ToCharArray();

            int x = userinputArray[0] == '0' ? userinputArray[1] == 'x' ? 3 : 2 : 1;

            return x;

        }
    }
}