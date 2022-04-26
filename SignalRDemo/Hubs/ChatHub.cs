using Microsoft.AspNet.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;

namespace SignalRDemo.Hubs
{
    public class ChatHub : Hub
    {
        public void Send(string name, string message)
        {
            Clients.All.addNewMessageToPage(name, message);
        }

        public void SendCount()
        {
            // Call the broadcastMessage method to update clients.  
            for (int i = 0; i <= 2; i++)
            {
                //"All" is dynamic, and broadcastMessage is the method that we'll  
                //create in JavaScript at client side.  
                Clients.All.broadcastMessage(i.ToString());
                Thread.Sleep(2000);
            }
        }

    }
}