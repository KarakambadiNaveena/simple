using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace August22
{
    internal class program11
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> dic = new Dictionary<int, string>();
            dic.Add(1, "pravallika");
            dic.Add(2, "Nani");
            dic.Add(3, "Sam");
            dic.Add(4, "Vaishu");

            foreach (KeyValuePair<int, string> item in dic)
            {
                Console.WriteLine(item.Key + " " + item.Value);

            }
            Console.WriteLine("Sorted by value");
            
            foreach (KeyValuePair<Int32, string> item in dic.OrderBy(key => key.Value))
            {
                Console.WriteLine("Key: {0}, Value: {1}", item.Key, item.Value);
            }
            Console.WriteLine("Sorted by Key");

            foreach (KeyValuePair<Int32, string> item in dic.OrderBy(key => key.Key))
            {
                Console.WriteLine("Key: {0}, Value: {1}", item.Key, item.Value);
            }
            Console.ReadKey();
        }
        }
    }

