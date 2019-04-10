using System;
using TechTalk.SpecFlow;

namespace Calculate
{
    [Binding]
    public class RegistrationPageSteps : RegistrationPagePom
    {
        [Given(@"MyAccount page '(.*)' is opened")]
        public void GivenMyAccountPageIsOpened(string page)
        {
            new OpenMyAccountPage(page);
        }
        
        [When(@"I input email '(.*)' in email field")]
        public void WhenIInputEmailInField(string email)
        {
            new RegistrationPagePom().InputEmail(email);
        }
        
        [When(@"I input password '(.*)' in '(.*)' field")]
        public void WhenIInputPasswordInField(string p0, string p1)
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I click on button '(.*)'")]
        public void WhenIClickOnButton(string p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I click on '(.*)' link")]
        public void WhenIClickOnLink(string p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I input email ''(.*)'email' field")]
        public void WhenIInputEmailEmailField(string p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"MyAccount page '(.*)' is opened")]
        public void ThenMyAccountPageIsOpened(string p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"Link '(.*)' is displayed")]
        public void ThenLinkIsDisplayed(string p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"Native mail client is opened")]
        public void ThenNativeMailClientIsOpened()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"Error message '(.*)' is displayed near field '(.*)'")]
        public void ThenErrorMessageIsDisplayedNearField(string p0, string p1)
        {
            ScenarioContext.Current.Pending();
        }
    }
}
