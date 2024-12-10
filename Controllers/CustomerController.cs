using Microsoft.AspNetCore.Mvc;
using NorthWindDockerApi.Services.Interfaces;

namespace NorthWindDockerApi.Controllers;

[ApiController]
[Route("api/v1/customers")]
public class CustomerController(ILogger<CustomerController> logger,
                                ICustomerService customerService) : ControllerBase
{
    
    [HttpGet(Name = "GetCustomers")]
    public async Task<IActionResult> GetCustomers([FromQuery] int page = 1, [FromQuery] int pageSize = 10)
    {
        logger.LogInformation("GetCustomers called");
        return Ok(await customerService.GetCustomersAsync(page, pageSize));
    }

    [HttpGet("{customerId}", Name = "GetCustomerById")]
    public async Task<IActionResult> GetCustomerById([FromRoute] string customerId)
    {
        var customer = await customerService.GetCustomersByIdAsync(customerId);
        if(customer is null)
        {
            logger.LogInformation($"No Customer found with id: {customerId}");
            return NotFound(customer);
        }
        logger.LogInformation($"Customer found with id {customerId}");
        return Ok(customer);
    }
}