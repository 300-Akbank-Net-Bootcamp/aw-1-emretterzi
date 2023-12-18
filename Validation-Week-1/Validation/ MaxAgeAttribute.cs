namespace VbApi.Validation;

using System;
using System.ComponentModel.DataAnnotations;

public class MaxAgeAttribute : ValidationAttribute
{
    private readonly int maxAge;

    public MaxAgeAttribute(int maxAge)
    {
        this.maxAge = maxAge;
    }

    protected override ValidationResult? IsValid(object value, ValidationContext validationContext)
    {
        if (value is DateTime dateOfBirth)
        {
            int age = CalculateAge(dateOfBirth);

            if (age > maxAge)
            {
                return new ValidationResult($"Age must be less than {maxAge}.");
            }

           

            return ValidationResult.Success;
        }

        return new ValidationResult("Invalid date of birth type.");
    }

    private int CalculateAge(DateTime birthDate)
    {
        DateTime currentDate = DateTime.Now;
        int age = currentDate.Year - birthDate.Year;

        if (birthDate.Date > currentDate.AddYears(-age)) age--;

        return age;
    }
}