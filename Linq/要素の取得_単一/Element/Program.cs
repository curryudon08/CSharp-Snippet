using System;
using System.Linq;
namespace Element
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = Enumerable.Range(1,10).ToArray();

            //シーケンスの指定位置の要素を取得
            var a = s.ElementAt(1);
            Console.WriteLine(a);

            //シーケンスの指定位置の要素を取得（条件に一致する値がない場合、規定値）
            var b = s.ElementAtOrDefault(10);
            Console.WriteLine(b);
        }
    }
}
