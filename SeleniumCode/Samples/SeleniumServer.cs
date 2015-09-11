using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Remote;
using Tahzoo.SeleniumCode.Properties;

namespace Tahzoo.SeleniumCode.Samples
{
    public class SeleniumServer
    {
        public void CallSeleniumServer()
        {
            DesiredCapabilities capability = DesiredCapabilities.Firefox();

            RemoteWebDriver driver = new RemoteWebDriver( new Uri("http://localhost:4444/wd/hub"), capability);

            try
            {
                driver = new FirefoxDriver();

                var urlOfCheeseLocatorPage = String.Format("http://{0}/Pages/cheeseLocator.html", Settings.Default.hostname);
                driver.Navigate().GoToUrl(urlOfCheeseLocatorPage);

                driver.FindElement(By.Id("windowOpener")).Click();

                driver.SwitchTo().Window("windowName");
                driver.FindElement(By.Id("CheesyButton")).Click();

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
