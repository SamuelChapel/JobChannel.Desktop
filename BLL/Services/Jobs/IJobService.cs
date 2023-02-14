using JobChannel.Domain.BO;

namespace BLL.Services.Jobs;
public interface IJobService
{
    Task<IEnumerable<Job>?> GetJobs();
}