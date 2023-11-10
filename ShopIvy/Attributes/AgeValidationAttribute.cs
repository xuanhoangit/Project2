using System;
using System.ComponentModel.DataAnnotations;

[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field, AllowMultiple = false)]
public class AgeValidationAttribute : ValidationAttribute
{
    private int _minimumAge;

    public AgeValidationAttribute(int minimumAge)
    {
        _minimumAge = minimumAge;
    }

    protected override ValidationResult IsValid(object value, ValidationContext validationContext)
    {
        if (value != null)
        {
            DateTime birthdate;
            if (DateTime.TryParse(value.ToString(), out birthdate))
            {
                int age = DateTime.Now.Year - birthdate.Year;

                if (birthdate > DateTime.Now.AddYears(-age))
                {
                    age--;
                }

                if (age < _minimumAge)
                {
                    return new ValidationResult($"You must be {_minimumAge} years old to use the service.");
                }
            }
            else
            {
                return new ValidationResult("This Date of birth field is not valid.");
            }
        }

        return ValidationResult.Success;
    }
}