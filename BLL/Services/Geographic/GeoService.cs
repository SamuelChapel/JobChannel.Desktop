using BLL.Http;
using BLL.Services.Geographic.Requests;
using JobChannel.Domain.BO;

namespace BLL.Services.Geographic;
internal class GeoService : IGeoService
{
    private readonly IJobChannelHttpClient _client;

    public GeoService(IJobChannelHttpClient client)
    {
        _client = client;
    }

    public async Task<IEnumerable<Region>?> GetRegions()
    {
        return await _client.GetRequest<IEnumerable<Region>>("api/Region");
    }

    public async Task<IEnumerable<DepartmentGetResponse>?> GetDepartments(int regionId)
    {
        return await _client.GetRequest<IEnumerable<DepartmentGetResponse>>($"api/Department/Region/{regionId}");
    }

    public async Task<IEnumerable<CityGetResponse>?> GetCitiesByDepartment(int departmentId)
    {
        return await _client.GetRequest<IEnumerable<CityGetResponse>>($"api/City/Department/{departmentId}");
    }

    public async Task<IEnumerable<CityGetResponse>?> GetCitiesByName(string name)
    {
        return await _client.GetRequest<IEnumerable<CityGetResponse>>($"api/City?name={name}");
    }
}
