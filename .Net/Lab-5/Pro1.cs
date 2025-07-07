using System;
using System.Collections;
using System.Reflection.PortableExecutable;

namespace Lab_5
{
    internal class Pro1
    {
        ArrayList StudentName = new ArrayList();
        
        public void addStudent(string name)
        {
            StudentName.Add(name);
        }

        public void removeStudent(string name)
        {
            StudentName.Remove(name);
        }

        public void removeStudent(int i, int j)
        {
            StudentName.RemoveRange(i, j);
        }

        public void clearStudent()
        {
            StudentName.Clear();
        }
    }
}
