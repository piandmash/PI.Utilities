using System;
using System.Globalization;
using System.ComponentModel.DataAnnotations;

namespace PI.Utilities.Attributes
{
    /// <summary>
    /// TimeZoneId validation attribute
    /// </summary>
    public class TimeZoneIdAttribute : ValidationAttribute
    {
        
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            //validate the timezone
            if(value is string)
            {
                try
                {
                    var timeZone = TimeZoneInfo.FindSystemTimeZoneById(value.ToString());
                    return null;
                }
                catch
                {
                }
            }
            string msg = (!String.IsNullOrEmpty(ErrorMessageString)) ? ErrorMessageString : "Unknown time zone id: {0}";
            return new ValidationResult(string.Format(msg, value));
        }
    }
}
