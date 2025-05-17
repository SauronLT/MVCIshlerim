using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Department;

public class Department
{
    public string Name { get; set; }
    public int EmployeeLimit { get; set; }
    private Employee[] Employees;
    private int count = 0;

    public Department(string name, int limit)
    {
        Name = name;
        EmployeeLimit = limit;
        Employees = new Employee[limit];
    }

    public void AddEmployee(Employee emp)
    {
        if (count >= EmployeeLimit)
            throw new CapacityLimitException("Limit keçildi.");

        Employees[count++] = emp;
    }

    // Indexer
    public Employee this[int index]
    {
        get => Employees[index];
        set => Employees[index] = value;
    }
}
