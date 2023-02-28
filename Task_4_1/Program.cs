using Task_4_1.Models;

namespace Task_4_1
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

            var people = from emp in employees
                         join dep in departments on emp.DepartmentId equals dep.Id
                         select new
                         {
                             Name = emp.Name,
                             Department = dep.Name,
                             Id = emp.Id
                         };

            foreach (var employee in people)
            {
                Console.WriteLine($"{employee.Name} работает в отделе {employee.Department}");
            }

            Console.WriteLine(new string('-', 50));

            var peopleWithExtension = employees.Join(departments,
                                                     emp => emp.DepartmentId,
                                                     dep => dep.Id,
                                                     (emp, dep) =>
                                                     new
                                                     {
                                                         Name = emp.Name,
                                                         Department = dep.Name,
                                                         Id = emp.Id
                                                     });
            foreach (var employee in people)
            {
                Console.WriteLine($"{employee.Name} работает в отделе {employee.Department}");
            }
        }
    }
}