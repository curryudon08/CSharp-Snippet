using System;
using System.Linq;

namespace Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = Enumerable.Range(1,10).ToArray();

            //シーケンスの合計値を取得する
            var a = s.Sum();
            Console.WriteLine(a);

            //シーケンスの各要素に関数を適した後の合計値を取得する
            var b = s.Sum(i => i * 2);
            Console.WriteLine(b);
        }
    }
}
