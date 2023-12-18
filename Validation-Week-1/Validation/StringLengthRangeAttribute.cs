namespace VbApi.Validation;


using System;
using System.ComponentModel.DataAnnotations;

 public class StringLengthRangeAttribute : ValidationAttribute
    {
        private readonly int maxLength;
        private readonly int minLength;

        public StringLengthRangeAttribute(int maxLength, int minLength)
        {
            this.maxLength = maxLength;
            this.minLength = minLength;
        }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value is string stringValue)
            {
                if (stringValue.Length < minLength || stringValue.Length > maxLength)
                {
                    return new ValidationResult($"The length of the string must be between {minLength} and {maxLength} characters.");
                }

             

                return ValidationResult.Success;
            }

            return new ValidationResult("Invalid string type.");
        }
    }

