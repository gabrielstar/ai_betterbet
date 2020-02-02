using ai_betterbet;
using Microsoft.AspNetCore.Mvc.Testing;
using System.Net.Http;
using System.Threading.Tasks;
using Xunit;

namespace ai_betterbet_tests
{
    /// <summary>
    /// For integration tests we provide context of our running application
    /// via Fixture
    /// </summary>
    public class MessagesControllerIntegrationTests : IClassFixture<WebApplicationFactory<Startup>>
    {
        private readonly HttpClient client;

        public MessagesControllerIntegrationTests(WebApplicationFactory<Startup> factory)
        {
            this.client = factory.CreateClient();
        }

        [Fact]
        public async Task CanGetMessagesAndMessageContainsGitHub()
        {
            // The endpoint or route of the controller action.
            var httpResponse = await client.GetAsync("/api/messages/info");

            // Must be successful.
            httpResponse.EnsureSuccessStatusCode();

            // Deserialize and examine results.
            var stringResponse = await httpResponse.Content.ReadAsStringAsync();
            Assert.Contains("github", stringResponse);
        }
    }
}