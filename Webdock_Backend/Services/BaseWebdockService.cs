using RestSharp;
using Webdock.Factory;

namespace Webdock.Services;

public abstract class BaseWebdockService
{
    protected readonly RestClient Client;

    protected BaseWebdockService(WebdockHttpClientFactory clientFactory)
    {
        Client = clientFactory.GetRestClient();

    }
}