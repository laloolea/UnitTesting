using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace UnitTestingXUnitIntro
{
    public class MailValidator
    {

        public bool IsValidEmail(string emailAddress)
        {
            if (string.IsNullOrEmpty(emailAddress))
            {
                throw new EmailNotProvidedException();
            }
            Regex regex = new Regex(@"^[\w0-9._%+-]+@[\w0-9.-]+\.[\w]{2,6}$");
            //email@email.com
            return regex.IsMatch(emailAddress);
        }

        public string IsSpam(string emailAddress)
        {
            if (string.IsNullOrEmpty(emailAddress))
            {
                throw new EmailNotProvidedException();
            }
            List<string> spammyDommains = new List<string>() { "spam.com", "dodgy.com", "donttrust.com" };
            return spammyDommains.Any(d => emailAddress.Contains(d)) ? "SPAM" : "INBOX";
        }
    }
}
