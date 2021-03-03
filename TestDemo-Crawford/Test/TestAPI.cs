using Newtonsoft.Json;
using NUnit.Framework;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using TestDemo_Crawford.Core;
using TestDemo_Crawford.Utilities;
using TestDemo_Crawford.Testdata;

namespace TestDemo_Crawford.Test
{
    class TestAPI
    {
        [Test]
        public static void APITest1()
        {
            try
            {   
                var response = GenericHelpers.CallAPI(APItestResource.client,APItestResource.request1);
                APIObjects.MainObject apiObject = JsonConvert.DeserializeObject<APIObjects.MainObject>(response.Content);
                Assert.AreEqual(HttpStatusCode.OK, response.StatusCode);
                Assert.AreEqual(TestdataValidation.firstName1, apiObject.data.first_name);
                Assert.AreEqual(TestdataValidation.lastName1, apiObject.data.last_name);
                
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }


        }
        [Test]
        public static void APITest2()
        {
            try
            {
                var response = GenericHelpers.CallAPI(APItestResource.client, APItestResource.request2);
                APIObjects.MainObject apiObject = JsonConvert.DeserializeObject<APIObjects.MainObject>(response.Content);
                Assert.AreEqual(HttpStatusCode.OK, response.StatusCode);
                Assert.AreEqual(TestdataValidation.firstName2, apiObject.data.first_name);
                Assert.AreEqual(TestdataValidation.lastName2, apiObject.data.last_name);
                
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }


        }
        [Test]
        public static void APITest3()
        {
            try
            {
                var response = GenericHelpers.CallAPI(APItestResource.client, APItestResource.request3);
                APIObjects.MainObject apiObject = JsonConvert.DeserializeObject<APIObjects.MainObject>(response.Content);
                Assert.AreEqual(HttpStatusCode.NotFound, response.StatusCode);
                
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }


        }

    }
}
