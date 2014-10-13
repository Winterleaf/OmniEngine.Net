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

using System.ComponentModel;
using WinterLeaf.Demo.Full.Models.User.Extendable;
using WinterLeaf.Engine;
using WinterLeaf.Engine.Classes.Decorations;
using WinterLeaf.Engine.Classes.Extensions;
using WinterLeaf.Engine.Classes.Helpers;
using WinterLeaf.Engine.Classes.Interopt;

#endregion

namespace WinterLeaf.Demo.Full.Models.Base
{
    /// <summary>
    /// 
    /// </summary>
    [TypeConverter(typeof (TypeConverterGeneric<Item_Base>))]
    public partial class Item_Base : ShapeBase
    {
        #region ProxyObjects Operator Overrides

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(Item_Base ts, string simobjectid)
        {
            return ReferenceEquals(ts, null) ? ReferenceEquals(simobjectid, null) : ts.Equals(simobjectid);
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
        public static bool operator !=(Item_Base ts, string simobjectid)
        {
            if (ReferenceEquals(ts, null))
                return !ReferenceEquals(simobjectid, null);
            return !ts.Equals(simobjectid);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator string(Item_Base ts)
        {
            if (ReferenceEquals(ts, null))
                return "0";
            return ts._ID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator Item_Base(string ts)
        {
            uint simobjectid = resolveobject(ts);
            return (Item_Base) Omni.self.getSimObject(simobjectid, typeof (Item_Base));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int(Item_Base ts)
        {
            return (int) ts._iID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator Item_Base(int simobjectid)
        {
            return (Item) Omni.self.getSimObject((uint) simobjectid, typeof (Item_Base));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint(Item_Base ts)
        {
            return ts._iID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator Item_Base(uint simobjectid)
        {
            return (Item_Base) Omni.self.getSimObject(simobjectid, typeof (Item_Base));
        }

        #endregion

        #region Init Persists

        /// <summary>
        /// If true, the object will automatically rotate around its Z axis.\n
        /// </summary>
        [MemberGroup("Misc")]
        public bool rotate
        {
            get { return Omni.self.GetVar(_ID + ".rotate").AsBool(); }
            set { Omni.self.SetVar(_ID + ".rotate", value.AsString()); }
        }

        /// <summary>
        /// If true, the object is not moving in the world.\n
        /// </summary>
        [MemberGroup("Misc")]
        public bool staticx
        {
            get { return Omni.self.GetVar(_ID + ".static").AsBool(); }
            set { Omni.self.SetVar(_ID + ".static", value.AsString()); }
        }

        #endregion

        #region Member Functions

        /// <summary>
        /// @brief Get the normal of the surface on which the object is stuck.      @return Returns The XYZ normal from where this Item is stuck.   @tsexample	   // Acquire the position where this Item is currently stuck	   %stuckPosition = %item.getLastStickPos();   @endtsexample   @note Server side only.   )
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public string getLastStickyNormal()
        {
            return m_ts.fnItem_getLastStickyNormal(_ID);
        }

        /// <summary>
        /// @brief Get the position on the surface on which this Item is stuck.      @return Returns The XYZ position of where this Item is stuck.   @tsexample	   // Acquire the position where this Item is currently stuck	   %stuckPosition = %item.getLastStickPos();   @endtsexample   @note Server side only.   )
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public string getLastStickyPos()
        {
            return m_ts.fnItem_getLastStickyPos(_ID);
        }

        /// <summary>
        /// @brief Is the object at rest (ie, no longer moving)?      @return True if the object is at rest, false if it is not.   @tsexample	   // Query the item on if it is or is not at rest.	   %isAtRest = %item.isAtRest();   @endtsexample   )
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public bool isAtRest()
        {
            return m_ts.fnItem_isAtRest(_ID);
        }

        /// <summary>
        /// @brief Is the object still rotating?      @return True if the object is still rotating, false if it is not.   @tsexample	   // Query the item on if it is or is not rotating.	   %isRotating = %itemData.isRotating();   @endtsexample   @see rotate   )
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public bool isRotating()
        {
            return m_ts.fnItem_isRotating(_ID);
        }

        /// <summary>
        /// @brief Is the object static (ie, non-movable)?      @return True if the object is static, false if it is not.   @tsexample	   // Query the item on if it is or is not static.	   %isStatic = %itemData.isStatic();   @endtsexample   @see static   )
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public bool isStatic()
        {
            return m_ts.fnItem_isStatic(_ID);
        }

        /// <summary>
        /// @brief Temporarily disable collisions against a specific ShapeBase object.   This is useful to prevent a player from immediately picking up an Item they have    just thrown.  Only one object may be on the timeout list at a time.  The timeout is    defined as 15 ticks.   @param objectID ShapeBase object ID to disable collisions against.   @return Returns true if the ShapeBase object requested could be found, false if it could not.   @tsexample	   // Set the ShapeBase Object ID to disable collisions against	   %ignoreColObj = %player.getID();	   // Inform this Item object to ignore collisions temproarily against the %ignoreColObj.	   %item.setCollisionTimeout(%ignoreColObj);   @endtsexample   )
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public bool setCollisionTimeout(int ignoreColObj)
        {
            return m_ts.fnItem_setCollisionTimeout(_ID, ignoreColObj);
        }

        #endregion

        #region T3D Callbacks

        /// <summary>
        /// @brief Informs the Item object that it is now sticking to another object.   This callback is only called if the ItemData::sticky property for this Item is true.   @param objID Object ID this Item object.   @note Server side only.   @see Item, ItemData)
        /// </summary>
        [ConsoleInteraction(true)]
        public virtual void onStickyCollision(string objID)
        {
        }

        /// <summary>
        /// Informs an Item object that it has entered liquid, along with information about the liquid type.   @param objID Object ID for this Item object.   @param waterCoverage How much coverage of water this Item object has.   @param liquidType The type of liquid that this Item object has entered.   @note Server side only.   @see Item, ItemData, WaterObject)
        /// </summary>
        [ConsoleInteraction(true)]
        public virtual void onEnterLiquid(string objID, string waterCoverage, string liquidType)
        {
        }

        /// <summary>
        /// Informs an Item object that it has left a liquid, along with information about the liquid type.   @param objID Object ID for this Item object.   @param liquidType The type of liquid that this Item object has left.   @note Server side only.   @see Item, ItemData, WaterObject)
        /// </summary>
        [ConsoleInteraction(true)]
        public virtual void onLeaveLiquid(string objID, string liquidType)
        {
        }

        #endregion

        public Item_Base()
        {
        }
    }
}