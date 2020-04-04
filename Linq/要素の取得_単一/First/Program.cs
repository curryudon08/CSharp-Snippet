using System;
using System.Linq;

namespace First
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = Enumerable.Range(1,10).ToArray();

            //シーケンスの最初の要素を取得
            var a = s.First();
            Console.WriteLine(a);

            //指定の条件を満たす、最初の要素を取得（条件に一致する値がない場合、例外）
            var b = s.First(i => i > 5);
            Console.WriteLine(b);

            //指定の条件を満たす、最初の要素を取得（条件に一致する値がない場合、規定値）
            var c = s.FirstOrDefault(i => i > 10);
            Console.WriteLine(c);
        }
    }
}
