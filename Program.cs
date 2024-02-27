namespace Operators_Jackson_Lydia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("INTEGERS");
            // initializes an integer that multiplies two integers
            int intMult = 8 * 66;
            // initializes an integer that adds two integers
            int intAdd = 46 + 57;

            // prints the max and min of two integer variables
            Console.WriteLine($"the max of {intMult} and {intAdd} is {Math.Max(intMult, intAdd)}. " +
                $"The minimum of the two is {Math.Min(intMult, intAdd)}.");

            // initializes bool to see if intmult is greater than intadd
            bool isIntGreater = intMult > intAdd;
            // prints if intmult is greater than intadd
            Console.WriteLine($"{intMult} is greater than {intAdd}, {isIntGreater}.");



            Console.WriteLine("SHORTS");
            // initializes a short that multiplies two shorts
            short shortMult = 8 * 66;
            // initializes a short that adds two shorts
            short shortAdd = 46 + 57;

            // prints the max and min of two shorts variables
            Console.WriteLine($"the max of {shortMult} and {shortAdd} is {Math.Max(shortMult, shortAdd)}. " +
                $"The minimum of the two is {Math.Min(shortMult, shortAdd)}.");

            // initializes bool to see if shortmult is greater than shortadd
            bool isshortGreater = shortMult > shortAdd;
            // prints if shortmult is greater than shortadd
            Console.WriteLine($"{shortMult} is greater than {shortAdd}, {isshortGreater}.");



            Console.WriteLine("LONGS");
            // initializes an long that multiplies two long
            long longMult = 8 * 66;
            // initializes an long that adds two long
            long longAdd = 46 + 57;

            // prints the max and min of two long variables
            Console.WriteLine($"the max of {longMult} and {longAdd} is {Math.Max(longMult, longAdd)}. " +
                $"The minimum of the two is {Math.Min(longMult, longAdd)}.");

            // initializes bool to see if longmult is greater than longadd
            bool islongGreater = longMult > longAdd;
            // prints if longmult is greater than longadd
            Console.WriteLine($"{longMult} is greater than {longAdd}, {islongGreater}.");



            Console.WriteLine("FLOATS");
            // initializes a float that multiplies two floats
            float floatMult = 8.2f * 66.23f;
            // initializes a float that adds two floats
            float floatAdd = 46.55f + 57.21f;

            // prints the max and min of two floats variables
            Console.WriteLine($"the max of {floatMult} and {floatAdd} is {Math.Max(floatMult, floatAdd)}. " +
                $"The minimum of the two is {Math.Min(floatMult, floatAdd)}.");

            // initializes bool to see if floatmult is greater than floatadd
            bool isfloatGreater = floatMult > floatAdd;
            // prints if floatmult is greater than floatadd
            Console.WriteLine($"{floatMult} is greater than {floatAdd}, {isfloatGreater}.");


            Console.WriteLine("DOUBLES");
            // initializes a double that multiplies two doubles
            double doubleMult = 8.67 * 66.32;
            // initializes a double that adds two doubles
            double doubleAdd = 46.21 + 57.45;

            // prints the max and min of two doubles variables
            Console.WriteLine($"the max of {doubleMult} and {doubleAdd} is {Math.Max(doubleMult, doubleAdd)}. " +
                $"The minimum of the two is {Math.Min(doubleMult, doubleAdd)}.");

            // initializes bool to see if doublemult is greater than doubleadd
            bool isdoubleGreater = doubleMult > doubleAdd;
            // prints if doublemult is greater than doubleadd
            Console.WriteLine($"{doubleMult} is greater than {doubleAdd}, {isdoubleGreater}.");


            Console.WriteLine("DECIMALS");
            // initializes a decimal that multiplies two decimal
            decimal decimalMult = (decimal)(8.32 * 66.43);
            // initializes a decimal that adds two decimal
            decimal decimalAdd = (decimal)(46.34 + 57.43);

            // prints the max and min of two decimal variables
            Console.WriteLine($"the max of {decimalMult} and {decimalAdd} is {Math.Max(decimalMult, decimalAdd)}. " +
                $"The minimum of the two is {Math.Min(decimalMult, decimalAdd)}.");

            // initializes bool to see if decimalmult is greater than decimaladd
            bool isdecimalGreater = decimalMult > decimalAdd;
            // prints if decimalmult is greater than decimaladd
            Console.WriteLine($"{decimalMult} is greater than {decimalAdd}, {isdecimalGreater}.");
        }
    }
}