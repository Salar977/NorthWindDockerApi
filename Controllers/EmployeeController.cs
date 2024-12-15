
using Microsoft.AspNetCore.Mvc;
using NorthWindDockerApi.Services.Interfaces;

namespace NorthWindDockerApi.Controllers;

[ApiController]
[Route("api/v1/employees")]
public class EmployeeController(IEmployeeService employeeService) : ControllerBase
{
    [HttpGet(Name = "GetEmployees")]
    public async Task<IActionResult> GetEmployees([FromQuery] int page = 1, [FromQuery] int pageSize = 10)
    {
        return Ok(await employeeService.GetEmployeesAsync(page, pageSize));
    }

    [HttpGet("{employeeId}", Name = "GetEmployeeById")]
    public async Task<IActionResult> GetEmployeeById([FromRoute] int employeeId)
    {
        var employee = await employeeService.GetEmployeesByIdAsync(employeeId);
        if(employee is null) return NotFound(employee);
        return Ok(employee);
    }
}
