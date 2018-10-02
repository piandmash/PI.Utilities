using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Net.Mail;
using PI.Utilities.Mail;
using PI.Utilities.Mail.Models;
using PI.Utilities.Mail.Interfaces;

namespace PI.Utilities.MailTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //create base model
            MailMessageBase mailMessage = new MailMessageBase()
            {
                From = "pete@piandmash.com",
                To = "pete@piandmash.com",
                Subject = "Test",
                BodyPlain = "This is a test"
            };
            //create the message builder
            MessageBuilder messageBuilder = new MessageBuilder();
            //generate the mail message
            MailMessage smtpMessage = messageBuilder.Generate(mailMessage);
            
            //check results
            Assert.AreEqual(mailMessage.Subject, smtpMessage.Subject);
        }

    }
}
