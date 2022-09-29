namespace MoneyDispenserApp;

internal class Program
{
    static void Main(string[] args)
    {
        Money(5.09);
    }

    public static string Money(double input)
    {
        input = input * 100;
        int c2Pound = 0;
        int c1Pound = 0;
        int c20P = 0;
        int c5P = 0;
        int c2P = 0;
        int c1P = 0;
        while (input > 0)
        {
            if (input > 200)
            {
                c2Pound++;
                input -= 200;
             
            }
            else if (input > 100)
            {
                c1Pound++;
                input -= 100;

            }
            else if (input > 20)
            {
                c20P++;
                input -= 20;
             
            }
            else if (input > 5)
            {
                c5P++;
                input -= 5;
            }
            else if (input > 2)
            { 
                c2P++;
                input -= 2;
                Console.WriteLine(input);
            }
            else
            {
                c1P++;
                input -=1;
            }
        }
        Console.WriteLine($"£2: {c2Pound}, £1: {c1Pound}, 20p:{c20P}, 5p:{c5P}, 2p:{c2P}, 1p:{c1P}");
        return $"£2: {c2Pound}, £1: {c1Pound}, 20p:{c20P}, 5p:{c5P}, 2p:{c2P}, 1p:{c1P}";
      }
   }
    