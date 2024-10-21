using Microsoft.AspNetCore.SignalR;

namespace SocialNetworkApp.SignalR
{
    public class NotificationHub : Hub
    {
        public async Task SendNotification(string message)
        {
            await Clients.All.SendAsync("ReceiveNotification", message);
        }
    }

}
