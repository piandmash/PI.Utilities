using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Mail;

namespace PI.Utilities.Mail.Interfaces
{
    public interface IMailMessage
    {

        /// <summary>
        /// Gets/sets the email To
        /// </summary>
        string To { get; set; }

        /// <summary>
        /// Gets/sets the email Subject
        /// </summary>
        string Subject { get; set; }

        /// <summary>
        /// Gets/sets the email body html value
        /// </summary>
        string BodyHtml { get; set; }

        /// <summary>
        /// Gets/sets the email body plain text value
        /// </summary>
        string BodyPlain { get; set; }

        /// <summary>
        /// Gets/sets the email from
        /// </summary>
        string From { get; set; }

        /// <summary>
        /// Gets/sets the email from display text
        /// </summary>
        string FromDisplay { get; set; }

        /// <summary>
        /// Gets/sets the email Cc addresses
        /// </summary>
        string Cc { get; set; }

        /// <markdown>
        /// ###List<string> FilesToAttach
        /// </markdown>
        /// <summary>
        /// Gets/sets a list of fiels to attach
        /// </summary>
        List<string> FilesToAttach { get; set; }

        /// <summary>
        /// Gets/sets if the body is HTML
        /// </summary>
        bool IsBodyHtml { get; set; }

        /// <summary>
        /// Gets/sets if the additional headers for the email
        /// </summary>
        string AdditionalHeaders { get; set; }

        /// <summary>
        /// Gets/sets the email Bcc addresses
        /// </summary>
        string Bcc { get; set; }

        /// <summary>
        /// Gets/sets if the content encoding type
        /// </summary>
        string ContentEncoding { get; set; }

        /// <summary>
        /// Gets/sets if the email header encoding type
        /// </summary>
        string HeaderEncoding { get; set; }

        /// <summary>
        /// Gets/sets if the email Priority
        /// </summary>
        MailPriority Priority { get; set; }

        /// <summary>
        /// Gets/sets if the email reply to value
        /// </summary>
        string ReplyTo { get; set; }
    }
}
