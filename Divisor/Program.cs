using System;
using System.Linq;
using System.Collections.Generic;

namespace Divisor
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = long.Parse(Console.ReadLine());

            foreach(var i in Divisor(n)){
                Console.WriteLine(i);
            }
        }

        static List<long> Divisor(long n){
            var l = new List<long>();
            for(var i = 1L; i * i <= n; i++){
                if(n % i == 0){
                    l.Add(i);
                    if(i * i != n){
                        l.Add(n / i);
                    }
                }
            }
            l.Sort();
            return l;
        }
    }
}
