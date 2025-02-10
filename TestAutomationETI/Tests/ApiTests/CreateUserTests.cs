using CreateUserModels;
using Newtonsoft.Json;
using RestSharp;
using System.Net;

namespace TestAutomationETI.Tests.ApiTests
{
    [TestFixture]
    public class CreateUserTests : BaseApiTest
    {
        [Test]
        public async Task CreateUser()
        {
            // make Post request .
            var requestBody = new CreateUserRequestModel("Teo", "Gym");
            var createRequestUser = new RestRequest(configuration.Endpoints.CreateUser).AddBody(requestBody);

            var responseUserCreated = await client.ExecutePostAsync(createRequestUser);
            TestContext.Progress.WriteLine("Post request executed.");

            Assert.IsNotNull(responseUserCreated);
            // assert status OK 201 .
            Assert.AreEqual(HttpStatusCode.Created, responseUserCreated.StatusCode);
            TestContext.Progress.WriteLine("Post request with status OK.");

            var dataUserCreated = JsonConvert.DeserializeObject<CreateUserResponseModel>(responseUserCreated.Content);

            // assert response is not empty .
            Assert.IsNotNull(dataUserCreated);

            // assert all parameters are returned
            Assert.AreEqual(requestBody.Name, dataUserCreated.Name);
            Assert.AreEqual(requestBody.Job, dataUserCreated.Job);
            Assert.IsNotNull(dataUserCreated.CreatedAt);
            Assert.IsNotNull(dataUserCreated.Id);
            TestContext.Progress.WriteLine("Asserted post request and test passed.");
        }
    }
}