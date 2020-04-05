using System;
using System.Linq;

namespace Aggregate
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = Enumerable.Range(1,10).ToArray();

            //シーケンスを集計する
            var a = s.Aggregate((i,j) => i + j);
            Console.WriteLine(a);

            var b = s.Aggregate((i,j) => i * j);
            Console.WriteLine(b);
        }
    }
}
