using System;
using System.Collections.Generic;
using System.Text;

namespace EA_Test_3
{
    class LinkList<T>
    {
        public Node<T> End { get; set; }

        public LinkList(T d)
        {
            this.End = new Node<T>(d);
        }

        public void Add(T d)
        {
            Node<T> NewNode = new Node<T>(d);
            NewNode.NextNode = this.End;
            this.End = NewNode;
        }

        public Node<T> Next(Node<T> node)
        {
            return node.NextNode;
        }

        public int GetLength()
        {
            int count = 0;
            Node<T> next = this.End;
            while(next != null)
            {
                count++;
                next = this.Next(next);
            }
            return count;
        }

        public Node<T> GetNode(int i)
        {
            int count = 1;
            Node<T> next = this.End;
            while (count <= i)
            {
                count++;
                next = this.Next(next);
            }
            return next;
        }

        public void Delete(int n)
        {                        
            GetNode(n - 2).NextNode = GetNode(n);
        }

    }
}
