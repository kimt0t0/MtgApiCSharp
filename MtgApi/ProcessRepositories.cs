using System.Threading.Tasks;
using static System.Net.Http.HttpClient;

namespace ProcessRepositories;
public class RepositoriesProcessor
{
    protected HttpClient? client;
    protected string? path;
    public RepositoriesProcessor(HttpClient client, string path)
    {
        this.client = client;
        this.path = path;
    }
    public async Task ProcessRepositoriesAsync()
    {
        var json = await client.GetStringAsync(path);
        Console.WriteLine($"{json} \n\n");
    }
}
