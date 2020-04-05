using System;
using System.Linq;

namespace Max
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = Enumerable.Range(1,10).ToArray();

            //シーケンスの最大値を取得する
            var a = s.Max();
            Console.WriteLine(a);

            //シーケンスの各要素に関数を適した後の最大値を取得する
            var b = s.Max(i => i * 2);
            Console.WriteLine(b);
        }
    }
}
