using RestSharp;
using System.Dynamic;
using Webdock.Factory;
using Webdock.Models.Response.Account;

namespace Webdock.Services.Account;

public class AccountService: BaseWebdockService, IAccountService
{

    public AccountService(WebdockHttpClientFactory clientFactory) : base(clientFactory)
    { }

    public async Task<AccountInformationResponse> GetAccountInformation(CancellationToken cancellationToken = default)
    {
        return await Client.GetAsync<AccountInformationResponse>(
            new RestRequest("/account/accountInformation"), cancellationToken);
    }
}