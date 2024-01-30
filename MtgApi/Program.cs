using System.Net.Http.Headers;
using ProcessRepositories;

namespace MtgApiReader;

public class Program
{
    public static async Task Main()
    {
        using HttpClient client = new();
        client.DefaultRequestHeaders.Accept.Clear();
        client.DefaultRequestHeaders.Accept.Add(
            new MediaTypeWithQualityHeaderValue("application/vnd.github.v3+json"));
        client.DefaultRequestHeaders.Add("Page-Size", "10");
        client.DefaultRequestHeaders.Add("Count", "10");

        var loadCards1 = new RepositoriesProcessor(client, "https://api.magicthegathering.io/v1/cards/1");
        var loadCards2 = new RepositoriesProcessor(client, "https://api.magicthegathering.io/v1/cards/2");
        var loadCards3 = new RepositoriesProcessor(client, "https://api.magicthegathering.io/v1/cards/3");

        await loadCards1.ProcessRepositoriesAsync();
        await loadCards2.ProcessRepositoriesAsync();
        await loadCards3.ProcessRepositoriesAsync();

    }
}
