using NorthWindDockerApi.Entities;

namespace NorthWindDockerApi.Services.Interfaces;

public interface IEmployeeService
{
    Task<IEnumerable<Employee>> GetEmployeesAsync(int page, int pageSize);
    Task<Employee> GetEmployeesByIdAsync(int employeeId);
}
