using RestSharp;
using RestSharp.Authenticators;
using Webdock.Extensions;
using Webdock.Models.Configuration;
using Webdock.Services;

namespace Webdock.Factory;

public class WebdockHttpClientFactory
{
    public readonly WebdockConnectionConfiguration _connectionConfiguration;
    private RestClient? _client;
    private const string BASE_URL = "https://api.webdock.io/v1";

    public WebdockHttpClientFactory(WebdockConnectionConfiguration connectionConfiguration)
    {
        _connectionConfiguration = connectionConfiguration;
    }

    public RestClient GetRestClient()
    {
        _client??=CreateClient();

        return _client;
    }

    private RestClient CreateClient()
    {
        var client = new RestClient(BASE_URL);

        client.UseJsonNetSerializer();
        client.Authenticator = new JwtAuthenticator(_connectionConfiguration.AuthorizationToken);

        return client;
    }
}