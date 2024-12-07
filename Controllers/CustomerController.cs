using Microsoft.AspNetCore.Mvc;
using NorthWindDockerApi.Services.Interfaces;

namespace NorthWindDockerApi.Controllers;

[ApiController]
[Route("api/v1/customers")]
public class CustomerController(ILogger<CustomerController> logger,
                                ICustomerService customerService) : ControllerBase
{
    
    [HttpGet(Name = "GetCustomers")]
    public async Task<IActionResult> GetCustomers([FromQuery] int page = 1, [FromQuery] int pageSize = 25)
    {
        logger.LogInformation("GetCustomers called");
        return Ok(await customerService.GetCustomersAsync(page, pageSize));
    }
}