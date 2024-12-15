using Microsoft.EntityFrameworkCore;
using NorthWindDockerApi.Entities;
using NorthWindDockerApi.Services.Interfaces;

namespace NorthWindDockerApi.Services;

public class EmployeeService(NorthwindDbContext dbContext, ILogger<EmployeeService> logger) : IEmployeeService
{
    public async Task<IEnumerable<Employee>> GetEmployeesAsync(int page, int pageSize)
    {
        logger.LogInformation("Getting employees");
        return await dbContext.Employees
            .OrderBy(e => e.EmployeeID)
            .Skip((page - 1) * pageSize)
            .Take(pageSize)
            .AsNoTracking()
            .ToListAsync();
    }

    public async Task<Employee> GetEmployeesByIdAsync(int employeeId)
    {
        var employee = await dbContext.Employees.Where(e => e.EmployeeID == employeeId).FirstOrDefaultAsync();
        if(employee is null)
        {
            logger.LogError("Employee not found");
            return null!;
        } 
        
        logger.LogInformation("Getting employee by id {employeeId}", employeeId);
        return employee;
    }
}