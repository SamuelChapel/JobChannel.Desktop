using System.IdentityModel.Tokens.Jwt;
using System.Net;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using BLL.Http.Requests;
using Domain.Contracts;

namespace BLL.Http;

public class JobChannelHttpClient : IJobChannelHttpClient
{
    private readonly HttpClient _client;
    public DateTime ExpireDate { get; private set; }
    private readonly JwtSecurityTokenHandler jwtSecurityTokenHandler;

    public enum TypeREST { Get, Post, Put, Delete };

    public JobChannelHttpClient(HttpClient client)
    {
        _client = client;
        _client.BaseAddress = new Uri(Resources.BaseAddress);

        ExpireDate = DateTime.MinValue;
        jwtSecurityTokenHandler = new JwtSecurityTokenHandler();
    }

    public async Task<T?> GetRequest<T>(string url)
    {
        var response = await CallHttpClient(TypeREST.Get, url);

        return await response.Content.ReadFromJsonAsync<T>();
    }

    public async Task<T?> PostRequest<T, TRequest>(string url, TRequest data) where TRequest : IRequest
    {
        var response = await CallHttpClient(TypeREST.Post, url, data);

        return await response.Content.ReadFromJsonAsync<T>();
    }

    public async Task<bool> PutRequest<TRequest>(string url, TRequest data) where TRequest : IRequest
    {
        var response = await CallHttpClient(TypeREST.Put, url, data);

        return response.StatusCode == HttpStatusCode.NoContent;
    }

    public async Task<bool> DeleteRequest(string url)
    {
        var response = await CallHttpClient(TypeREST.Delete, url);

        return response.StatusCode == HttpStatusCode.NoContent;
    }

    private async Task<HttpResponseMessage> CallHttpClient(TypeREST typeREST, string uri, object? data = null)
    {
        try
        {
            if (IsTokenExpired())
                await GetAccessToken();

            StringContent? jsonBodyParameter = null;
            if (data != null)
                jsonBodyParameter = new StringContent(JsonSerializer.Serialize(data), Encoding.UTF8, "application/json");

            return typeREST switch
            {
                TypeREST.Get => await _client.GetAsync(_client.BaseAddress + uri),
                TypeREST.Post => await _client.PostAsync(uri, jsonBodyParameter),
                TypeREST.Put => await _client.PutAsync(uri, jsonBodyParameter),
                TypeREST.Delete => await _client.DeleteAsync(uri),
                _ => throw new NotImplementedException("Type Rest non Valide")
            };
        }
        catch (Exception)
        {
            return new HttpResponseMessage(HttpStatusCode.BadRequest);
        }
    }

    public async Task GetAccessToken()
    {
        try
        {
            var authRequest = new AuthenticationRequest("Admin", Resources.AdminPassword);

            var httpResponse = await _client.PostAsJsonAsync(_client.BaseAddress + Resources.authUrl, authRequest);
            var responseToken = await httpResponse.Content.ReadAsStringAsync();

            var token = jwtSecurityTokenHandler.ReadJwtToken(responseToken);

            ExpireDate = token.ValidTo;

            _client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", responseToken);
        }
        catch (Exception)
        {
            throw new Exception("Authentication Problem");
        }
    }

    public bool IsTokenExpired()
    {
        return DateTime.UtcNow > ExpireDate;

    }
}
