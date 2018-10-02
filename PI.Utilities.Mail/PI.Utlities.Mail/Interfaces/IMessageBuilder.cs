using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Mail;

namespace PI.Utilities.Mail.Interfaces
{
    /// <summary>
    /// An interface for a a message builder to use
    /// </summary>
    public interface IMessageBuilder
    {
        /// <summary>
        /// Generates a message from the IMailMessage object
        /// </summary>
        /// <param name="message">An IMailMessage object to generate the MailMessage from</param>
        /// <param name="model">An optional model to bind to the parameters of the MailMessage</param>
        /// <returns>A generated System.Net.Mail.MailMessage</returns> 
        MailMessage Generate(IMailMessage message, object model = null);
    }
}
