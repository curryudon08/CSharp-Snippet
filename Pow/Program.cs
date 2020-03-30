using System;

namespace Pow
{
    class Program
    {
        static void Main(string[] args)
        {
            var _ = Console.ReadLine().Split();
            var x = long.Parse(_[0]);
            var n = long.Parse(_[1]);

            Console.WriteLine(Pow(x, n, 1000000007));
        }

        static long Pow(long x, long n, long mod){
            var val = 1L;
            while(n > 0){
                if(n % 2 == 1){
                    val = val * x % mod;
                }
                x = x * x % mod;
                n = n >> 1;
            }
            return val;
        }
    }
}
