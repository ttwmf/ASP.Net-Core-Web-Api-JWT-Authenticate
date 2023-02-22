﻿using JWTAuth.WebApi.Models;

namespace JWTAuth.WebApi.Repositories.Contracts
{
    public interface IEmployeeRepository
    {
        public List<Employee> GetEmployeeDetails();
        public Employee GetEmployeeDetails(int id);
        public void AddEmployee(Employee employee);
        public void UpdateEmployee(Employee employee);
        public Employee DeleteEmployee(int id);
        public bool CheckEmployee(int id);
    }
}
