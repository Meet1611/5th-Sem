using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5
{
    internal class Pro3
    {
        public void StackOperation()
        {
            Stack<int> s = new Stack<int>();
            s.Push(1);
            s.Push(2);
            s.Push(3);
            s.Push(4);
            s.Push(5);
            s.Pop();
            s.Pop();
            Console.WriteLine("Top element in stack :", s.Peek());
            if(s.Contains(3))
            {
                Console.WriteLine("Stack contains 3");
            }
            else
            {
                Console.WriteLine("Stack does not contain 3");
            }

            Console.WriteLine("Stack : ");
            foreach (var item in s)
            {
                Console.WriteLine(item);
            }
            s.Clear();
        }
    }
}
