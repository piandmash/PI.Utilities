using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Mail;
using System.Net.Mime;

using PI.Utilities.Mail.Interfaces;
using System.IO;

namespace PI.Utilities.Mail
{
    /// <summary>
    /// Standard simple message builder
    /// </summary>
    public class MessageBuilder : IMessageBuilder
    {
        /// <summary>
        /// Formats the the model in the template
        /// Should be overridden by any other MessageBuilder
        /// </summary>
        /// <param name="template">The template to use</param>
        /// <param name="model">The object ot format</param>
        /// <returns>A formatted string</returns>
        public virtual string Format(string template, object model)
        {
            return template;
        }

        /// <summary>
        /// Generates a message from the IMailMessage object
        /// </summary>
        /// <param name="message">An IMailMessage object to generate the MailMessage from</param>
        /// <param name="model">An optional model to bind to the parameters of the MailMessage</param>
        /// <returns>A generated System.Net.Mail.MailMessage</returns>
        public MailMessage Generate(IMailMessage message, object model = null)
        {
            // Create email message with default email address
            MailMessage mail = new MailMessage();

            // Set Email From
            mail.From = (!String.IsNullOrEmpty(message.FromDisplay)) ? new MailAddress(Format(message.From, model), Format(message.FromDisplay, model)) : new MailAddress(Format(message.From, model));

            // Clear and set Email To
            mail.To.Clear();
            SetAddresses(mail.To, message.To, model);

            // Check for and set Carbon Copy recipients
            if (!String.IsNullOrEmpty(message.Cc)) SetAddresses(mail.CC, message.Cc, model);

            // Check for and set Blind Carbon Copy recipients
            if (!String.IsNullOrEmpty(message.Bcc)) SetAddresses(mail.Bcc, message.Bcc, model);

            // Set Subject
            mail.Subject = Format(message.Subject, model);

            // Check if plain text version specified
            if (message.IsBodyHtml && !String.IsNullOrEmpty(Format(message.BodyPlain, model)))
            {
                // PLAIN TEXT VERSION
                AlternateView plainTextView = AlternateView.CreateAlternateViewFromString(Format(message.BodyPlain, model), null, MediaTypeNames.Text.Plain);
                mail.AlternateViews.Add(plainTextView);
            }

            // HTML TEXT VERSION                
            mail.Body = (message.IsBodyHtml) ? message.BodyHtml : message.BodyPlain;
            mail.BodyEncoding = String.IsNullOrEmpty(message.ContentEncoding) ? Encoding.UTF8 : Encoding.GetEncoding(message.ContentEncoding);
            mail.IsBodyHtml = message.IsBodyHtml;

            if (message.IsBodyHtml && !String.IsNullOrEmpty(Format(message.BodyHtml, model)))
            {
                // HTML VERSION
                AlternateView htmlView = AlternateView.CreateAlternateViewFromString(Format(message.BodyHtml, model), null, MediaTypeNames.Text.Html);
                mail.AlternateViews.Add(htmlView);
            }

            mail.HeadersEncoding = String.IsNullOrEmpty(message.HeaderEncoding) ? Encoding.UTF8 : Encoding.GetEncoding(message.HeaderEncoding);

            if (message.FilesToAttach != null)
            {
                // Attachment
                foreach (string path in message.FilesToAttach)
                {
                    // Check if file exists
                    if (File.Exists(path))
                    {
                        // Attach file to message
                        Attachment messageAttachment = new Attachment(path);
                        mail.Attachments.Add(messageAttachment);
                    }
                }
            }
            return mail;
        }

        protected virtual void SetAddresses(MailAddressCollection mac, string addresses, object model)
        {
            foreach (string add in addresses.Split(';')) mac.Add(new MailAddress(Format(add, model)));
        }
    }
}
