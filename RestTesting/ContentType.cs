using RestSharp;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace RestTesting
{
    public class ContentType
    {
        [Fact]
        public void ContentTypeTest()
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
