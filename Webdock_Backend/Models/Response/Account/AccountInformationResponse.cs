namespace Webdock.Models.Response.Account;

public class AccountInformationResponse
{
    public int UserId { get; init; }
    public string CompanyName { get; init; } = null!;
    public string UserName { get; init; } = null!;
    public string UserAvatar { get; init; } = null!;
    public string UserEmail { get; init; } = null!;
    public bool IsTeamMember { get; init; }
    public string TeamLeader { get; init; } = null!;
    public string AccountBalance { get; init; } = null!;
    public int AccountBalanceRaw { get; init; }
    public string AccountBalanceRawCurrency { get; init; } = null!;
}