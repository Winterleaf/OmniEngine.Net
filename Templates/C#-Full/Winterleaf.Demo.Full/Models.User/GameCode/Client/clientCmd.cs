using WinterLeaf.Demo.Full.Models.User.Extendable;
using WinterLeaf.Engine.Classes;
using WinterLeaf.Engine.Classes.Decorations;
using WinterLeaf.Engine.Classes.Extensions;
using WinterLeaf.Engine.Classes.View.Creators;
using WinterLeaf.Engine.Containers;
using WinterLeaf.Engine.Classes.Interopt;

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
                omni.console.commandToServer("SAD", new[] { password });
            }

        [ConsoleInteraction(true)]
        public static void SadSetPassword(string password)
            {
            omni.console.commandToServer("SADSetPassword", new[] { password });
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
        public static void ClientCmdRefreshWeaponHud(string amount, string preview, string ret, string zoomret,
            string amountInClips)
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
                ((GuiBitmapCtrl)"PreviewImage").setBitmapX("art/gui/weaponHud/" + preview);
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
                {
                ZoomReticle.setBitmapX(zoomret == "" ? "" : "art/gui/weaponHud/" + zoomret);
                }
            }

        // ----------------------------------------------------------------------------
        // Vehicle Support
        // ----------------------------------------------------------------------------
        [ConsoleInteraction(true)]
        public static void ClientCmdtoggleVehicleMapToggle(string toggle)
            {
            if (toggle.AsBool())
                {
                omni.dGlobal["$mvForwardAction"] = 0;//Gamepad vehicle stop
                omni.dGlobal["$mvBackwardAction"] = 0;//Gamepad vehicle stop
                ((ActionMap)"moveMap").pop();
                ((ActionMap)"vehicleMap").push();
                }
            else
                {
                ((ActionMap)"moveMap").push();
                ((ActionMap)"vehicleMap").pop();
                }
            }

        [ConsoleInteraction(true)]
        public static void ClientCmdPushVehicleMap()
            {
            ((ActionMap)"moveMap").pop();
            ((ActionMap)"vehicleMap").push();
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
                ((ActionMap)"turretMap").push();
            else
                ((ActionMap)"turretMap").pop();
            }
        }
    }