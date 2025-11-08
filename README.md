# OkSurf.cs
Web-API for [ok.surf](https://ok.surf/) free REST API for developers to retrieve the latest Google news in a familiar JSON format

## Example
```cs
using OkSurfApi;

namespace Application
{
    internal class Program
    {
        static async Task Main()
        {
            var api = new OkSurf();
            string newsFeed = await api.GetNewsFeed();
            Console.WriteLine(newsFeed);
        }
    }
}
```
