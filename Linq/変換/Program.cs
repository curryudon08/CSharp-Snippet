using System;
using System.Linq;

namespace 変換
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = Enumerable.Range(1,10);

            //シーケンスから配列を生成
            var a = s.ToArray();
            Console.WriteLine(string.Join(",",a.Select(i => Convert.ToString(i))));

            //シーケンスからリストを生成
            var b = s.ToList();
            Console.WriteLine(string.Join(",",b.Select(i => Convert.ToString(i))));

            //シーケンスからDictionaryを生成
            var c = s.ToDictionary(i => i, i => i * i);
            foreach(var t in c){
                Console.Write(string.Format("({0},{1}),",t.Key,t.Value));
            }
        }
    }
}
