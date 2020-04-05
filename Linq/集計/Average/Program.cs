using System;
using System.Linq;

namespace Average
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = Enumerable.Range(1,10).ToArray();

            //シーケンスの平均値を取得する
            var a = s.Average();
            Console.WriteLine(a);

            //シーケンスの各要素に関数を適した後の平均値を取得する
            var b = s.Average(i => i * 2);
            Console.WriteLine(b);
        }
    }
}
