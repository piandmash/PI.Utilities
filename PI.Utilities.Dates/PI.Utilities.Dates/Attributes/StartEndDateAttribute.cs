using System;
using System.Globalization;
using System.ComponentModel.DataAnnotations;
using PI.Utilities.Dates.Interfaces;
namespace PI.Utilities.Dates.Attributes
{
    /// <summary>
    /// TimeZoneId validation attribute
    /// </summary>
    public class StartEndDateAttribute : ValidationAttribute
    {
        private DateTime MinDate;
        private DateTime MaxDate;
        private bool _IsStartDate;

        public StartEndDateAttribute(bool isStartDate = true, string minimumDate = "2000-01-01", string maximumDate = "2200-01-01")
        {
            _IsStartDate = isStartDate;
            MinDate = DateTime.Parse(minimumDate);
            MaxDate = DateTime.Parse(maximumDate);
        }
        
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            //validate the dates
            if (validationContext.ObjectInstance is IStartEndDatePair)
            {
                var item = validationContext.ObjectInstance as IStartEndDatePair;

                DateTime dateToCheck = (_IsStartDate) ? item.StartDate : item.EndDate;
                if (dateToCheck >= MinDate && dateToCheck <= MaxDate
                    && item.StartDate <= item.EndDate) return null;
            }
            string msg = (!String.IsNullOrEmpty(ErrorMessageString)) ? ErrorMessageString : "The start date needs to be before the end date and be in the range of '{0}' and '{1}'.";
            return new ValidationResult(string.Format(CultureInfo.CurrentCulture, msg, MinDate, MaxDate));
        }
    }
}
