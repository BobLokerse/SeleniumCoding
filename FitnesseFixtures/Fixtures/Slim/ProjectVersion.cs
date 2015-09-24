namespace Tahzoo.FitnesseFixtures.Fixtures.Slim
{
    public class ProjectVersion
    {
        public string Current()
        {
            return GetType().Assembly.GetName().Version.ToString();
        }
    }
}
