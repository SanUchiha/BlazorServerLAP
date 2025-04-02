using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace BlazorServerLAP.Attributes;

public partial class PasswordValidationAttribute : ValidationAttribute
{
    private const string LengthPattern = @"^.{8,50}$";
    private const string UpperCasePattern = @"[A-Z]";
    private const string LowerCasePattern = @"[a-z]";
    private const string DigitPattern = @"\d";
    private const string SpecialCharPattern = @"[@$!%*?&]";

    protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
    {
        if (value is not string password)
            return new ValidationResult("La contraseña es obligatoria.");

        // Validación de longitud
        if (!Regex.IsMatch(password, LengthPattern))
            return new ValidationResult("La contraseña debe tener entre 8 y 50 caracteres.");

        // Validación de letra mayúscula
        if (!Regex.IsMatch(password, UpperCasePattern))
            return new ValidationResult("Debe incluir al menos una letra mayúscula.");

        // Validación de letra minúscula
        if (!Regex.IsMatch(password, LowerCasePattern))
            return new ValidationResult("Debe incluir al menos una letra minúscula.");

        // Validación de número
        if (!Regex.IsMatch(password, DigitPattern))
            return new ValidationResult("Debe incluir al menos un número.");

        // Validación de carácter especial
        if (!Regex.IsMatch(password, SpecialCharPattern))
            return new ValidationResult("Debe incluir al menos un carácter especial (@$!%*?&).");

        return ValidationResult.Success;
    }
}