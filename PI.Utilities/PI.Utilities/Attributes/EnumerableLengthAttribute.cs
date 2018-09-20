using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PI.Utilities.Attributes
{
    /// <summary>
    /// Attibute for any IEnumerable item that needs to have a min or max length set
    /// </summary>
    public class EnumerableLengthAttribute : StringLengthAttribute
    {
        /// <summary>
        /// Initializes a new instance of the EnumerableLengthAttribute class by using a specified minimum and maximum lengths.
        /// </summary>
        /// <param name="minimumLength">The minimum length of the enumeration</param>
        /// <param name="maximumLength">Optional maximum length of the enumeration, if set to 0 then there is no maximum</param>
        public EnumerableLengthAttribute(int minimumLength, int maximumLength = 0) : base(maximumLength)
        {
            MinimumLength = minimumLength;
        }

        /// <summary>
        /// Initializes a new instance of the EnumerableLengthAttribute class by using a specified maximum length.
        /// </summary>
        /// <param name="maximumLength">Maximum length of the enumeration, if set to 0 then there is no maximum</param>
        public EnumerableLengthAttribute(int maximumLength) : base(maximumLength)
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
            var count = 0;
            //cast
            if (value is System.Collections.IEnumerable enumerable)
            {
                foreach (var i in enumerable) count += 1;
            }
            if (count >= MinimumLength && (MaximumLength == 0 || count <= MaximumLength)) return null;
            string msg = (!String.IsNullOrEmpty(ErrorMessageString)) ? ErrorMessageString : "The collection should contain at least {0} and no more than {1} items.";
            return new ValidationResult(string.Format(msg, MinimumLength, MaximumLength));
        }
    }
}
