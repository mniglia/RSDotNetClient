using System.Net;
using System.Resources;
using System.Security.Authentication;
using RSDotNetClient.RestClient.Requests;
using RSDotNetClient.RestClient.Responses;
using RestSharp;

namespace RSDotNetClient.RestClient.Operations
{
    public class AuthenticationOperation
    {
        private const string AUTHENTICATION_BASE_URL = "https://lon.identity.api.rackspacecloud.com/v2.0"; 

        public AuthenticationResponse Authenticate(AuthenticationRequest credentials)
        {
            var client = new RestSharp.RestClient(AUTHENTICATION_BASE_URL);
            var request = new RestRequest("tokens", Method.POST);
            request.AddParameter("application/json", credentials.ToJson(), ParameterType.RequestBody);
            request.AddHeader("Accept", "application/json");
            request.AddHeader("ContentType", "application/json");

            var response = client.Execute<AuthenticationResponse>(request);

            if(response.StatusCode == HttpStatusCode.Unauthorized)
                throw new AuthenticationException("The server did not authorise the request");

            if (response.ErrorException != null)
                throw response.ErrorException;

            AuthenticationResponse data = response.Data;

            return data;
        }
    }

}
