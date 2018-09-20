using System;
using System.ComponentModel.DataAnnotations;

namespace PI.Utilities.Attributes
{
    /// <summary>
    /// ObjectId validation attribute
    /// </summary>
    public class ObjectIdAttribute : ValidationAttribute
    {
        
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            //validate the object id
            if(value is string)
            {
                try
                {
                    if(value != null && value.ToString().Length == 24) return null;
                }
                catch
                {
                }
            }
            string msg = (!String.IsNullOrEmpty(ErrorMessageString)) ? ErrorMessageString : "The id '{0}' should be 24 characters";
            return new ValidationResult(string.Format(msg, value));
        }
    }
}
