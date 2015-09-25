using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;

namespace Tahzoo.SeleniumCode.PmTool.PageObjects
{
    public class LoginPage
    {
        private readonly IWebDriver _driver;

        public LoginPage(IWebDriver driver)
        {
            _driver = driver;
            PageFactory.InitElements(_driver, this);
        }


        [FindsBy(How = How.Id, Using = "username")]
        public IWebElement LoginElement { get; set; }

        [FindsBy(How = How.Id, Using = "password")]
        public IWebElement PasswordElement { get; set; }

        [FindsBy(How = How.CssSelector, Using = "button[type=submit]")]
        public IWebElement SubmitButton { get; set; }

        [FindsBy(How = How.ClassName, Using = "errorMessage")]
        public IWebElement ErrorMessage { get; set; }

        public void SetUsername(string name)
        {
            LoginElement.SendKeys(name);
        }

        public void SetPassword(string secret)
        {
            PasswordElement.SendKeys(secret);
        }

        public OpportunitiesListPage LoginExpectingSuccess()
        {
            SubmitButton.Click();
            WebDriverWait wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(10));
            wait.Until(d => d.FindElement(By.Id("opportunitySearchText")).Displayed);

            return new OpportunitiesListPage(_driver);
        }

        public LoginPage LoginExpectingFailure()
        {
            SubmitButton.Click();
            WebDriverWait wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(10));
            // note: the errormessage is misused to show a "busy" icon while checking against the server
            wait.Until(d =>
            {
                var elt = d.FindElement(By.ClassName("errorMessage"));
                return elt.Displayed && elt.Text.Contains("Failed");
            });

            return this;
        }

        public string GetErrorMessage()
        {
            return ErrorMessage.Text;
        }

        public bool IsErrorMessageVisible()
        {
            return ErrorMessage.Displayed;
        }
    }

}
