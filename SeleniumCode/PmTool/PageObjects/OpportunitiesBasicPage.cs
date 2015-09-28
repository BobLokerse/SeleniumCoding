using System;
using System.Collections.Generic;
using System.Linq;
using OpenQA.Selenium;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;

namespace Tahzoo.SeleniumCode.PmTool.PageObjects
{
    /// <summary>
    /// This page object represents the left side of the opportunity pages
    /// </summary>
    public class OpportunitiesBasicPage
    {
        protected readonly IWebDriver _driver;

        public OpportunitiesBasicPage(IWebDriver driver)
        {
            _driver = driver;
            Support.Waiter.WaitForElement(_driver, By.Id("opportunitySearchText"), 5);

            PageFactory.InitElements(_driver, this);
        }

        [FindsBy(How = How.Id, Using = "opportunitySearchText")]
        protected IWebElement SearchBox { get; set; }

        // TODO put nice id around this list
        [FindsBy(How = How.CssSelector, Using = "div.col-lg-3 .list-group.ng-scope a")]
        protected IList<IWebElement> Opportunities { get; set; }

        public void EnterSearch(string searchText)
        {
            SearchBox.Clear();
            SearchBox.SendKeys(searchText);
        }

        public int GetOpportunityCount()
        {
            try
            {
                return Opportunities.Count;
            }
            catch (Exception)
            {
                if (_driver is EdgeDriver)
                {
                    // it seems the Edge driver can't handle empty selections?
                    return 0;
                }

                throw;
            }
        }

        public OpportunitiesDetailsPage GoToDetailsPage(string opportunityName)
        {
            EnterSearch(opportunityName);

            var link = Opportunities.First();
            link.Click();
            return new OpportunitiesDetailsPage(_driver);
        }

        public void Close()
        {
            _driver.Close();
            _driver.Dispose();
        }

    }
}
