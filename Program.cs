namespace Operatoes_Bruner_Zach
{
    internal class Program
    {
        
        
        static void Main(string[] args)
        {
            // Initializes an interger that multiplies two intergers
            int intMult = 6 * 45;
            // Initialized an integer that adds to integers
            int intAdd = 55 + 66;
            // Prints the maxium and minimum of the two integer variables
             Console.WriteLine($"The max of {intMult} of {intAdd} is {Math.Max (intMult, intAdd)}. " +
                $"The min of the two is {Math.Min(intMult, intAdd)}.");
            // Initializes boolean to see if intMult is greater that intAdd           
            bool isIntGreater = intMult > intAdd;
            // Prints if intMult is greater than intAdd
            Console.WriteLine($"{intMult} is greater than {intAdd}, {isIntGreater}.");



            // Initializes an interger that multiplies two intergers
            short shortMult = 6 * 45;
            // Initialized an integer that adds to integers
            short shortAdd = 55 + 66;
            // Prints the maxium and minimum of the two integer variables
            Console.WriteLine($"The max of {shortMult} of {shortAdd} is {Math.Max(shortMult, shortAdd)}. " +
               $"The min of the two is {Math.Min(shortMult, shortAdd)}.");
            // Initializes boolean to see if shortMult is greater that shortAdd           
            bool isshortGreater = shortMult > shortAdd;
            // Prshorts if shortMult is greater than shortAdd
            Console.WriteLine($"{shortMult} is greater than {shortAdd}, {isshortGreater}.");


            // Initializes an longerger that multiplies two longergers
            long longMult = 6 * 45;
            // Initialized an longeger that adds to longegers
            long longAdd = 55 + 66;
            // Prlongs the maxium and minimum of the two longeger variables
            Console.WriteLine($"The max of {longMult} of {longAdd} is {Math.Max(longMult, longAdd)}. " +
               $"The min of the two is {Math.Min(longMult, longAdd)}.");
            // Initializes boolean to see if longMult is greater that longAdd           
            bool islongGreater = longMult > longAdd;
            // Prlongs if longMult is greater than longAdd
            Console.WriteLine($"{longMult} is greater than {longAdd}, {islongGreater}.");



            // Initializes an float that multiplies two float
           float floatMult = 6.5f * 45.24f;
            // Initialized an float that adds to float
           float floatAdd = 55.35f + 66.15f;
            // Prints the maximum and minimum of the two float variables
            Console.WriteLine($"The max of {floatMult} of {floatAdd} is {Math.Max(floatMult,floatAdd)}. " +
               $"The min of the two is {Math.Min(floatMult,floatAdd)}.");
            // Initializes boolean to see if floatMult is greater that floatAdd           
            bool isfloatGreater =floatMult > floatAdd;
            // Prints if floatMult is greater than floatAdd
            Console.WriteLine($"{floatMult} is greater than {floatAdd}, {isfloatGreater}.");



            // Initializes an Double  that multiplies two Double
            Double DoubleMult = 6.69 * 45.58;
            // Initialized an Double that adds to Double
            Double DoubleAdd = 55.45 + 66.15;
            // Prints the maxium and minimum of the two Double variables
            Console.WriteLine($"The max of {DoubleMult} of {DoubleAdd} is {Math.Max(DoubleMult, DoubleAdd)}. " +
               $"The min of the two is {Math.Min(DoubleMult, DoubleAdd)}.");
            // Initializes boolean to see if DoubleMult is greater that DoubleAdd           
            bool isDoubleGreater = DoubleMult > DoubleAdd;
            // PrDoubles if DoubleMult is greater than DoubleAdd
            Console.WriteLine($"{DoubleMult} is greater than {DoubleAdd}, {isDoubleGreater}.");
        }
    }
}