using System;
using Tahzoo.SeleniumCode.PmTool;
using Tahzoo.SeleniumCode.PmTool.PageObjects;

namespace Tahzoo.FitnesseFixtures.PmTool
{
    public class TestOpportunityPage
    {
        private Browser _browser = Browser.Firefox;

        private OpportunityPageTester _tester;
        private OpportunitiesBasicPage _opportunityPage;

        public void SetBrowser(string browserName)
        {
            if (!Enum.TryParse(browserName, true, out _browser))
            {
                if (String.Equals(browserName, "ie", StringComparison.OrdinalIgnoreCase))
                {
                    _browser = Browser.InternetExplorer;
                }
            }

            _tester = new OpportunityPageTester(_browser);
        }

        public bool LoginWithFixedCredentials()
        {
            _opportunityPage = _tester.Login(TestPmtoolLogin.TestUsername, TestPmtoolLogin.TestPassword);
            return _opportunityPage != null;
        }

        public int CountHitsForSearch(string search)
        {
            _opportunityPage.EnterSearch(search);
            return _opportunityPage.GetOpportunityCount();
        }

        public bool GoToDetailsPage(string name)
        {
            var pg = _opportunityPage.GoToDetailsPage(name);
            return pg.GetTitle().Contains("detail");
        }

        public void CloseBrowser()
        {
            _opportunityPage.Close();
        }
    }
}
