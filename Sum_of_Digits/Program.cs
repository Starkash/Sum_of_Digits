using System;

namespace Sum_of_Digits
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter Any Number");
            int n1 = int.Parse(Console.ReadLine());
            int sum = 0; 
            while (n1 != 0)
            {
                int rem = n1 % 10;
                 sum = sum + rem;
                n1 = n1 / 10;

            }
            Console.WriteLine("Sum of Digits is :"+sum);
        }
    }
}
