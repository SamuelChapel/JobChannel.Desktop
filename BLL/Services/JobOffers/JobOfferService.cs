using BLL.Http;
using BLL.Services.JobOffers.Requests;
using BLL.Services.JobOffers.Resquests;
using JobChannel.Domain.BO;

namespace BLL.Services.JobOffers;

internal class JobOfferService : IJobOfferService
{
    private readonly IJobChannelHttpClient _client;

    public JobOfferService(IJobChannelHttpClient client)
    {
        _client = client;
    }

    public async Task<IEnumerable<JobOfferFindResponse>?> GetJobOffers(JobOfferFindRequest request)
    {
        return await _client.PostRequest<IEnumerable<JobOfferFindResponse>, JobOfferFindRequest>("api/JobOffer/search", request);
    }

    public async Task<JobOffer?> GetJobOfferById(int id)
    {
        return await _client.GetRequest<JobOffer>($"api/JobOffer/{id}");
    }

    public async Task<int> CreateJobOffer(JobOfferCreateRequest request)
    {
        return await _client.PostRequest<int, JobOfferCreateRequest>("api/JobOffer", request);
    }

    public async Task<bool> ModifyJobOffer(JobOfferUpdateRequest request)
    {
        return await _client.PutRequest($"api/JobOffer/{request.Id}", request);
    }

    public async Task<bool> DeleteJobOffer(int id)
    {
        return await _client.DeleteRequest($"api/JobOffer/{id}");
    }
}
