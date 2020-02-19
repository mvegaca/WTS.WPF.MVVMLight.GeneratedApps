using System.Threading.Tasks;

namespace ForcedLogin.Contracts.Services
{
    public interface IApplicationHostService
    {
        Task StartAsync();

        Task StopAsync();
    }
}
