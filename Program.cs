using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq3
{
    class Program
    {
        static void Main(string[] args)
        {
            var Emp = Employee.GetEmployee();
            var Dep = Department.GetDepart();
            
            var collec = Emp.Join(
                          Dep,
                          e => e.DepId,
                          d => d.Id,
                          (e, d) => new {
                              id = d.Id,
                              Country = d.Country,
                              City = d.City,
                              FirstName = e.FirstName,
                              LastName = e.LastName,
                              Age = e.Age

                          }
                      ).Where(x => x.Country == "Ukraine")
                      .OrderBy(e=>e.FirstName);

            collec.ToList().ForEach(collects => Console.WriteLine(
                           $"{collects.id,-15} - " +
                           $"{collects.Country,-15} - " +
                           $"{collects.FirstName,-15} - " +
                           $"{collects.LastName,-15}")
                           );
            Console.WriteLine();
            //2
            var coll2 = Emp.Where(Employee => Employee.Id > 0)
                       .OrderBy(Employee => -Employee.Age);
                       
                         

            foreach (var Employee in coll2)
            {
                Console.WriteLine($"{Employee.Id,-15}-"+$"{Employee.FirstName,-15}-" +
                    $"{Employee.LastName,-15}-"+$"{Employee.Age,-15}");
            }
            Console.WriteLine();
            
            //3
            var coll3 = from Employee in Emp
                        group Employee by Employee.Age;
            foreach (var group in coll3)
            {
                Console.WriteLine($"{group.Key}-{group.Count()}");
            }
        }
    }
}
