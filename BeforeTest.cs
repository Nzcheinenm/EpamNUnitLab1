using Newtonsoft.Json;
using NUnit.Framework;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Text;

namespace NUnitTestProject1
{
    class BeforeTest
    {
        Response deserializedProduct;
        public String country;
        public String continent;
        public int deaths;
        public void Setup()
        {
            var client = new RestClient("https://disease.sh/v2/countries/Russia");
            var request = new RestRequest
            {
                Method = Method.GET
            };
            request.AddHeader("Accept", "application/json");
            deserializedProduct = JsonConvert.DeserializeObject<Response>(client.Execute(request).Content);

            country = deserializedProduct.Country;
            continent = deserializedProduct.Continent;
            deaths = int.Parse(deserializedProduct.Deaths);
        }
    }
}
