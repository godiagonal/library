// The library
// Samuel Johansson och Lukas Peterson
// Version 1.0 2015-10-26

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Helpers
{
    /// <summary>
    /// Static model object validation methods
    /// </summary>
    public static class ObjectValidator
    {
        /// <summary>
        /// Validate a model object before saving
        /// </summary>
        /// <param name="obj">Object to validate</param>
        /// <returns>Error result, null means ok</returns>
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
