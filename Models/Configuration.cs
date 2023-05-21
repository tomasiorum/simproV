using OpenQA.Selenium;
namespace SimproV
{
    public class Configuration
    {
        public static IWebDriver driver { get; set; }
    }
    class TestSite
    {
        public static string Url { get; set; }

    }
    class WaitTime
    {
        public static int Ms { get; set; }
    }
    class ProjectBase
    {
        public static string Path { get; set; }
    }
}
