namespace VbApi.Controllers;

using Microsoft.AspNetCore.Mvc;
[Route("api/[controller]")]
[ApiController]

public class StaffController : ControllerBase
{
    public StaffController()
    {
    }

    [HttpPost]
    public Staff Post([FromBody] Staff value)
    {
        return value;
    }
    
}