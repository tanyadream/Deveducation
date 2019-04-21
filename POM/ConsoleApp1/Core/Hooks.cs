using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;

namespace MyAccount
{
    [Binding]
    public class Hooks
    {
        [BeforeScenario]
        public static void BeforeTestRun()
        {
            IWebDriver driver;

            driver = new ChromeDriver();
            ScenarioContext.Current["browser"] = driver;
        }

        [AfterScenario]
        public static void CloseBrowser()
        {
            IWebDriver driver = (IWebDriver)ScenarioContext.Current["browser"];
            driver.Quit();
        }
    }


	//[AfterScenario]
	//public static void CloseBrowser1()
	//{
	//	IWebDriver finder; finder = new ChromeDriver();
	//	finder.Navigate().GoToUrl("https://test-myaccount.maximarkets.org/?lang=ru#register");
	//	System.Threading.Thread.Sleep(30000);
	//	finder.FindElement(By.CssSelector("div:nth-child(1) > div > div:nth-child(3) > button")).Click();
	//	finder.FindElement(By.CssSelector("div:nth-child(1) > div > div input")).SendKeys("C:\\Users\\User\\Desktop\\Test.jpg");
	//	System.Threading.Thread.Sleep(3000);
	//	string Expected = "Test.jpg";
	//	string Actual = finder.FindElement(By.CssSelector("#content > div > div:nth-child(2) > div > div > div:nth-child(1) > div > div.col-xs-12.col-sm-6 > div.text-truncate")).Text;
	//	Assert.AreEqual(Actual, Expected);
	//}
}
