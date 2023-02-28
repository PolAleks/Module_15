using Task_4_2.Models;

namespace Task_4_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var departments = new List<Department>()
            {
                new Department() {Id = 1, Name = "Программирование"},
                new Department() {Id = 2, Name = "Продажи"}
            };

            var employees = new List<Employee>()
            {
                new Employee() { DepartmentId = 1, Name = "Инна", Id = 1},
                new Employee() { DepartmentId = 1, Name = "Андрей", Id = 2},
                new Employee() { DepartmentId = 2, Name = "Виктор ", Id = 3},
                new Employee() { DepartmentId = 3, Name = "Альберт ", Id = 4},
            };

            var selectGroupEmploeers = departments.GroupJoin(employees,
                                                             dep => dep.Id,
                                                             emp => emp.DepartmentId,
                                                             (dep, empls) => new
                                                             {
                                                                 Department = dep.Name,
                                                                 Emploees = empls.Select(emp => emp.Name)
                                                             });
            foreach(var dep in selectGroupEmploeers)
            {
                Console.WriteLine(dep.Department);

                foreach(var emp in dep.Emploees) {
                    Console.WriteLine(emp);
                }
            }
        }
    }
}