using System;
using System.Linq;

namespace Other
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = Enumerable.Range(1,10).ToArray();

            //シーケンスの全ての要素が条件を満たすか
            var a = s.All(i => i < 10);
            Console.WriteLine(a);

            //シーケンスが条件の要素を含むか
            var b = s.Contains(5);
            Console.WriteLine(b);

            //シーケンスが等しいか
            var c = s.SequenceEqual(Enumerable.Range(1,10).ToArray());
            Console.WriteLine(c);
        }
    }
}
