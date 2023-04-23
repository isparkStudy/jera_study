
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace HttpClientDemo
{
    class HttpClientDemo
    {
        static async Task Main()
        {
            HttpClient httpClient = new HttpClient();

            HttpResponseMessage httpRequestMessage = await httpClient.GetAsync("http://www.microsoft.com/");
            string responseBody = await httpRequestMessage.Content.ReadAsStringAsync();

            Console.WriteLine(responseBody);
        }
    }
}
