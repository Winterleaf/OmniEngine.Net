#region

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime;
using WinterLeaf.Demo.Full.Models.User.GameCode.Client.art.gui;
using WinterLeaf.Demo.Full.Models.User.GameCode.Server.AI;
using WinterLeaf.Engine;
using WinterLeaf.Engine.Classes;
using WinterLeaf.Engine.Classes.Decorations;
using WinterLeaf.Engine.Classes.Extensions;
using WinterLeaf.Engine.Classes.Helpers;
using WinterLeaf.Engine.Classes.View.Creators;
using WinterLeaf.Engine.Containers;

#endregion

namespace WinterLeaf.Demo.Full.Models.User.Extendable
    {
    /// <summary>
    /// 
    /// </summary>
    [TypeConverter(typeof(TypeConverterGeneric<AIPlayerData>))]
    public class AIPlayerData : PlayerData
        {
        private static readonly Random r = new Random();
        
        public override bool OnFunctionNotFoundCallTorqueScript()
            {
            return false;
            }
        
        public override void onDisabled(ShapeBase obj, string lastState)
            {

            //console.print("### AI DEAD ###!");
            Player npc = obj.ID;

            Util.cancelAll(npc);
            ScriptObject aimanager = null;

            aimanager = npc["aiManager"];
            if (!aimanager.isObject())
                {
                console.error("Bad aiManager");
                return;
                }
            npc.setImageTarget(0, false);



            SimObject item = ((SimObject)npc.getMountedImage(iGlobal["$WeaponSlot"]))["item"];
            if (item.isObject())
                {
                //string item = console.GetVarString(ShapeBase.getMountedImage(npc, WeaponSlot).AsString() + ".item");
                if (r.Next(1, 100) > 80)
                    {
                    int amount = npc.getInventory(item["image.ammo"]);

                    if (amount.AsBool())
                        npc.Throw(item["image.clip"], 1);
                    }
                }

            npc.tossPatch();
            npc.playDeathCry();
            npc.playDeathAnimation();
            int ctov = 2000;

            if (AI.lastcount > 0)
                AI.spawnAI(aimanager);

            npc.schedule((ctov - 1000).AsString(), "startFade", "1000", "0", "true");
            Util._schedule("1", "0", "SafeDeleteCallback", npc);
           
            }

        [ConsoleInteraction]
        public static void SafeDeleteCallback(SimObject obj)
        {
            obj.delete();
            AI.aiscreated--;
        }

        #region AutoGen Operator Overrides

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(AIPlayerData ts, string simobjectid)
            {
            if (object.ReferenceEquals(ts, null))
                return object.ReferenceEquals(simobjectid, null);
            return ts.Equals(simobjectid);
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
            {
            return base.GetHashCode();
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
            {
            return (this._ID == (string) myReflections.ChangeType(obj, typeof (string)));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator !=(AIPlayerData ts, string simobjectid)
            {
            if (object.ReferenceEquals(ts, null))
                return !object.ReferenceEquals(simobjectid, null);
            return !ts.Equals(simobjectid);
            }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator string(AIPlayerData ts)
            {
            if (object.ReferenceEquals(ts, null))
                return "0";
            return ts._ID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator AIPlayerData(string ts)
            {
            uint simobjectid = resolveobject(ts);
            return (AIPlayerData) Omni.self.getSimObject(simobjectid, typeof (AIPlayerData));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int(AIPlayerData ts)
            {
            if (object.ReferenceEquals(ts, null))
                return 0;
            int i;
            return int.TryParse(ts._ID, out i) ? i : 0;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator AIPlayerData(int simobjectid)
            {
            return (AIPlayerData) Omni.self.getSimObject((uint) simobjectid, typeof (AIPlayerData));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint(AIPlayerData ts)
            {
            if (object.ReferenceEquals(ts, null))
                return 0;
            uint i;
            return uint.TryParse(ts._ID, out i) ? i : 0;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator AIPlayerData(uint simobjectid)
            {
            return (AIPlayerData) Omni.self.getSimObject(simobjectid, typeof (AIPlayerData));
            }

        #endregion
        }
    }