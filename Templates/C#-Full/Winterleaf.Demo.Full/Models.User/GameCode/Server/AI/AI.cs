#region

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading;
using WinterLeaf.Demo.Full.Models.User.Extendable;
using WinterLeaf.Engine;
using WinterLeaf.Engine.Classes;
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
        internal volatile static int aiscreated;

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
                ((SimSet)"rootgroup").pushToBack(MobRoot);
                BackgroundWorker spawnwait = new BackgroundWorker();
                spawnwait.DoWork += spawnwait_DoWork;
                spawnwait.RunWorkerAsync(new threadparam(i * 10, MobRoot));
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
            threadparam tp = (threadparam)e.Argument;
            Thread.Sleep(tp.Delay);
            lock (Omni.self.tick)
                spawnAI(tp.MobRoot);
            }

        #endregion



        public static void bwr_AIThought_DoWork(object sender, DoWorkEventArgs e)
            {
            while (lastcount > 0 && Omni.self.IsRunning)
                {
                List<AIInterval> t =
                    m_thoughtqueue.toArray().Where(item => item.Intervaltime < DateTime.Now).Take(20).ToList();
                lock (Omni.self.tick)
                    foreach (AIInterval item in t)
                        {
                        m_thoughtqueue.Remove(item);
                        if (item.Player_id.AsString().isObject())
                            ((DemoPlayer)item.Player_id).Think();
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
            ObjectCreator npcScriptObject = new ObjectCreator("AIPlayer", "", typeof(DemoPlayer));
            npcScriptObject["dataBlock"] = "DemoPlayer";
            npcScriptObject["path"] = "";
            AIPlayer npc = npcScriptObject.Create();




            //npc.TickCounterNotifyServer = true;
            //npc.TickCounterAdd("Combat::Attack", 10);

            if (npc != 0)
                {
                ((SimSet)"MissionCleanup").pushToBack(npc);
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

            Marker node = path.getObject((uint)r.Next(0, path.getCount() - 1));

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

                DemoPlayer aiPlayer = SpawnOnPath("Team" + aiManager["aiteam"],
                    "MissionGroup/Paths/team" + aiManager["aiteam"] + "Path");

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