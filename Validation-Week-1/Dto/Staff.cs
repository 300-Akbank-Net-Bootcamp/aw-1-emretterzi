using VbApi.Validation;

namespace VbApi.Controllers;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

public class Staff
{
    [Required]
    [StringLengthRange(maxLength: 250, minLength: 10, ErrorMessage = "Invalid Name")]
    public string? Name { get; set; }

    [EmailAddress(ErrorMessage = "Email address is not valid.")]
    public string? Email { get; set; }

    [Phone(ErrorMessage = "Phone is not valid.")]
    public string? Phone { get; set; }

    [Range(minimum: 30, maximum: 400, ErrorMessage = "Hourly salary does not fall within allowed range.")]
    public decimal? HourlySalary { get; set; }
    
    
    
    
    public Staff(string? name, string? email, string? phone, decimal? hourlySalary)
    {
        Name = name;
        Email = email;
        Phone = phone;
        HourlySalary = hourlySalary;
    }
}

