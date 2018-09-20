using System;
using System.Collections.Generic;
using System.Text;

namespace PI.Utilities.Models
{

    /// <summary>
    /// A class to manage model errors
    /// </summary>
    public class ModelError
    {
        /// <summary>
        /// Gets/sets if the first letter of the field should be set to lower case - defaults to true
        /// </summary>
        private bool FieldFirstLetterLower { get; set; } = true;

        private string _Field = "";
        /// <summary>
        /// Get/set the field with the error
        /// </summary>
        public string Field
        {
            get
            {
                if (FieldFirstLetterLower && !String.IsNullOrEmpty(_Field))
                {
                    string firstLetter = _Field.Substring(0, 1);
                    string rest = (_Field.Length > 1) ? _Field.Substring(1) : "";
                    _Field = firstLetter.ToLower() + rest;
                }
                return _Field;
            }
            set
            {
                _Field = value;
            }
        }
        
        /// <summary>
        /// Get/set the error message
        /// </summary>
        public string Message { get; set; }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="field">The field name</param>
        /// <param name="message">The error message</param>
        public ModelError(string field, string message, bool fieldFirstLetterLower = true)
        {
            FieldFirstLetterLower = true;
            Field = field;
            Message = message;
        }

        /// <summary>
        /// Overrides the ToString method to return the Message
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return Message;
        }

    }
}
