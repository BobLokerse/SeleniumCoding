using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Remote;
using Tahzoo.SeleniumCode.Properties;

namespace Tahzoo.SeleniumCode.Helpers
{
    public class Browser
    {
        private static IWebDriver _webDriver;

        public static IWebDriver GetFirefoxDriver()
        {
            _webDriver = new FirefoxDriver();
            return _webDriver;
        }

        public IWebDriver Driver
        {
            get { return _webDriver; }
        }

        public static RemoteWebDriver GetFirefoxServerDriver()
        {
            DesiredCapabilities capability = DesiredCapabilities.Firefox();

            RemoteWebDriver driver = new RemoteWebDriver(
                new Uri(String.Format("http://{0}/wd/hub", Settings.Default.hostnameServer)),
                capability);
            return driver;
        }

        public static RemoteWebDriver GetChromeServerDriver()
        {
            DesiredCapabilities capability = DesiredCapabilities.Chrome();

            // path to chrome driver set in the System env. Path.
            // http://stackoverflow.com/a/15215657/200824


            RemoteWebDriver driver = new RemoteWebDriver(
                new Uri(String.Format("http://{0}/wd/hub", Settings.Default.hostnameServer)),
                capability);
            return driver;
        }
    }
}
