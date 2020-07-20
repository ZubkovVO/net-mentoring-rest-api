using RestSharp;
using System.Net;
using Xunit;

namespace RestTesting
{
    public class ResponseCodeTest
    {
        [Fact]
        public void Response_code_200()
        {
            RestClient client = new RestClient("https://jsonplaceholder.typicode.com");
            RestRequest request = new RestRequest("users", DataFormat.Json);

            // act
            var response = client.Get(request);

            // assert
            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }
    }
}
