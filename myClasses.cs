using System;

namespace myClasses
{
    public class GenericList<T> where T:IComparable
    {
        public string nameList;
        
        public GenericList(){
            Console.WriteLine("GenericList created!");
        }

        public T Max(T a, T b)
        {
            return a.CompareTo(b) > 0 ? a : b;
        }

    }

}