using Webdock.Models.Response.Account;

namespace Webdock.Services.Account;

public interface IAccountService
{
    public Task<AccountInformationResponse> GetAccountInformation(CancellationToken cancellationToken = default);
}