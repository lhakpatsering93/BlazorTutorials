using EmployeeManagement.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Api.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            //seed department table
            modelBuilder.Entity<Department>().HasData(new Department { DepartmentId = 1, DepartmentName = "IT" });
            modelBuilder.Entity<Department>().HasData(new Department { DepartmentId = 2, DepartmentName = "HR" });
            modelBuilder.Entity<Department>().HasData(new Department { DepartmentId = 3, DepartmentName = "PayRoll" });
            modelBuilder.Entity<Department>().HasData(new Department { DepartmentId = 4, DepartmentName = "Admin" });
            //seed employee table
            modelBuilder.Entity<Employee>().HasData(new Employee
            {
                EmployeeId = 1,
                FirstName = "John",
                LastName = "Hast",
                Email = "johnHast@gmail.com",
                DateOfBirth = new DateTime(2020, 10, 05),
                Gender = Gender.Male,
                DepartmentId = 1,
                PhotoPath = "images/john.jpg"
            });
            modelBuilder.Entity<Employee>().HasData(new Employee
            {
                EmployeeId = 2,
                FirstName = "doe",
                LastName = "Hast",
                Email = "doeHast@gmail.com",
                DateOfBirth = new DateTime(2020, 10, 05),
                Gender = Gender.Female,
                DepartmentId = 2,
                PhotoPath = "images/john.jpg"
            });
            modelBuilder.Entity<Employee>().HasData(new Employee
            {
                EmployeeId = 3,
                FirstName = "mathew",
                LastName = "Hast",
                Email = "jmathewHast@gmail.com",
                DateOfBirth = new DateTime(2020, 10, 05),
                Gender = Gender.Male,
                DepartmentId = 3,
                PhotoPath = "images/john.jpg"
            });
            modelBuilder.Entity<Employee>().HasData(new Employee
            {
                EmployeeId = 4,
                FirstName = "sarah",
                LastName = "Hast",
                Email = "sarahHast@gmail.com",
                DateOfBirth = new DateTime(2020, 10, 05),
                Gender = Gender.Female,
                DepartmentId = 4,
                PhotoPath = "images/john.jpg"
            });
        }
    }
}
