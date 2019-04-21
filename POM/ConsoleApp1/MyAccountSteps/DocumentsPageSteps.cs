using System;
using ConsoleApp1.MyAccountPOM;
using Should;
using TechTalk.SpecFlow;

namespace MyAccount
{
    [Binding]
    public class DocumentPageSteps : DocumentsPage
    {
        [Given(@"Documents page is opened")]
        public void GivenRegistrationPageIsOpened()
        {
            OpenDocumentsPage();
        }

        [When(@"I click on Upload button")]
        public void WhenIClickOnUploadButton()
        {
			ClickButtonUpload();
        }

		/*[Then(@"The title is not null")]
		public void ThenSignOutLinkIsDisplayed(bool visibility)
		{
			ChooseDocument();
		}
		*/
    }
}
