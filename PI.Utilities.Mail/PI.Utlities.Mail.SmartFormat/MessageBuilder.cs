using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Mail;
using System.Net.Mime;

using PI.Utilities.Mail.Interfaces;
using PI.Utilities.Mail.Models;
using System.IO;
using SmartFormat;

namespace PI.Utilities.Mail.SmartFormat
{
    /// <summary>
    /// Standard simple message builder
    /// </summary>
    public class MessageBuilder : PI.Utilities.Mail.MessageBuilder, IMessageBuilder
    {
        /// <summary>
        /// The formatter being used
        /// </summary>
        public SmartFormatter Formatter { get; set; } = Smart.CreateDefaultSmartFormat();

        /// <summary>
        /// Stadard constructor
        /// </summary>
        public MessageBuilder() { }

        /// <summary>
        /// Create the message builder with a specified smart formatter
        /// </summary>
        /// <param name="formatter"></param>
        public MessageBuilder(SmartFormatter formatter)
        {
            Formatter = formatter;
        }


        /// <summary>
        /// Formats the the model in the template
        /// </summary>
        /// <param name="template">The template to use</param>
        /// <param name="model">The object ot format</param>
        /// <returns>A formatted string</returns>
        public override string Format(string template, object model)
        {
            if (model == null) return template;
            return Formatter.Format(template, model);
        }
        
    }
}
