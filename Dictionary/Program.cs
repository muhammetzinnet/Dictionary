using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> dic = new Dictionary<int, string>();

            dic.Add(1, "eyup çevik");
            dic.Add(2, "halid çevik");
            dic.Add(3, "zinnet çevik");

            Console.WriteLine(dic[3]);

            foreach (var item in dic)
                Console.WriteLine(item);

            Console.WriteLine(dic.Count);

            Console.WriteLine(dic.ContainsKey(2));
            Console.WriteLine(dic.ContainsValue("eyup çevik"));

            dic.Remove(2);
            foreach (var item in dic)
                Console.WriteLine(item);

            foreach (var item in dic.Keys)
                Console.WriteLine(item);

            foreach(var item in dic.Values)
                Console.WriteLine(item);
        }
    }
}
