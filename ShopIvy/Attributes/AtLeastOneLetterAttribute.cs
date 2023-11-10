using System.ComponentModel.DataAnnotations;

public class AtLeastOneLetterAttribute : ValidationAttribute
{
    protected override ValidationResult IsValid(object value, ValidationContext validationContext)
    {
        if (value == null || string.IsNullOrWhiteSpace(value.ToString()))
        {
            return new ValidationResult(ErrorMessage);
        }

        if (ContainsAtLeastOneLetter(value.ToString()))
        {
            return ValidationResult.Success;
        }

        return new ValidationResult(ErrorMessage);
    }

    private bool ContainsAtLeastOneLetter(string input)
    {
        foreach (char c in input)
        {
            if (char.IsLetter(c))
            {
                return true;
            }
        }
        return false;
    }
}
