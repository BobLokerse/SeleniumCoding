using System;
using System.Diagnostics;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using Tahzoo.SeleniumCode.Helpers;
using Tahzoo.SeleniumCode.Properties;

namespace Tahzoo.SeleniumCode.Samples
{
    public class SeleniumServer
    {
        public void CallSeleniumServerWithFireFox()
        {
            var driver = Browser.GetFirefoxServerDriver();

            RunCheeseLocatorExample(driver);
        }

        public void CallSeleniumServerWithChrome()
        {
            var driver = Browser.GetChromeServerDriver();

            RunCheeseLocatorExample(driver);
        }

        public static void RunCheeseLocatorExample(RemoteWebDriver driver)
        {
            try
            {
                var urlOfCheeseLocatorPage = String.Format("http://{0}/Pages/cheeseLocator.html", Settings.Default.hostname);
                driver.Navigate().GoToUrl(urlOfCheeseLocatorPage);

                driver.FindElement(By.Id("windowOpener")).Click();

                driver.SwitchTo().Window("windowName");
                driver.FindElement(By.Id("CheesyButton")).Click();

                WaitHelper.WaitTillAlertIsPresent(driver);

                driver.SwitchTo().Alert().Accept();
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("An exception occured: " + ex.Message);
                Debug.WriteLine("An exception occured: " + ex.Message);
            }
            finally
            {
                driver.Quit();
            }
        }
    }
}
