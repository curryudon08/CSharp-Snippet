using System;
using System.Linq;

namespace Min
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = Enumerable.Range(1,10).ToArray();

            //シーケンスの最小値を取得する
            var a = s.Min();
            Console.WriteLine(a);

            //シーケンスの各要素に関数を適した後の最小値を取得する
            var b = s.Min(i => i * 2);
            Console.WriteLine(b);
        }
    }
}
