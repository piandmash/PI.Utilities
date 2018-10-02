using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Mail;
using System.Net.Mime;

using PI.Utilities.Mail.Interfaces;
using System.IO;

namespace PI.Utilities.Mail
{
    public static class MailMessageExtension
    {
        /// <summary>
        /// Extends the MailMessage object with a generator from an IMailMessage
        /// </summary>
        /// <param name="message">An IMailMessage object to generate the MailMessage from</param>
        /// <returns>A generated System.Net.Mail.MailMessage</returns>
        public static MailMessage Generate(this MailMessage msg, IMailMessage message)
        {
            MessageBuilder builder = new MessageBuilder();
            return builder.Generate(message);
        }
    }
    
}
