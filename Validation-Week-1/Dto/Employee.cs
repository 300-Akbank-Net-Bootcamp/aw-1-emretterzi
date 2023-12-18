using VbApi.Controllers;
using VbApi.Validation;

namespace VbApi.Dto;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

public class Employee 
{
    
    [Required]
    [StringLengthRange(maxLength: 250, minLength: 10, ErrorMessage = "Invalid Name")] //custon validation 
    public string Name { get; set; }

    [Required]
    [MaxAge(maxAge: 50, ErrorMessage = "Age must be less than 50.")]   //custon validation 
    public DateTime DateOfBirth { get; set; }
    
    [EmailAddress(ErrorMessage = "Email address is not valid.")]
    public string Email { get; set; }

    [Phone(ErrorMessage = "Phone is not valid.")]
    public string Phone { get; set; }

    [Range(minimum: 50, maximum: 400, ErrorMessage = "Hourly salary does not fall within allowed range.")]
    [MinLegalSalaryRequired(minJuniorSalary: 50, minSeniorSalary: 200)]
    public double HourlySalary { get; set; }
    
    
    
    public Employee(string name, DateTime dateOfBirth, string email, string phone, double hourlySalary)
    {
        Name = name;
        DateOfBirth = dateOfBirth;
        Email = email;
        Phone = phone;
        HourlySalary = hourlySalary;
    }

    
}
