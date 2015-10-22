using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Helpers
{
    public static class ObjectValidator
    {
        public static ValidationResult Validate(object obj)
        {
            ValidationContext context = new ValidationContext(obj, null, null);
            IList<ValidationResult> errors = new List<ValidationResult>();

            if (!Validator.TryValidateObject(obj, context, errors, true))
            {
                foreach (ValidationResult result in errors)
                {
                    return result;
                }
            }

            return null;
        }
    }
}
