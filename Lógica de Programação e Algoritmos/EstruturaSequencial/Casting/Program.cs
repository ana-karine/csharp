namespace Casting
{    
    class Program
    {
        static void Main(string[] args)
        {
            int numberA, numberB;
            double division;
            double divisionWithCasting;

            numberA = 5;
            numberB = 2;

            division = numberA / numberB;
            divisionWithCasting = (double) numberA / numberB;

            Console.WriteLine("Divisão = " + division); // 2
            Console.WriteLine("Divisão com Casting = " + divisionWithCasting); // 2,5
        }
    }
}
