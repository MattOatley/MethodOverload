using System;
using System.Diagnostics.CodeAnalysis;

namespace MethodOverload
{
    class Program
    {
        static void Main(string[] args)
        {

            
            string result = Add(2, 3, true);
            Console.WriteLine($"You have {result}");
            
        
        }
        public static int Add(int x, int y)
        {
            return x + y;
        }
        public static decimal Add(decimal x, decimal y)
        {
            return x + y;
        }
        public static string Add(int x, int y, bool isTrue)
        {
            int sum = x + y;
            if (isTrue == true && sum > 1)
            {
                return $"{sum} dollars";
            }
            else if (isTrue == true && sum <= 1)
            {
                return ($"{sum} dollar");
            }
            else
            {
                return "Sorry something went wrong!";
            }
            
            
            
        }
    }
}
