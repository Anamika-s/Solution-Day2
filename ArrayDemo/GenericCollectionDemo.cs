using System;
using System.Collections.Generic;  // this namesnspace is used for generic collectio
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayDemo
{
    internal class GenericCollectionDemo
    {
        static void Main()
        {
            // ArrayList > List
            List<int> list = new List<int>();
            list.Add(1);
            //list.Add("aaaa");

            Queue<string> list2 = new Queue<string>();

            Stack<string> stack = new Stack<string>();

            Dictionary<int, string> list1 = new Dictionary<int, string>(); 



        }
    }
}
