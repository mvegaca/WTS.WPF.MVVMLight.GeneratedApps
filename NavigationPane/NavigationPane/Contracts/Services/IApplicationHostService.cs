using System.Threading.Tasks;

namespace NavigationPane.Contracts.Services
{
    public interface IApplicationHostService
    {
        Task StartAsync();

        Task StopAsync();
    }
}
