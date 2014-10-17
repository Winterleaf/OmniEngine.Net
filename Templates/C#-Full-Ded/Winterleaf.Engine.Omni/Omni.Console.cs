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
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using WinterLeaf.Engine.Classes.Extensions;
using WinterLeaf.Engine.Classes.Interopt;
using WinterLeaf.Engine.Containers;

#endregion

namespace WinterLeaf.Engine
{
    public sealed partial class Omni
    {
        #region Console

        internal IntPtr _torque_gethwnd()
        {
            return SafeNativeMethods.mtorque_gethwnd();
        }

        ///// <summary>
        /////   This object is used to control threaded access inside of Evaluate, Thread safety.
        ///// </summary>
        //private readonly object _evallock = new object();

        /// <summary>
        ///   Removes the tagged string from Torque.
        /// </summary>
        /// <param name="tag"> </param>
        public void _removeTaggedString(string tag)
        {
            StringBuilder sb = new StringBuilder(tag, 1024);

            SafeNativeMethods.mremoveTaggedString(sb);
        }

        /// <summary>
        ///   This function evaluates a script block and returns the value, It is a carry over and now the Util.eval should be used.
        /// </summary>
        /// <param name="script"> </param>
        /// <param name="returnmeaval"> </param>
        /// <returns> </returns>
        public string Evaluate(string script, bool returnmeaval)
        {
            if (!script.Trim().EndsWith("}"))
                {
                if (!script.Trim().EndsWith(";"))

                    script = script.Trim() + ";";
                }

            script = script.Trim();

            //if (script.Length > 131072)

            //    throw new Exception("Script Block Exceeds 64k characters");

            const string varnam = "%t";

            bool dovalcatch = false;

            if ((script.Contains('=')) || !returnmeaval)

                dovalcatch = false;

            else
                {
                if (script.Contains("[") || script.Contains("("))

                    dovalcatch = true;
                }

            if (dovalcatch)
                {
                script = varnam + "=" + script + ";return %t;";

                StringBuilder s = new StringBuilder(script);

                StringBuilder r = new StringBuilder(4096);

                SafeNativeMethods.mConsoleCall(s, r, Debugging);

                return r.ToString();
                }

            else
                {
                StringBuilder s = new StringBuilder(script, 131072);

                StringBuilder r = new StringBuilder(4096);

                SafeNativeMethods.mConsoleCall(s, r, Debugging);

                return r.ToString();
                }
        }

        /// <summary>
        ///   Gets a tagged string object from torque.
        /// </summary>
        /// <param name="tag"> </param>
        /// <returns> </returns>
        public string GetTaggedString(string tag)
        {
            StringBuilder t = new StringBuilder(tag, 1024);

            StringBuilder ret = new StringBuilder(4096);

            SafeNativeMethods.mgetTaggedString(t, ret);

            return ret.ToString();
        }

        //Handles getting variables from the engine.

        /// <summary>
        ///   Adds the passed string to the Torques Tagged String list.
        /// </summary>
        /// <param name="mystring"> </param>
        /// <returns> </returns>
        public string AddTaggedString(string mystring)
        {
            //fun days...
            //we need to encode colors.
            StringBuilder newstring = new StringBuilder();

            for (int i = 0; i < mystring.Length; i++)
                {
                if (mystring[i] == '\\')
                    {
                    if ((mystring[i + 1] == 'c') || (mystring[i + 1] == 'C'))
                        {
                        switch (mystring[i + 2])
                            {
                                case '0':

                                    newstring.Append((char) 2);

                                    newstring.Append((char) 1);

                                    i = i + 2;

                                    break;

                                case '1':

                                    newstring.Append((char) 2);

                                    i = i + 2;

                                    break;

                                case '2':

                                    newstring.Append((char) 3);

                                    i = i + 2;

                                    break;

                                case '3':

                                    newstring.Append((char) 4);

                                    i = i + 2;

                                    break;

                                case '4':

                                    newstring.Append((char) 5);

                                    i = i + 2;

                                    break;

                                case '5':

                                    newstring.Append((char) 6);

                                    i = i + 2;

                                    break;

                                case '6':

                                    newstring.Append((char) 7);

                                    i = i + 2;

                                    break;

                                case '7':

                                    newstring.Append((char) 11);

                                    i = i + 2;

                                    break;

                                case '8':

                                    newstring.Append((char) 12);

                                    i = i + 2;

                                    break;

                                case '9':

                                    newstring.Append((char) 14);

                                    i = i + 2;

                                    break;

                                default:

                                    newstring.Append(mystring[i]);

                                    break;
                            }
                        }

                    else

                        newstring.Append(mystring[i]);
                    }
                else
                    newstring.Append(mystring[i]);
                }

            StringBuilder ms = new StringBuilder(newstring.ToString(), 4096);

            if (mystring.Length > 4096)

                throw new Exception("String exceed length of 4096");

            StringBuilder r = new StringBuilder(4096);

            SafeNativeMethods.maddTaggedString(ms, r);

            return r.ToString();
        }

        /// <summary>
        ///   Posts a message inside of the Torque console as a warning.
        /// </summary>
        /// <param name="message"> </param>
        public void Warn(string message)
        {
            if (SafeNativeMethods.mConsole_warnf == null)
                return;
            if (message.Length > 4096)

                throw new Exception("Message Length exceeds 4096 characters");

            StringBuilder s = new StringBuilder(message, 4096);

            SafeNativeMethods.mConsole_warnf(s);
        }

        /// <summary>
        ///   Posts a message inside of the Troque console as a Print.
        /// </summary>
        /// <param name="message"> </param>
        public void Print(string message)
        {
            if (SafeNativeMethods.mConsole_printf == null)
                return;
            if (message.Length > 4096)

                throw new Exception("Message Length exceeds 4096 characters");

            StringBuilder s = new StringBuilder(message, 4096);

            SafeNativeMethods.mConsole_printf(s);
        }

        /// <summary>
        ///   Posts a message inside of the Torque console as a Error.
        /// </summary>
        /// <param name="message"> </param>
        public void Error(string message)
        {
            if (SafeNativeMethods.mConsole_errorf == null)
                return;
            if (message.Length > 4096)

                throw new Exception("Message Length exceeds 4096 characters");

            StringBuilder s = new StringBuilder(message, 4096);

            SafeNativeMethods.mConsole_errorf(s);
        }

        /// <summary>
        ///   Deletes the variable from Torques Memory.
        /// </summary>
        /// <param name="global_variable"> </param>
        public void DeleteVariables(string global_variable)
        {
            StringBuilder sb = new StringBuilder(global_variable, 4096);

            SafeNativeMethods.mdeleteVariables(sb);
        }

        /// <summary>
        ///   Returns true or false if the object passed has the function.
        /// </summary>
        /// <param name="simobject"> </param>
        /// <param name="method"> </param>
        /// <returns> </returns>
        public bool ObjectHasMethod(string simobject, string method)
        {
            if (simobject.Contains('.'))
                simobject = GetVar(simobject);

            StringBuilder s = new StringBuilder(simobject, 4096);

            StringBuilder m = new StringBuilder(method, 4096);

            bool r = SafeNativeMethods.mobjectHasMethod(s, m);

            return r;
        }

        /// <summary>
        ///   Returns true or false if the function exists inside of Torque.
        /// </summary>
        /// <param name="function_name"> </param>
        /// <returns> </returns>
        public bool IsFunction(string function_name)
        {
            if (function_name.Length > 4096)

                throw new Exception("Function name exceeds 4096");

            StringBuilder sb = new StringBuilder(function_name, 4096);

            bool result = SafeNativeMethods.misFunction(sb);

            return result;
        }

        /// <summary>
        ///   Gets the ID (UINT32) of the object passed.
        /// </summary>
        /// <param name="simobj_id"> </param>
        /// <returns> </returns>
        public UInt32 GetObjectID(string simobj_id)
        {
            if (simobj_id.Contains('.'))
                simobj_id = GetVar(simobj_id);

            StringBuilder ss = new StringBuilder(simobj_id, 4096);

            UInt32 id = SafeNativeMethods.mGetObjectID(ss);

            return id;
        }

        /// <summary>
        ///   Calls PathOnMissionLoadDone inside of Torque
        /// </summary>
        public void PathOnMissionLoadDone()
        {
            SafeNativeMethods.mpathOnMissionLoadDone();
        }

        /// <summary>
        ///   Calls ClearServerPaths inside of Torque
        /// </summary>
        public void ClearServerPaths()
        {
            SafeNativeMethods.mclearServerPaths();
        }

        /// <summary>
        ///   Returns the datablock id to the passed simobject.
        /// </summary>
        /// <param name="simobject"> </param>
        /// <returns> </returns>
        public UInt32 GetDatablock(string simobject)
        {
            if (simobject.Contains('.'))
                simobject = GetVar(simobject);
            StringBuilder sb = new StringBuilder(simobject, 4096);
            UInt32 d = SafeNativeMethods.mgetDataBlock(sb);
            return d;
        }

        /// <summary>
        ///   Gets the name of the object passed, usually the ID of an object.
        /// Note this function accepts compound simobjects... 
        /// 
        /// i.e. 
        /// player.client
        /// 1233.client.3
        /// 123.3.3
        ///  
        /// </summary>
        /// <param name="simobject"> </param>
        /// <returns> </returns>
        public string GetName(string simobject)
        {
            if ((simobject.StartsWith("$")) || (!simobject.Contains('.')))

                return _getName_(simobject);

            string[] parts = simobject.Split('.');
            string v1 = parts[0];

            for (int i = 1; i <= parts.GetUpperBound(0); i++)
                {
                if (parts[i].Trim() == "")
                    continue;

                v1 = __GetVar(v1 + "." + parts[i]);

                if (v1 == "")

                    break;
                }

            return v1.Trim() != "" ? _getName_(v1) : "";
        }

        private string _getName_(string simobject)
        {
            string itemname = simobject;

            if (!simobject.IsNumeric())
                return itemname;

            StringBuilder re = new StringBuilder(4096);

            SafeNativeMethods.mgetName(simobject.AsUint(), re);

            itemname = re.ToString().Trim();

            return itemname;
        }

        /// <summary>
        ///   Gets the ID of the name passed.
        /// </summary>
        /// <param name="name"> </param>
        /// <returns> </returns>
        public Int32 NameToId(string name)
        {
            StringBuilder n = new StringBuilder(name, 4096);

            Int32 r = SafeNativeMethods.mnameToID(n);

            return r;
        }

        /// <summary>
        ///   Determines if the classname is a member of the superclassname
        /// </summary>
        /// <param name="classname"> </param>
        /// <param name="superclassname"> </param>
        /// <returns> </returns>
        public bool IsMemberOfClass(string classname, string superclassname)
        {
            if (classname.Length > 4096)

                throw new Exception("Classname exceeds 4096 characters");

            if (superclassname.Length > 4096)

                throw new Exception("SuperClassName exceeds 4096");

            StringBuilder cs = new StringBuilder(classname, 4096);

            StringBuilder scn = new StringBuilder(superclassname, 4096);

            bool r = SafeNativeMethods.misMemberOfClass(cs, scn);

            return r;
        }

        /// <summary>
        ///   Calls Torque's spawn object code.
        /// </summary>
        /// <param name="spawnClass"> </param>
        /// <param name="spawnDataBlock"> </param>
        /// <param name="spawnName"> </param>
        /// <param name="spawnProperties"> </param>
        /// <param name="spawnScript"> </param>
        /// <returns> </returns>
        public UInt32 SpawnObject(string spawnClass, string spawnDataBlock, string spawnName, string spawnProperties, string spawnScript)
        {
            StringBuilder sc = new StringBuilder(spawnClass, 4096);

            StringBuilder spb = new StringBuilder(spawnDataBlock, 4096);

            StringBuilder sn = new StringBuilder(spawnName, 4096);

            StringBuilder sp = new StringBuilder(spawnProperties, 4096);

            StringBuilder ss = new StringBuilder(spawnScript, 4096);

            UInt32 result = 0;

            result = SafeNativeMethods.mspawnObject(sc, spb, sn, sp, ss);

            return result;
        }

        /// <summary>
        ///   Gets the classname of the simobject.
        /// </summary>
        /// <param name="simobject"> </param>
        /// <returns> </returns>
        public string GetClassName(string simobject)
        {
            StringBuilder so = new StringBuilder(simobject, 4096);

            StringBuilder ret = new StringBuilder(4096);

            SafeNativeMethods.mgetClassName(so, ret);

            return ret.ToString();
        }

        /// <summary>
        ///   Calls a function on a object in a parent package for the object. So.. function AIPlayer::something(%this) { Parent::SomeThing(%this); }
        /// </summary>
        /// <param name="simobject"> </param>
        /// <param name="function"> </param>
        /// <param name="namespacedepth"> How many parents to go up. </param>
        /// <param name="parameters"> </param>
        /// <param name="donotpassdepth"> Use this flag, when the parent being called is a C++ function. </param>
        /// <returns> </returns>
        public string ConsoleCallParent(string simobject, string function, int namespacedepth, string[] parameters, bool donotpassdepth = false)
        {
            if (simobject.Contains('.'))
                simobject = GetVar(simobject);

            StringBuilder so = new StringBuilder(simobject, 1024);

            StringBuilder f = new StringBuilder(function, 1024);

            StringBuilder ret = new StringBuilder("", 1024);

            List<IntPtr> myp = new List<IntPtr>();

            string[] newparams = new string[parameters.GetUpperBound(0) + (donotpassdepth ? 2 : 3)];

            newparams[0] = "";

            if (!donotpassdepth)

                newparams[parameters.GetUpperBound(0) + 2] = namespacedepth.ToString(CultureInfo.InvariantCulture);

            int c = 1;

            foreach (string p in parameters)
                {
                if (parameters[c - 1] == "")

                    newparams[c] = " ";

                else

                    newparams[c] = parameters[c - 1];

                c++;
                }

            myp.AddRange(newparams.Select(Marshal.StringToCoTaskMemAnsi));

            SafeNativeMethods.mParentCall(so, f, namespacedepth, ret, myp.Count, myp.ToArray(), Debugging);

            foreach (IntPtr ptr in myp)

                Marshal.FreeCoTaskMem(ptr);

            return ret.ToString();
        }

        /// <summary>
        ///   Calls a parent function to a global function.
        /// </summary>
        /// <param name="function"> </param>
        /// <param name="namespacedepth"> </param>
        /// <param name="parameters"> </param>
        /// <param name="DoNotPassDepth"> </param>
        /// <returns> </returns>
        public string ConsoleCallParent(string function, int namespacedepth, string[] parameters, bool DoNotPassDepth = false)
        {
            StringBuilder f = new StringBuilder(function, 1024);

            StringBuilder ret = new StringBuilder("", 1024);

            List<IntPtr> myp = new List<IntPtr>();

            string[] newparams = new string[parameters.GetUpperBound(0) + (DoNotPassDepth ? 2 : 3)];

            newparams[0] = "";

            if (!DoNotPassDepth)

                newparams[parameters.GetUpperBound(0) + 2] = namespacedepth.ToString(CultureInfo.InvariantCulture);

            int c = 1;

            foreach (string p in parameters)
                {
                if (parameters[c - 1] == "")

                    newparams[c] = " ";

                else

                    newparams[c] = parameters[c - 1];

                c++;
                }

            myp.AddRange(newparams.Select(Marshal.StringToCoTaskMemAnsi));

            SafeNativeMethods.mParentCallFunct(f, namespacedepth, ret, myp.Count, myp.ToArray(), Debugging);

            foreach (IntPtr ptr in myp)

                Marshal.FreeCoTaskMem(ptr);

            return ret.ToString();
        }

        /// <summary>
        ///   This function is a generic handler for the Object::Function() syntax. The classname is really a misnomer since it can be a classname, package or simobject.
        /// </summary>
        /// <param name="classname"> </param>
        /// <param name="function"> </param>
        /// <param name="parameters"> </param>
        /// <returns> </returns>
        public string ConsoleCallCn(string classname, string function, string[] parameters)
        {
            if (classname.IsNumeric())
                classname = GetName(classname);

            StringBuilder cn = new StringBuilder(classname);

            StringBuilder f = new StringBuilder(function, 1024);

            StringBuilder ret = new StringBuilder("", 1024);

            List<IntPtr> myp = new List<IntPtr>();

            string[] newparams = new string[parameters.GetUpperBound(0) + 2];

            newparams[0] = "";

            int c = 1;

            foreach (string p in parameters)
                {
                if ((parameters[c - 1] == "") || (parameters[c - 1] == "(null)"))

                    newparams[c] = " ";

                else

                    newparams[c] = parameters[c - 1];

                if (newparams[c] == null)
                    newparams[c] = " ";

                c++;
                }

            myp.AddRange(newparams.Select(Marshal.StringToCoTaskMemAnsi));

            SafeNativeMethods.mClassname_Call(cn, f, myp.Count, myp.ToArray(), ret, Debugging);

            foreach (IntPtr ptr in myp)

                Marshal.FreeCoTaskMem(ptr);

            return ret.ToString();
        }

        /// <summary>
        ///   Sends the command to client just like TorqueScript's function.
        /// </summary>
        /// <param name="client"> </param>
        /// <param name="function"> </param>
        /// <param name="parameters"> </param>
        public void CommandToClient(string client, string function, string[] parameters)
        {
            if (client.LastIndexOf('.') > 0)

                client = GetVar(client);

            function = (byte) function[0] == (byte) 1 ? function : AddTaggedString(function);

            string[] newparams = new string[parameters.GetUpperBound(0) + 4];

            newparams[0] = "CommandToClient";

            newparams[1] = client;

            newparams[2] = function;

            int c = 3;

            foreach (string p in parameters)
                {
                if (parameters[c - 3] == "")

                    newparams[c] = " ";

                else
                    {
                    newparams[c] = parameters[c - 3];

                    if (parameters[c - 3].ToLower() == "true")

                        newparams[c] = "1";

                    if (parameters[c - 3].ToLower() == "false")

                        newparams[c] = "0";
                    }

                c++;
                }

            List<IntPtr> myp = new List<IntPtr>();

            myp.AddRange(newparams.Select(Marshal.StringToCoTaskMemAnsi));

            SafeNativeMethods.mcommandToClient(myp.Count, myp.ToArray());

            foreach (IntPtr ptr in myp)

                Marshal.FreeCoTaskMem(ptr);
        }

        /// <summary>
        ///   Sends a command to the server just like the TorqueScript function.
        /// </summary>
        /// <param name="function"> </param>
        /// <param name="parameters"> </param>
        public void CommandToServer(string function, string[] parameters)
        {
            function = (byte) function[0] == (byte) 1 ? function : AddTaggedString(function);

            string[] newparams = new string[parameters.GetUpperBound(0) + 3];

            newparams[0] = "CommandToServer";

            newparams[1] = function;

            int c = 2;

            foreach (string p in parameters)
                {
                if (parameters[c - 2] == "")

                    newparams[c] = " ";

                else

                    newparams[c] = parameters[c - 2];

                if (parameters[c - 2].ToLower() == "true")

                    newparams[c] = "1";

                if (parameters[c - 2].ToLower() == "false")

                    newparams[c] = "0";

                c++;
                }

            List<IntPtr> myp = new List<IntPtr>();

            myp.AddRange(newparams.Select(Marshal.StringToCoTaskMemAnsi));

            SafeNativeMethods.mcommandToServer(myp.Count, myp.ToArray());

            foreach (IntPtr ptr in myp)

                Marshal.FreeCoTaskMem(ptr);
        }

        /// <summary>
        ///   Returns the simtime from Torque.
        /// </summary>
        /// <returns> </returns>
        public int ConsoleGetSimTime()
        {
            return SafeNativeMethods.mConsole_getSimTime();
        }

        /// <summary>
        ///   Determines if the id or name passed is an object. Note: handles player.client
        /// </summary>
        /// <param name="simobjectid"> </param>
        /// <returns> </returns>
        public bool IsObject(string simobjectid)
        {
            if (simobjectid == null)
                return false;
            if (simobjectid.IndexOf('.') > 1)
                simobjectid = GetVar(simobjectid);

            if (simobjectid == "0")
                return false;

            StringBuilder sod = new StringBuilder(simobjectid, 4096);

            bool m = SafeNativeMethods.misObject(sod);
            return m;
        }

        /// <summary>
        ///   Determines if the simobject has the field passed.
        /// </summary>
        /// <param name="simobjectId"> </param>
        /// <param name="fieldname"> </param>
        /// <returns> </returns>
        public bool SimObjectIsField(string simobjectId, string fieldname)
        {
            if (simobjectId.Contains('.'))
                simobjectId = GetVar(simobjectId);

            StringBuilder sb = new StringBuilder(simobjectId, 1024);

            StringBuilder fn = new StringBuilder(fieldname, 1024);

            bool r = false;

            r = SafeNativeMethods.mSimObject_isField(sb, fn);

            return r;
        }

        /// <summary>
        ///   Determines if the namespace passed has the function.
        /// </summary>
        /// <param name="namespaceorObject"> </param>
        /// <param name="method"> </param>
        /// <returns> </returns>
        public bool NameSpaceIsMethod(string namespaceorObject, string method)
        {
            StringBuilder sb = new StringBuilder(namespaceorObject, 1024);

            StringBuilder m = new StringBuilder(method, 1024);

            bool r = SafeNativeMethods.mNameSpace_isMethod(sb, m);

            return r;
        }

        public bool NameSpaceIsInNamespaceHierarchy(string simobjectId, string name)
        {
            StringBuilder sb = new StringBuilder(simobjectId, 1024);

            StringBuilder n = new StringBuilder(name, 1024);

            bool r = SafeNativeMethods.mNameSpace_isInNamespaceHierarchy(sb, n);

            return r;
        }

        /// <summary>
        ///   Customized container radius search which returns a list of simobject ID's in the radius.
        /// </summary>
        /// <param name="p"> </param>
        /// <param name="searchradius"> </param>
        /// <param name="searchmask"> </param>
        /// <param name="useclientcontainer"> </param>
        /// <returns> </returns>
        public List<UInt32> ContainerRadiusSearch(Point3F p, double searchradius, UInt32 searchmask, bool useclientcontainer)
        {
            uint[] foundid = new UInt32[100];

            List<uint> lid = new List<uint>();

            Int32 countof = SafeNativeMethods.mContainerRadiusSearch(p.x, p.y, p.z, (float) searchradius, searchmask, useclientcontainer, foundid);

            if (countof <= 0)
                return lid;
            for (int i = 0; i < foundid.GetUpperBound(0); i++)

                lid.Add(foundid[i]);

            return lid;
        }

        #region GetVar

        /// <summary>
        /// 
        /// </summary>
        /// <param name="variable"></param>
        /// <returns></returns>
        public string GetVar(string variable)
        {
            return _GetVar(variable);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="variable"></param>
        /// <returns></returns>
        private string _GetVar(string variable)
        {
            variable = variable.TrimStart();
            if (variable == string.Empty)

                return string.Empty;

            if ((variable[0] == '$') || variable.IndexOf('.') == -1)

                return __GetVar(variable);

            variable = variable.Replace(" ", "");

            #region Compound Variable

            string[] stack = variable.Split('.');

            string result = stack[0];

            int counter = 1;

            int stackupperbound = stack.GetUpperBound(0);

            while (counter <= stackupperbound)
                {
                string fieldname = stack[counter];

                counter++;

                int index = -1;

                if (fieldname.IndexOf('[') > -1)
                    {
                    string[] indexes = fieldname.Split('[');

                    string indexv = indexes[1].Replace("]", "");

                    if (indexv.IsNumeric())
                        {
                        index = indexv.AsInt();

                        fieldname = indexes[0];
                        }
                    }

                result = fn_SimObject_getFieldValue(result, fieldname, index);
                }

            #endregion

            return result;
        }

        private string __GetVar(string variable)
        {
            if (variable.Length > 4096)

                throw new Exception("Variable Name exceeds 4096 characters.");

            StringBuilder s = new StringBuilder(variable, 4096);

            if (s[0] == '$')
                s = s.Replace('[', ' ').Replace(']', ' ').Replace(" ", "");

            StringBuilder r = new StringBuilder(4096);

            SafeNativeMethods.mcs_torque_getvariable(s, r);

            string result = r.ToString().Trim();
#if DEBUG
            if (Debugging)

                Console.WriteLine("Requested Variable:'" + s + "' Response was:'" + result + "'");
#endif
            return result;
        }

        #endregion

        #region SetVar

        #region

        public void SetVar(string variable, double value)
        {
            _SetVar(variable, value.AsString(), true);
        }

        public void SetVar(string variable, Int16 value)
        {
            _SetVar(variable, value.AsString(), true);
        }

        public void SetVar(string variable, float value)
        {
            _SetVar(variable, value.AsString(), true);
        }

        public void SetVar(string variable, Int32 value)
        {
            _SetVar(variable, value.AsString(), true);
        }

        public void SetVar(string variable, Int64 value)
        {
            _SetVar(variable, value.AsString(), true);
        }

        public void SetVar(string variable, UInt16 value)
        {
            _SetVar(variable, value.AsString(), true);
        }

        public void SetVar(string variable, UInt32 value)
        {
            _SetVar(variable, value.AsString(), true);
        }

        public void SetVar(string variable, UInt64 value)
        {
            _SetVar(variable, value.AsString(), true);
        }

        public void SetVar(string variable, bool value)
        {
            _SetVar(variable, value.AsString(), true);
        }

        public void SetVar(UInt32 variable, string value)
        {
            _SetVar(variable.AsString(), value);
        }

        public void SetVar(UInt32 variable, Int16 value)
        {
            _SetVar(variable.AsString(), value.AsString());
        }

        public void SetVar(UInt32 variable, Int32 value)
        {
            _SetVar(variable.AsString(), value.AsString());
        }

        public void SetVar(UInt32 variable, Int64 value)
        {
            _SetVar(variable.AsString(), value.AsString());
        }

        public void SetVar(UInt32 variable, UInt16 value)
        {
            _SetVar(variable.AsString(), value.AsString());
        }

        public void SetVar(UInt32 variable, UInt32 value)
        {
            _SetVar(variable.AsString(), value.AsString());
        }

        public void SetVar(UInt32 variable, UInt64 value)
        {
            _SetVar(variable.AsString(), value.AsString());
        }

        public void SetVar(UInt32 variable, bool value)
        {
            _SetVar(variable.AsString(), value.ToString(CultureInfo.InvariantCulture));
        }

        public void SetVar(string variable, string value)
        {
            _SetVar(variable, value, true);
        }

        #endregion

        private void _SetVar(string variable, string value, bool check = false)
        {
            variable = variable.TrimStart();
            if (variable.StartsWith("$") || (!variable.Contains('.')))
                {
                __SetVar(variable, value);

                return;
                }

            #region variable is compound i.e. %varname.test.t

            string[] parts = variable.Split('.');

            string leftMostSimObject = parts[0];

            for (int i = 1; i <= parts.GetUpperBound(0) - 1; i++)
                {
                if (parts[i] == string.Empty)
                    continue;

                leftMostSimObject = GetVar(leftMostSimObject + "." + parts[i]);

                if (leftMostSimObject == string.Empty)

                    break;
                }

            if (leftMostSimObject == string.Empty)
                return;

            string property = parts[parts.GetUpperBound(0)]; //grabs client

            int index = -1;

            if (property.Contains('['))
                {
                string[] pstack = property.Split('[');

                string idxs = pstack[1].Replace("]", string.Empty);

                if (idxs.IsNumeric())
                    {
                    property = pstack[0];

                    index = idxs.AsInt();
                    }
                }

            fn_SimObject_setFieldValue(leftMostSimObject, property, value, index);

            #endregion
        }

        private void __SetVar(string variable, string value)
        {
            string tvalue = value.ToLower();

            if (tvalue == "false")

                value = "0";

            if (tvalue == "true")

                value = "1";

            if (variable.Length > 4096)

                throw new Exception("Variable Name exceeds 4096 characters.");

            StringBuilder s = new StringBuilder(variable, 4096);

            if (s[0] == '$')
                s = s.Replace('[', ' ').Replace(']', ' ').Replace(" ", "");

            StringBuilder r = new StringBuilder(value, 4096);

            SafeNativeMethods.mcs_torque_setvariable(s, r);
#if DEBUG
            if (!Debugging)
                return;

            Console.WriteLine("Setting variable: '" + s + "' to value: '" + r + "'");

            r = new StringBuilder(4096);

            SafeNativeMethods.mcs_torque_getvariable(s, r);

            if (r.ToString() == value)
                return;

            Error("Failed to update variable '" + s + "' to '" + value + "' the check value was '" + r + "'.");

            Console.WriteLine("Failed to update variable '" + s + "' to '" + value + "' the check value was '" + r + "'.");
#endif
        }

        #endregion

        #endregion

        #region "Scene Object Helpers"

        /// <summary>
        ///   Get's the mask type of the object.
        /// </summary>
        /// <param name="sceneObject"> </param>
        /// <returns> </returns>
        public UInt32 SceneObjectGetTypeMask(string sceneObject)
        {
            if (sceneObject.Contains('.'))
                sceneObject = GetVar(sceneObject);
            StringBuilder so = new StringBuilder(sceneObject, 1024);

            UInt32 r;

            r = SafeNativeMethods.mSceneObject_getTypeMask(so);

            return r;
        }

        /// <summary>
        ///   Does a raidus search for a specified simobject type.
        /// </summary>
        /// <param name="pos"> </param>
        /// <param name="radius"> </param>
        /// <param name="mask"> </param>
        /// <param name="useclientcontainer"> </param>
        /// <returns> </returns>
        public Dictionary<uint, float> SceneObjectInitContainerRadiusSearch(Point3F pos, float radius, UInt32 mask, bool useclientcontainer)
        {
            uint[] results = new uint[500];

            float[] disresults = new float[500];

            SafeNativeMethods.mSceneObject_initContainerRadiusSearch(pos.x, pos.y, pos.z, radius, mask, useclientcontainer, results, disresults);

            Dictionary<uint, float> r = new Dictionary<uint, float>();

            for (int i = 0; i < 500; i++)
                {
                if (results[i] != 0)

                    r.Add(results[i], disresults[i]);

                else

                    break;
                }

            return r;
        }

        #endregion

        #region "Client Group Helpers"

        /// <summary>
        ///   Gets the number of objects in the client group.
        /// </summary>
        /// <returns> </returns>
        public UInt32 ClientGroupGetCount()
        {
            uint r = SafeNativeMethods.mclientGroup_getCount();

            return r;
        }

        /// <summary>
        ///   Gets the specified object back from the client group.
        /// </summary>
        /// <param name="index"> </param>
        /// <returns> </returns>
        public UInt32 ClientGroupGetObject(UInt32 index)
        {
            uint r = SafeNativeMethods.mclientGroup_getObject(index);

            return r;
        }

        #endregion

        /// <summary>
        ///   Executes the function with the passed parameters.
        /// </summary>
        /// <param name="function"> </param>
        /// <param name="parameters"> </param>
        /// <returns> </returns>
        public string Execute(string function, string[] parameters)
        {
            StringBuilder ret = new StringBuilder(4096);

            string[] newparams = parameters.GetUpperBound(0) == -1 ? new string[1] : new string[parameters.GetUpperBound(0) + 2];

            newparams[0] = function;

            int c = 1;
            for (int i = 0; i < parameters.Count(); i++)
                {
                if (parameters[c - 1] == "")

                    newparams[c] = " ";

                else
                    {
                    newparams[c] = parameters[c - 1];

                    if (parameters[c - 1].ToLower() == "true")

                        newparams[c] = "1";

                    if (parameters[c - 1].ToLower() == "false")

                        newparams[c] = "0";
                    }

                c++;
                }

            List<IntPtr> myp = new List<IntPtr>();

            myp.AddRange(newparams.Select(Marshal.StringToCoTaskMemAnsi));

            SafeNativeMethods.mexecute(newparams.Count(), myp.ToArray(), ret);

            foreach (IntPtr intPtr in myp)

                Marshal.FreeCoTaskMem(intPtr);

            return ret.ToString();
        }

        /// <summary>
        ///   Calls the member function on the simobject with the passed parameters.
        /// </summary>
        /// <param name="simobject"> </param>
        /// <param name="function"> </param>
        /// <param name="parameters"> </param>
        /// <returns> </returns>
        public string SimObjectCall(string simobject, string function, string[] parameters)
        {
            if (simobject.Contains('.'))

                simobject = GetVar(simobject);

            StringBuilder so = new StringBuilder(simobject, 1024);

            StringBuilder ret = new StringBuilder(4096);

            string[] newparams = new string[parameters.GetUpperBound(0) + 3];

            newparams[0] = function;

            newparams[1] = "";

            int c = 2;
            for (int i = 0; i < parameters.Count(); i++)
                {
                if (parameters[c - 2] == "")

                    newparams[c] = " ";

                else
                    {
                    newparams[c] = parameters[c - 2];

                    if (parameters[c - 2].ToLower() == "true")

                        newparams[c] = "1";

                    if (parameters[c - 2].ToLower() == "false")

                        newparams[c] = "0";
                    }

                c++;
                }

            List<IntPtr> myp = new List<IntPtr>();

            myp.AddRange(newparams.Select(Marshal.StringToCoTaskMemAnsi));

            SafeNativeMethods.mSimObject_Call(so, newparams.Count(), myp.ToArray(), ret);

            foreach (IntPtr intPtr in myp)

                Marshal.FreeCoTaskMem(intPtr);

            return ret.ToString();
        }

        /// <summary>
        ///   Calls the member function on the simobject with the passed parameters.
        /// </summary>
        /// <param name="simobject"> </param>
        /// <param name="function"> </param>
        /// <param name="parameters"> </param>
        /// <returns> </returns>
        public string SimObjectCallScript(string simobject, string function, string[] parameters)
        {
            if (simobject.Contains('.'))

                simobject = GetVar(simobject);

            StringBuilder so = new StringBuilder(simobject, 1024);

            StringBuilder ret = new StringBuilder(4096);

            string[] newparams = new string[parameters.GetUpperBound(0) + 3];

            newparams[0] = function;

            newparams[1] = "";

            int c = 2;

            for (int i = 0; i < parameters.Count(); i++)
                {
                if (parameters[c - 2] == "")

                    newparams[c] = " ";

                else
                    {
                    newparams[c] = parameters[c - 2] ?? "";

                    if (parameters[c - 2].ToLower() == "true")

                        newparams[c] = "1";

                    if (parameters[c - 2].ToLower() == "false")

                        newparams[c] = "0";
                    }

                c++;
                }

            List<IntPtr> myp = new List<IntPtr>();

            myp.AddRange(newparams.Select(Marshal.StringToCoTaskMemAnsi));

            SafeNativeMethods.mSimObject_CallScript(so, newparams.Count(), myp.ToArray(), ret);

            foreach (IntPtr intPtr in myp)

                Marshal.FreeCoTaskMem(intPtr);

            return ret.ToString();
        }

        /// <summary>
        ///   Gets Eular Rotation.
        /// </summary>
        /// <param name="simobject"> </param>
        /// <returns> </returns>
        public TransformF GetEulerRotation(string simobject)
        {
            StringBuilder sb = new StringBuilder(simobject, 4096);

            const double x = 0;

            const double y = 0;

            const double z = 0;

            SafeNativeMethods.mgetEulerRotation(sb, (float) x, (float) y, (float) z);

            TransformF ret = new TransformF((float) x, (float) y, (float) z);

            return ret;
        }

        /// <summary>
        ///   Create Matrix from Euler.
        /// </summary>
        /// <param name="transform"> </param>
        /// <returns> </returns>
        public TransformF MathMatrixCreateFromEuler(TransformF transform)
        {
            StringBuilder ret = new StringBuilder(1024);

            SafeNativeMethods.mMath_MatrixCreateFromEuler(transform.mOrientationX, transform.mOrientationY, transform.mOrientationZ, ret);

            return new TransformF(ret.ToString());
        }

        /// <summary>
        ///   Creates Matrix from vector.
        /// </summary>
        /// <param name="transform"> </param>
        /// <param name="vector"> </param>
        /// <returns> </returns>
        public TransformF MathMatrixMulVector(TransformF transform, Point3F vector)
        {
            float x = transform.mPositionX;

            float y = transform.mPositionY;

            float z = transform.mPositionZ;

            float ang = transform.MAngle;

            float ax = transform.mOrientationX;

            float ay = transform.mOrientationY;

            float az = transform.mOrientationZ;

            float xx = vector.x;

            float yy = vector.y;

            float zz = vector.z;

            StringBuilder ret = new StringBuilder(1024);

            SafeNativeMethods.mMath_MatrixMulVector(x, y, z, ang, ax, ay, az, xx, yy, zz, ret);

            TransformF r = new TransformF(ret.ToString());

            return r;
        }
    }
}