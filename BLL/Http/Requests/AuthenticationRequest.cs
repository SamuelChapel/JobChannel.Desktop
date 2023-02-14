using Domain.Contracts;

namespace BLL.Http.Requests;

public record AuthenticationRequest(
    string login,
    string password
    ) : IRequest;
