using Microsoft.EntityFrameworkCore;
using NorthWindDockerApi.Entities;
using NorthWindDockerApi.Services.Interfaces;

namespace NorthWindDockerApi.Services;

public class CustomerService(NorthwindDbContext dbContext) : ICustomerService
{
    public async Task<IEnumerable<Customer>> GetCustomersAsync(int page, int pageSize)
    {
        return await dbContext.Customers
            .OrderBy(c => c.Country)
            .Skip((page - 1) * pageSize)
            .Take(pageSize)
            .AsNoTracking()
            .ToListAsync();
    }

    public async Task<Customer> GetCustomersByIdAsync(string customerId)
    {
        var customer = await dbContext.Customers.Where(c => c.CustomerID.Contains(customerId)).FirstOrDefaultAsync();
        if(customer is null) return null!;
        return customer;
    }
}