using BLL.Http;
using JobChannel.Domain.BO;

namespace BLL.Services.Jobs;
public class JobService : IJobService
{
    private readonly IJobChannelHttpClient _client;

    public JobService(IJobChannelHttpClient client)
    {
        _client = client;
    }

    public async Task<IEnumerable<Job>?> GetJobs()
    {
        return await _client.GetRequest<IEnumerable<Job>>("api/Job");
    }
}
