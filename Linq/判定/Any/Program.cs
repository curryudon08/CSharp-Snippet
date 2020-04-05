using System;
using System.Linq;

namespace Any
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = Enumerable.Range(1,10).ToArray();

            //シーケンスに要素があるか
            var a = s.Any();
            Console.WriteLine(a);

            //シーケンスに条件を満たす要素があるか
            var b = s.Any(i => i > 10);
            Console.WriteLine(b);
        }
    }
}
