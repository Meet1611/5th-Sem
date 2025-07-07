using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5
{
    internal class Pro5
    {
        public void DictionaryOperation()
        {
            Dictionary<int, string> dict = new Dictionary<int, string>();
            dict.Add(1, "John Doe");
            dict.Add(2, "Jane Smith");
            dict.Add(3, "Alice Johnson");
            dict.Add(4, "Bob Brown");
            dict.Remove(2); 
            if(dict.ContainsKey(3))
            {
                Console.WriteLine("Key 3 exists with value: " + dict[3]);
            }
            else
            {
                Console.WriteLine("Key 3 does not exist.");
            }

            if(dict.ContainsValue("Alice Johnson"))
            {
                Console.WriteLine("Value 'Alice Johnson' exists in the dictionary.");
            }
            else
            {
                Console.WriteLine("Value 'Alice Johnson' does not exist in the dictionary.");
            }

            foreach(var temp in dict)
            {   
                Console.WriteLine(temp.Key + " : " + temp.Value);
            }
            dict.Clear();
        }
    }
}
