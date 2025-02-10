using Microsoft.Extensions.Configuration;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using TestAutomationETI.Helper;

namespace TestAutomationETI.Tests.UiTests
{
    [TestFixture]
    public abstract class BaseUiTest
    {
        protected IWebDriver driver;
        protected WebDriverWait wait;
        protected Config configuration;

        [SetUp]
        public void Setup()
        {
            var config = new ConfigurationBuilder().SetBasePath($"{Directory.GetCurrentDirectory()}").AddJsonFile("config.json", optional: false).Build();
            configuration = config.GetRequiredSection("Config").Get<Config>();

            // create ChromeDriver object .
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            wait = new WebDriverWait(driver, new TimeSpan(0, 0, 30));

            TestContext.Progress.WriteLine("TestCase:" + TestContext.CurrentContext.Test.Name);
        }

        [TearDown]
        public void TearDown()
        {
            driver.Quit();
            driver.Dispose();
        }
    }
}
