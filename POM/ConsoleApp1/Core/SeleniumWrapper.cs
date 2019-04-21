using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace MyAccount
{
    public class SeleniumWrapper
    {
        protected static IWebDriver Driver = (IWebDriver)ScenarioContext.Current["browser"];
        
        protected void OpenPage(string page)
        {
            Driver.Navigate().GoToUrl(page);
            WaitPageIsLoaded();
            WaitAjaxIsNotComplete();
            WaitLoaderIsDisabled();
        }

        protected void RefreshPage()
        {
            Driver.Navigate().Refresh();
        }

        protected IWebElement FindElement(By locator)
        {
            return Driver.FindElement(locator);
        }

        protected internal void WaitPageIsLoaded(int waitTime = 30)
        {
            var executor = (IJavaScriptExecutor)Driver;

            for (var i = 0; i < waitTime * 4; i++)
            {
                if (((string)executor.ExecuteScript("return document.readyState")).Equals("complete"))
                    return;
                Thread.Sleep(250);
            }

            throw new Exception($"Page has not been loaded in {waitTime} seconds");
        }

        protected internal void WaitForPageUpdated()
        {
            WaitPageIsLoaded();
            WaitAjaxIsNotComplete();
            WaitLoaderIsDisabled();
        }

        protected internal void WaitAjaxIsNotComplete(int waitTime = 60)
        {
            var executor = (IJavaScriptExecutor)Driver;

            for (var i = 0; i < waitTime * 4; i++)
            {
                if ((long)executor.ExecuteScript("return jQuery.active") == 0)
                    return;
                Thread.Sleep(250);
            }

            throw new Exception($"Ajax requests did not finish within {waitTime} seconds");
        }

        protected internal void WaitLoaderIsDisabled(int waitTime = 30)
        {
            var executor = (IJavaScriptExecutor)Driver;

            for (var i = 0; i <= waitTime * 4; i++)
            {
                if (executor.ExecuteScript("return document.querySelector('div.loader')") == null)
                    return;
                Thread.Sleep(250);
            }

            throw new Exception($"Spinner did not disabled within {waitTime} seconds");
        }
        
        protected internal void WaitElementVisible(By locator, int waitTime = 25)
        {
            WaitForPageUpdated();
            try
            {
                new WebDriverWait(Driver, TimeSpan.FromSeconds(waitTime))
                    .Until(ExpectedConditions.ElementIsVisible(locator));
            }
            catch (WebDriverException)
            {
                throw new WebDriverException($"The element with locator -> {locator} <- did not visible for {waitTime} seconds");
            }
        }

        protected internal void WaitElementInvisible(By locator, int waitTime = 5)
        {
            try
            {
                new WebDriverWait(Driver, TimeSpan.FromSeconds(waitTime))
                    .Until(ExpectedConditions.InvisibilityOfElementLocated(locator));
            }
            catch (WebDriverException)
            {
                throw new WebDriverException("The element is visible for " + waitTime + " seconds");
            }
        }

        protected internal bool IsElementVisible(By locator, int waitTime = 3)
        {
            bool res;

            try
            {
                WaitElementVisible(locator, waitTime);
                res = true;
            }
            catch (WebDriverException)
            {
                res = false;
            }

            return res;
        }

        protected internal IWebElement GetParent(IWebElement element)
        {
            return element.FindElement(By.XPath("./parent::*"));
        }

        protected internal String GetErrorForField(IWebElement element)
        {
            return GetParent(element).FindElement(By.CssSelector(".help-block")).Text;
        }
    }
}
