using System;
using System.Linq;

namespace Last
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = Enumerable.Range(1,10).ToArray();

            //シーケンスの最後の要素を取得
            var a = s.Last();
            Console.WriteLine(a);

            //指定の条件を満たす、最後の要素を取得（条件に一致する値がない場合、例外）
            var b = s.Last(i => i > 5);
            Console.WriteLine(b);

            //指定の条件を満たす、最後の要素を取得（条件に一致する値がない場合、規定値）
            var c = s.LastOrDefault(i => i > 10);
            Console.WriteLine(c);
        }
    }
}
