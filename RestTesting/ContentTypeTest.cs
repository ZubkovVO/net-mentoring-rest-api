using RestSharp;
using Xunit;

namespace RestTesting
{
    public class ContentTypeTest
    {
        [Fact]
        public void Content_Type_Verification()
        {
            // arrange
            RestClient client = new RestClient("https://jsonplaceholder.typicode.com/users");
            RestRequest request = new RestRequest("", Method.GET);

            // act
            IRestResponse response = client.Execute(request);

            // assert
            Assert.Equal("application/json; charset=utf-8", response.ContentType);
        }
    }
}
