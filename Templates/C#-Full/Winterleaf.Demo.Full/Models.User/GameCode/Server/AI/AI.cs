// WinterLeaf Entertainment
// Copyright (c) 2014, WinterLeaf Entertainment LLC
// 
// All rights reserved.
// 
// The use of the WinterLeaf Entertainment LLC OMNI "Community Edition" is governed by this license agreement ("Agreement").
// 
// These license terms are an agreement between WinterLeaf Entertainment LLC and you.  Please read them. They apply to the source code and any other assets or works that are included with the product named above, which includes the media on which you received it, if any. These terms also apply to any updates, supplements, internet-based services, and support services for this software and its associated assets, unless other terms accompany those items. If so, those terms apply. You must read and agree to this Agreement terms BEFORE installing OMNI "Community Edition" to your hard drive or using OMNI in any way. If you do not agree to the license terms, do not download, install or use OMNI. Please make copies of this Agreement for all those in your organization who need to be familiar with the license terms.
// 
// This license allows companies of any size, government entities or individuals to create, sell, rent, lease, or otherwise profit commercially from, games using executables created from the source code that accompanies OMNI "Community Edition".
// 
// BY CLICKING THE ACCEPTANCE BUTTON AND/OR INSTALLING OR USING OMNI "Community Edition", THE INDIVIDUAL ACCESSING OMNI ("LICENSEE") IS CONSENTING TO BE BOUND BY AND BECOME A PARTY TO THIS AGREEMENT. IF YOU DO NOT ACCEPT THESE TERMS, DO NOT INSTALL OR USE OMNI. IF YOU COMPLY WITH THESE LICENSE TERMS, YOU HAVE THE RIGHTS BELOW:
// 
// Redistribution and use in source and binary forms, with or without modification, are permitted provided that the following conditions are met:
// 
//     Redistributions of source code must retain the all copyright notice, this list of conditions and the following disclaimer.
//     Redistributions in binary form must reproduce the above copyright notice, this list of conditions and the following disclaimer in the documentation and/or other materials provided with the distribution.
//     With respect to any Product that the Licensee develop using the Software:
//     Licensee shall:
//         display the OMNI Logo, in the start-up sequence of the Product (unless waived by WinterLeaf Entertainment);
//         display in the "About" box or in the credits screen of the Product the text "OMNI by WinterLeaf Entertainment";
//         display the OMNI Logo, on all external Product packaging materials and the back cover of any printed instruction manual or the end of any electronic instruction manual;
//         notify WinterLeaf Entertainment in writing that You are publicly releasing a Product that was developed using the Software within the first 30 days following the release; and
//         the Licensee hereby grant WinterLeaf Entertainment permission to refer to the Licensee or the name of any Product the Licensee develops using the Software for marketing purposes. All goodwill in each party's trademarks and logos will inure to the sole benefit of that party.
//     Neither the name of WinterLeaf Entertainment LLC or OMNI nor the names of its contributors may be used to endorse or promote products derived from this software without specific prior written permission.
//     The following restrictions apply to the use of OMNI "Community Edition":
//     Licensee may not:
//         create any derivative works of OMNI Engine, including but not limited to translations, localizations, or game making software other than Games;
//         redistribute, encumber, sell, rent, lease, sublicense, or otherwise transfer rights to OMNI "Community Edition"; or
//         remove or alter any trademark, logo, copyright or other proprietary notices, legends, symbols or labels in OMNI Engine; or
//         use the Software to develop or distribute any software that competes with the Software without WinterLeaf Entertainment’s prior written consent; or
//         use the Software for any illegal purpose.
// 
// THIS SOFTWARE IS PROVIDED BY WINTERLEAF ENTERTAINMENT LLC ''AS IS'' AND ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE IMPLIED WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE ARE DISCLAIMED. IN NO EVENT SHALL WINTERLEAF ENTERTAINMENT LLC BE LIABLE FOR ANY DIRECT, INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES (INCLUDING, BUT NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES; LOSS OF USE, DATA, OR PROFITS; OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND ON ANY THEORY OF LIABILITY, WHETHER IN CONTRACT, STRICT LIABILITY, OR TORT (INCLUDING NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT OF THE USE OF THIS SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE. 

#region

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading;
using WinterLeaf.Demo.Full.Models.User.Extendable;
using WinterLeaf.Engine;
using WinterLeaf.Engine.Classes.Decorations;
using WinterLeaf.Engine.Classes.Extensions;
using WinterLeaf.Engine.Classes.Interopt;
using WinterLeaf.Engine.Classes.View.Creators;
using WinterLeaf.Engine.Containers;

#endregion

namespace WinterLeaf.Demo.Full.Models.User.GameCode.Server.AI
{
    public class AI
    {
        private static readonly Random r = new Random();
        private static readonly pInvokes omni = new pInvokes();
        internal static readonly ConcurrentList<AIInterval> m_thoughtqueue = new ConcurrentList<AIInterval>();
        internal static int _lastcount;
        private static readonly object _lastcount_lock = new object();
        private static readonly object _aiscreated_lock = new object();
        internal static volatile int aiscreated;

        internal static int lastcount
        {
            get
            {
                lock (_lastcount_lock)
                    {
                    return _lastcount;
                    }
            }
            set
            {
                lock (_lastcount_lock)
                    {
                    _lastcount = value;
                    }
            }
        }

        #region Console Commands

        /// <summary>
        /// Only Call from the console, not thread-safe
        /// </summary>
        /// <param name="count">Number of AI to create.</param>
        [ConsoleInteraction(true)]
        public static void createAI(int count)
        {
            if (count == 0)
                return;

            if (lastcount > 0)
                {
                omni.console.error("Mobs already spawned");
                return;
                }
            using (BackgroundWorker bwr_AIThought = new BackgroundWorker())
                {
                bwr_AIThought.DoWork += bwr_AIThought_DoWork;
                bwr_AIThought.RunWorkerAsync();
                }

            lastcount = count;
            int team = 0;
            for (int i = 0; i < count; i++)
                {
                team++;
                if (team == 3)
                    team = 1;

                ObjectCreator ocf = new ObjectCreator("ScriptObject", "Mob" + i.AsString());
                ocf["player"] = "";
                ocf["aiteam"] = team.AsString();
                ScriptObject MobRoot = ocf.Create();
                ((SimSet) "rootgroup").pushToBack(MobRoot);
                BackgroundWorker spawnwait = new BackgroundWorker();
                spawnwait.DoWork += spawnwait_DoWork;
                spawnwait.RunWorkerAsync(new threadparam(i*10, MobRoot));
                }
        }

        /// <summary>
        /// Deletes all AI in Game.  Only call from in-game console.
        /// </summary>
        [ConsoleInteraction(true)]
        public static void deleteAI()
        {
            lock (Omni.self.tick)
                {
                m_thoughtqueue.Clear();
                for (int i = 0; i < lastcount; i++)
                    {
                    ScriptObject mobholder = "Mob" + i.AsString();
                    omni.Util.cancelAll(mobholder);
                    omni.Util.cancelAll(mobholder["player"]);
                    mobholder["player"].delete();
                    mobholder.delete();
                    }
                m_thoughtqueue.Clear();
                lastcount = 0;
                aiscreated = 0;
                }
        }

        public static void spawnwait_DoWork(object sender, DoWorkEventArgs e)
        {
            threadparam tp = (threadparam) e.Argument;
            Thread.Sleep(tp.Delay);
            lock (Omni.self.tick)
                spawnAI(tp.MobRoot);
        }

        #endregion

        //internal static int aiscreated
        //    {
        //    get
        //        {
        //        lock (_aiscreated_lock)
        //            {
        //            return _aiscreated;
        //            }
        //        }
        //    set
        //        {
        //        lock (_aiscreated_lock)
        //            {
        //            _aiscreated = value;
        //            }
        //        }
        //    }

        public static void bwr_AIThought_DoWork(object sender, DoWorkEventArgs e)
        {
            while (lastcount > 0 && Omni.self.IsRunning)
                {
                List<AIInterval> t = m_thoughtqueue.toArray().Where(item => item.Intervaltime < DateTime.Now).Take(20).ToList();
                lock (Omni.self.tick)
                    foreach (AIInterval item in t)
                        {
                        m_thoughtqueue.Remove(item);
                        if (item.Player_id.AsString().isObject())
                            ((DemoPlayer) item.Player_id).Think();
                        }
                Thread.Sleep(100);
                }
        }

        #region Spawning

        #region Support Function

        /// <summary>
        /// Not thread-safe, must be called from function that locks tick.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="spawnpoint"></param>
        /// <returns></returns>
        public static UInt32 Spawn(string name, TransformF spawnpoint)
        {
            ObjectCreator npcScriptObject = new ObjectCreator("AIPlayer", "", typeof (DemoPlayer));
            npcScriptObject["dataBlock"] = "DemoPlayer";
            npcScriptObject["path"] = "";
            AIPlayer npc = npcScriptObject.Create();

            //npc.TickCounterNotifyServer = true;
            //npc.TickCounterAdd("Combat::Attack", 10);

            if (npc != 0)
                {
                ((SimSet) "MissionCleanup").pushToBack(npc);
                npc.setShapeName(name);
                npc.setTransform(spawnpoint);
                }

            return npc;
        }

        /// <summary>
        /// Spawns a AI on a passed path.
        /// </summary>
        /// <param name="ainame"></param>
        /// <param name="path"></param>
        /// <returns></returns>
        public static DemoPlayer SpawnOnPath(string ainame, SimSet path)
        {
            if (!omni.console.isObject(path))
                return null;

            Marker node = path.getObject((uint) r.Next(0, path.getCount() - 1));

            TransformF transform = node.getTransform();
            return Spawn(ainame, transform);
        }

        #endregion

        /// <summary>
        /// Thread-Safe
        /// </summary>
        /// <param name="aiManager"></param>
        public static void spawnAI(ScriptObject aiManager)
        {
            //lock (Omni.self.tick)
            {
            if (!aiManager.isObject())
                {
                omni.console.error("Bad aiManager!");
                return;
                }

            DemoPlayer aiPlayer = SpawnOnPath("Team" + aiManager["aiteam"], "MissionGroup/Paths/team" + aiManager["aiteam"] + "Path");

            if (aiPlayer == null)
                {
                omni.console.error("UNABLE TO SPAWN MONSTER!@!!!!!a");
                return;
                }
            if (!omni.console.isObject(aiPlayer))
                {
                omni.console.error("UNABLE TO SPAWN MONSTER!@!!!!!");
                return;
                }

            aiPlayer.FollowPath("MissionGroup/Paths/team" + aiManager["aiteam"] + "Path", 0);
            aiPlayer.setMoveSpeed(0.8f);
            aiManager["player"] = aiPlayer;
            aiPlayer["aiManager"] = aiManager;
            aiPlayer["aiteam"] = aiManager["aiteam"];

            aiPlayer.setInventory("Lurker", 1);
            aiPlayer.setInventory("LurkerClip", 1000);
            aiPlayer.setInventory("LurkerAmmo", 1000);
            aiPlayer.setInventory("LurkerGrenadeLauncher", 1);
            aiPlayer.setInventory("LurkerGrenadeAmmo", 10);
            aiPlayer.setInventory("ProxMine", 5);
            aiPlayer.setInventory("DeployableTurret", 5);

            aiPlayer.mountImage("LurkerWeaponImage", 0, true, "");

            TransformF t = aiPlayer.getTransform();
            t.mPositionZ += r.Next(0, 200);
            aiPlayer.setTransform(t);

            aiPlayer.AddObjectTo_MobSearchGroup(aiManager["aiteam"].AsInt());

            m_thoughtqueue.Add(new AIInterval(DateTime.Now.AddMilliseconds(500), aiPlayer));

            aiscreated++;
            }
        }

        #endregion

        public class AIInterval
        {
            private DateTime m_intervaltime;

            private int m_player_id;

            public AIInterval(DateTime dt, int p)
            {
                m_intervaltime = dt;
                m_player_id = p;
            }

            public DateTime Intervaltime
            {
                get { return m_intervaltime; }
                set { m_intervaltime = value; }
            }

            public int Player_id
            {
                get { return m_player_id; }
                set { m_player_id = value; }
            }
        }

        public class ConcurrentList<T>
        {
            private readonly List<T> m_Objects;
            private readonly object mlock = new object();

            public ConcurrentList()
            {
                m_Objects = new List<T>();
            }

            public void Add(T obj)
            {
                lock (mlock)
                    m_Objects.Add(obj);
            }

            public T[] toArray()
            {
                T[] temp;
                lock (mlock)
                    temp = m_Objects.ToArray();
                return temp;
            }

            public void Remove(T toremove)
            {
                lock (mlock)
                    m_Objects.Remove(toremove);
            }

            public void Clear()
            {
                lock (mlock)
                    m_Objects.Clear();
            }
        }

        private class threadparam
        {
            public threadparam(int delay, int mobroot)
            {
                Delay = delay;
                MobRoot = mobroot;
            }

            public int Delay { get; set; }
            public int MobRoot { get; set; }
        }

    }
}