using Microsoft.AspNetCore.SignalR;
using MlsaAwesomeBlazor.Shared;

namespace MlsaAwesomeBlazor.Server.Hubs
{
    public class ChatHub : Hub
    {
        public async void SendMessage(string author, string message)
        {
            await Clients.All.SendAsync("ReceiveMessage", new ChatMessage
            {
                Author = author,
                Message = message
            });
        }
    }
}