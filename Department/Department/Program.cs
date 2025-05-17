namespace Department
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Department dep = new Department("eli", 2);

            dep.AddEmployee(new Employee("veli", 25, 1000));
            dep.AddEmployee(new Employee("şefteli", 28, 1100));

            Console.WriteLine(dep[0]);
            Console.WriteLine(dep[1]);

        }
    }
}
