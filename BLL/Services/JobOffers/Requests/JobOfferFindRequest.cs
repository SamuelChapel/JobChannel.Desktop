using Domain.Contracts;

namespace BLL.Services.JobOffers.Resquests;

public record JobOfferFindRequest(
        int? Count = 30,
        int? Page = 1,
        IEnumerable<int>? Id_Region = null,
        IEnumerable<int>? Id_Department = null,
        IEnumerable<int>? Id_City = null,
        IEnumerable<int>? Id_Job = null,
        IEnumerable<int>? Id_Contract = null,
        DateTime? StartDate = null,
        DateTime? EndDate = null,
        string? SearchString = null
    ) : IRequest;

public enum JobOfferFindRequestOrderBy
{
    Title, 
    Description,
    PublicationDate,
    ModificationDate,
    Url,
    Salary,
    Experience,
    Company,
    Job,
    Contract, 
    City
}