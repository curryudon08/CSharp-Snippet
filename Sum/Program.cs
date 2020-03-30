using System;

namespace Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = long.Parse(Console.ReadLine());
            Console.WriteLine(Sum(n));
        }

        //等差数列の和
        static long Sum(long n){
            return ((1 + n) * n) / 2;
        }
    }
}
