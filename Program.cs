using System;

namespace SumofNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum=0;
            Console.WriteLine("Hello, please input a number I can sum up");
            int n = int.Parse(Console.ReadLine());
            while (n > 0)
            {
                sum+= n;
                n--;
            }
            Console.WriteLine("The sum of all the numbers preceding the number you've inputted is {0}", sum);

        }
    }
}
