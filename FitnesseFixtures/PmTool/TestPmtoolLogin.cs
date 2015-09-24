using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tahzoo.SeleniumCode.PmTool;

namespace Tahzoo.FitnesseFixtures.PmTool
{
    public class TestPmtoolLogin
    {
        private Browser _browser = Browser.Firefox;

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

        public bool CanLogin()
        {
            using (var login = new LoginCheck(_browser))
            {
                return login.TestFailedLogin(Username ?? "", Password ?? "");
            }
        }
    }
}
