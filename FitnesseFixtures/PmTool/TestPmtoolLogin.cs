using System;
using Tahzoo.SeleniumCode.PmTool;

namespace Tahzoo.FitnesseFixtures.PmTool
{
    public class TestPmtoolLogin
    {
        private Browser _browser = Browser.Firefox;

        internal const string TestUsername = "pmtooltester";
        internal const string TestPassword = "AT9t6V9:";

        public void SetBrowser(string browserName)
        {
            if (!Enum.TryParse(browserName, true, out _browser))
            {
                if (String.Equals(browserName, "ie", StringComparison.OrdinalIgnoreCase))
                {
                    _browser = Browser.InternetExplorer;
                }
            }
        }

        public string Username { get; set; }

        public string Password { get; set; }

        public bool CannotLogin()
        {
            using (var login = new LoginCheck(_browser))
            {
                return login.TestFailedLogin(Username ?? "", Password ?? "");
            }
        }

        public bool CanLoginWithFixedCredentials()
        {
            using (var login = new LoginCheck(_browser))
            {
                return login.TestCorrectLogin(TestUsername, TestPassword);
            }
        }
    }
}
