using System;
using System.Globalization;
using System.ComponentModel.DataAnnotations;

namespace PI.Utilities.Attributes
{
    /// <summary>
    /// Culture name validation attribute, takes a string or int to check a culture for
    /// </summary>
    public class CultureNameAttribute : ValidationAttribute
    {

        
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            //validate the culture name
            if(value is string)
            {
                try
                {
                    var culture = CultureInfo.GetCultureInfo(value.ToString());
                    if (culture != null) return null;
                }
                catch
                {
                }
            }

            //validate the culture name
            if (value is int)
            {
                try
                {
                    var culture = CultureInfo.GetCultureInfo((int)value);
                    if (culture != null) return null;
                }
                catch
                {
                }
            }
            string msg = (!String.IsNullOrEmpty(ErrorMessageString)) ? ErrorMessageString : "Unknown culture name: {0}";
            return new ValidationResult(string.Format(msg, value));
        }
    }
}
