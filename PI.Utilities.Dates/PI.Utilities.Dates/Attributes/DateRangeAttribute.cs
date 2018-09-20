using System;
using System.Globalization;
using System.ComponentModel.DataAnnotations;
using PI.Utilities.Dates.Models;
namespace PI.Utilities.Dates.Attributes
{
    /// <summary>
    /// DateRange validation attribute
    /// </summary>
    public class DateRangeAttribute : ValidationAttribute
    {
        
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            //validate the date range
            if(value is string)
            {
                try
                {
                    if (DateRange.IsValid(value.ToString())) return null;
                }
                catch
                {
                }
            }
            string msg = (!String.IsNullOrEmpty(ErrorMessageString)) ? ErrorMessageString : "Unknown date range: {0}";
            return new ValidationResult(string.Format(msg, value));
        }
    }
}
