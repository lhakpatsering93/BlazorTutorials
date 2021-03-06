using EmployeeManagement.Models;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace EmployeeManagement.Web.Services
{
    public class EmployeeServices : IEmployeeServices
    {
        public HttpClient HttpClient { get; }
        public EmployeeServices(HttpClient httpClient)
        {
            HttpClient = httpClient;
        }

        public async Task<IEnumerable<Employee>> GetEmployee()
        {
            return await HttpClient.GetJsonAsync<Employee[]>("api/Employee");
        }
    }
}
