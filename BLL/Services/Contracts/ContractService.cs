using BLL.Http;
using JobChannel.Domain.BO;

namespace BLL.Services.Contracts;
public class ContractService : IContractService
{
    private readonly IJobChannelHttpClient _client;

    public ContractService(IJobChannelHttpClient client)
    {
        _client = client;
    }

    public async Task<IEnumerable<Contract>?> GetContracts()
    {
        return await _client.GetRequest<IEnumerable<Contract>>("api/Contract");
    }
}
