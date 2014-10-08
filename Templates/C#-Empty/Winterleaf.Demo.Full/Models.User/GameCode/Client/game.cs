using WinterLeaf.Demo.Full.Models.User.Extendable;
using WinterLeaf.Demo.Full.Models.User.GameCode.Client.Audio;
using WinterLeaf.Engine.Classes;
using WinterLeaf.Engine.Classes.Decorations;
using WinterLeaf.Engine.Classes.Extensions;
using WinterLeaf.Engine.Classes.Interopt;

namespace WinterLeaf.Demo.Full.Models.User.GameCode.Client
    {
    public class game
        {
        private static readonly pInvokes omni = new pInvokes();

        [ConsoleInteraction(true)]
        public static void ClientCmdGameEnd(string endgamepause)
            {
            audio.sfxStopAll("");


            if (GuiCanvas.EditorIsActive() || GuiCanvas.GuiEditorIsActive())
                return;
            // Copy the current scores from the player list into the
            // end game gui (bit of a hack for now).
            GuiTextListCtrl EndGameGuiList = "EndGameGuiList";
            EndGameGuiList.clear();

            GuiTextListCtrl PlayerListGuiList = "PlayerListGuiList";

            for (int i = 0; i < PlayerListGuiList.rowCount(); i++)
                {
                string text = PlayerListGuiList.getRowText(i);
                string id = PlayerListGuiList.getRowId(i).AsString();
                EndGameGuiList.addRow(id.AsInt(), text, -1);
                }
            EndGameGuiList.sortNumerical(1, false);
            ((GuiCanvas) "Canvas").setContent("EndGameGui");

            if (endgamepause.AsInt() > 0)
                omni.Util._schedule((endgamepause.AsInt()*1000).AsString(), "0", "ShowLoading");
            }
        }
    }