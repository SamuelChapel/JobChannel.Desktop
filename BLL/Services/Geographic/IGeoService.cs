using BLL.Services.Geographic.Requests;
using JobChannel.Domain.BO;

namespace BLL.Services.Geographic;
public interface IGeoService
{
    Task<IEnumerable<CityGetResponse>?> GetCitiesByDepartment(int departmentId);
    Task<IEnumerable<CityGetResponse>?> GetCitiesByName(string name);
    Task<IEnumerable<DepartmentGetResponse>?> GetDepartments(int regionId);
    Task<IEnumerable<Region>?> GetRegions();
}
