using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;


namespace StackList
{
    public class Stack<T>
    {
        public Node<T> Head { get; set; }
        public Stack()
        {
            Head = null;
        }
        public void Push(T value)
        {
            Node<T> node = new Node<T>();
            node.Value = value;
            if(Head == null)
            {
                Head = node;
            }
            else
            {
                node.NexNode = Head;
                Head = node;
            }
        }
        public T Pop()
        {
            if(Head==null)
            {
                throw new InvalidOperationException("Стек пустой");
            }
            T result = Head.Value;
            Head = Head.NexNode;
            return result;
        }
    }
}