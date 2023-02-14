namespace BLL.Services.Geographic.Requests;

public record CityGetResponse(
        int Id,
        string Name,
        string PostCode,
        string DepartmentName
        )
{
    public sealed override string ToString()
    {
        return $"{Name} {PostCode} ({DepartmentName})";
    }
}
