using Tahzoo.SeleniumCode.Samples;

namespace Tahzoo.FitnesseFixtures.Fixtures.Slim
{
    public class FixtureSearch4Cheese
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
