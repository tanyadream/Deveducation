using OpenQA.Selenium;

namespace MyAccount
{
    public class DocumentsPage : SeleniumWrapper
    {
        //internal static By EmailField = By.Id("email");
        //internal static By PasswordField = By.Id("password");
        //internal static By ConfirmField = By.Id("confirm");
        internal static By BtnSubmit = By.CssSelector("button.btn.btn-success");
        //internal static By ErrorMessage = By.CssSelector("div.alert.alert-danger");

        /// <summary>
        /// This method open Documents page of MyAccount.
        /// </summary>
        /// <returns></returns>
        public DocumentsPage OpenDocumentsPage()
        {
            OpenPage("https://test-myaccount.maximarkets.org/?lang=en#documents");
            return this;
        }

		/// <summary>
		/// This method upload document in Documents page.
		/// </summary>
		/// <returns></returns>
		/*public DocumentsPage ChooseDocument()
		{
			IWebDriver finder;
			//finder = new ChromeDriver();
			finder.Navigate().GoToUrl("https://test-myaccount.maximarkets.org/?lang=ru#register");
			System.Threading.Thread.Sleep(30000);
			finder.FindElement(By.CssSelector("div:nth-child(1) > div > div:nth-child(3) > button")).Click();
			finder.FindElement(By.CssSelector("div:nth-child(1) > div > div input")).SendKeys("C:\\Users\\User\\Desktop\\Test.jpg");
			System.Threading.Thread.Sleep(3000);
			string Expected = "Test.jpg";
			string Actual = finder.FindElement(By.CssSelector("#content > div > div:nth-child(2) > div > div > div:nth-child(1) > div > div.col-xs-12.col-sm-6 > div.text-truncate")).Text;
			Assert.AreEqual(Actual, Expected);
		}
		*/
		/// <summary>
		/// This method fill text in Email field.
		/// </summary>
		/// <param name="email"></param>
		/// <returns></returns>
		//public RegistrationPage FillEmailField(string email)
		//{
		//FindElement(EmailField).SendKeys(email);
		//return this;
		//}

		/// <summary>
		/// This method fill text in Password field.
		/// </summary>
		/// <param name="password"></param>
		/// <returns></returns>
		//public RegistrationPage FillPasswordField(string password)
		//{
		//FindElement(PasswordField).SendKeys(password);
		//return this;
		//}

		/// <summary>
		/// This method fill text in Confirm password field.
		/// </summary>
		/// <param name="confirm"></param>
		/// <returns></returns>
		//public RegistrationPage FillConfirmField(string confirm)
		//{
		//FindElement(ConfirmField).SendKeys(confirm);
		//return this;
		//}

		/// <summary>
		/// This method click on button Submit.
		/// </summary>
		/// <returns></returns>
		public DocumentsPage ClickButtonUpload()
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


