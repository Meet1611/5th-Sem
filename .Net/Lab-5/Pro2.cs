using System;

namespace Lab_5
{
    internal class Pro2
    {
        public void ListOperation()
        {
            List<string> Students = new List<string>();
            Students.Add("John Doe");
            Students.Add("Jane Smith");
            Students.Add("Alice Johnson");
            Students.Remove("Jane Smith");
            Students.Add("Bob Brown");
            Students.RemoveRange(0, 1);
            
            foreach (var student in Students)
            {
                Console.WriteLine(student);
            }

            Students.Clear();
        }
    }
}
