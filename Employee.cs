﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq3
{
    class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public int DepId { get; set; }
        public static IEnumerable<Employee> GetEmployee()
        {
            return new List<Employee>
            {
            new Employee()
            {
            Id = 1, FirstName = "Tamara", LastName = "Ivanova", Age = 22, DepId = 2
            },
            new Employee()
            {
            Id = 2, FirstName = "Nikita", LastName = "Larin", Age = 33, DepId = 1
            },
            new Employee()
            {
            Id = 3, FirstName = "Alica", LastName = "Ivanova", Age = 43, DepId = 3
            },
            new Employee()
            {
            Id = 4, FirstName = "Lida", LastName = "Marusyk", Age = 22, DepId = 2
            },
            new Employee()
            {
            Id = 5, FirstName = "Lida", LastName = "Voron", Age = 36, DepId = 4
            },
            new Employee()
            {
            Id = 6, FirstName = "Ivan", LastName = "Kalyta", Age = 22, DepId = 2
            },
            new Employee()
            {
            Id = 7, FirstName = "Nikita", LastName = "Krotov", Age = 27, DepId = 4
            }

            };
        
        }
    }
} 
    

