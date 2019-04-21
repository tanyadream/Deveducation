using OpenQA.Selenium;

namespace MyAccount
{
    public class AccountStatusPage : SeleniumWrapper
    {
		//internal static By EmailField = By.Id("email");
		//internal static By PasswordField = By.Id("password");
		//internal static By ConfirmField = By.Id("confirm");
		internal static By BtnSubmit = By.CssSelector("button.btn.btn-success");
		internal static By AccountSelect = By.CssSelector("select.form-control.account-select");
		//internal static By ErrorMessage = By.CssSelector("div.alert.alert-danger");

		/// <summary>
		/// This method open Registration page of MyAccount.
		/// </summary>
		/// <returns></returns>
		public AccountStatusPage OpenRegistrationPage()
        {
            OpenPage("https://test-myaccount.maximarkets.org/#account-status");
            return this;
        }

		/// <summary>
		/// This method click on button ShowReport.
		/// </summary>
		/// <returns></returns>
		public AccountStatusPage ClickAccountSelectButton()
		{
			FindElement(AccountSelect).Click();
			return this;
		}

		/// <summary>
		/// This method click on button ShowReport.
		/// </summary>
		/// <returns></returns>
		public AccountStatusPage ClickShowReportButton()
        {
            FindElement(BtnSubmit).Click();
            return this;
        }

        /// <summary>
        /// Get error text for email field.
        /// </summary>
        /// <returns></returns>
        //public string GetErrorForEmail()
        //{
            //return GetErrorForField(FindElement(EmailField));
        //}

        /// <summary>
        /// Get error text for password field.
        /// </summary>
        /// <returns></returns>
        //public string GetErrorForPassword()
        //{
            //return GetErrorForField(FindElement(PasswordField));
        //}

        /// <summary>
        /// Get error text for confirm field.
        /// </summary>
        /// <returns></returns>
        //public string GetErrorForConfirm()
        //{
            //return GetErrorForField(FindElement(ConfirmField));
        //}

        /// <summary>
        /// Get error for trying to register with existed in DB email
        /// </summary>
        /// <returns></returns>
        //public string GetErrorMessage()
        //{
            //return FindElement(ErrorMessage).Text;
        //}
    }
}


