using Tahzoo.SeleniumCode.Samples;

namespace Tahzoo.FitnesseFixtures
{
    public class FixtureSearch4Cheese : fit.ColumnFixture
    {
        private string _resultTitle = null;

        public void SearchForCheese()
        {
            _resultTitle = GoogleSuggest.Search4Cheese();
        }

        public string Title()
        {
            return _resultTitle;
        }
    }
}
