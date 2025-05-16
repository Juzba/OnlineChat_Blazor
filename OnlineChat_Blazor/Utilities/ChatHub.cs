using Microsoft.AspNetCore.SignalR;

namespace OnlineChat_Blazor.Utilities
{
    public class ChatHub: Hub
    {
        public async Task SendMessage()
        {
            await Clients.All.SendAsync("RefreshChat");
        }
    }
}
