using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using Microsoft.AspNet.SignalR;
using Microsoft.AspNet.SignalR.Hubs;

namespace GroupChat
{
    [HubName("chatHub")]
    public class ChatHub : Hub
    {
        public async Task JoinRoom(string userName, string roomName)
        {
            await Groups.Add(Context.ConnectionId, roomName);
            Clients.Group(roomName).broadCastMessage(userName + ": joined room: " + roomName);
        }

        public Task LeaveRoom(string roomName)
        {
            return Groups.Remove(Context.ConnectionId, roomName);
        }

        public void Send(string name, string message, string groupName)
        {
            Clients.Group(groupName).broadCastMessage(name, message);
        }
    }
}