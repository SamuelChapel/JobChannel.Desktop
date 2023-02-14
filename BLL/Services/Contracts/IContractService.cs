using JobChannel.Domain.BO;

namespace BLL.Services.Contracts;
public interface IContractService
{
    Task<IEnumerable<Contract>?> GetContracts();
}