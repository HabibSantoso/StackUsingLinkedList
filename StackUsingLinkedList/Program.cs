using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackUsingLinkedList
{
    class Node
    {
        public int info;
        public Node next;
        public Node(int i, Node n)
        {
            info = i;
            next = n;
        }
    }

    class Stack
    {
        Node top;

        public Stack()
        {
            top = null;
        }

        bool empty()
        {
            if (top == null)
            { 
                return (true);
            }
            else
            {
                return (false);
            }
        }

        public void push(int element)
        {
            Node fresh;
            fresh = new Node(element, null);

            fresh.next = top;
            top = fresh;
            Console.WriteLine("\n" + element + " pushed.");
        }

        public void pop()
        {
            Console.WriteLine("\nThe poped element is: " + top.info);
            top = top.next; // make top point to the next node in sequence
        }

        public void display()
        {
            Node tmp;

           
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
