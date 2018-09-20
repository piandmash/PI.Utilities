using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using PI.Utilities.Attributes;

namespace PI.Utilities.Dates.Attributes
{
    /// <summary>
    /// DateRange validation attribute
    /// </summary>
    public class EnumerableDateRangeAttribute : EnumerableLengthAttribute
    {


        /// <summary>
        /// Initializes a new instance of the EnumerableLengthAttribute class by using a specified minimum and maximum lengths.
        /// </summary>
        /// <param name="minimumLength">The minimum length of the enumeration</param>
        /// <param name="maximumLength">Optional maximum length of the enumeration, if set to 0 then there is no maximum</param>
        public EnumerableDateRangeAttribute(int minimumLength, int maximumLength = 0) : base(maximumLength)
        {
            MinimumLength = minimumLength;
        }

        /// <summary>
        /// Initializes a new instance of the EnumerableLengthAttribute class by using a specified maximum length.
        /// </summary>
        /// <param name="maximumLength">Maximum length of the enumeration, if set to 0 then there is no maximum</param>
        public EnumerableDateRangeAttribute(int maximumLength) : base(maximumLength)
        {

        }

        /// <summary>
        ///  Determines whether a specified object is valid.
        /// </summary>
        /// <param name="value">The object to validate</param>
        /// <param name="validationContext">The validation context</param>
        /// <returns></returns>
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            int count = 0;
            int errors = 0;
            List<string> errorValues = new List<string>();
            //cast
            if (value is System.Collections.IEnumerable enumerable)
            {
                foreach (var i in enumerable)
                {
                    if (!DateRange.IsValid(i.ToString()))
                    {
                        errorValues.Add(i.ToString());
                        errors += 1;
                    }
                    count += 1;
                }
            }
            if (errors == 0 && count >= MinimumLength && (MaximumLength == 0 || count <= MaximumLength)) return null;
            string msg = (!String.IsNullOrEmpty(ErrorMessageString)) ? ErrorMessageString : "The collection should contain at least {0} and no more than {1} items, there were {2} values sent that were not a Date Range.";
            return new ValidationResult(string.Format(msg, MinimumLength, MaximumLength, errors));
        }
    }
}
