using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;

namespace SignalR
{
    public class FocusHub : Hub
    {
        //public void Hello()
        //{
        //    Clients.All.hello();
        //}


        public void OnFocus(string elementId, string htmlColor)
        {
            Clients.All.onFocus(elementId, htmlColor);

        }

        public void OutFocus(string elementId)
        {
            Clients.All.outFocus(elementId);


        }

        public void ChangeText(string elementId,string text)
        {
            Clients.All.changeText(elementId, text);
        }

    }
}