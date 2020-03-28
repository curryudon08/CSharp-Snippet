using System;
using System.Linq;
using System.Collections.Generic;

namespace Permutation
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var items = Enumerable.Range(1, n).ToArray();

            foreach(var l in Permutation(items)){
                var s = l.Select(i => i.ToString());
                Console.WriteLine(string.Join(" ", l));
            }
        }

        //全ての要素を使用した順列を求める
        static IEnumerable<T[]> Permutation<T>(IEnumerable<T> items){
            if (items.Count() == 1){
                yield return new T[]{items.First()};
                yield break;
            }

            foreach (var item in items){
                var used = new T[]{item};
                var unused = items.Except(used);
                foreach(var itm in Permutation(unused)){
                    yield return used.Concat(itm).ToArray();
                }
            }
        }
    }
}
