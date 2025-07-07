using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5
{
    internal class Pro4
    {
        public void QueueOperation()
        {
            Queue<int> q = new Queue<int>();
            q.Enqueue(1);
            q.Enqueue(2);
            q.Enqueue(3);
            q.Enqueue(4);
            q.Enqueue(5);
            q.Dequeue();
            q.Dequeue();
            Console.WriteLine("Front element in queue: " + q.Peek());
            
            if (q.Contains(3))
            {
                Console.WriteLine("Queue contains 3");
            }
            else
            {
                Console.WriteLine("Queue does not contain 3");
            }
            Console.WriteLine("Queue elements: ");
            foreach (var item in q)
            {
                Console.WriteLine(item);
            }
            
            q.Clear();
        }
    }
}
