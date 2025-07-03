// IHttpService.cs
namespace RoundTheCode.VsCode.WebApi.Services;

public interface IHttpService
{
	Task<string> ReadAsync();
}