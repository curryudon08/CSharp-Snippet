using System;

namespace Lcm
{
    class Program
    {
        static void Main(string[] args)
        {
            var _ = Console.ReadLine().Split();
            var a = int.Parse(_[0]);
            var b = int.Parse(_[1]);

            Console.WriteLine(Lcm(a, b));
        }

        //最小公倍数
        static long Lcm(long m, long n){
        	return (m * n) / Gcd(m, n);
        }

        //最大公約数
        static long Gcd(long m, long n)
        {
	        while (m % n != 0){
        		var temp = n;
		        n = m % n;
		        m = temp;
	        }
        	return n;
        }
    }
}
