using System;
using System.Linq;

namespace Skip
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = Enumerable.Range(1,10).ToArray();

            //シーケンスの先頭から指定した個数をとばして、残りを取得する
            var a = s.Skip(3);
            Console.WriteLine(string.Join(",",a.Select(i => Convert.ToString(i))));

            //シーケンスの先頭から、条件を満たす間をとばして、残りを取得する
            var b = s.SkipWhile(i => i < 5);
            Console.WriteLine(string.Join(",",b.Select(i => Convert.ToString(i))));
        }
    }
}
