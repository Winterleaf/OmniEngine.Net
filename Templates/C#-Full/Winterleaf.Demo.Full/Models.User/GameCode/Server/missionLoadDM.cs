using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WinterLeaf.Demo.Full.Models.User.GameCode.Server.Game;
using WinterLeaf.Engine;

namespace WinterLeaf.Demo.Full.Models.User.GameCode.Server
    {
    class missionLoadDM : missionLoadBase
        {
        //Override any functions you want for this type of mission.
        public override void loadMission(string missionName, bool isFirstMission)
            {
            base.loadMission(missionName, isFirstMission);
            console.print("### LOAD MISSION###");
            }
        }
    }
