using Microsoft.Extensions.Configuration;
using RestSharp;
using System.Diagnostics;
using TestAutomationETI.Helper;

namespace TestAutomationETI.Tests.ApiTests
{
    [TestFixture]
    public abstract class BaseApiTest
    {
        protected RestClient client; 
        protected Config configuration;

        [SetUp]
        public void Setup()
        {
            var config = new ConfigurationBuilder().SetBasePath($"{Directory.GetCurrentDirectory()}").AddJsonFile("config.json", optional: false).Build();

            configuration = config.GetRequiredSection("Config").Get<Config>();

            client = new RestClient(configuration.Url);

            TestContext.Progress.WriteLine("TestCase:" + TestContext.CurrentContext.Test.Name);
        }

        [TearDown]
        public void TearDown()
        {
            client.Dispose();
        }
    }
}
