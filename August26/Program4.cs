using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace August26_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedList<string> mylist = new LinkedList<string>();
            mylist.AddFirst("Navi");
            mylist.AddLast("Navs");
            mylist.AddAfter(mylist.First, "sam");
            mylist.AddBefore(mylist.Last, "raj");
            mylist.AddBefore(mylist.Last.Previous, "rams");
            mylist.AddAfter(mylist.First.Next, "mom");
            LinkedListNode<string> foundnode = mylist.Find("raj");
            foundnode.Value = "ram";



            foreach (var item in mylist)
            {
                Console.WriteLine(item);

            }
            Console.ReadKey();
        }
    }
}
