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

using WinterLeaf.Demo.Full.Models.User.Extendable;
using WinterLeaf.Engine.Classes.Decorations;
using WinterLeaf.Engine.Classes.Extensions;
using WinterLeaf.Engine.Classes.Interopt;
using WinterLeaf.Engine.Classes.View.Creators;
using WinterLeaf.Engine.Containers;

namespace WinterLeaf.Demo.Full.Models.User.GameCode.Client
{
    public class clientCmd
    {
        private static readonly pInvokes omni = new pInvokes();
        //-----------------------------------------------------------------------------
        // Server Admin Commands
        //-----------------------------------------------------------------------------
        [ConsoleInteraction(true)]
        public static void SAD(string password)
        {
            if (password.Trim() != "")
                omni.console.commandToServer("SAD", new[] {password});
        }

        [ConsoleInteraction(true)]
        public static void SadSetPassword(string password)
        {
            omni.console.commandToServer("SADSetPassword", new[] {password});
        }

        //----------------------------------------------------------------------------
        // Misc server commands
        //----------------------------------------------------------------------------
        [ConsoleInteraction(true)]
        public static void clientCmdSyncClock(string time)
        {
            // Time update from the server, this is only sent at the start of a mission
            // or when a client joins a game in progress.
        }

        //-----------------------------------------------------------------------------
        // Damage Direction Indicator
        //-----------------------------------------------------------------------------
        [ConsoleInteraction(true)]
        public static void clientCmdSetDamageDirection(string direction)
        {
            GuiControl DamageHUD = "DamageHUD";
            if (!DamageHUD.isObject())
                return;
            GuiBitmapCtrl ctrl = DamageHUD.findObjectByInternalName("damage_" + direction, true);
            if (!ctrl.isObject())
                return;

            omni.Util.cancelAll(ctrl);
            ctrl.setVisible(true);
            ctrl.schedule("500", "setVisible", "false");
        }

        //-----------------------------------------------------------------------------
        // Teleporter visual effect
        //-----------------------------------------------------------------------------
        [ConsoleInteraction(true)]
        public static void clientCmdPlayTeleportEffect(Point3F position, SimDataBlock effectDataBlock)
        {
            if (!effectDataBlock.isObject())
                return;
            ObjectCreator tch = new ObjectCreator("Explosion");
            tch["position"] = position.AsString();
            tch["datablock"] = effectDataBlock;
            tch.Create();
        }

        // ----------------------------------------------------------------------------
        // WeaponHUD
        // ----------------------------------------------------------------------------

        // Update the Ammo Counter with current ammo, if not any then hide the counter.
        [ConsoleInteraction(true)]
        public static void ClientCmdSetAmmoAmountHud(string amount, string amountInClips)
        {
            GuiTextCtrl AmmoAmount = "AmmoAmount";
            if (!amount.AsBool())
                AmmoAmount.setVisible(false);
            else
                {
                AmmoAmount.setVisible(true);
                AmmoAmount.setText("Ammo: " + amount + "/" + amountInClips);
                }
        }

        // Here we update the Weapon Preview image & reticle for each weapon.  We also
        // update the Ammo Counter (just so we don't have to call it separately).
        // Passing an empty parameter ("") hides the HUD component.
        [ConsoleInteraction(true)]
        public static void ClientCmdRefreshWeaponHud(string amount, string preview, string ret, string zoomret, string amountInClips)
        {
            amount = omni.Util.detag(amount);
            preview = omni.Util.detag(preview);
            ret = omni.Util.detag(ret);
            zoomret = omni.Util.detag(zoomret);
            amountInClips = omni.Util.detag(amountInClips);

            GuiTextCtrl AmmoAmount = "AmmoAmount";

            if (!amount.AsBool())
                AmmoAmount.setVisible(false);
            else
                {
                if ("AmmoAmount".isObject())
                    {
                    AmmoAmount.setVisible(true);
                    AmmoAmount.setText("Ammo: " + amount + "/" + amountInClips);
                    }
                }

            GuiBitmapBorderCtrl WeaponHUD = "WeaponHUD";

            if (preview.Trim() == "")
                WeaponHUD.setVisible(false);
            else
                {
                WeaponHUD.setVisible(true);
                ((GuiBitmapCtrl) "PreviewImage").setBitmapX("art/gui/weaponHud/" + preview);
                }

            GuiCrossHairHud Reticle = "Reticle";

            if (ret.Trim() == "")
                Reticle.setVisible(false);
            else
                {
                Reticle.setVisible(true);
                Reticle.setBitmapX("art/gui/weaponHud/" + ret);
                }

            GuiCrossHairHud ZoomReticle = "ZoomReticle";

            if ("ZoomReticle".isObject())
                ZoomReticle.setBitmapX(zoomret == "" ? "" : "art/gui/weaponHud/" + zoomret);
        }

        // ----------------------------------------------------------------------------
        // Vehicle Support
        // ----------------------------------------------------------------------------
        [ConsoleInteraction(true)]
        public static void ClientCmdtoggleVehicleMapToggle(string toggle)
        {
            if (toggle.AsBool())
                {
                omni.dGlobal["$mvForwardAction"] = 0; //Gamepad vehicle stop
                omni.dGlobal["$mvBackwardAction"] = 0; //Gamepad vehicle stop
                ((ActionMap) "moveMap").pop();
                ((ActionMap) "vehicleMap").push();
                }
            else
                {
                ((ActionMap) "moveMap").push();
                ((ActionMap) "vehicleMap").pop();
                }
        }

        [ConsoleInteraction(true)]
        public static void ClientCmdPushVehicleMap()
        {
            ((ActionMap) "moveMap").pop();
            ((ActionMap) "vehicleMap").push();
        }

        // ----------------------------------------------------------------------------
        // Turret Support
        // ----------------------------------------------------------------------------

        // Call by the Turret class when a player mounts or unmounts it.
        // %turret = The turret that was mounted
        // %player = The player doing the mounting
        // %mounted = True if the turret was mounted, false if it was unmounted
        [ConsoleInteraction(true)]
        public static void TurretMountCallback(string turret, string player, bool mounted)
        {
            if (mounted)
                ((ActionMap) "turretMap").push();
            else
                ((ActionMap) "turretMap").pop();
        }
    }
}