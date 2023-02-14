using BLL.Services.Base;
using BLL.Services.JobOffers.Requests;
using BLL.Services.JobOffers.Resquests;
using JobChannel.Domain.BO;

namespace BLL.Services.JobOffers;

public interface IJobOfferService
{
    public Task<IEnumerable<JobOfferFindResponse>?> GetJobOffers(JobOfferFindRequest request);

    public Task<int> CreateJobOffer(JobOfferCreateRequest request);

    public Task<JobOffer?> GetJobOfferById(int id);

    public Task<bool> ModifyJobOffer(JobOfferUpdateRequest request);

    public Task<bool> DeleteJobOffer(int id);
}
