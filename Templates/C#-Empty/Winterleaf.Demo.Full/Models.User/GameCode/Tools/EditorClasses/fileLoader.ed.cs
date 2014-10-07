using WinterLeaf.Engine.Classes;
using WinterLeaf.Engine.Classes.Decorations;
using WinterLeaf.Engine.Classes.Interopt;

namespace WinterLeaf.Demo.Full.Models.User.GameCode.Tools.EditorClasses
    {
    public class fileLoader
        {
        public static readonly pInvokes omni = new pInvokes();

        [ConsoleInteraction]
        public static void loadDirectory(string path, string type, string dsoType)
            {
            if (type == "")
                type = "ed.cs";
            if (dsoType == "")
                dsoType = "edso";

            string cspath = path + "/*." + type;

            // Because in a shipping version there will be no .cs files, we can't just
            // find all the cs files and exec them.

            // First we find all the scripts and compile them if there are any
            // In the shipping version, this wont find anything.
            string dsopath;
            if (!omni.bGlobal["$Scripts::ignoreDSOs"])
                {
                bool dsoReloc = compileDirectory(cspath, "");

                // Finally we find all the dsos and exec them instead

                // If the DSOs are relocated by the engine (which will be the case when
                // running the tools) then we need to look for the scripts again.

                if (! dsoReloc)
                    dsopath = path + "/*." + type + "." + dsoType;
                else
                    dsopath = cspath;
                }
            else
                dsopath = cspath;

            //error("Execing Directory " @ %dsopath @ " ...");
            string file = omni.Util.findFirstFile(dsopath, false);

            while (file != "")
                {
                //error("  Found File: " @ %file);

                // As we cant exec() a .dso directly, we need to strip that part from the filename
                int pos = omni.Util.strstr(file, "." + dsoType);
                string csfile;
                if (pos != -1)
                    csfile = omni.Util.getSubStr(file, 0, pos);
                else
                    csfile = file;

                omni.Util.exec(csfile, false, false);
                file = omni.Util.findNextFile(dsopath);
                }
            }

        [ConsoleInteraction]
        public static bool compileDirectory(string path, string dsoPath)
            {
            string saveDSOPath = omni.sGlobal["$Scripts::OverrideDSOPath"];
            omni.sGlobal["$Scripts::OverrideDSOPath"] = dsoPath;

            bool dsoReloc = false;

            string file = omni.Util.findFirstFile(path, false);

            //error("Compiling Directory " @ %path @ " ...");
            while (file != "")
                {
                //error("  Found File: " @ %file @ " (" @ getDSOPath(%file) @ ")");
                if (omni.Util.filePath(file) != omni.Util.filePath(omni.Util.getDSOPath(file)))
                    dsoReloc = true;

                omni.Util.compile(file, false);
                file = omni.Util.findNextFile(path);
                }

            omni.sGlobal["$Scripts::OverrideDSOPath"] = saveDSOPath;

            return dsoReloc;
            }

        [ConsoleInteraction]
        public static void listDirectory(string path)
            {
            string file = omni.Util.findFirstFile(path, false);

            omni.Util._echo("Listing Directory " + path + " ...");
            while (file != "")
                {
                omni.Util._echo("  " + file);
                file = omni.Util.findNextFile(path);
                }
            }
        }
    }