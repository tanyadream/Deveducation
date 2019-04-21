using System;
using ConsoleApp1.MyAccountPOM;
using Should;
using TechTalk.SpecFlow;

namespace MyAccount
{
    [Binding]
    public class LoginPageSteps : LoginPage
    {
        [Given(@"Login page is opened")]
        public void GivenLoginPageIsOpened()
        {
            OpenLoginPage();
        }

		//[Given(@"Registration is completed with email '(.*)'")]
		//public void GivenRegistrationIsCompletedWithEmail(string email)
		//{
		//    if (email == "unique email")
		//    {
		//        email = $"{DateTime.Now:ddMMMyyyyHHmmssf}@test.test";
		//    }

		//    ScenarioContext.Current["existedEmail"] = email;

		//    OpenRegistrationPage().FillEmailField(email).FillPasswordField("123qwe")
		//        .FillConfirmField("123qwe").ClickSubmitButton();
		//}

		//[When(@"I try to login with exist email")]
		//public void WhenITryToLoginWithExistEmail()
		//{
		//var existedEmail = (string)ScenarioContext.Current["existedEmail"];

		//RefreshPage();
		//OpenLoginPage().FillEmailField(existedEmail).FillPasswordField("123qwe")
		//.FillConfirmField("123qwe").ClickSubmitButton();
		//}

		[When(@"I input 'se11@se.se' in email field")]
		public void WhenIInputInEmailField(string email)
		{
			if (email == "se11@se.se")
			{
				email = $"se11@se.se";
			}

			FillEmailField(email);
		}
        
        [When(@"I input '123qwe' in password field")]
        public void WhenIInputInPasswordField(string password)
        {
            FillPasswordField(password);
        }
        
        //[When(@"I input '(.*)' in confirm field")]
        //public void WhenIInputInConfirmField(string confirm)
        //{
            //FillConfirmField(confirm);
        //}

        [When(@"I click on Login button")]
        public void WhenIClickOnLoginButton()
        {
            ClickLoginButton();
        }

		//[When(@"I add cookies file")]
		//public void WhenIClickOnSubmitButton()
		//{
			//ClickSubmitButton();
		//}

		//WebDriver driver = new FirefoxDriver();
		//login
		//Set<Cookie> cookies = driver.manage().getCookies();
		//saveToFile(new File("/path/to/file), cookies);
		//driver.quit();

		[Then(@"Visibility of SignOut link is 'true'")]
        public void ThenSignOutLinkIsDisplayed(bool visibility)
        {
            var res = new MyAccountPage().IsSignOutLinkVisible();
            res.ShouldEqual(visibility);
        }
		 
        //[Then(@"Error message for confirm field is equals '(.*)'")]
        //public void ThenErrorMessageForConfirmFieldIsEquals(string errorMessage)
        //{
            //GetErrorForConfirm().ShouldEqual(errorMessage);
        //}

        [Then(@"Error message for email field is equals '(.*)'")]
        public void ThenErrorMessageForEmailFieldIsEquals(string errorMessage)
        {
            GetErrorForEmail().ShouldEqual(errorMessage);
        }

        [Then(@"Error message is equals '(.*)'")]
        public void ThenErrorMessageIsEquals(string errorMessage)
        {
            GetErrorMessage().ShouldEqual(errorMessage);
        }
    }
}
