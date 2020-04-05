using System;
using System.Linq;

namespace 集合
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = Enumerable.Range(1,5).ToArray();
            var t = s.Select(i => i * 2).ToArray();

            //和
            var a = s.Union(t);
            Console.WriteLine(string.Join(",",a.Select(i => Convert.ToString(i))));

            //差
            var b = s.Except(t);
            Console.WriteLine(string.Join(",",b.Select(i => Convert.ToString(i))));

            //積
            var c = s.Intersect(t);
            Console.WriteLine(string.Join(",",c.Select(i => Convert.ToString(i))));
        }
    }
}
