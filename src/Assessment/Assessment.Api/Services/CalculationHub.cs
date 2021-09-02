using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assessment.Api.Services
{
    public class CalculationHub : Hub
    {

        public override async Task OnConnectedAsync()
        {
            
            
            await Groups.AddToGroupAsync(Context.ConnectionId, "Calculation Clients");
            
            await base.OnConnectedAsync();
        }

        public override async Task OnDisconnectedAsync(Exception exception)
        {
            await Groups.RemoveFromGroupAsync(Context.ConnectionId, "Calculation Clients");
            await base.OnDisconnectedAsync(exception);
        }

        public Task SendMessageToCaller(string user, Models.Status status)
        {
            return Clients.Caller.SendAsync("ReceiveStatus", user, status);
        }

        public string GetConnectionId()
        {
            return Context.ConnectionId;
        }

    }
}
