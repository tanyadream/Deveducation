using MyAccount;
using OpenQA.Selenium;

namespace ConsoleApp1.MyAccountPOM
{
    public class MyAccountPage : SeleniumWrapper
    {
        internal static By SignOutLink = By.CssSelector("a[href='#signOut']");
        
        public bool IsSignOutLinkVisible()
        {
            return IsElementVisible(SignOutLink);
        }
    }
}
