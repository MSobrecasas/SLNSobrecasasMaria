using System.ComponentModel.DataAnnotations;

namespace SistemaWebMisRecetas.Validations
{
    public class CheckAgeAttribute : ValidationAttribute
    {
        public CheckAgeAttribute()
        {
            ErrorMessage = "Solo se permite edades mayores a 18";
        }
        public override bool IsValid(object value)
        {
            int edad = (int) value;

            if (edad < 18) return false;

            return true;
        }
    }
}
