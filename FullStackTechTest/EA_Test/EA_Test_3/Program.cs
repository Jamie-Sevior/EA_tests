using System;
using System.Collections.Generic;

namespace EA_Test_3
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkList<string> list1 = new LinkList<string>("first entry");
            list1.Add("second entry");
            list1.Add("third entry");
            list1.Add("fourth entry");
            list1.Add("fifth entry");

            LinkList<int> list2 = new LinkList<int>(123);
            list2.Add(456);
            list2.Add(789);

            int i = list1.GetLength();
            var testnode = list1.GetNode(4);
            list1.Delete(4);
            testnode = list1.GetNode(3);
        }
    }
}
