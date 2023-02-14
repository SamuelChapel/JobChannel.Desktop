using Domain.Contracts;

namespace BLL.Http;

public interface IJobChannelHttpClient
{
    public Task<T?> GetRequest<T>(string url);

    public Task<T?> PostRequest<T, TRequest>(string url, TRequest data) where TRequest : IRequest;

    public Task<bool> PutRequest<TRequest>(string url, TRequest data) where TRequest : IRequest;

    public Task<bool> DeleteRequest(string url);
}
