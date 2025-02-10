using GetUserListModels;
using Newtonsoft.Json;
using RestSharp;
using System.Net;

namespace TestAutomationETI.Tests.ApiTests
{
    [TestFixture]
    public class GetUsersTests : BaseApiTest
    {
        [Test]
        public async Task ListUser()
        {
            // make Get request .
            var getRequestUserList = new RestRequest($"{configuration.Endpoints.CreateUser}?page=2");
            var responseUserList = await client.ExecuteGetAsync(getRequestUserList);
            TestContext.Progress.WriteLine("Get request executed.");

            // assert status OK 200 .
            Assert.AreEqual(HttpStatusCode.OK, responseUserList.StatusCode);
            TestContext.Progress.WriteLine("Get request with status OK.");

            // prepare Json body .
            var dataUserList = JsonConvert.DeserializeObject<GetUserListResponse>(responseUserList.Content);

            Assert.IsNotNull(dataUserList);
            // assert one user exists .
            Assert.IsTrue(dataUserList.Data.Any());
            Assert.IsNotNull(dataUserList.Data.First().Id);
            TestContext.Progress.WriteLine("Asserted get request and test passed.");
        }
    }
}