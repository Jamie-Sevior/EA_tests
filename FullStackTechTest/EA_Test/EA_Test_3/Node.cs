using System;
using System.Collections.Generic;
using System.Text;

namespace EA_Test_3
{
    public class Node<T>
    {
        internal T Data { get;}
        internal Node<T> NextNode { get; set; }

        public Node(T d)
        {
            this.Data = d;
            this.NextNode = null;
        }

        

    }
}
