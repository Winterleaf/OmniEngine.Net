#region

using System.IO;
using Winterleaf.Demo.Full.Dedicated.Models.User.Extendable;
using WinterLeaf.Engine.Classes;
using WinterLeaf.Engine.Classes.Interopt;

#endregion

namespace Winterleaf.Demo.Full.Dedicated.Models.User.GameCode
    {
    public class levelInfo
        {
        //------------------------------------------------------------------------------
        // Loading info is text displayed on the client side while the mission
        // is being loaded.  This information is extracted from the mission file
        // and sent to each the client as it joins.
        //------------------------------------------------------------------------------

        //------------------------------------------------------------------------------
        // clearLoadInfo
        //
        // Clears the mission info stored
        //------------------------------------------------------------------------------

        public static void ClearLoadInfo()
            {
            LevelInfo thelevelinfo = "theLevelInfo";
            if (thelevelinfo.isObject())
                thelevelinfo.delete();
            }

        //------------------------------------------------------------------------------
        // buildLoadInfo
        //
        // Extract the map description from the .mis file
        //------------------------------------------------------------------------------

        public static void BuildLoadInfo(string mission)
            {
            //Replaced the torque file stuff w/ csharp, less stuff inside of torque.
            ClearLoadInfo();
            string missionpath =System.IO. Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory()) + "\\" +
                                 mission.Replace("/", "\\");
            if (File.Exists(missionpath))
                {
                string infoObject = "";
                using (StreamReader sr = new StreamReader(missionpath))
                    {
                    bool inInfoBlock = false;
                    while (sr.Peek() >= 0)
                        {
                        string line = sr.ReadLine();
                        if (line.Trim().StartsWith("new ScriptObject(MissionInfo) {"))
                            inInfoBlock = true;
                        if (line.Trim().StartsWith("new LevelInfo(theLevelInfo) {"))
                            inInfoBlock = true;
                        else if (inInfoBlock && line.Trim().StartsWith("};"))
                            {
                            inInfoBlock = false;
                            infoObject += line;
                            break;
                            }
                        if (inInfoBlock)
                            infoObject += line + " ";
                        }
                    }
                pInvokes.console.Eval(infoObject);
                }
            else
                {
                pInvokes.console.error(string.Format("Level File {0} not found.", mission));
                }
            }

        //------------------------------------------------------------------------------
        // dumpLoadInfo
        //
        // Echo the mission information to the console
        //------------------------------------------------------------------------------

        public static void DumpLoadInfo()
            {
            LevelInfo thelevelinfo = "theLevelInfo";

            pInvokes.console.print("Level Name: " + thelevelinfo["name"]);
            pInvokes.console.print("Level Description:");
            for (int i = 0; thelevelinfo["desc[" + i + "]"] != ""; i++)
                pInvokes.console.print("     " + thelevelinfo["desc[" + i + "]"]);
            }
        }
    }
