using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//Since this is a base model we must extend the extendable class.
using WinterLeaf.Demo.Full.Models.User.Extendable;
using WinterLeaf.Demo.Full.Models.User.GameCode.Server.Game;

namespace WinterLeaf.Demo.Full.Models.User.GameCode.Server
    {
    public class GameConnectionDM : GameConnection
        {
        //Put all your overrides here.
        public override string onConnectRequest(GameConnection client, string netAddress, string name)
            {
            console.print("###Connection Request: " + netAddress + "###");
            return base.onConnectRequest(client, netAddress, name);
            }
        }
    }
