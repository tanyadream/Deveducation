using OpenQA.Selenium;

namespace MyAccount
{
    public class RegistrationPage : SeleniumWrapper
    {
        internal static By EmailField = By.Id("email");
        internal static By PasswordField = By.Id("password");
        internal static By ConfirmField = By.Id("confirm");
        internal static By BtnSubmit = By.CssSelector("button.btn.btn-success");
        internal static By ErrorMessage = By.CssSelector("div.alert.alert-danger");

        /// <summary>
        /// This method open Registration page of MyAccount.
        /// </summary>
        /// <returns></returns>
        public RegistrationPage OpenRegistrationPage()
        {
            OpenPage("https://test-my.umarkets.com/?lang=en#register");
            return this;
        }

        /// <summary>
        /// This method fill text in Email field.
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        public RegistrationPage FillEmailField(string email)
        {
            FindElement(EmailField).SendKeys(email);
            return this;
        }

        /// <summary>
        /// This method fill text in Password field.
        /// </summary>
        /// <param name="password"></param>
        /// <returns></returns>
        public RegistrationPage FillPasswordField(string password)
        {
            FindElement(PasswordField).SendKeys(password);
            return this;
        }

        /// <summary>
        /// This method fill text in Confirm password field.
        /// </summary>
        /// <param name="confirm"></param>
        /// <returns></returns>
        public RegistrationPage FillConfirmField(string confirm)
        {
            FindElement(ConfirmField).SendKeys(confirm);
            return this;
        }

        /// <summary>
        /// This method click on button Submit.
        /// </summary>
        /// <returns></returns>
        public RegistrationPage ClickSubmitButton()
        {
            FindElement(BtnSubmit).Click();
            return this;
        }

        /// <summary>
        /// Get error text for email field.
        /// </summary>
        /// <returns></returns>
        public string GetErrorForEmail()
        {
            return GetErrorForField(FindElement(EmailField));
        }

        /// <summary>
        /// Get error text for password field.
        /// </summary>
        /// <returns></returns>
        public string GetErrorForPassword()
        {
            return GetErrorForField(FindElement(PasswordField));
        }

        /// <summary>
        /// Get error text for confirm field.
        /// </summary>
        /// <returns></returns>
        public string GetErrorForConfirm()
        {
            return GetErrorForField(FindElement(ConfirmField));
        }

        /// <summary>
        /// Get error for trying to register with existed in DB email
        /// </summary>
        /// <returns></returns>
        public string GetErrorMessage()
        {
            return FindElement(ErrorMessage).Text;
        }
    }
}


