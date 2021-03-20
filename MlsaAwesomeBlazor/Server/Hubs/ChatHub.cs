using Microsoft.AspNetCore.SignalR;

namespace MlsaAwesomeBlazor.Server.Hubs
{
    public class ChatHub : Hub
    {
        public async void SendMessage(string author, string message)
        {
            await Clients.All.SendAsync("ReceiveMessage", new
            {
                author,
                message
            });
        }
    }
}