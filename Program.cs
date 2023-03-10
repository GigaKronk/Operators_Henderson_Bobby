using System;

namespace Operators_Henderson_Bobby
{
    class Program
    {
        static void Main(string[] args)

        {


            // Initializes an short that multipes two shorts
            short shortMult = 6 * 45;
            // Initializes an short that adds to shorts
            short shortAdd = 55 + 66;
            // Prints the maximum and minimum of the two short variables
            Console.WriteLine($"The max of {shortMult} and {shortAdd} is {Math.Max(shortMult, shortAdd)}." +
                $"The min of the two is {Math.Min(shortMult, shortAdd)}");

            // Initializes boolean to see if shortMult is greater than shortAdd
            bool isshortGreater = shortMult > shortAdd;
            // Prints if shortMult is greater than shortAdd
            Console.WriteLine($"{shortMult} is greater than {shortAdd}, {isshortGreater}.");




            // Initializes an long that multipes two longs
            long longMult = 6 * 45;
            // Initializes an long that adds to longs
            long longAdd = 55 + 66;
            // Prints the maximum and minimum of the two long variables
            Console.WriteLine($"The max of {longMult} and {longAdd} is {Math.Max(longMult, longAdd)}." +
                $"The min of the two is {Math.Min(longMult, longAdd)}");

            // Initializes boolean to see if longMult is greater than longAdd
            bool islongGreater = longMult > longAdd;
            // Prints if longMult is greater than longAdd
            Console.WriteLine($"{longMult} is greater than {longAdd}, {islongGreater}.");





            // Initializes an float that multipes two floats
            float floatMult = 6.5f * 45.3f;
            // Initializes an float that adds to floats
            float floatAdd = 55.33f + 66.15f;
            // Prints the maximum and minimum of the two float variables
            Console.WriteLine($"The max of {floatMult} and {floatAdd} is {Math.Max(floatMult, floatAdd)}." +
                $"The min of the two is {Math.Min(floatMult, floatAdd)}");

            // Initializes boolean to see if floatMult is greater than floatAdd
            bool isfloatGreater = floatMult > floatAdd;
            // Prints if floatMult is greater than floatAdd
            Console.WriteLine($"{floatMult} is greater than {floatAdd}, {isfloatGreater}.");






            // Initializes an double that multipes two doubles
            double doubleMult = 6.67 * 45.26;
            // Initializes an double that adds to doubles
            double doubleAdd = 55.15 + 66.54;
            // Prints the maximum and minimum of the two double variables
            Console.WriteLine($"The max of {doubleMult} and {doubleAdd} is {Math.Max(doubleMult, doubleAdd)}." +
                $"The min of the two is {Math.Min(doubleMult, doubleAdd)}");

            // Initializes boolean to see if doubleMult is greater than doubleAdd
            bool isdoubleGreater = doubleMult > doubleAdd;
            // Prints if doubleMult is greater than doubleAdd
            Console.WriteLine($"{doubleMult} is greater than {doubleAdd}, {isdoubleGreater}.");






            // Initializes an decimal that multipes two decimals
            decimal decimalMult = (decimal)(6.65 * 45.15);
            // Initializes an decimal that adds to decimals
            decimal decimalAdd = (decimal)(55.45 + 66.35);
            // Prints the maximum and minimum of the two decimal variables
            Console.WriteLine($"The max of {decimalMult} and {decimalAdd} is {Math.Max(decimalMult, decimalAdd)}." +
                $"The min of the two is {Math.Min(decimalMult, decimalAdd)}");

            // Initializes boolean to see if decimalMult is greater than decimalAdd
            bool isdecimalGreater = decimalMult > decimalAdd;
            // Prints if decimalMult is greater than decimalAdd
            Console.WriteLine($"{decimalMult} is greater than {decimalAdd}, {isdecimalGreater}.");





            



        }
    }
}
