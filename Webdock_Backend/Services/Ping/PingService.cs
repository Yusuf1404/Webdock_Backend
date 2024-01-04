using RestSharp;
using System.Dynamic;
using Webdock.Factory;
using Webdock.Models.Response;
using Webdock.Models.Response;

namespace Webdock.Services;

public class PingService: BaseWebdockService, IPingService
{
    public PingService(WebdockHttpClientFactory clientFactory) : base(clientFactory)
    { }

    public async Task<PingResponse> GetPing(CancellationToken cancellationToken = default)
    {
        return await Client.GetAsync<PingResponse>(new RestRequest("/ping"), cancellationToken);
    }
    public async Task<PingResponse> GetPingAsync(CancellationToken cancellationToken = default)
    {
        var ping = await Client.GetAsync<PingResponse>(new RestRequest("/ping"),cancellationToken);
        return ping;
    }
}