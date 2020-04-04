using System;
using System.Linq;

namespace Other
{
    class Program
    {
        static void Main(string[] args)
        {
            //シーケンスをフィルターする
            var a = Enumerable.Range(1,10).Where(i => i % 2 == 0);
            Console.WriteLine(string.Join(",",a.Select(i => Convert.ToString(i))));

            //シーケンスから重複のないデータを取得する
            var b = Enumerable.Repeat(1,10).Distinct();
            Console.WriteLine(string.Join(",",b.Select(i => Convert.ToString(i))));
        }
    }
}
