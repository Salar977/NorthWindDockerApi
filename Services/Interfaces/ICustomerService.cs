using NorthWindDockerApi.Entities;

namespace NorthWindDockerApi.Services.Interfaces;

public interface ICustomerService
{
    Task<IEnumerable<Customer>> GetCustomersAsync(int page, int pageSize);
}