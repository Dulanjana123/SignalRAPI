using System.Collections.Generic;
using System.Threading.Tasks;

namespace SignalRAPI.Hub
{
    public interface IMessageHubClient
    {
        Task SendOffersToUser(List<string> message);
    }
}
