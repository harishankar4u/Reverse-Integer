using System.Collections.Generic;
using static System.Runtime.InteropServices.JavaScript.JSType;

class program
{
    public static void Main(string[] args)
    {
        Console.WriteLine(ReverseInteger(123)); //output 321
        Console.WriteLine(ReverseInteger(120)); //output 21
        Console.WriteLine(ReverseInteger(-123)); //output -321
        Console.WriteLine(ReverseInteger(1534236469)); //output 0
    }
    public static int ReverseInteger(int value)
    {
        int result = 0;
        while (value != 0)
        {
            int digit = value % 10;
            if (result > int.MaxValue/10 || (result== int.MaxValue / 10 && digit>7))
            {
                return 0;
            }
            //int.MaxValue = 2147483647(last digit is 7)
            //int.MinValue = -2147483648(last digit is -8)
            //By checking before multiplying and adding, you prevent overflow instead of reacting too late.

            if (result < int.MinValue / 10 || (result == int.MinValue / 10 && digit<-8))
            {
                return 0;
            }
            
            result= result*10+ digit;
            value=value/10;

        }
        return result;
    }
}