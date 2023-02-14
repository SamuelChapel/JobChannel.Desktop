using Domain.Contracts;

namespace BLL.Services.JobOffers.Requests;
public record JobOfferUpdateRequest(
        int Id,
        string Title,
        string Description,
        DateTime PublicationDate,
        DateTime ModificationDate,
        string Url,
        string Salary,
        string Experience,
        string Company,
        int JobId,
        int ContractId,
        int CityId
        ) : IRequest;
