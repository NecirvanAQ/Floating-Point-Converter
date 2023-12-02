using System;
using System.Collections.Generic;


class Program
{
    static void Main(string[] args)
    {
        double answer;
        string mantissa;
        
        do
        {
            Console.WriteLine("Enter mantissa (8 bits): ");
            mantissa = Console.ReadLine();

        } while (mantissa.Length != 8 || (!mantissa.Substring(0,2).Contains("1") && !mantissa.Substring(0, 2).Contains("0")));
        
        string exponent;
        do
        {
            Console.WriteLine("Enter exponent (4 bits): ");
            exponent = Console.ReadLine();

        } while (exponent.Length != 4);

        double doubleExponent = -7 + Convert.ToDouble(Convert.ToInt32(exponent, 2));
        if (exponent[0] == '1')
        {
            doubleExponent -= 8;
        }

        double doubleMantissa = Convert.ToDouble(Convert.ToInt32(mantissa, 2));
        if (mantissa[0] == '1')
        {
            doubleMantissa -= 256;
        }

        Console.WriteLine("\n"+doubleMantissa*Math.Pow(2, doubleExponent));
    }

}
