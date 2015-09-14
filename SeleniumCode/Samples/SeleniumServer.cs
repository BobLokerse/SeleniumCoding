using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using Tahzoo.SeleniumCode.Properties;

namespace Tahzoo.SeleniumCode.Samples
{
    public class SeleniumServer
    {
        public void CallSeleniumServerWithFireFox()
        {
            DesiredCapabilities capability = DesiredCapabilities.Firefox();

            RemoteWebDriver driver = new RemoteWebDriver(new Uri("http://localhost:4444/wd/hub"), capability);

            RunCheeseLocatorExample(driver);
        }

        public void CallSeleniumServerWithChrome()
        {
            DesiredCapabilities capability = DesiredCapabilities.Chrome();

            // path to chrome driver set in the System env. Path.
            // http://stackoverflow.com/a/15215657/200824
            

            RemoteWebDriver driver = new RemoteWebDriver( new Uri("http://localhost:4444/wd/hub"), capability);

            RunCheeseLocatorExample(driver);
        }

        private static void RunCheeseLocatorExample(RemoteWebDriver driver)
        {
            try
            {
                var urlOfCheeseLocatorPage = String.Format("http://{0}/Pages/cheeseLocator.html", Settings.Default.hostname);
                driver.Navigate().GoToUrl(urlOfCheeseLocatorPage);

                driver.FindElement(By.Id("windowOpener")).Click();

                driver.SwitchTo().Window("windowName");
                driver.FindElement(By.Id("CheesyButton")).Click();

                WaitTillAlertIsPresent(driver);

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

        private static void WaitTillAlertIsPresent(RemoteWebDriver driver)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.Until(ExpectedConditions.AlertIsPresent());
        }
    }
}
