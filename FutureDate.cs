#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;
namespace DojoSurveyWithValidation.Models;
public class FutureDateAttribute : ValidationAttribute
{
    protected override ValidationResult IsValid(object value, ValidationContext validationContext)
    {
        if (((DateTime)value) < DateTime.Now)
        {
            return new ValidationResult("La fecha no puede ser menor al dia de hoy");
        }
        else
        {
            return ValidationResult.Success;
        }
    }
}
