using Microsoft.AspNetCore.Http;


namespace NewStore.Infrastructure
{
    public static class UrlExtensions
    {
        public static string PathEndQuery(this HttpRequest request) => request.QueryString.HasValue ? $"{request.Path} {request.QueryString}" : request.Path.ToString();
    }
}
