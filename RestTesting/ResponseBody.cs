﻿using Newtonsoft.Json;
using RestSharp;
using RestSharp.Serialization.Json;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace RestTesting
{
    public class ResponseBody
    {
        [Fact]
        public void ContentTypeTest()
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
