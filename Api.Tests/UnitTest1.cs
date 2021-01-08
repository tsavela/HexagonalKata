using System.Net.Http;
using Microsoft.AspNetCore.Mvc.Testing;
using Xunit;

namespace Api.Tests
{
    public class UnitTest1
    {
        private HttpClient _client;

        public UnitTest1()
        {
            var factory = new WebApplicationFactory<Api.Startup>();
            _client = factory.CreateClient();
        }
        
        [Fact]
        public void Test1()
        {

        }
    }
}