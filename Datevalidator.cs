using System.ComponentModel.DataAnnotations;
public class FutureDateAttribute : ValidationAttribute
{
    protected override ValidationResult IsValid(object? value, ValidationContext validationContext)
    {
        if(value is DateTime dateTime){
            if(dateTime > DateTime.Now)
            {
                return new ValidationResult (ErrorMessage ?? "La fecha no debe ser posterior al presente momento");

            }
        }
        return ValidationResult.Success!;
    }
}