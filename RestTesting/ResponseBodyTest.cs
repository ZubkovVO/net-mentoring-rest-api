using Newtonsoft.Json;
using RestSharp;
using System.Collections.Generic;
using Xunit;

namespace RestTesting
{
    public class ResponseBodyTest
    {
        [Fact]
        public void Response_Body_Contains_10Users()
        {
            // arrange
            RestClient client = new RestClient("https://jsonplaceholder.typicode.com");
            RestRequest request = new RestRequest("users", DataFormat.Json);

            // act
            var response = client.Get(request);

            List<Root> root = JsonConvert.DeserializeObject<List<Root>>(response.Content);

            // assert
           Assert.Equal(10, root.Count);
        }
    }
}
