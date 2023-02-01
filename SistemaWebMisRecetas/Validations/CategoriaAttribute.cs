using System.ComponentModel.DataAnnotations;
using System;

namespace SistemaWebMisRecetas.Validations
{
    public class CategoriaAttribute : ValidationAttribute
    {
        public CategoriaAttribute()
        {
            ErrorMessage = "Solo se permite la categoria desayuno";
        }
        public override bool IsValid(object value)
        {
            if (value.ToString() != "desayuno") return false;

            return true;
        }
    }
}
