using System.Net.Http;
using System.Threading.Tasks;
using ApprovalTests;
using Microsoft.AspNetCore.Mvc.Testing;
using Xunit;

namespace Api.Tests
{
    public class PurchaseControllerTests
    {
        private readonly HttpClient _client;

        public PurchaseControllerTests()
        {
            var factory = new WebApplicationFactory<Api.Startup>();
            _client = factory.CreateClient();
        }
        
        [Fact]
        public async Task Purchase_ShouldReturnCorrectJson_WhenCalled()
        {
            // Arrange

            // Act
            var response = await _client.PostAsync("purchase/1", null);

            // Assert
            response.EnsureSuccessStatusCode();
            var content = await response.Content.ReadAsStringAsync();
            Approvals.VerifyJson(content);
        }
    }
}