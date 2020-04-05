using System;
using System.Linq;

namespace Count
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = Enumerable.Range(1,10).ToArray();

            //シーケンスの要素数を取得する
            var a = s.Count();
            Console.WriteLine(a);

            //シーケンスの条件を満たす要素数を取得する
            var b = s.Count(i => i % 2 == 0);
            Console.WriteLine(b);
        }
    }
}
