using System.Text;

namespace MoneyDispenserApp;

public class Program
{
    static void Main(string[] args)
    {
        //Money(5.09);
        Convert(741);
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

    public static string Convert(int i)
    {
        if(i <= 0)
        {
            throw new ArgumentOutOfRangeException("Dont be an idiot");
        }
        StringBuilder str = new StringBuilder("");
        while (i > 0)
        {
            if (i > 1000)
            {
                str.Append("M");
                i -= 1000;
            }
            else if (i >= 900)
            {
                str.Append("CM");
                i -= 900;
            }
            else if (i >= 500)
            {
                str.Append("D");
                i -= 500;
            }
            else if (i >= 400)
            {
                str.Append("CD");
                i -= 400;
            }
            else if (i >= 100)
            {
                str.Append("C");
                i -= 100;
            }
            else if (i >= 90)
            {
                str.Append("XC");
                i -= 90;
            }
            else if (i >= 50)
            {
                str.Append("L");
                i -= 50;
            }
            else if (i >= 40)
            {
                str.Append("XL");
                i -= 40;
            }
            else if (i >= 10)
            {
                str.Append("X");
                i -= 10;
            }
            else if (i >= 9)
            {
                str.Append("IX");
                i -= 9;
            }
            else if (i >= 5)
            {
                str.Append("V");
                i -= 5;
            }
            else if (i >= 4)
            {
                str.Append("IV");
                i -= 4;
            }
            else
            {
                str.Append("I");
                i -= 1;
            }
        }
        Console.WriteLine(str.ToString());
        return str.ToString();
    }
   }
    