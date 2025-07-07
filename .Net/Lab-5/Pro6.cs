using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5
{
    internal class Pro6
    {
        public void HashSetOperation()
        {
            Hashtable table = new Hashtable();
            table.Add(1, "John Doe");
            table.Add(2, "Jane Smith");
            table.Add(3, "Alice Johnson");
            table.Add(4, "Bob Brown");
            table.Remove(2); 
            
            if(table.ContainsKey(3))
            {
                Console.WriteLine("Key 3 exists with value: " + table[3]);
            }
            else
            {
                Console.WriteLine("Key 3 does not exist.");
            }

            if(table.ContainsValue("Alice Johnson"))
            {
                Console.WriteLine("Value 'Alice Johnson' exists in the hashtable.");
            }
            else
            {
                Console.WriteLine("Value 'Alice Johnson' does not exist in the hashtable.");
            }
            table.Clear();
        }
    }
}
