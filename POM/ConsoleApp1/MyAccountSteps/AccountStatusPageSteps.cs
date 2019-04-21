using System;
using ConsoleApp1.MyAccountPOM;
using Should;
using TechTalk.SpecFlow;

namespace MyAccount
{
    [Binding]
    public class AccountStatusPageSteps : AccountStatusPage
    {
        [Given(@"Account status page is opened")]
        public void GivenAccountStatusPageIsOpened()
        {
            OpenRegistrationPage();
        }

		//[Given(@"Registration is completed with email '(.*)'")]
		//public void GivenRegistrationIsCompletedWithEmail(string email)
		//{
		//if (email == "unique email")
		//{
		//email = $"{DateTime.Now:ddMMMyyyyHHmmssf}@test.test";
		//}

		//ScenarioContext.Current["existedEmail"] = email;

		//OpenRegistrationPage().FillEmailField(email).FillPasswordField("123qwe")
		//.FillConfirmField("123qwe").ClickSubmitButton();
		//}


		[When(@"Choose to data")]
		public void WhenChooseToDataField(string EndDateField)
		{
			FillToDataField(EndDateField);
		}

		[When(@"Choose from data")]
		public void WhenChooseFronData(string StartDateField)
		{
			if (StartDateField == "01/04/2019")
			{
				StartDateField = $"01/04/2019";
			}

			FillStartDate(StartDateField);
		}

		[When(@"I choose MetaTraider4")]
        public void WhenIChooseMetaTraider4()

        {
			ClickAccountSelectButton();
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

		[Then(@"Visibility of SignOut link is '(.*)'")]
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

        //[Then(@"Error message for email field is equals '(.*)'")]
        //public void ThenErrorMessageForEmailFieldIsEquals(string errorMessage)
        //{
            //GetErrorForEmail().ShouldEqual(errorMessage);
        //}

        //[Then(@"Error message is equals '(.*)'")]
        //public void ThenErrorMessageIsEquals(string errorMessage)
        //{
            //GetErrorMessage().ShouldEqual(errorMessage);
        //}
    }
}
