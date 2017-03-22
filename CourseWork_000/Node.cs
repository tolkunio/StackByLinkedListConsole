using System;
using System.Collections.Generic;
using System.Text;

namespace StackList
{
    public class Node<T>
    {
        public T Value { get; set; }
        public Node<T> NexNode { get; set; }
        public Node()
        {
            this.NexNode = null;
        }

    }
}
