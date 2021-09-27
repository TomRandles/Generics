using System;

namespace Reflection.Domain
{
    public class Employee
    {
        public string Name { get; set; }
        public void Speak<T>()
        {
            Console.WriteLine(typeof(T).Name);
        }
    }
}
