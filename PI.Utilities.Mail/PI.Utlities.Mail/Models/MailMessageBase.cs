using System;
using System.Collections.Generic;
using System.Text;
using PI.Utilities.Mail.Interfaces;
using System.Net.Mail;

namespace PI.Utilities.Mail.Models
{
    /// <summary>
    /// A base class that implements the IMailMessage interface
    /// </summary>
    public class MailMessageBase : IMailMessage
    {

        /// <summary>
        /// Gets/sets the email To
        /// </summary>
        public string To { get; set; }

        /// <summary>
        /// Gets/sets the email Subject
        /// </summary>
        public string Subject { get; set; }

        /// <summary>
        /// Gets/sets the email body html value
        /// </summary>
        public string BodyHtml { get; set; }

        /// <summary>
        /// Gets/sets the email body plain text value
        /// </summary>
        public string BodyPlain { get; set; }

        /// <summary>
        /// Gets/sets the email from
        /// </summary>
        public string From { get; set; }

        /// <summary>
        /// Gets/sets the email from display text
        /// </summary>
        public string FromDisplay { get; set; }

        /// <summary>
        /// Gets/sets the email Cc addresses
        /// </summary>
        public string Cc { get; set; }

        /// <markdown>
        /// ###List<string> FilesToAttach
        /// </markdown>
        /// <summary>
        /// Gets/sets a list of fiels to attach
        /// </summary>
        public List<string> FilesToAttach { get; set; } = new List<string>();

        /// <summary>
        /// Gets/sets if the body is HTML
        /// </summary>
        public bool IsBodyHtml { get; set; }

        /// <summary>
        /// Gets/sets if the additional headers for the email
        /// </summary>
        public string AdditionalHeaders { get; set; }

        /// <summary>
        /// Gets/sets the email Bcc addresses
        /// </summary>
        public string Bcc { get; set; }

        /// <summary>
        /// Gets/sets if the content encoding type
        /// </summary>
        public string ContentEncoding { get; set; } = "utf-8";

        /// <summary>
        /// Gets/sets if the email header encoding type
        /// </summary>
        public string HeaderEncoding { get; set; } = "utf-8";

        /// <summary>
        /// Gets/sets if the email Priority
        /// </summary>
        public MailPriority Priority { get; set; } = MailPriority.Normal;

        /// <summary>
        /// Gets/sets if the email reply to value
        /// </summary>
        public string ReplyTo { get; set; }

        
    }
}
