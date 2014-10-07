using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using WinterLeaf.Demo.Full.Models.User.CustomObjects.Utilities;
using WinterLeaf.Demo.Full.Models.User.Extendable;
using WinterLeaf.Engine;
using WinterLeaf.Engine.Classes.Decorations;
using WinterLeaf.Engine.Classes.Extensions;
using WinterLeaf.Engine.Classes.Helpers;

namespace WinterLeaf.Demo.Full.Models.User.GameCode.Server
{
    //-----------------------------------------------------------------------------
    // Openable  - a base class for the objects like doors, lockers,
    // switcher etc. Anything that can be opened and closed.
    //-----------------------------------------------------------------------------

    //--------------------------------------------------------------------------------------------------
    [TypeConverter(typeof(TypeConverterGeneric<Openable>))]
    public class Openable : ShapeBase
    {
        private bool inTransition
        {
            get
            {
                return this["inTransition"].AsBool();
            }
            set
            {
                this["inTransition"] = value.AsString();
            }
        }

        private bool isOpen
        {
            get
            {
                return this["isOpen"].AsBool();
            }
            set
            {
                this["isOpen"] = value.AsString();
            }
        }

        [ConsoleInteraction]
        public virtual void init()
        {
            this.inTransition = false;
            //Set the right position of the Openable by starting corresponding animation
            if (this.isOpen)
            {
                this.setThreadDir(0, !((SimObject)this.getDataBlock())["openAnimationReverse"].AsBool());
                this.playThread(0, ((SimObject)this.getDataBlock())["openAnimation"]);
            }
        }

        [ConsoleInteraction]
        public virtual void open()
        {
            if (!this.getFieldValue("isLocked").AsBool() && !this.getFieldValue("isOpen").AsBool() && !this.inTransition)
            {
                this.setFieldValue("inTransition", true.AsString());
                this.playThread(0, ((SimObject)this.getDataBlock())["openAnimation"]);
                if (((SimObject)this.getDataBlock())["openAnimationReverse"].AsBool())
                {
                    this.setThreadDir(0, false);
                    this.setThreadPosition(0, 1);
                }
                this.playAudio(0, ((SimObject)this.getDataBlock())["openSnd"]);
                this.signal("onOpening");
            }
        }

        [ConsoleInteraction]
        public virtual void close()
        {
        if (!this.getFieldValue("isLocked").AsBool() && this.getFieldValue("isOpen").AsBool() && !this.inTransition)
        {
            this.setFieldValue("inTransition", true.AsString());
            this.playThread(0, ((SimObject)this.getDataBlock())["closeAnimation"]);
            if (((SimObject)this.getDataBlock())["closeAnimationReverse"].AsBool())
            {
                this.setThreadDir(0, false);
                this.setThreadPosition(0, 1);
            }
            this.playAudio(0, ((SimObject)this.getDataBlock())["closeSnd"]);
            this.signal("onClosing");
            }
        }

        [ConsoleInteraction]
        public virtual void onAnimationEnd(int slot)
        {
            if(slot != 0 || !this.inTransition) 
                return;
            this.setFieldValue("inTransition", false.AsString());
	
            if(this.isOpen)
            {
                this.setFieldValue("isOpen", false.AsString());
                this.signal("onClosed");
            }
            else
            {
                this.setFieldValue("isOpen", true.AsString());
                this.signal("onOpened");
            }
        }

        [ConsoleInteraction]
        public virtual void setLockedState(string flg)
        {
            this.setFieldValue("isLocked", flg);            
        }

        [ConsoleInteraction]
        public virtual bool useObject(ShapeBase user)   //TODO FIX
        {
            if(!console.Call_Classname("Usable","use", new string[]{this, user}).AsBool())
                return false;
	
            //if the openable is closed check whether we need a key to unlock
            if(this.getFieldValue("isLocked").AsBool())
            {
                SimObject key = this.getFieldValue("keyToUnlock");
                Util._echo("KEY:", key, " user ", user.getInventory(key).AsString());
                if(key !="")
                {
                    if(user.getInventory(key) > 0)
                    {
                    this["isLocked"] = false.AsString();
                    message.MessageClient(user["client"], "MsgDoorLocked", "Door is unlocked.", key["pickUpName"]);
                    }
                    else
                    {
                    message.MessageClient(user["client"], "MsgDoorLocked", "You need a %1!", key["pickUpName"]);
                    return false;
                    }
                }
                else
                message.MessageClient(user["client"], "MsgDoorLocked", "Door is locked.");
            }

            if(this.getFieldValue("isOpen").AsBool())
                this.close();
            else
                this.open();
            return true;
        }

        #region ProxyObjects Operator Overrides

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(Openable ts, string simobjectid)
        {
            return object.ReferenceEquals(ts, null)
                ? object.ReferenceEquals(simobjectid, null)
                : ts.Equals(simobjectid);
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
            return (this._ID == (string)myReflections.ChangeType(obj, typeof(string)));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator !=(Openable ts, string simobjectid)
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
        public static implicit operator string(Openable ts)
        {
            return ReferenceEquals(ts, null) ? "0" : ts._ID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator Openable(string ts)
        {
            uint simobjectid = resolveobject(ts);
            return (Openable)Omni.self.getSimObject(simobjectid, typeof(Openable));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int(Openable ts)
        {
            return (int)ts._iID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator Openable(int simobjectid)
        {
            return (Openable)Omni.self.getSimObject((uint)simobjectid, typeof(Openable));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint(Openable ts)
        {
            return ts._iID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator Openable(uint simobjectid)
        {
            return (Openable)Omni.self.getSimObject(simobjectid, typeof(Openable));
        }

        #endregion
    }
}
