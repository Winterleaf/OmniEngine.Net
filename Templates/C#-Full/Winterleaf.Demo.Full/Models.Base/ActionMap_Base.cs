


#region
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WinterLeaf.Engine;
using WinterLeaf.Engine.Classes;
using WinterLeaf.Engine.Containers;
using WinterLeaf.Engine.Enums;
using System.ComponentModel;
using System.Threading;
using  WinterLeaf.Engine.Classes.Interopt;
using WinterLeaf.Engine.Classes.Decorations;
using WinterLeaf.Engine.Classes.Extensions;
using WinterLeaf.Engine.Classes.Helpers;
using WinterLeaf.Demo.Full.Models.User.Extendable;
#endregion

namespace WinterLeaf.Demo.Full.Models.Base
    {
    /// <summary>
    /// 
    /// </summary>
    [TypeConverter(typeof(TypeConverterGeneric<ActionMap_Base>))]
    public partial class ActionMap_Base: SimObject
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
            return object.ReferenceEquals(ts, null) ? object.ReferenceEquals(simobjectid, null) : ts.Equals(simobjectid);
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
            
            return (this._ID ==(string)myReflections.ChangeType( obj,typeof(string)));
            }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator !=(ActionMap_Base ts, string simobjectid)
            {
            if (object.ReferenceEquals(ts, null))
                return !object.ReferenceEquals(simobjectid, null);
            return !ts.Equals(simobjectid);

            }


            /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator string( ActionMap_Base ts)
            {
            if (object.ReferenceEquals(ts, null))
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
           return  (ActionMap_Base) Omni.self.getSimObject(simobjectid,typeof(ActionMap_Base));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int( ActionMap_Base ts)
            {
            return (int)ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator ActionMap_Base(int simobjectid)
            {
            return  (ActionMap) Omni.self.getSimObject((uint)simobjectid,typeof(ActionMap_Base));
            }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint( ActionMap_Base ts)
            {
            return ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator ActionMap_Base(uint simobjectid)
            {
            return  (ActionMap_Base) Omni.self.getSimObject(simobjectid,typeof(ActionMap_Base));
            }
#endregion
#region Init Persists

#endregion
#region Member Functions
/// <summary>
/// ( ActionMap, bind, bool, 5, 10, actionMap.bind( device, action, [modifier spec, mod...], command ) 
/// 			  @hide)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  bool bind(string a2, string a3, string a4, string a5= "", string a6= "", string a7= "", string a8= "", string a9= ""){

return pInvokes.m_ts.fnActionMap_bind(_ID, a2, a3, a4, a5, a6, a7, a8, a9);
}
/// <summary>
///  ),
///     @brief Associates a make command and optional break command to a specified input device action.
///     Must include parenthesis and semicolon in the make and break command strings.
///     @param device The device to bind to. Can be a keyboard, mouse, joystick or gamepad.
///     @param action The device action to bind to. The action is dependant upon the device. Specify a key for keyboards.
///     @param makeCmd The command to execute when the device/action is made.
///     @param breakCmd [optional] The command to execute when the device or action is unmade.
///     @return True the bind was successful, false if the device was unknown or description failed.
/// 	@tsexample
/// 	// Print to the console when the spacebar is pressed
/// 	function onSpaceDown()
/// 	{
/// 	   echo(\"Space bar down!\");
/// 	}
/// 	// Print to the console when the spacebar is released
/// 	function onSpaceUp()
/// 	{
/// 	   echo(\"Space bar up!\");
/// 	}
///    // Bind the commands onSpaceDown() and onSpaceUp() to spacebar events
/// 	moveMap.bindCmd(keyboard, \"space\", \"onSpaceDown();\", \"onSpaceUp();\");
/// 	@endtsexample)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  bool bindCmd(string device, string action, string makeCmd, string breakCmd = ""){

return pInvokes.m_ts.fnActionMap_bindCmd(_ID, device, action, makeCmd, breakCmd);
}
/// <summary>
/// ( ActionMap, bindObj, bool, 6, 11, (device, action, [modifier spec, mod...], command, object)
/// 			  @hide)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  bool bindObj(string a2, string a3, string a4, string a5, string a6= "", string a7= "", string a8= "", string a9= "", string a10= ""){

return pInvokes.m_ts.fnActionMap_bindObj(_ID, a2, a3, a4, a5, a6, a7, a8, a9, a10);
}
/// <summary>
/// @brief Gets the ActionMap binding for the specified command.
///    Use getField() on the return value to get the device and action of the binding.
///    @param command The function to search bindings for.
///    @return The binding against the specified command. Returns an empty string(\"\") 
///    if a binding wasn't found.
/// 	@tsexample
/// 	// Find what the function \"jump()\" is bound to in moveMap
/// 	%bind = moveMap.getBinding( \"jump\" );
/// 	if ( %bind !$= \"\" )
/// 	{
/// 	// Find out what device is used in the binding
/// 		%device = getField( %bind, 0 );
/// 	// Find out what action (such as a key) is used in the binding
/// 		%action = getField( %bind, 1 );
/// 	}
/// 	@endtsexample
///    @see getField)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  string getBinding(string command){

return pInvokes.m_ts.fnActionMap_getBinding(_ID, command);
}
/// <summary>
/// @brief Gets ActionMap command for the device and action.
///    @param device The device that was bound. Can be a keyboard, mouse, joystick or a gamepad.
///    @param action The device action that was bound.  The action is dependant upon the device. Specify a key for keyboards.
///    @return The command against the specified device and action.
/// 	@tsexample
/// 	// Find what function is bound to a device\'s action
/// 	// In this example, \"jump()\" was assigned to the space key in another script
/// 	%command = moveMap.getCommand(\"keyboard\", \"space\");
/// 	// Should print \"jump\" in the console
/// 	echo(%command)
/// 	@endtsexample)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  string getCommand(string device, string action){

return pInvokes.m_ts.fnActionMap_getCommand(_ID, device, action);
}
/// <summary>
/// @brief Gets the Dead zone for the specified device and action.
///    @param device The device that was bound.  Can be a keyboard, mouse, joystick or a gamepad.
///    @param action The device action that was bound. The action is dependant upon the device. Specify a key for keyboards.
///    @return The dead zone for the specified device and action. Returns \"0 0\" if there is no dead zone  
///    or an empty string(\"\") if the mapping was not found.
/// 	@tsexample
/// 	%deadZone = moveMap.getDeadZone( \"gamepad\", \"thumbrx\");
/// 	@endtsexample)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  string getDeadZone(string device, string action){

return pInvokes.m_ts.fnActionMap_getDeadZone(_ID, device, action);
}
/// <summary>
/// @brief Get any scaling on the specified device and action.
///    @param device The device that was bound. Can be keyboard, mouse, joystick or gamepad.
///    @param action The device action that was bound. The action is dependant upon the device. Specify a key for keyboards.
///    @return Any scaling applied to the specified device and action.
/// 	@tsexample
/// 	%scale = %moveMap.getScale( \"gamepad\", \"thumbrx\");
/// 	@endtsexample)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  float getScale(string device, string action){

return pInvokes.m_ts.fnActionMap_getScale(_ID, device, action);
}
/// <summary>
/// @brief Determines if the specified device and action is inverted.
///    Should only be used for scrolling devices or gamepad/joystick axes.
///    @param device The device that was bound. Can be a keyboard, mouse, joystick or a gamepad.
///    @param action The device action that was bound.  The action is dependant upon the device. Specify a key for keyboards.
///    @return True if the specified device and action is inverted.
/// 	@tsexample
///    %if ( moveMap.isInverted( \"mouse\", \"xaxis\"))
///       echo(\"Mouse's xAxis is inverted\");
/// 	@endtsexample)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  bool isInverted(string device, string action){

return pInvokes.m_ts.fnActionMap_isInverted(_ID, device, action);
}
/// <summary>
/// @brief Pop the ActionMap off the %ActionMap stack.
///    Deactivates an %ActionMap and removes it from the @ActionMap stack.
/// 	@tsexample
/// 	// Deactivate moveMap
/// 	moveMap.pop();
/// 	@endtsexample
///    @see ActionMap)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void pop(){

pInvokes.m_ts.fnActionMap_pop(_ID);
}
/// <summary>
/// @brief Push the ActionMap onto the %ActionMap stack.
///    Activates an ActionMap and placees it at the top of the ActionMap stack.
/// 	@tsexample
/// 	// Make moveMap the active action map
/// 	moveMap.push();
/// 	@endtsexample
///    @see ActionMap)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void push(){

pInvokes.m_ts.fnActionMap_push(_ID);
}
/// <summary>
/// @brief Saves the ActionMap to a file or dumps it to the console.
///    @param fileName The file path to save the ActionMap to. If a filename is not specified 
///     the ActionMap will be dumped to the console.
///    @param append Whether to write the ActionMap at the end of the file or overwrite it.
/// 	@tsexample
/// 	// Write out the actionmap into the config.cs file
///    moveMap.save( \"scripts/client/config.cs\" );
/// 	@endtsexample)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void save(string fileName = null , bool append = false){
if (fileName== null) {fileName = null;}

pInvokes.m_ts.fnActionMap_save(_ID, fileName, append);
}
/// <summary>
/// @brief Removes the binding on an input device and action.
///    @param device The device to unbind from. Can be a keyboard, mouse, joystick or a gamepad.
///    @param action The device action to unbind from. The action is dependant upon the device. Specify a key for keyboards.
///    @return True if the unbind was successful, false if the device was unknown or description failed.
/// 	@tsexample
/// 	moveMap.unbind(\"keyboard\", \"space\");
/// 	@endtsexample)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  bool unbind(string device, string action){

return pInvokes.m_ts.fnActionMap_unbind(_ID, device, action);
}
/// <summary>
/// @brief Remove any object-binding on an input device and action.
///    @param device The device to bind to.  Can be keyboard, mouse, joystick or gamepad.
///    @param action The device action to unbind from. The action is dependant upon the device. Specify a key for keyboards.
///    @param obj The object to perform unbind against.
///    @return True if the unbind was successful, false if the device was unknown or description failed.
/// 	@tsexample
///    moveMap.unbindObj(\"keyboard\", \"numpad1\", \"rangeChange\", %player);
///    @endtsexample)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  bool unbindObj(string device, string action, string obj){

return pInvokes.m_ts.fnActionMap_unbindObj(_ID, device, action, obj);
}

#endregion
#region T3D Callbacks

#endregion
public ActionMap_Base (){}
}}
