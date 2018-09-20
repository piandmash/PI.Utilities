using System;
using System.Globalization;
using System.ComponentModel.DataAnnotations;

namespace PI.Utilities.Attributes
{
    /// <summary>
    /// Culture name validation attribute, takes a string or int to check a culture for
    /// </summary>
    public class RequiredForGroupAttributeAttributeAttribute : ValidationAttribute
    {
        private int MinimumNotNullItemCount = 1;
        private string[] OtherItems;

        public RequiredForGroupAttributeAttributeAttribute(string[] otherItems, int minimumNotNullItemCount = 1)
        {
            OtherItems = otherItems;
            MinimumNotNullItemCount = minimumNotNullItemCount;
        }

        
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            int notNullCount = 0;
            //valid if this item is not null
            bool mainItemNotNull = value != null;
            if (value is string) mainItemNotNull = String.IsNullOrEmpty(value.ToString());
            if (mainItemNotNull) notNullCount += 1;
            //check the other items
            foreach (string s in OtherItems)
            {
                bool otherItemNotNull = false;
                var otherProperty = validationContext.ObjectType.GetProperty(s);
                if (otherProperty == null) return new ValidationResult(String.Format("Unknown property: {0}.", s));
                var otherPropertyValue = otherProperty.GetValue(validationContext.ObjectInstance, null);
                if (otherPropertyValue != null)
                {
                    otherItemNotNull = true;
                    if (otherPropertyValue is string) otherItemNotNull = String.IsNullOrEmpty(otherPropertyValue.ToString());
                }
                if (otherItemNotNull) notNullCount += 1;
            }
            if (notNullCount >= MinimumNotNullItemCount) return null;
            string msg = (!String.IsNullOrEmpty(ErrorMessageString)) ? ErrorMessageString : "You require at lease {0} items not to be null, only {1} found.";
            return new ValidationResult(string.Format(msg, MinimumNotNullItemCount, notNullCount));
        }
    }
}
