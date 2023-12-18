using VbApi.Dto;

namespace VbApi.Controllers;

using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

[Route("api/[controller]")]
[ApiController]
public class EmployeeController : ControllerBase
{
    public EmployeeController()
    {
    }

    
    
    [HttpPost]
    public Employee Post([FromBody] Employee value)
    {
        
        return value;
    }
}