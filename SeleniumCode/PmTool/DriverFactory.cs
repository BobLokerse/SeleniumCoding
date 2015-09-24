using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace Tahzoo.SeleniumCode.PmTool
{
    public static class DriverFactory
    {
        public static IWebDriver GetDriver(Browser browser)
        {
            switch (browser)
            {
                case Browser.Chrome:
                    return new OpenQA.Selenium.Chrome.ChromeDriver();

                case Browser.Edge:
                    return new OpenQA.Selenium.Edge.EdgeDriver();

                case Browser.Firefox:
                    return new OpenQA.Selenium.Firefox.FirefoxDriver();

                case Browser.InternetExplorer:
                    return new OpenQA.Selenium.IE.InternetExplorerDriver();

                case Browser.Opera:
                    return new OpenQA.Selenium.Opera.OperaDriver();
            }

            throw new ArgumentOutOfRangeException("browser", "Unsupported browser");
        }
    }
}
