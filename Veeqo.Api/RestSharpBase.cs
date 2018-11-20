using System;
using System.Collections.Generic;
using System.Text;
using RestSharp;

namespace Veeqo.Api
{
    public class RestSharpBase
    {
        private RestClient client;
        private RestRequest request;

        public RestSharpBase(string requestEndpoint, Method method)
        {
            // client.Authenticator = new HttpBasicAuthenticator(username, password);
            client = new RestClient("http://api.veeqo.com/");
            request = new RestRequest(requestEndpoint, method);
            //request.AddParameter("name", "value"); // adds to POST or URL querystring based on Method
            //request.AddUrlSegment("id", "123"); // replaces matching token in request.Resource

            // easily add HTTP Headers
            request.AddHeader("x-api-key", "9ffe9e782cc4f2cbdcb301e4818862fb");
        }

        public IRestResponse Execute()
        {
            return client.Execute(request);
        }
    }
}
