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

using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Permissions;
using System.Threading;
using System.Xml.Linq;
using WinterLeaf.Engine.Classes.Helpers;

namespace WinterLeaf.Engine.Classes.LiveScripts
{
    /// <summary>
    /// This class is implemented as a Threaded Singleton.
    /// Its primary purpose is to Monitor the location set in the
    /// game folder for XML and CS files and recompile them 
    /// whenever they change.
    /// </summary>
    public class csFactory
    {
        #region Constructors

        #region Private

        /// <summary>
        /// In the singleton design the you do not create the object using a constructor.
        /// </summary>
        private csFactory()
        {
        }

        #endregion

        #endregion

        #region Enumerations

        #region Private

        private enum filetype
        {
            CS,
            XML,
            UNKOWN
        }

        #endregion

        #endregion

        #region Variables

        #region Private

        /// <summary>
        /// Used for the Singleton Implementation
        /// </summary>
        private static volatile csFactory _instance;

        /// <summary>
        /// Used for the Singleton Implementation
        /// </summary>
        private static readonly object syncRoot = new object();

        /// <summary>
        /// The file System Watcher object that watches the Location specified for CS Scripts in the
        /// Game folder.
        /// </summary>
        private static FileSystemWatcher _fswatcher;

        /// <summary>
        /// This is a Concurrent Queue which handles logging the file system events.
        /// This is because if the event the file system watcher raises is not handled in
        /// a timely fashion the file system watcher will time out and stop reporting changes.
        /// </summary>
        private static readonly ConcurrentQueue<FileSystemEventArgs> Events = new ConcurrentQueue<FileSystemEventArgs>();

        /// <summary>
        /// Flag used to stop the thread watching the folders.
        /// </summary>
        private static volatile bool _isRunning = false;

        /// <summary>
        /// The thread that watches the events in the Events Queue.
        /// </summary>
        private static Thread _thread;

        /// <summary>
        /// Dictionary to track the index and instance 
        /// </summary>
        private readonly Dictionary<UInt64, xmlOverrideData> _overrideData = new Dictionary<UInt64, xmlOverrideData>();

        /// <summary>
        /// Dictionary for filename/index
        /// </summary>
        private readonly Dictionary<string, UInt64> _overrideXmlFilenameIndex = new Dictionary<string, UInt64>();

        private UInt64 _lastIndex = 0;

        /// <summary>
        /// The folder location to monitor.
        /// </summary>
        private string _location = string.Empty;

        #endregion

        #endregion

        #region Properties

        #region Public

        /// <summary>
        /// This is how you access the instance of the singleton.
        /// </summary>
        public static csFactory Instance
        {
            get
            {
                if (_instance != null)
                    return _instance;
                lock (syncRoot)
                    if (_instance == null)
                        _instance = new csFactory();
                return _instance;
            }
        }

        #endregion

        #endregion

        #region Functions

        #region Private

        private void PerformInitialInventory()
        {
            foreach (string file in Directory.GetFiles(_location, "*.xml", SearchOption.AllDirectories))
                ProcessXML(file);
        }

        /// <summary>
        /// Reads the specified XML file and creates the Override Definition
        /// </summary>
        /// <param name="filename"></param>
        /// <returns></returns>
        private bool ProcessXML(string filename)
        {
            xmlOverrideData data = new xmlOverrideData();
            bool readFile = false;
            XDocument doc = null;
            while (!readFile)
                {
                try
                    {
                    doc = XDocument.Load(filename);
                    readFile = true;
                    }
                catch (Exception)
                    {
                    return false;
                    }
                }

            if (doc.Root.Name != "OverrideConfig")
                return false;

            data.XmlFileName = filename;

            if (doc.Root.HasAttributes)
                {
                foreach (XAttribute attr in doc.Root.Attributes().Where(attr => attr.Name == "Type"))
                    {
                    switch (attr.Value.ToLower())
                        {
                            case "memberconsolefunctionoverride":
                                data.ScriptType = xmlOverrideData.ScriptTypes.MemberFunction;
                                break;
                            case "classes":
                                data.ScriptType = xmlOverrideData.ScriptTypes.Classes;
                                break;
                            default:
                                data.ScriptType = xmlOverrideData.ScriptTypes.Undefined;
                                break;
                        }
                    }
                }
            if (data.ScriptType == xmlOverrideData.ScriptTypes.Undefined)
                {
                #region

                lock (Omni.self.tick)
                    Omni.self.Error(">>csFactory::Error Processing C# Script XML File: '" + filename + "' Reason: Unknown ScriptType.");
                return false;

                #endregion
                }

            #region "Read Rest of XML"

            foreach (XElement el in doc.Root.Elements())
                {
                if (el.Name == "NameSpace")
                    data.NameSpace = el.Value;

                else if (el.Name == "Files")
                    {
                    foreach (XElement element in el.Elements())
                        data.CsFileNames.Add(Path.Combine(_location, element.Value));
                    }

                else if (el.Name == "ClassName")
                    data.ClassName = el.Value;

                else if (el.Name == "ReferencedAssemblies")
                    {
                    foreach (XElement element in el.Elements())
                        data.ReferencedAssemblies.Add(element.Value);
                    }

                else if (el.Name == "FunctionOverrides")
                    {
                    foreach (XElement element in el.Elements())
                        data.FunctionOverrides.Add(new CustomClassFunctDef(element.Value));
                    }
                }

            #endregion

            if (data.NameSpace == "" && data.ScriptType != xmlOverrideData.ScriptTypes.Classes)
                {
                #region

                lock (Omni.self.tick)
                    Omni.self.Error(">>csFactory::Error Processing C# Script XML File: '" + filename + "' Reason: NameSpace Not Resolved.");
                return false;

                #endregion
                }

            if (data.CsFileNames.Count == 0)
                {
                #region

                lock (Omni.self.tick)
                    Omni.self.Error(">>csFactory::Error Processing C# Script XML File: '" + filename + "' Reason: No C# File Set.");
                return false;

                #endregion
                }

            if (data.ClassName == "" && data.ScriptType != xmlOverrideData.ScriptTypes.Classes)
                {
                #region

                lock (Omni.self.tick)
                    Omni.self.Error(">>csFactory::Error Processing C# Script XML File: '" + filename + "' Reason: No ClassName Not Set.");
                return false;

                #endregion
                }

            if (data.ReferencedAssemblies.Count == 0)
                {
                #region

                lock (Omni.self.tick)
                    Omni.self.Error(">>csFactory::WARNING: Script XML File: '" + filename + "' Reason: No Referenced Assemblies.");

                #endregion
                }

            if (data.FunctionOverrides.Count == 0 && data.ScriptType != xmlOverrideData.ScriptTypes.Classes)
                {
                #region

                lock (Omni.self.tick)
                    Omni.self.Error(">>csFactory::WARNING: Script XML File: '" + filename + "' Reason: No Function Overrides Defined.");

                #endregion
                }

            #region

//#if DEBUG
            lock (Omni.self.tick)
                Omni.self.Warn(">>csFactory::INFO: Adding Script XML File: '" + filename + "'.");

            foreach (CustomClassFunctDef s in data.FunctionOverrides)
                {
                lock (Omni.self.tick)
                    Omni.self.Warn(">>csFactory::INFO::DETAIL: Adding Function Override: '" + s.mFunctName + "'");
                }
//#endif

            #endregion

            #region

            bool haderror = false;
            foreach (string f in data.CsFileNames)
                {
                if (!File.Exists(f))
                    {
                    lock (Omni.self.tick)
                        {
                        Omni.self.Error(">>csFactory::Error Processing C# Script XML File: '" + filename + "' C# Script file '" + f + "' does not exist.");
                        haderror = true;
                        }
                    }
                }

            if (haderror)
                return false;

            #endregion

            if (!data.Compile())
                return false;

            if (data.ScriptType == xmlOverrideData.ScriptTypes.Classes)
                {
                data.IResult = Omni.self.IndexAssembly(data.CompiledAssembly);
                foreach (string f in data.IResult.ClassesFound)
                    {
                    lock (Omni.self.tick)
                        Omni.self.Warn(">>csFactory::INFO: Registered Class '" + f + "'.");
                    }
                foreach (string f in data.IResult.GlobalFunctsFound)
                    {
                    lock (Omni.self.tick)
                        Omni.self.Warn(">>csFactory::INFO: Registered Global Function '" + f + "'.");
                    }
                }
            RegisterScriptXml(data.XmlFileName, data);
            return true;
        }

        /// <summary>
        /// Creates the FileSystemWatcher and wires up the events.
        /// </summary>
        private void StartWatchers()
        {
            if (_fswatcher != null)
                _fswatcher.EnableRaisingEvents = false;
            _fswatcher = null;
            _fswatcher = new FileSystemWatcher(_location);
            _fswatcher.IncludeSubdirectories = true;
            _fswatcher.NotifyFilter = NotifyFilters.Attributes | NotifyFilters.CreationTime | NotifyFilters.DirectoryName | NotifyFilters.FileName | NotifyFilters.LastAccess | NotifyFilters.LastWrite | NotifyFilters.Size;

            _fswatcher.Changed += new FileSystemEventHandler(_fswatcher_Changed);
            _fswatcher.Created += new FileSystemEventHandler(_fswatcher_Created);
            _fswatcher.Deleted += new FileSystemEventHandler(_fswatcher_Deleted);
            _fswatcher.InternalBufferSize = 65536;
            _fswatcher.EnableRaisingEvents = true;

            _isRunning = true;
            _thread = new Thread(evntTimer_Elapsed);
            _thread.Start();
        }

        /// <summary>
        /// Thread body that monitors the event Queue.
        /// </summary>
        private static void evntTimer_Elapsed()
        {
            while (_isRunning)
                {
                Thread.Sleep(2000);
                FileSystemEventArgs fsea;
                while (Events.TryDequeue(out fsea))
                    {
                    switch (fsea.ChangeType)
                        {
                            case WatcherChangeTypes.Changed:
                                onChanged(fsea);
                                break;
                            case WatcherChangeTypes.Deleted:
                                onDelete(fsea);
                                break;
                            case WatcherChangeTypes.Created:
                                onCreated(fsea);
                                break;
                        }
                    }
                }
        }

        /// <summary>
        /// Utility function that determines if the Script file is a C# or XML File.
        /// </summary>
        /// <param name="e"></param>
        /// <returns></returns>
        private static filetype GetFileType(FileSystemEventArgs e)
        {
            switch (Path.GetExtension(e.FullPath).ToLower())
                {
                    case ".cs":
                        return filetype.CS;
                    case ".xml":
                        return filetype.XML;
                    default:
                        return filetype.UNKOWN;
                }
        }

        /// <summary>
        /// What to do when a file is deleted.
        /// </summary>
        /// <param name="e"></param>
        private static void onDelete(FileSystemEventArgs e)
        {
            switch (GetFileType(e))
                {
                    case filetype.CS:
                    {
                        xmlOverrideData d = Instance.getObjectByCsFilePath(e.FullPath);
                        if (d != null)
                            {
                            Instance.UnRegisterScriptXml(d.XmlFileName);
                            if (d.ScriptType == xmlOverrideData.ScriptTypes.Classes)
                                Omni.self.DeIndexClass(d.IResult);
                            Instance.ProcessXML(d.XmlFileName);
                            }
                        break;
                    }
                    case filetype.XML:
                    {
                        xmlOverrideData d = Instance.getObjectByXmlFilePath(e.FullPath);
                        if (d != null)
                            {
                            Instance.UnRegisterScriptXml(e.FullPath);
                            if (d.ScriptType == xmlOverrideData.ScriptTypes.Classes)
                                Omni.self.DeIndexClass(d.IResult);
                            }
                        break;
                    }
                }
        }

        /// <summary>
        /// What to do when a file changes.
        /// </summary>
        /// <param name="e"></param>
        private static void onChanged(FileSystemEventArgs e)
        {
            switch (GetFileType(e))
                {
                    case filetype.CS:
                    {
                        xmlOverrideData d = Instance.getObjectByCsFilePath(e.FullPath);
                        if (d != null)
                            {
                            Instance.UnRegisterScriptXml(d.XmlFileName);
                            if (d.ScriptType == xmlOverrideData.ScriptTypes.Classes)
                                Omni.self.DeIndexClass(d.IResult);
                            Instance.ProcessXML(d.XmlFileName);
                            }
                        break;
                    }
                    case filetype.XML:
                    {
                        xmlOverrideData d = Instance.getObjectByXmlFilePath(e.FullPath);
                        if (d != null)
                            {
                            Instance.UnRegisterScriptXml(e.FullPath);
                            if (d.ScriptType == xmlOverrideData.ScriptTypes.Classes)
                                Omni.self.DeIndexClass(d.IResult);
                            }
                        Instance.ProcessXML(d != null ? d.XmlFileName : e.FullPath);
                        break;
                    }
                }
        }

        /// <summary>
        /// What to do when a file is changed.
        /// </summary>
        /// <param name="e"></param>
        private static void onCreated(FileSystemEventArgs e)
        {
            switch (GetFileType(e))
                {
                    case filetype.CS:
                        //We don't do anything if they create a CS file.
                        break;
                    case filetype.XML:
                        Instance.ProcessXML(e.FullPath);
                        break;
                }
        }

        /// <summary>
        /// Registers an Override with the engine.
        /// </summary>
        /// <param name="xmlfilename"></param>
        /// <param name="dta"></param>
        private void RegisterScriptXml(string xmlfilename, xmlOverrideData dta)
        {
            xmlfilename = xmlfilename.ToLower();
            UnRegisterScriptXml(xmlfilename);
            _lastIndex++;
            _overrideData.Add(_lastIndex, dta);
            _overrideXmlFilenameIndex.Add(xmlfilename, _lastIndex);
        }

        /// <summary>
        /// Unregisters an override with the engine.
        /// </summary>
        /// <param name="xmlfilename"></param>
        private void UnRegisterScriptXml(string xmlfilename)
        {
            xmlfilename = xmlfilename.ToLower();

            if (!_overrideXmlFilenameIndex.ContainsKey(xmlfilename))
                return;

            ulong idx = _overrideXmlFilenameIndex[xmlfilename];

            _overrideData.Remove(idx);

            _overrideXmlFilenameIndex.Remove(xmlfilename);
        }

        private xmlOverrideData getObjectByXmlFilePath(string xmlfilename)
        {
            xmlfilename = xmlfilename.ToLower();
            return _overrideXmlFilenameIndex.ContainsKey(xmlfilename) ? (_overrideData[_overrideXmlFilenameIndex[xmlfilename]]) : null;
        }

        private xmlOverrideData getObjectByCsFilePath(string csfilename)
        {
            return _overrideData.Values.FirstOrDefault(t => t.CsFileNames.Any(f => String.Equals(f, csfilename, StringComparison.CurrentCultureIgnoreCase)));
        }

        #region FileMonitoring

        private void _fswatcher_Deleted(object sender, FileSystemEventArgs e)
        {
            Events.Enqueue(e);
        }

        private void _fswatcher_Changed(object sender, FileSystemEventArgs e)
        {
            Events.Enqueue(e);
        }

        private void _fswatcher_Created(object sender, FileSystemEventArgs e)
        {
            Events.Enqueue(e);
        }

        #endregion

        #endregion

        #region Internal

        /// <summary>
        /// Starts the folder monitoring for CS and XML file Changes
        /// To the GameFolder specified.  The Folder is
        /// Relational to the Game Folder.
        /// </summary>
        /// <param name="GameFolder">Location off the Game Folder to monitor.</param>
        /// <returns>True/False if it was able to start the monitor.</returns>
        [PermissionSet(SecurityAction.Demand, Name = "FullTrust")]
        internal bool StartMonitoring(string GameFolder)
        {
            if (GameFolder == "")
                return true;

            _location = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, GameFolder);
            if (!Directory.Exists(_location))
                return false;

            PerformInitialInventory();

            StartWatchers();
            return true;
        }

        /// <summary>
        /// Stops the monitoring of the folder system for CS and XML Changes.
        /// </summary>
        internal void StopMonitoring()
        {
            _isRunning = false;
            if (_fswatcher != null)
                {
                _fswatcher.EnableRaisingEvents = false;
                _fswatcher = null;
                }
        }

        /// <summary>
        /// Returns the member overrides for a specific namespace.
        /// </summary>
        /// <param name="namespc">Namespace to search for.</param>
        /// <returns></returns>
        internal List<xmlOverrideData> GetMemberOverrides(string namespc)
        {
            return _overrideData.Values.Where(od => String.Equals(od.NameSpace, namespc, StringComparison.CurrentCultureIgnoreCase) && od.ScriptType == xmlOverrideData.ScriptTypes.MemberFunction).ToList();
        }

        #endregion

        #endregion
    }
}