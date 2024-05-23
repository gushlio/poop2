﻿using DataAccessLayer;
using Domain.Entity;

namespace Domain.Manager
{
    public class EmployeeManager
    {
        private EmployeeDatabase employeeDatabase = new EmployeeDatabase();

        public void AddEmployee(Employee employee)
        {
            employeeDatabase.AddEmployee(employee.FirstName, employee.LastName, employee.EmailAddress, employee.Password, employee.Salary, employee.HireDate, employee.JobTitle);
        }
        public List<Employee> GetAllEmployees()
        {
            List<IDictionary<string, object>> employeesData = employeeDatabase.GetAllEmployees();
            List<Employee> employees = new List<Employee>();

            foreach (var employeeData in employeesData)
            {
                Employee employee = new Employee(
                    Convert.ToInt32(employeeData["Id"]),
                    employeeData["FirstName"].ToString(),
                    employeeData["LastName"].ToString(),
                    employeeData["EmailAddress"].ToString(),
                    employeeData["Password"].ToString(),
                    Convert.ToDouble(employeeData["Salary"]),
                    Convert.ToDateTime(employeeData["HireDate"]),
                    employeeData["JobTitle"].ToString()
                );
                employees.Add(employee);
            }

            return employees;
        }
        public void DeleteEmployee(Employee employee)
        {
            employeeDatabase.DeleteEmployee(employee.Id);
        }

        public void UpdateEmployee(Employee employee)
        {
            employeeDatabase.UpdateEmployee(employee.Id, employee.FirstName, employee.LastName, employee.EmailAddress, employee.Password, employee.Salary, employee.HireDate, employee.JobTitle);
        }

        public bool ValidateLogin(string email, string password)
        {
            return employeeDatabase.ValidateLogin(email, password);
        }

        public string GetJobTitle(string email)
        {
            return employeeDatabase.GetJobTitle(email);
        }

    }
}