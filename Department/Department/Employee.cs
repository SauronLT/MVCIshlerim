using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Department
{
    public class Employee : IPerson
    {
        private static int _idCounter = 0;
        public int Id { get; }
        public string Name { get; }
        public int Age { get; }
        public double Salary { get; }

        public Employee(string name, int age, double salary)
        {
            Id = ++_idCounter;
            Name = name;
            Age = age;
            Salary = salary;
        }

        public string ShowInfo()
        {
            return $"Id: {Id}, Name: {Name}, Age: {Age}, Salary: {Salary}";
        }

        public override string ToString() => ShowInfo();
    }
}
