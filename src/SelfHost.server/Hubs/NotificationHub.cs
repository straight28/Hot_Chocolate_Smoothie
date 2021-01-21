using Microsoft.AspNet.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SelfHost.server.Hubs
{
    public class NotificationHub : Hub
    {
        public void ServerTime()
        {
            do
            {
                Clients.All.displayTime($"{DateTime.UtcNow:F}");
                Thread.Sleep(TimeSpan.FromSeconds(1));

            } while (true);
        }
    }
}
