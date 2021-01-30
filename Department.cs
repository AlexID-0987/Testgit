using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq3
{
    class Department
    {
        public int Id { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public static IEnumerable<Department> GetDepart()
        {
            return new List<Department>
            {

            new Department(){ Id = 1, Country = "Ukraine", City = "Donetsk" },
            new Department(){ Id = 2, Country = "Ukraine", City = "Kyiv" },
            new Department(){ Id = 3, Country = "France", City = "Paris" },
            new Department(){ Id = 4, Country = "Russia", City = "Moscow" }
            };
        }
    }
}
