using System;
using System.Linq;

namespace ソート
{
    class Program
    {
        static void Main(string[] args)
        {

            var s = new int[]{1,5,3,10,7,8,2,4,9,6};

            //反転
            var a = s.Reverse().ToArray();
            Console.WriteLine(string.Join(",",a.Select(i => Convert.ToString(i))));

            //昇順
            var b = s.OrderBy(i => i);
            Console.WriteLine(string.Join(",",b.Select(i => Convert.ToString(i))));

            //降順
            var c = s.OrderByDescending(i => i);
            Console.WriteLine(string.Join(",",c.Select(i => Convert.ToString(i))));

            //複数の条件でソートする際は、Thenby、ThenByDescendingを使用する
        }
    }
}
