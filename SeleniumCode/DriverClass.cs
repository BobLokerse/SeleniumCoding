using System;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Remote;
using Tahzoo.SeleniumCode.Properties;

namespace Tahzoo.SeleniumCode
{
    public class DriverClass
    {
        public static FirefoxDriver GetFirefoxDriver()
        {
            return new FirefoxDriver();
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
