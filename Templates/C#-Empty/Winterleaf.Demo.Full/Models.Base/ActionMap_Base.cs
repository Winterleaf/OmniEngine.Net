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

using System.ComponentModel;
using WinterLeaf.Demo.Full.Models.User.Extendable;
using WinterLeaf.Engine;
using WinterLeaf.Engine.Classes.Decorations;
using WinterLeaf.Engine.Classes.Helpers;
using WinterLeaf.Engine.Classes.Interopt;

#endregion

namespace WinterLeaf.Demo.Full.Models.Base
{
    /// <summary>
    /// 
    /// </summary>
    [TypeConverter(typeof (TypeConverterGeneric<ActionMap_Base>))]
    public partial class ActionMap_Base : SimObject
    {
        #region ProxyObjects Operator Overrides

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(ActionMap_Base ts, string simobjectid)
        {
            return ReferenceEquals(ts, null) ? ReferenceEquals(simobjectid, null) : ts.Equals(simobjectid);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            return (this._ID == (string) myReflections.ChangeType(obj, typeof (string)));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator !=(ActionMap_Base ts, string simobjectid)
        {
            if (ReferenceEquals(ts, null))
                return !ReferenceEquals(simobjectid, null);
            return !ts.Equals(simobjectid);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator string(ActionMap_Base ts)
        {
            if (ReferenceEquals(ts, null))
                return "0";
            return ts._ID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator ActionMap_Base(string ts)
        {
            uint simobjectid = resolveobject(ts);
            return (ActionMap_Base) Omni.self.getSimObject(simobjectid, typeof (ActionMap_Base));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int(ActionMap_Base ts)
        {
            return (int) ts._iID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator ActionMap_Base(int simobjectid)
        {
            return (ActionMap) Omni.self.getSimObject((uint) simobjectid, typeof (ActionMap_Base));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint(ActionMap_Base ts)
        {
            return ts._iID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator ActionMap_Base(uint simobjectid)
        {
            return (ActionMap_Base) Omni.self.getSimObject(simobjectid, typeof (ActionMap_Base));
        }

        #endregion

        #region Init Persists

        #endregion

        #region Member Functions

        /// <summary>
        /// ( ActionMap, bind, bool, 5, 10, actionMap.bind( device, action, [modifier spec, mod...], command ) 			  @hide)
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public bool bind(string a2, string a3, string a4, string a5 = "", string a6 = "", string a7 = "", string a8 = "", string a9 = "")
        {
            return m_ts.fnActionMap_bind(_ID, a2, a3, a4, a5, a6, a7, a8, a9);
        }

        /// <summary>
        ///  ),    @brief Associates a make command and optional break command to a specified input device action.    Must include parenthesis and semicolon in the make and break command strings.    @param device The device to bind to. Can be a keyboard, mouse, joystick or gamepad.    @param action The device action to bind to. The action is dependant upon the device. Specify a key for keyboards.    @param makeCmd The command to execute when the device/action is made.    @param breakCmd [optional] The command to execute when the device or action is unmade.    @return True the bind was successful, false if the device was unknown or description failed.	@tsexample	// Print to the console when the spacebar is pressed	function onSpaceDown()	{	   echo(\"Space bar down!\");	}	// Print to the console when the spacebar is released	function onSpaceUp()	{	   echo(\"Space bar up!\");	}   // Bind the commands onSpaceDown() and onSpaceUp() to spacebar events	moveMap.bindCmd(keyboard, \"space\", \"onSpaceDown();\", \"onSpaceUp();\");	@endtsexample)
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public bool bindCmd(string device, string action, string makeCmd, string breakCmd = "")
        {
            return m_ts.fnActionMap_bindCmd(_ID, device, action, makeCmd, breakCmd);
        }

        /// <summary>
        /// ( ActionMap, bindObj, bool, 6, 11, (device, action, [modifier spec, mod...], command, object)			  @hide)
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public bool bindObj(string a2, string a3, string a4, string a5, string a6 = "", string a7 = "", string a8 = "", string a9 = "", string a10 = "")
        {
            return m_ts.fnActionMap_bindObj(_ID, a2, a3, a4, a5, a6, a7, a8, a9, a10);
        }

        /// <summary>
        /// @brief Gets the ActionMap binding for the specified command.   Use getField() on the return value to get the device and action of the binding.   @param command The function to search bindings for.   @return The binding against the specified command. Returns an empty string(\"\")    if a binding wasn't found.	@tsexample	// Find what the function \"jump()\" is bound to in moveMap	%bind = moveMap.getBinding( \"jump\" );	if ( %bind !$= \"\" )	{	// Find out what device is used in the binding		%device = getField( %bind, 0 );	// Find out what action (such as a key) is used in the binding		%action = getField( %bind, 1 );	}	@endtsexample   @see getField)
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public string getBinding(string command)
        {
            return m_ts.fnActionMap_getBinding(_ID, command);
        }

        /// <summary>
        /// @brief Gets ActionMap command for the device and action.   @param device The device that was bound. Can be a keyboard, mouse, joystick or a gamepad.   @param action The device action that was bound.  The action is dependant upon the device. Specify a key for keyboards.   @return The command against the specified device and action.	@tsexample	// Find what function is bound to a device\'s action	// In this example, \"jump()\" was assigned to the space key in another script	%command = moveMap.getCommand(\"keyboard\", \"space\");	// Should print \"jump\" in the console	echo(%command)	@endtsexample)
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public string getCommand(string device, string action)
        {
            return m_ts.fnActionMap_getCommand(_ID, device, action);
        }

        /// <summary>
        /// @brief Gets the Dead zone for the specified device and action.   @param device The device that was bound.  Can be a keyboard, mouse, joystick or a gamepad.   @param action The device action that was bound. The action is dependant upon the device. Specify a key for keyboards.   @return The dead zone for the specified device and action. Returns \"0 0\" if there is no dead zone     or an empty string(\"\") if the mapping was not found.	@tsexample	%deadZone = moveMap.getDeadZone( \"gamepad\", \"thumbrx\");	@endtsexample)
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public string getDeadZone(string device, string action)
        {
            return m_ts.fnActionMap_getDeadZone(_ID, device, action);
        }

        /// <summary>
        /// @brief Get any scaling on the specified device and action.   @param device The device that was bound. Can be keyboard, mouse, joystick or gamepad.   @param action The device action that was bound. The action is dependant upon the device. Specify a key for keyboards.   @return Any scaling applied to the specified device and action.	@tsexample	%scale = %moveMap.getScale( \"gamepad\", \"thumbrx\");	@endtsexample)
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public float getScale(string device, string action)
        {
            return m_ts.fnActionMap_getScale(_ID, device, action);
        }

        /// <summary>
        /// @brief Determines if the specified device and action is inverted.   Should only be used for scrolling devices or gamepad/joystick axes.   @param device The device that was bound. Can be a keyboard, mouse, joystick or a gamepad.   @param action The device action that was bound.  The action is dependant upon the device. Specify a key for keyboards.   @return True if the specified device and action is inverted.	@tsexample   %if ( moveMap.isInverted( \"mouse\", \"xaxis\"))      echo(\"Mouse's xAxis is inverted\");	@endtsexample)
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public bool isInverted(string device, string action)
        {
            return m_ts.fnActionMap_isInverted(_ID, device, action);
        }

        /// <summary>
        /// @brief Pop the ActionMap off the %ActionMap stack.   Deactivates an %ActionMap and removes it from the @ActionMap stack.	@tsexample	// Deactivate moveMap	moveMap.pop();	@endtsexample   @see ActionMap)
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public void pop()
        {
            m_ts.fnActionMap_pop(_ID);
        }

        /// <summary>
        /// @brief Push the ActionMap onto the %ActionMap stack.   Activates an ActionMap and placees it at the top of the ActionMap stack.	@tsexample	// Make moveMap the active action map	moveMap.push();	@endtsexample   @see ActionMap)
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public void push()
        {
            m_ts.fnActionMap_push(_ID);
        }

        /// <summary>
        /// @brief Saves the ActionMap to a file or dumps it to the console.   @param fileName The file path to save the ActionMap to. If a filename is not specified     the ActionMap will be dumped to the console.   @param append Whether to write the ActionMap at the end of the file or overwrite it.	@tsexample	// Write out the actionmap into the config.cs file   moveMap.save( \"scripts/client/config.cs\" );	@endtsexample)
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public void save(string fileName = null, bool append = false)
        {
            if (fileName == null)
                fileName = null;

            m_ts.fnActionMap_save(_ID, fileName, append);
        }

        /// <summary>
        /// @brief Removes the binding on an input device and action.   @param device The device to unbind from. Can be a keyboard, mouse, joystick or a gamepad.   @param action The device action to unbind from. The action is dependant upon the device. Specify a key for keyboards.   @return True if the unbind was successful, false if the device was unknown or description failed.	@tsexample	moveMap.unbind(\"keyboard\", \"space\");	@endtsexample)
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public bool unbind(string device, string action)
        {
            return m_ts.fnActionMap_unbind(_ID, device, action);
        }

        /// <summary>
        /// @brief Remove any object-binding on an input device and action.   @param device The device to bind to.  Can be keyboard, mouse, joystick or gamepad.   @param action The device action to unbind from. The action is dependant upon the device. Specify a key for keyboards.   @param obj The object to perform unbind against.   @return True if the unbind was successful, false if the device was unknown or description failed.	@tsexample   moveMap.unbindObj(\"keyboard\", \"numpad1\", \"rangeChange\", %player);   @endtsexample)
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public bool unbindObj(string device, string action, string obj)
        {
            return m_ts.fnActionMap_unbindObj(_ID, device, action, obj);
        }

        #endregion

        #region T3D Callbacks

        #endregion

        public ActionMap_Base()
        {
        }
    }
}