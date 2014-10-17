using WinterLeaf.Demo.Full.Models.User.Extendable;
using WinterLeaf.Engine;
using WinterLeaf.Engine.Classes;
using WinterLeaf.Engine.Classes.Interopt;

static public class Player_Script
    {
    public static readonly pInvokes omni = new pInvokes();
    static public void playPain(Player player)
        {
        player.playAudio(0, "PainCrySound");
        omni.console.error("The script is doing this!");

        }
    static public void playDeathCry(Player player)
        {
        player.playAudio(0, "DeathCrySound");
        }

    static public void DoSomethingcool(Player player,string myMessage)
        {
        omni.console.error("This is something cool " + myMessage);
        }
    }

 



