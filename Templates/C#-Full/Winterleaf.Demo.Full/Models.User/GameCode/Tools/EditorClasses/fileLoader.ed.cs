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

using WinterLeaf.Engine.Classes.Decorations;
using WinterLeaf.Engine.Classes.Interopt;

namespace WinterLeaf.Demo.Full.Models.User.GameCode.Tools.EditorClasses
{
    public class fileLoader
    {
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
            if (!pInvokes.bGlobal["$Scripts::ignoreDSOs"])
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
            string file = pInvokes.Util.findFirstFile(dsopath, false);

            while (file != "")
                {
                //error("  Found File: " @ %file);

                // As we cant exec() a .dso directly, we need to strip that part from the filename
                int pos = pInvokes.Util.strstr(file, "." + dsoType);
                string csfile;
                if (pos != -1)
                    csfile = pInvokes.Util.getSubStr(file, 0, pos);
                else
                    csfile = file;

                pInvokes.Util.exec(csfile, false, false);
                file = pInvokes.Util.findNextFile(dsopath);
                }
        }

        [ConsoleInteraction]
        public static bool compileDirectory(string path, string dsoPath)
        {
            string saveDSOPath = pInvokes.sGlobal["$Scripts::OverrideDSOPath"];
            pInvokes.sGlobal["$Scripts::OverrideDSOPath"] = dsoPath;

            bool dsoReloc = false;

            string file = pInvokes.Util.findFirstFile(path, false);

            //error("Compiling Directory " @ %path @ " ...");
            while (file != "")
                {
                //error("  Found File: " @ %file @ " (" @ getDSOPath(%file) @ ")");
                if (pInvokes.Util.filePath(file) != pInvokes.Util.filePath(pInvokes.Util.getDSOPath(file)))
                    dsoReloc = true;

                pInvokes.Util.compile(file, false);
                file = pInvokes.Util.findNextFile(path);
                }

            pInvokes.sGlobal["$Scripts::OverrideDSOPath"] = saveDSOPath;

            return dsoReloc;
        }

        [ConsoleInteraction]
        public static void listDirectory(string path)
        {
            string file = pInvokes.Util.findFirstFile(path, false);

            pInvokes.Util._echo("Listing Directory " + path + " ...");
            while (file != "")
                {
                pInvokes.Util._echo("  " + file);
                file = pInvokes.Util.findNextFile(path);
                }
        }
    }
}