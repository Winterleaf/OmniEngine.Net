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
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security;
using System.Security.Permissions;
using System.Text;
using WinterLeaf.Engine.Classes;
using WinterLeaf.Engine.Classes.Decorations;
using WinterLeaf.Engine.Classes.Extensions;
using WinterLeaf.Engine.Classes.Helpers;
using WinterLeaf.Engine.Classes.Interopt;
using WinterLeaf.Engine.Classes.LiveScripts;

#endregion

namespace WinterLeaf.Engine
{
    /// <summary>
    /// Core Controller Class.  This class provides all the binding between the Models (C#) and the Views C++
    /// </summary>
    [SecuritySafeCritical]
    [PermissionSet(SecurityAction.Demand, Name = "FullTrust")]
    public sealed partial class Omni
    {
        /// <summary>
        ///     Used to signal the application hosting the dnTorque Object that T3D is
        ///     shutting down.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public delegate void ShutDownEventHandler(object sender, EventArgs e);

        #region Private Variables

        /// <summary>
        ///     The max number of proxy items allowed.
        /// </summary>
        private const int SimDictSize = CustomQueue.Maxsize;

        /// <summary>
        ///     Static reference to itself.
        /// </summary>
        private static Omni _mSelf;

        /// <summary>
        ///     The name of the T3D dll.
        /// </summary>
        private static string _mDll;

        /// <summary>
        ///     Flag to stop dnTorque
        /// </summary>
        private static bool _mStop;

        /// <summary>
        ///     Paramets for the T3D dll.
        /// </summary>
        private static string[] _mCmdParams;

        /// <summary>
        ///     Class Name, class info.
        /// </summary>
        private static readonly SortedDictionary<string, CustomClassDef> MCustomClassDef = new SortedDictionary<string, CustomClassDef>();

        /// <summary>
        ///     Dictionary of constructors for creating new T3D objects.
        /// </summary>
        private static readonly SortedDictionary<string, ObjectActivator> MObjectCreateDefs = new SortedDictionary<string, ObjectActivator>();

        /// <summary>
        ///     Callback used by T3D to call back to the C# when a new simobject is registered with the simDictionary
        /// </summary>
        private static SafeNativeMethods.RegisterSimObject_Callback _mLocalhandleRegisterSimObjectCallback;

        private static SafeNativeMethods.setIcon_Callback _mLocalhandleSetIconCallback;

        /// <summary>
        ///     Callback used by T3D to call back to the C# when a object needs to call a member function.
        /// </summary>
        private static SafeNativeMethods.WLE_EngineCallBack _mLocalhandleWleEngineCallBack;

        /// <summary>
        /// </summary>
        private static SafeNativeMethods.WLE_ExportVariablesAsSettings _mWLE_ExportVariablesAsSettings;

        /// <summary>
        ///     Callback used by T3D to call back to the C# when a global function call occurs
        /// </summary>
        private static SafeNativeMethods.WLE_GlobalFunctionCallBack _mWLE_GlobalFunctionCallBack;

        private static SafeNativeMethods.isFunction_Callback _mWLE_isFunction_Callback;

        private static SafeNativeMethods.gisFunction_Callback _mWLE_gisFunction_Callback;

        private static SafeNativeMethods.setIcon_Callback _mWLE_setIcon_Callback;

        private static string _mNameSpace;

        private static string _mNameSpaceUserObjectsProxyObjects;

        /// <summary>
        ///     A queue used to track available slots in the array used to map T3D simobjects to tsObjects.
        /// </summary>
        private readonly CustomQueue _mAvailable = new CustomQueue();

        /// <summary>
        ///     A dictionary of all static functions in this project prefixed with "event_"
        /// </summary>
        private readonly SortedDictionary<string, CustomClassFunctDef> _mGlobalFuncts = new SortedDictionary<string, CustomClassFunctDef>();

        /// <summary>
        ///     Handle to the window
        /// </summary>
        private readonly IntPtr _mhinstance = IntPtr.Zero;

        /// <summary>
        ///     A array which tracks all the proxy objects for the T3D objects.
        /// </summary>
        private readonly ModelBase[] _msimdict = new ModelBase[SimDictSize];

        //private readonly String[] _msimdictclass = new String[SimDictSize];

        private bool _ScriptExtensions_Allow = true;

        private bool _ScriptExtensions_HandleExceptions = true;

        private string _mlNameSpaceUserObjectsProxyObjects;

        /// <summary>
        ///     Object used for locking the T3D dll.
        /// </summary>
        private object _tick = new object();

        private string mcsScriptGameFolder = string.Empty;

        public List<ModelBase> SimDictionary
        {
            get { return _msimdict.Where(mb => mb != null).ToList(); }
        }

        #endregion

        private int deletedcount = 0;
        private string spaces = "                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                             ";

        /// <summary>
        /// Default constructor.
        /// </summary>
        /// <param name="hinstance">Window Handle for harness application</param>
        public Omni(IntPtr hinstance)
        {
            _mhinstance = hinstance;
            _mSelf = this;
        }

        /// <summary>
        ///     Reference to the dnTorque Instance
        /// </summary>
        public static Omni self
        {
            get { return _mSelf; }
        }

        /// <summary>
        ///     Whether the engine is running or not.
        /// </summary>
        public bool IsRunning
        {
            get { return !_mStop; }
        }

        /// <summary>
        ///     Turns on/off debugging information
        /// </summary>
        public bool Debugging { get; set; }

        /// <summary>
        /// When set to true, all TorqueScript calls will be echoed to the console.
        /// </summary>
        public bool DebuggingShowScriptCalls { get; set; }

        /// <summary>
        ///     The icon for the window
        /// </summary>
        public Icon WindowIcon { get; set; }

        /// <summary>
        ///     Locks the T3D mtorque_enginetick
        /// </summary>
        public object tick
        {
            get { return _tick; }
            set { _tick = value; }
        }

        /// <summary>
        ///     Handle to the window.
        /// </summary>
        public IntPtr torque_hwnd
        {
            get { return SafeNativeMethods.mtorque_gethwnd(); }
        }

        /// <summary>
        /// When true, CSharp files in LiveScripts will be evaluated.
        /// </summary>
        public bool ScriptExtensions_Allow
        {
            get { return _ScriptExtensions_HandleExceptions; }
            set { _ScriptExtensions_HandleExceptions = value; }
        }

        /// <summary>
        /// When true, all scripts in LiveScripts will be called with a wrapping Try/Catch clause.
        /// </summary>
        public bool ScriptExtensions_HandleExceptions
        {
            get { return _ScriptExtensions_HandleExceptions; }
            set { _ScriptExtensions_HandleExceptions = value; }
        }

        public Exception LastError
        {
            get { return mLastError; }
            set { mLastError = value; }
        }

        private static object CreateObject(Type type)
        {
            //No leak here, constructor only gets created once.
            if (MObjectCreateDefs.ContainsKey(type.FullName))
                return MObjectCreateDefs[type.FullName]();
            ConstructorInfo ctor = type.GetConstructors()[0];
            NewExpression newExp = Expression.New(ctor);
            LambdaExpression lambda = Expression.Lambda(typeof (ObjectActivator), newExp, null);
            ObjectActivator compiled = (ObjectActivator) lambda.Compile();
            MObjectCreateDefs.Add(type.FullName, compiled);
            return compiled();
        }

        private void ShutDownCleanUp()
        {
            SafeNativeMethods.FreeDLL();
            OnShutDownEvent();
        }

        private volatile Exception mLastError = null;

        private void bwr_InitializeTorque(object sender, DoWorkEventArgs e)
        {
            Process.GetCurrentProcess().PriorityClass = ProcessPriorityClass.RealTime;

            //foreach (string file in
            //    Directory.GetFiles(AppDomain.CurrentDomain.BaseDirectory + @"shaders\procedural").Where(file => !Path.GetFileName(file).StartsWith(".")))
            //    File.Delete(file);

            MObjectCreateDefs.Clear();
            try
                {
                SafeNativeMethods.SetUpDynamicDLL(_mDll);
                }
            catch (Exception err)
            {
                LastError = err;
                _mStop = true;
                if (_ScriptExtensions_Allow)
                    csFactory.Instance.StopMonitoring();

                return;
            }
            //create a list of pointers for our parameters
            List<IntPtr> myp = new List<IntPtr> {Marshal.StringToCoTaskMemAnsi(Assembly.GetExecutingAssembly().Location)};
            //Add the pointer to a managed memory string containing the location of the Assembly.
            //Create a managed memory string object and put our command line parameters in each one, 
            //then add the pointer to that object into our list.
            myp.AddRange(_mCmdParams.Select(Marshal.StringToCoTaskMemAnsi));

            //Now, this if fun stuff, we need to save the pointer to the instance eval delegate
            //and save it to a static variable so the DotNet's Garabage collection doesn't
            //decide to through it away on a cleanup since no object inside of DotNet
            //will have a reference to it.  

            _mLocalhandleRegisterSimObjectCallback = RegisterSimObject_Callback;
            GC.SuppressFinalize(_mLocalhandleRegisterSimObjectCallback);

            _mLocalhandleWleEngineCallBack = WLE_EngineCallBack;
            GC.SuppressFinalize(_mLocalhandleWleEngineCallBack);

            _mWLE_GlobalFunctionCallBack = WLE_GlobalFunctionCallBack;
            GC.SuppressFinalize(_mWLE_GlobalFunctionCallBack);

            _mWLE_ExportVariablesAsSettings = WLE_ExportVariablesAsSettings;
            GC.SuppressFinalize(_mWLE_ExportVariablesAsSettings);

            _mWLE_isFunction_Callback = isFunction_Callback;
            GC.SuppressFinalize(_mWLE_isFunction_Callback);

            _mWLE_gisFunction_Callback = gisFunction_Callback;
            GC.SuppressFinalize(_mWLE_gisFunction_Callback);

            _mWLE_setIcon_Callback = SetIconCallBack;
            GC.SuppressFinalize(_mWLE_setIcon_Callback);

            //We make an extern call to the T3D dll passing our pointers so the T3D can
            //make callbacks.

            SafeNativeMethods.mSetHandler_SimIdDictionary(_mLocalhandleRegisterSimObjectCallback);
            SafeNativeMethods.mSetEngineCallback(_mLocalhandleWleEngineCallBack);
            SafeNativeMethods.mSetGlobalFunctionCallback(_mWLE_GlobalFunctionCallBack);
            SafeNativeMethods.mSetExportVariablesAsSettings(_mWLE_ExportVariablesAsSettings);
            SafeNativeMethods.mSetWLE_IsFunction(_mWLE_isFunction_Callback);
            SafeNativeMethods.mSetWLE_gIsFunction(_mWLE_gisFunction_Callback);
            SafeNativeMethods.m_SetWLE_setIcon(_mWLE_setIcon_Callback);

            //Initialize the T3D dll and capture its window handle.
            SafeNativeMethods.mdnt_torque_engineinit(myp.Count, myp.ToArray(), _mhinstance);
            //if (WindowIcon != null)
            //    SetParentIcon(WindowIcon);

            foreach (IntPtr ptr in myp)

                Marshal.FreeCoTaskMem(ptr);

            //We make one cal to the engine tick before doing anything else at this point
            //so Torque can set everything up.
            SafeNativeMethods.mtorque_enginetick();
            //Loop until told to stop.

            //I use to have this in a try/catch block, but since errors through from calling a managed memory object
            //are considered "Hard" errors, a try catch block will not catch them.

            //Since Torque's console is not multi-threaded we have to be careful on async calls, i.e. calls
            //made to torque not as a result of torque calling a exported function, but instead of a 
            //csharp function running in a seperate thread.
            //So to prevent corruption, only allow async functions to make calls back to Torque when it is
            //in an idle state, i.e. not "Ticking".  This way there is no way to calls can enter the same Torque
            //function at the same time and cause memory corruption.
            while (!_mStop)
                {
                lock (_tick)
                    SafeNativeMethods.mtorque_enginetick();
                }

            if (_ScriptExtensions_Allow)
                csFactory.Instance.StopMonitoring();

            SafeNativeMethods.mtorque_enginesignalshutdown();
            SafeNativeMethods.mtorque_enginetick();
            SafeNativeMethods.mtorque_enginetick();
            SafeNativeMethods.mtorque_enginetick();
            SafeNativeMethods.mtorque_enginetick();
            //Commenting this out for now, causing a memory corruption issue.
            SafeNativeMethods.mtorque_engineshutdown();

            SafeNativeMethods.mClearEngineCallback();
            SafeNativeMethods.mClearHandler_SimIdDictionary();
            SafeNativeMethods.mClearGlobalFunctionCallback();
            SafeNativeMethods.mClearExportVariablesAsSettings();
            SafeNativeMethods.mClearWLE_IsFunction();
            SafeNativeMethods.mClearWLE_gIsFunction();
            SafeNativeMethods.mClearWLE_setIcon();

            GC.ReRegisterForFinalize(_mLocalhandleRegisterSimObjectCallback);
            _mLocalhandleRegisterSimObjectCallback = null;
            GC.ReRegisterForFinalize(_mLocalhandleWleEngineCallBack);
            _mLocalhandleWleEngineCallBack = null;

            GC.Collect();

            ShutDownCleanUp();
        }

        private void InsertRecordIntoSimDictionary(ModelBase o)
        {
            int pos = _mAvailable.Pop();
            _msimdict[pos] = o;
            o["WLE_OMNI_ARRAY_POSTION"] = pos.AsString();
        }

        private void OnShutDownEvent()
        {
            if (onShutDown != null)
                onShutDown(null, EventArgs.Empty);
        }

        private void WLE_GlobalFunctionCallBack(int argc, IntPtr argv, byte[] buffer)
        {
            string function = Marshal.PtrToStringAnsi(Marshal.ReadIntPtr(argv, IntPtr.Size*0)).ToLower();

            if (_mGlobalFuncts.ContainsKey(function))
                {
                if (function == "main")
                    {
                    List<string> myparams = new List<string>(22);
                    for (int i = 1; i < argc; i++)
                        myparams.Add(Marshal.PtrToStringAnsi(Marshal.ReadIntPtr(argv, IntPtr.Size*i)));

                    byte[] returnbytes2 = Encoding.ASCII.GetBytes(_mGlobalFuncts[function].mFunctPtr.Invoke(null, new object[] {myparams.Count, myparams.ToArray()}).ToString());
                    Buffer.BlockCopy(returnbytes2, 0, buffer, 0, returnbytes2.Length);
                    buffer[returnbytes2.Length] = 0;
                    return;
                    }

#if DEBUG
                if (Debugging)
                    self.Error("!!!!GlobalFunctionCallBack!!!! Calling CSHARP Function '" + function + "'.");
#endif
                CustomClassFunctDef ccfd = _mGlobalFuncts[function];
                object[] parameters = new object[ccfd.MParams.Count()];
                for (int i = 0; i < ccfd.MParams.Count(); i++)
                    parameters[i] = (i < argc - 1 ? myReflections.ChangeType(Marshal.PtrToStringAnsi(Marshal.ReadIntPtr(argv, IntPtr.Size*(i + 1))), ccfd.MParams[i].ParameterType) : myReflections.ChangeType(string.Empty, ccfd.MParams[i].ParameterType));

                byte[] returnbytes = Encoding.ASCII.GetBytes(ccfd.CallFunction(null, parameters).ToString());
                Buffer.BlockCopy(returnbytes, 0, buffer, 0, returnbytes.Length);
                buffer[returnbytes.Length] = 0;
                return;
                }
#if DEBUG
            if (DebuggingShowScriptCalls)
                self.Error("!!!!GlobalFunctionCallBack!!!! Calling TorqueScript Function '" + function + "'.");
#endif
            List<IntPtr> myp = new List<IntPtr>();
            StringBuilder returnval = new StringBuilder(8000);
            for (int i = 0; i < argc; i++)
                myp.Add(Marshal.StringToCoTaskMemAnsi(Marshal.PtrToStringAnsi(Marshal.ReadIntPtr(argv, IntPtr.Size*i))));
            SafeNativeMethods.mexecuteScript(argc, myp.ToArray(), returnval);
            byte[] returnbytes1 = Encoding.ASCII.GetBytes(returnval.ToString());
            Buffer.BlockCopy(returnbytes1, 0, buffer, 0, returnbytes1.Length);
            buffer[returnbytes1.Length] = 0;
        }

        private void WLE_EngineCallBack(int simobjectid, int WLE_OMNI_ARRAY_POSTION, int argc, IntPtr argv, byte[] returnbuff)
        {
            ModelBase proxyobject = null;
            if (WLE_OMNI_ARRAY_POSTION == 0)
                proxyobject = simobjectid;
            else
                proxyobject = _msimdict[WLE_OMNI_ARRAY_POSTION];

            string poName = proxyobject.GetType().FullName.ToLower();

            if (MCustomClassDef.ContainsKey(poName))
                {
                //This is where I will need to check if the class 
                //blocks script calls, i.e. all calls made stop here
                //versus getting sent to the proxyobject.callscript function.
                CustomClassDef ccd = MCustomClassDef[poName];
                string tfunction = Marshal.PtrToStringAnsi(Marshal.ReadIntPtr(argv, 0)).ToLower();

                #region ScriptExtensions

                if (_ScriptExtensions_Allow)
                    {
                    List<xmlOverrideData> ovr = csFactory.Instance.GetMemberOverrides(proxyobject.GetType().FullName);
                    foreach (xmlOverrideData xd in ovr)
                        {
                        foreach (CustomClassFunctDef ccfd in xd.FunctionOverrides)
                            {
                            if (ccfd.mFunctName.ToLower() != tfunction)
                                continue;
                            object[] parameters = new object[ccfd.MParams.Count()];

                            parameters[0] = myReflections.ChangeType(proxyobject.ID, ccfd.MParams[0].ParameterType);

                            for (int i = 1; i < ccfd.MParams.Count(); i++)
                                parameters[i] = (i < argc - 1 ? myReflections.ChangeType(Marshal.PtrToStringAnsi(Marshal.ReadIntPtr(argv, IntPtr.Size*(i + 1))), ccfd.MParams[i].ParameterType) : myReflections.ChangeType(string.Empty, ccfd.MParams[i].ParameterType));

                            byte[] returnbytes1 = Encoding.ASCII.GetBytes(ccfd.CallFunction(proxyobject, parameters).ToString());
                            Buffer.BlockCopy(returnbytes1, 0, returnbuff, 0, returnbytes1.Length);
                            returnbuff[returnbytes1.Length] = 0;
                            return;
                            }
                        }
                    }

                #endregion

                if (ccd.mFuncts.ContainsKey(tfunction))
                    {
#if DEBUG
                    if (Debugging)
                        self.Error("!!!!EngineCallBack!!!! " + proxyobject.getClassName() + " Calling CSHARP function '" + tfunction + "'.");
#endif
                    CustomClassFunctDef ccfd = ccd.mFuncts[tfunction];
                    object[] parameters = new object[ccfd.MParams.Count()];
                    for (int i = 0; i < ccfd.MParams.Count(); i++)
                        parameters[i] = (i < argc - 2 ? myReflections.ChangeType(Marshal.PtrToStringAnsi(Marshal.ReadIntPtr(argv, IntPtr.Size*(i + 2))), ccfd.MParams[i].ParameterType) : myReflections.ChangeType(string.Empty, ccfd.MParams[i].ParameterType));

                    byte[] returnbytes1 = Encoding.ASCII.GetBytes(ccd.mFuncts[tfunction].CallFunction(proxyobject, parameters).ToString());
                    Buffer.BlockCopy(returnbytes1, 0, returnbuff, 0, returnbytes1.Length);
                    returnbuff[returnbytes1.Length] = 0;
                    return;
                    }
                }
            string function = Marshal.PtrToStringAnsi(Marshal.ReadIntPtr(argv, 0));
            if ((!proxyobject.OnFunctionNotFoundCallTorqueScript()) && !MCustomClassDef[poName].Allowedcallbacks.Contains(function.ToLower()))
                return;

            #region Debug

#if DEBUG
            if (DebuggingShowScriptCalls)
                self.Error("!!!!EngineCallBack!!!! " + proxyobject.getClassName() + " Calling TorqueScript function '" + function + "'.");
#endif

            #endregion

            List<string> myparams = new List<string>(20);
            for (int i = 2; i < argc; i++)
                myparams.Add(Marshal.PtrToStringAnsi(Marshal.ReadIntPtr(argv, IntPtr.Size*i)));

            string returnObject = proxyobject.callScript(function, myparams.ToArray());
            byte[] returnbytes = Encoding.ASCII.GetBytes(returnObject);
            Buffer.BlockCopy(returnbytes, 0, returnbuff, 0, returnbytes.Length);
            returnbuff[returnbytes.Length] = 0;
        }

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern IntPtr SendMessage(IntPtr hWnd, UInt32 Msg, int wParam, int lParam);

        private void SetIconCallBack(IntPtr handle)
        {
            //Right now we don't know how to set the window handle on linux.
            //todo Add code to change icon in linux.
            if (LibraryManager.IsLinux())
                return;
            if (WindowIcon != null)
                SendMessage(handle, 0x0080, 1 /*ICON_LARGE*/, (int) WindowIcon.Handle);
        }

        public void dumpDictionary()
        {
            int objectcount = 0;

            for (int i = 0; i < CustomQueue.Maxsize; i++)
                {
                if ((object) _msimdict[i] != null)
                    {
                    objectcount++;
                    this.Print(i + "   " + _msimdict[i].isObject() + "    " + _msimdict[i].ID + " " + _msimdict[i].GetType().ToString() + " ");
                    }
                }
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();

            long totalBytesOfMemoryUsed = Process.GetCurrentProcess().PrivateMemorySize64;

            this.Print("Total Active Objects:    " + objectcount);
            this.Print("Total Deleted Objects:  " + deletedcount);

            long managedMemmory = GC.GetTotalMemory(false);

            this.Print("Memory Used by C#:    " + string.Format(CultureInfo.InvariantCulture, "{0:N0}", managedMemmory));
            this.Print("Memory Used by Application:    " + string.Format(CultureInfo.InvariantCulture, "{0:N0}", totalBytesOfMemoryUsed));
            this.Print("Memory Used Difference:    " + string.Format(CultureInfo.InvariantCulture, "{0:N0}", totalBytesOfMemoryUsed - managedMemmory));
            this.Print("Total simobjects C# Objects:  " + string.Format(CultureInfo.InvariantCulture, "{0:N0}", ModelBase.Objectcount));
        }

        public void dumpDictionaryGrouped()
        {
            int objectcount = 0;

            Dictionary<string, int> details = new Dictionary<string, int>();
            for (int i = 0; i < CustomQueue.Maxsize; i++)
                {
                if ((object) _msimdict[i] != null)
                    {
                    objectcount++;
                    if (!details.ContainsKey(_msimdict[i].GetType().ToString()))
                        details.Add(_msimdict[i].GetType().ToString(), 0);
                    details[_msimdict[i].GetType().ToString()]++;
                    }
                }

            this.Print("");
            this.Print("");
            this.Print("Objects in memory count.");

            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();

            foreach (KeyValuePair<string, int> kvp in details)
                this.Print((kvp.Key + spaces).Substring(0, 110) + "    " + kvp.Value);

            long totalBytesOfMemoryUsed = Process.GetCurrentProcess().PrivateMemorySize64;

            this.Print("Total Active Objects:    " + objectcount);
            this.Print("Total Deleted Objects:  " + deletedcount);

            long managedMemmory = GC.GetTotalMemory(false);

            this.Print("Memory Used by C#:    " + string.Format(CultureInfo.InvariantCulture, "{0:N0}", managedMemmory));
            this.Print("Memory Used by Application:    " + string.Format(CultureInfo.InvariantCulture, "{0:N0}", totalBytesOfMemoryUsed));
            this.Print("Memory Used Difference:    " + string.Format(CultureInfo.InvariantCulture, "{0:N0}", totalBytesOfMemoryUsed - managedMemmory));
            this.Print("Total simobjects C# Objects:  " + string.Format(CultureInfo.InvariantCulture, "{0:N0}", ModelBase.Objectcount));
        }

        private void RegisterSimObject_Callback(int arrayPosition, bool addObject, StringBuilder classNameSpace, StringBuilder className)
        {
            _msimdict[arrayPosition] = null;
            _mAvailable.Push(arrayPosition);
            deletedcount++;
        }

        private void WLE_ExportVariablesAsSettings(StringBuilder filename, StringBuilder variablename, StringBuilder value, bool append)
        {
            throw new Exception("Shouldn't happen");
            //Todo Settings - Switch this back when fixed.
            //if (!append)
            //    Settings.ClearVariables(filename.ToString());
            //Settings.SetVariable(filename.ToString(), variablename.ToString(), value.ToString());
        }

        private int gisFunction_Callback(StringBuilder function)
        {
            return _mGlobalFuncts.ContainsKey(function.ToString().ToLower()) ? 1 : 0;
        }

        private int isFunction_Callback(int simobjectid, int WLE_OMNI_ARRAY_POSITION, StringBuilder function)
        {
            if (WLE_OMNI_ARRAY_POSITION < 0)
                return 0;
            ModelBase proxyobject;
            if (WLE_OMNI_ARRAY_POSITION == 0)
                proxyobject = simobjectid;
            else
                proxyobject = _msimdict[WLE_OMNI_ARRAY_POSITION];
#if DEBUG
            if (Debugging)
                self.Error("!!!!isFunction_Callback!!!! Checking Function is callback for '" + proxyobject.getClassName() + "' Function '" + function + "'.");
#endif

            string poName = proxyobject.GetType().FullName.ToLower();

            if (!MCustomClassDef.ContainsKey(poName))
                return 0;
            //This is where I will need to check if the class 
            //blocks script calls, i.e. all calls made stop here
            //versus getting sent to the proxyobject.callscript function.
            return MCustomClassDef[poName].mFuncts.ContainsKey(function.ToString().ToLower()) ? 1 : 0;
        }

        private bool isExposedFunction(MethodInfo mi)
        {
            object[] u = mi.GetCustomAttributes(typeof (ConsoleInteraction), true);
            return u.Any() && (((ConsoleInteraction) u[0]).ExposeToConsole);
        }

        private bool isExposedSystemFunction(MethodInfo mi)
        {
            object[] u = mi.GetCustomAttributes(typeof (MemberFunctionConsoleInteraction), true);
            return u.Any() && (((MemberFunctionConsoleInteraction) u[0]).ExposeToConsole);
        }

        private string getAlias(MethodInfo mi)
        {
            object[] u = mi.GetCustomAttributes(typeof (ConsoleInteraction), true);
            return u.GetUpperBound(0) >= 0 ? ((ConsoleInteraction) u[0]).Alias : "";
        }

        internal ModelBase GetSimObjectUnsafe(uint simobjectid, Type type)
        {
            ModelBase sourceproxyobject = getSimObject(simobjectid, typeof (ModelBase));

            if (sourceproxyobject.GetType().FullName == type.GetType().FullName)
                return sourceproxyobject;

            ModelBase targetproxyobject = (ModelBase) CreateObject(type);
            targetproxyobject.SetUpObject(simobjectid);

            foreach (PropertyInfo pi in sourceproxyobject.GetType().GetProperties(BindingFlags.Public))
                {
                foreach (PropertyInfo tpi in type.GetProperties(BindingFlags.Public).Where(tpi => tpi.Name == pi.Name && tpi.GetType() == pi.GetType()))
                    {
                    try
                        {
                        tpi.SetValue(targetproxyobject, pi.GetValue(sourceproxyobject, null), null);
                        }
                    catch (Exception)
                        {
                        }
                    }
                }

            return targetproxyobject;
        }

        /// <summary>
        ///     Fetches a proxy from the proxy array.
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <param name="type"></param>
        /// <returns></returns>
        public ModelBase getSimObject(uint simobjectid, Type type)
        {
            int cindex = GetVar(simobjectid + ".WLE_OMNI_ARRAY_POSTION").AsInt();
            if (cindex != 0)
                return _msimdict[cindex];

            string torqueClassName = _mlNameSpaceUserObjectsProxyObjects + fn_SimObject_getClassName(simobjectid.AsString()).ToLower();
            string overrideClassNamespace = (GetVar(simobjectid + ".WLE_OVERRIDE_PROXY_CLASSTYPE")).ToLower();
            ModelBase proxyobject = null;
            if (MCustomClassDef.ContainsKey(overrideClassNamespace))
                {
                proxyobject = (ModelBase) CreateObject(MCustomClassDef[overrideClassNamespace].mType);
                proxyobject.SetUpObject(simobjectid);
                InsertRecordIntoSimDictionary(proxyobject);
                return proxyobject;
                }

            if (MCustomClassDef.ContainsKey(torqueClassName))
                {
                proxyobject = (ModelBase) CreateObject(MCustomClassDef[torqueClassName].mType);
                proxyobject.SetUpObject(simobjectid);
                InsertRecordIntoSimDictionary(proxyobject);
                return proxyobject;
                }

            proxyobject = (ModelBase) CreateObject(type);

            proxyobject.SetUpObject(simobjectid);
            if (proxyobject.isObject())
                InsertRecordIntoSimDictionary(proxyobject);
            return proxyobject;
        }

        private void _InitializeTorque(string[] torqueCmdParams, string T3D_DLLName, string Logic_DLL, string Root_NameSpace, String csScriptGameFolder)
        {
            mcsScriptGameFolder = csScriptGameFolder;
            _mNameSpace = Root_NameSpace;
            _mNameSpaceUserObjectsProxyObjects = _mNameSpace + ".Models.User.Extendable.";
            _mlNameSpaceUserObjectsProxyObjects = _mNameSpaceUserObjectsProxyObjects.ToLower();
            _msimdict[0] = null;
            for (int i = 1; i < CustomQueue.Maxsize - 1; i++)
                _mAvailable.Push(i);
            //Save a copy of the Command Params.
            _mCmdParams = torqueCmdParams;

            _mDll = T3D_DLLName;

            Assembly mAssembly = Assembly.LoadFrom(Logic_DLL);
            IndexAssembly(mAssembly);

            if (_ScriptExtensions_Allow)
                csFactory.Instance.StartMonitoring(mcsScriptGameFolder);

            //All functions which CAN be exported into T3D have been reflected and indexed.

            //Create a new background worker to run the engine tick in.
            using (BackgroundWorker bwr = new BackgroundWorker())
                {
                bwr.DoWork += bwr_InitializeTorque;
                bwr.RunWorkerAsync();
                }
        }

        /// <summary>
        /// This function reads the passed in Assembly and parses all of the Omni Decorations out and makes them available in the engine.
        /// Used mainly for internal purposes.
        /// </summary>
        /// <param name="mAssembly"></param>
        /// <returns></returns>
        internal IndexingResult IndexAssembly(Assembly mAssembly)
        {
            IndexingResult iResult = new IndexingResult();
            List<Type> classlist = mAssembly.GetTypes().ToList();
            classlist.Sort((x, y) => String.CompareOrdinal(x.FullName, y.FullName));
            List<CustomClassFunctDef> staticfunctions = new List<CustomClassFunctDef>();

            foreach (Type c in classlist)
                {
                if (c.FullName != null && c.FullName.StartsWith(_mNameSpace + ".Models.User"))
                    {
                    CustomClassDef ccd = new CustomClassDef {mType = c, mClassName = c.FullName.ToLower(), mCtor = c.GetConstructor(new Type[] {})};

                    #region Constructor check

#if DEBUG
                    ConstructorInfo ci;

                    try
                        {
                        ci = c.GetConstructor(new Type[] {});
                        }
                    catch (Exception)
                        {
                        throw new Exception("Class " + c.FullName + " does not have a empty constructor.");
                        }
                    ccd.mCtor = ci;
#endif

                    #endregion

                    List<MethodInfo> miList = c.GetMethods(BindingFlags.Static | BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance).ToList();
                    miList.Sort((x, y) => String.CompareOrdinal(x.Name, y.Name));
                    foreach (MethodInfo mi in miList)
                        {
                        #region Process MethodInfo

                        if (mi.IsStatic && !mi.IsSpecialName && isExposedFunction(mi))
                            {
                            if (getAlias(mi) != "")
                                {
                                CustomClassFunctDef ccfd = new CustomClassFunctDef {mFunctName = getAlias(mi).ToLower(), mFunctPtr = mi};
                                staticfunctions.Add(ccfd);
                                }
                            else
                                {
                                CustomClassFunctDef ccfd = new CustomClassFunctDef {mFunctName = mi.Name.ToLower(), mFunctPtr = mi};
                                staticfunctions.Add(ccfd);
                                }
                            }
                        else if (!mi.IsSpecialName && isExposedFunction(mi))
                            {
                            if ((mi.GetBaseDefinition().DeclaringType != mi.DeclaringType) || (mi.GetBaseDefinition().DeclaringType.Namespace.StartsWith(_mNameSpace + ".Models.User")))
                                {
                                if (getAlias(mi) != "")
                                    {
                                    CustomClassFunctDef ccfd = new CustomClassFunctDef {mFunctName = getAlias(mi).ToLower(), mFunctPtr = mi};
                                    ccd.mFuncts.Add(getAlias(mi), ccfd);
                                    }
                                else
                                    {
                                    CustomClassFunctDef ccfd = new CustomClassFunctDef {mFunctName = mi.Name.ToLower(), mFunctPtr = mi};
                                    ccd.mFuncts.Add(ccfd.mFunctName, ccfd);
                                    }
                                }
                            }
                        else if (!mi.IsSpecialName && isExposedSystemFunction(mi))
                            {
                            if (!ccd.Allowedcallbacks.Contains(mi.Name.ToLower()))
                                ccd.Allowedcallbacks.Add(mi.Name.ToLower());
                            }

                        #endregion
                        }

                    //Don't add any empty classes to the dictionary.
                    if (!ccd.mFuncts.Any() && !ccd.Allowedcallbacks.Any())
                        continue;
                    MCustomClassDef.Add(ccd.mClassName, ccd);
                    iResult.ClassesFound.Add(ccd.mClassName);
                    }
#if DEBUG
                else if (!c.FullName.StartsWith(_mNameSpace + ".Models.Base"))
                    Console.WriteLine("!!!WARNING!!!!  Skipping C# Type : '" + c.FullName + "'.");
#endif
                }

            //});
            //We are going to sort them to improve performance.
            staticfunctions.Sort((x, y) => String.CompareOrdinal(x.mFunctName, y.mFunctName));
            foreach (CustomClassFunctDef ccfd in staticfunctions)
                {
                _mGlobalFuncts.Add(ccfd.mFunctName, ccfd);
                iResult.GlobalFunctsFound.Add(ccfd.mFunctName);
                }

            return iResult;
        }

        /// <summary>
        ///     Stops T3D
        /// </summary>
        public void Stop()
        {
            _mStop = true;
        }

        /// <summary>
        ///     Starts the T3D dll.
        /// </summary>
        /// <param name="cmdParams"></param>
        /// <param name="dllName"></param>
        public void Initialize(string[] cmdParams, string dllName, string Logic_DLL, string root_Namepsace, String csScriptGameFolder = "")
        {
            _InitializeTorque(cmdParams, dllName, Logic_DLL, root_Namepsace, csScriptGameFolder);
        }

        /// <summary>
        ///     Event raised when T3D is shutting down.
        /// </summary>
        public event ShutDownEventHandler onShutDown;

        /// <summary>
        /// Removes all linkage from the OMNI Framework for the passed in Assembly.
        /// </summary>
        /// <param name="iResult"></param>
        internal void DeIndexClass(IndexingResult iResult)
        {
            if (iResult == null)
                return;
            lock (tick)
                {
                foreach (string c in iResult.ClassesFound)
                    {
                    for (int i = 0; i < SimDictSize; i++)
                        {
                        if (_msimdict[i] == null)
                            continue;
                        if (_msimdict[i].GetType().FullName.ToLower() != c)
                            continue;

                        self.Error(">>csFactory::INFO: Deleting Proxy Object for class '" + _msimdict[i].GetType().FullName.ToLower() + "'. ID: " + _msimdict[i].GetID() + " Name: " + _msimdict[i].getName());
                        _msimdict[i].delete();
                        _msimdict[i] = null;
                        }
                    MObjectCreateDefs.Remove(c);
                    MCustomClassDef.Remove(c);
                    }
                foreach (string g in iResult.GlobalFunctsFound)
                    _mGlobalFuncts.Remove(g);
                }
        }

        /// <summary>
        /// Shuts down the Engine.
        /// </summary>
        public void StopEngine()
        {
            _mStop = true;
        }

        /// <summary>
        ///     Used by the new object creator.
        /// </summary>
        /// <returns></returns>
        private delegate object ObjectActivator();
    }
}