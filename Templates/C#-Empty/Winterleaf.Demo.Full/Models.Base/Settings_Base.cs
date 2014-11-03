


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
    [TypeConverter(typeof(TypeConverterGeneric<Settings_Base>))]
    public partial class Settings_Base: SimObject
{

#region ProxyObjects Operator Overrides
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(Settings_Base ts, string simobjectid)
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
        public static bool operator !=(Settings_Base ts, string simobjectid)
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
        public static implicit operator string( Settings_Base ts)
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
        public static implicit operator Settings_Base(string ts)
            {
            uint simobjectid = resolveobject(ts);
           return  (Settings_Base) Omni.self.getSimObject(simobjectid,typeof(Settings_Base));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int( Settings_Base ts)
            {
            return (int)ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator Settings_Base(int simobjectid)
            {
            return  (Settings) Omni.self.getSimObject((uint)simobjectid,typeof(Settings_Base));
            }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint( Settings_Base ts)
            {
            return ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator Settings_Base(uint simobjectid)
            {
            return  (Settings_Base) Omni.self.getSimObject(simobjectid,typeof(Settings_Base));
            }
#endregion
#region Init Persists
/// <summary>
/// The file path and name to be saved to and loaded from.
/// </summary>
[MemberGroup("")]
public String file
       {
       get
          {
          return Omni.self.GetVar(_ID + ".file").AsString();
          }
       set
          {
          Omni.self.SetVar(_ID + ".file", value.AsString());
          }
       }

#endregion
#region Member Functions
/// <summary>
/// settingObj.beginGroup(groupName, fromStart = false);)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void beginGroup(string groupName, bool includeDefaults = false){

pInvokes.m_ts.fn_Settings_beginGroup(_ID, groupName, includeDefaults);
}
/// <summary>
/// settingObj.clearGroups();)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void clearGroups(){

pInvokes.m_ts.fn_Settings_clearGroups(_ID);
}
/// <summary>
/// settingObj.endGroup();)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void endGroup(){

pInvokes.m_ts.fn_Settings_endGroup(_ID);
}
/// <summary>
/// , false, false), settingObj.findFirstValue();)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  string findFirstValue(string pattern = "", bool deepSearch = false, bool includeDefaults = false){

return pInvokes.m_ts.fn_Settings_findFirstValue(_ID, pattern, deepSearch, includeDefaults);
}
/// <summary>
/// settingObj.findNextValue();)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  string findNextValue(){

return pInvokes.m_ts.fn_Settings_findNextValue(_ID);
}
/// <summary>
/// settingObj.getCurrentGroups();)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  string getCurrentGroups(){

return pInvokes.m_ts.fn_Settings_getCurrentGroups(_ID);
}
/// <summary>
/// %success = settingObj.read();)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  bool read(){

return pInvokes.m_ts.fn_Settings_read(_ID);
}
/// <summary>
/// settingObj.remove(settingName, includeDefaults = false);)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void remove(string settingName, bool includeDefaults = false){

pInvokes.m_ts.fn_Settings_remove(_ID, settingName, includeDefaults);
}
/// <summary>
/// settingObj.setDefaultValue(settingName, value);)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void setDefaultValue(string settingName, string value){

pInvokes.m_ts.fn_Settings_setDefaultValue(_ID, settingName, value);
}
/// <summary>
/// ), settingObj.setValue(settingName, value);)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void setValue(string settingName, string value = ""){

pInvokes.m_ts.fn_Settings_setValue(_ID, settingName, value);
}
/// <summary>
/// ), settingObj.value(settingName, defaultValue);)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  string value(string settingName, string defaultValue = ""){

return pInvokes.m_ts.fn_Settings_value(_ID, settingName, defaultValue);
}
/// <summary>
/// (Settings, write, bool, 2, 2, %success = settingObj.write();)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  bool write(){

return pInvokes.m_ts.fnSettings_write(_ID);
}

#endregion
#region T3D Callbacks

#endregion
public Settings_Base (){}
}}
