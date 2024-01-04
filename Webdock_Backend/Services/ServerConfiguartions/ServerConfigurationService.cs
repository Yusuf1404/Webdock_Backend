using RestSharp;
using System.Dynamic;
using System.Reflection;
using Webdock.Factory;
using Webdock.Models.Response.Account;
using Webdock.Services;
using Webdock_Backend.Models.Configuration;
using Webdock_Backend.Models.RequestModel.Server;
using Webdock_Backend.Services.ServerConfiguartions;

namespace Webdock_Backend.Services.ServerConfiguartion
{
    public class ServerConfigurationService: BaseWebdockService, IServerConfigurationService
    {
        public ServerConfigurationService(WebdockHttpClientFactory clientFactory) : base(clientFactory)
        { }

        public async Task<ServerLocation> GetServerLocation(CancellationToken cancellationToken = default)
        {
            return await Client.GetAsync<ServerLocation>(
             new RestRequest("/locations"), cancellationToken);
        }

        public async Task<ServerProfile> GetServerProfile(ServerProfile locationid,CancellationToken cancellationToken = default)
        {
            return await Client.GetAsync<ServerProfile>(
             new RestRequest($"/profiles?locationId={locationid}"),cancellationToken);
        }

        public async Task<ServerImages> GetServerImage(string locationid, CancellationToken cancellationToken = default)
        {
            return await Client.GetAsync<ServerImages>(
             new RestRequest("/images"), cancellationToken);
        }


    }
}
