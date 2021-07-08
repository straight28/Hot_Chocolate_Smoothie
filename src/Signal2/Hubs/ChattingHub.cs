using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;

namespace Signal2.Hubs
{


    public class ChattingHub : Hub
    {
        [HubMethodName("Send")]
        public async Task SendMessage(string id, string message)
        {
            await Clients.All.SendAsync("Received", id, message);
        }
    }
}
