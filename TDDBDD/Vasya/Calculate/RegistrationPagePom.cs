using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculate
{
    public class RegistrationPagePom
    {
        WebDriver driver = new ChromeDriver();

        //Locators:
        var emailField = driver.GetElementById('email');

        //Methods:
        public string GetUniqueEmail()
        {
            return Math.Random() + "qwe@gmail.com"
        }

        public void InputEmail(string emailField)
        {
            emailField.SendKeys(emailField);
        }

        public string GetEmailFromemailField()
        {
            return emailField.GetKeys();
        }
    }
}
