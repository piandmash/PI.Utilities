using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Net.Mail;
using PI.Utilities.Mail.SmartFormat;
using PI.Utilities.Mail.Models;

namespace PI.Utlities.Mail.SmartFormatTests
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
                Subject = "Test {Name}",
                BodyPlain = "This is a test"
            };
            dynamic test = new { Name = "Pete" };
            //create the message builder
            MessageBuilder messageBuilder = new MessageBuilder();
            //generate the mail message
            MailMessage smtpMessage = messageBuilder.Generate(mailMessage, test);

            //check results
            Assert.AreEqual("Test Pete", smtpMessage.Subject);
        }
    }
}
