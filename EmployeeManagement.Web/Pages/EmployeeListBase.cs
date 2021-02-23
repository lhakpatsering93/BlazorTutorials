using EmployeeManagement.Models;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Web.Pages
{
    public class EmployeeListBase : ComponentBase
    {
        public IEnumerable<Employee> Employees { get; set; }
        protected override async Task OnInitializedAsync()
        {
            await Task.Run(LoadEmployees);
           
        }
        private void LoadEmployees()
        {
            System.Threading.Thread.Sleep(3000);
            Employee e1 = new Employee
            {
                EmployeeId = 1,
                FirstName = "John",
                LastName = "Hast",
                Email = "johnHast@gmail.com",
                DateOfBirth = new DateTime(2020, 10, 05),
                Gender = Gender.Male,
                DepartmentId =1,
                PhotoPath = "images/john.jpg"
            };
            Employee e2 = new Employee
            {
                EmployeeId = 1,
                FirstName = "John",
                LastName = "Hast",
                Email = "johnHast@gmail.com",
                DateOfBirth = new DateTime(2020, 10, 05),
                Gender = Gender.Male,
                DepartmentId = 1,
                PhotoPath = "images/john.jpg"
            };
            Employee e3 = new Employee
            {
                EmployeeId = 1,
                FirstName = "John",
                LastName = "Hast",
                Email = "johnHast@gmail.com",
                DateOfBirth = new DateTime(2020, 10, 05),
                Gender = Gender.Male,
                DepartmentId = 1,
                PhotoPath = "images/john.jpg"
            };
            Employee e4 = new Employee
            {
                EmployeeId = 1,
                FirstName = "John",
                LastName = "Hast",
                Email = "johnHast@gmail.com",
                DateOfBirth = new DateTime(2020, 10, 05),
                Gender = Gender.Male,
                DepartmentId = 1,
                PhotoPath = "images/john.jpg"
            };

            Employees = new List<Employee> { e1, e2, e3 , e4 }; 

        }
    }
}
