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
using WinterLeaf.Demo.Full.Models.User.CustomObjects.Utilities;
using WinterLeaf.Engine.Classes.Extensions;
using WinterLeaf.Engine.Classes.View.Creators;

#endregion

namespace WinterLeaf.Demo.Full.Models.User.Extendable
{
    public partial class ItemData
    {
        public override bool OnFunctionNotFoundCallTorqueScript()
        {
            return false;
        }

        public override int onThrow(ShapeBase user, int amount)
        {
            if (amount == 0)
                amount = 1;

            if (this["maxInventory"] != string.Empty)
                {
                if (amount > this["maxInventory"].AsInt())
                    amount = this["maxInventory"].AsInt();
                }

            if (!amount.AsBool())
                return 0;

            user.decInventory(this, amount);
            //ShapeBaseShapeBaseDecInventory(player, datablock, amount);

            // Construct the actual object in the world, and add it to
            // the mission group so it's cleaned up when the mission is
            // done.  The object is given a random z rotation.
            ObjectCreator tch = new ObjectCreator("Item", string.Empty);
            tch["datablock"] = this;
            tch["rotation"] = "0 0 1 " + (new Random().Next(0, 360));
            tch["count"] = amount;

            Item item = tch.Create();

            ((SimSet) "MissionGroup").pushToBack(item);

            item.SchedulePop();

            return item;
        }

        public override bool onPickup(Item obj, ShapeBase user, int amount)
        {
            int count = obj["count"].AsInt();

            //string count = console.GetVarString(item + ".count");

            if (count == 0)
                {
                count = this["count"].AsInt();
                if (count == 0)
                    {
                    if (this["maxInventory"] != string.Empty)
                        {
                        if (count != this["maxInventory"].AsInt())
                            return false;
                        }
                    else
                        count = 1;
                    }
                }
            user.incInventory(((this).getName()), count);

            GameConnection client = user["client"];
            if (client.isObject())
                message.MessageClient(client, "MsgItemPickup", console.ColorEncode(@"\c0You picked up %1"), this["pickupName"]);

            // If the item is a static respawn item, then go ahead and
            // respawn it, otherwise remove it from the world.
            // Anything not taken up by inventory is lost.

            if (obj.isStatic())
                obj.Respawn();
            else
                obj.delete();

            return true;
        }

        public static Item createItem(ItemData datablock)
        {
            ObjectCreator tch = new ObjectCreator("Item");
            tch["dataBlock"] = datablock;
            tch["static"] = true;
            tch["rotate"] = true;
            return tch.Create();
        }

        public override bool onUse(ShapeBase user)
        {
            return false;
        }

        public override void onInventory(ShapeBase user, int value)
        {
        }
    }
}