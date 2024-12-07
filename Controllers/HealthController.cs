using System.Text;
using Microsoft.AspNetCore.Mvc;

namespace NorthWindDockerApi.Controllers;

[ApiController]
[Route("health")]
public class HealthController : Controller
{
    [HttpGet]
    public string Hello()
    {
        string hostName = System.Net.Dns.GetHostName();
        StringBuilder sb = new();
        foreach(var adr in System.Net.Dns.GetHostEntry(hostName).AddressList)
            sb.Append($"Address: {adr.AddressFamily} {adr.ToString()}\n");
        return $"Hello from host: {hostName}\n{sb.ToString()}\nApi is Healthy!";
    }
}