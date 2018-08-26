using Newtonsoft.Json;
using TescoApi.Request;
using System.Net;
namespace TescoApi
{
    public class ApiCall
    {
        public const string RootUrl = "https://dev.tescolabs.com/grocery/products/?query={query}&offset={offset}&limit={limit}";

        public static T Send<T>(IApiRequest request)
        {
            using (var client = new WebClient())
            {

                client.BaseAddress = RootUrl;
                var url = request.GetUrl();
                var jsonResponse = client.DownloadString(url);
                var dto = JsonConvert.DeserializeObject<T>(jsonResponse);
                return dto;
            }
        }
    }
}

