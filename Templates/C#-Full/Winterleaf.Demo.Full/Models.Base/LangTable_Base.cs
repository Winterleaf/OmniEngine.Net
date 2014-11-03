


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
    [TypeConverter(typeof(TypeConverterGeneric<LangTable_Base>))]
    public partial class LangTable_Base: SimObject
{

#region ProxyObjects Operator Overrides
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(LangTable_Base ts, string simobjectid)
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
        public static bool operator !=(LangTable_Base ts, string simobjectid)
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
        public static implicit operator string( LangTable_Base ts)
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
        public static implicit operator LangTable_Base(string ts)
            {
            uint simobjectid = resolveobject(ts);
           return  (LangTable_Base) Omni.self.getSimObject(simobjectid,typeof(LangTable_Base));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int( LangTable_Base ts)
            {
            return (int)ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator LangTable_Base(int simobjectid)
            {
            return  (LangTable) Omni.self.getSimObject((uint)simobjectid,typeof(LangTable_Base));
            }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint( LangTable_Base ts)
            {
            return ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator LangTable_Base(uint simobjectid)
            {
            return  (LangTable_Base) Omni.self.getSimObject(simobjectid,typeof(LangTable_Base));
            }
#endregion
#region Init Persists

#endregion
#region Member Functions
/// <summary>
/// , ), 
/// 			  (string filename, [string languageName])
/// 			  @brief Adds a language to the table
/// 			  @param filename Name and path to the language file
/// 			  @param languageName Optional name to assign to the new language entry
/// 			  @return True If file was successfully found and language created
/// 			  )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  int addLanguage(string filename = "", string languageName = ""){

return pInvokes.m_ts.fn_LangTable_addLanguage(_ID, filename, languageName);
}
/// <summary>
/// ()
/// 			  @brief Get the ID of the current language table
/// 			  @return Numerical ID of the current language table)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  int getCurrentLanguage(){

return pInvokes.m_ts.fn_LangTable_getCurrentLanguage(_ID);
}
/// <summary>
/// (int language)
/// 			  @brief Return the readable name of the language table
/// 			  @param language Numerical ID of the language table to access
/// 			  @return String containing the name of the table, NULL if ID was invalid or name was never specified)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  string getLangName(int langId){

return pInvokes.m_ts.fn_LangTable_getLangName(_ID, langId);
}
/// <summary>
/// ()
/// 			  @brief Used to find out how many languages are in the table
/// 			  @return Size of the vector containing the languages, numerical)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  int getNumLang(){

return pInvokes.m_ts.fn_LangTable_getNumLang(_ID);
}
/// <summary>
/// (string filename)
/// 			  @brief Grabs a string from the specified table
/// 			  If an invalid is passed, the function will attempt to 
/// 			  to grab from the default table
/// 			  @param filename Name of the language table to access
/// 			  @return Text from the specified language table, \"\" if ID was invalid and default table is not set)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  string getString(uint id){

return pInvokes.m_ts.fn_LangTable_getString(_ID, id);
}
/// <summary>
/// (int language)
/// 			  @brief Sets the current language table for grabbing text
/// 			  @param language ID of the table)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void setCurrentLanguage(int langId){

pInvokes.m_ts.fn_LangTable_setCurrentLanguage(_ID, langId);
}
/// <summary>
/// (int language)
/// 			  @brief Sets the default language table
/// 			  @param language ID of the table)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void setDefaultLanguage(int langId){

pInvokes.m_ts.fn_LangTable_setDefaultLanguage(_ID, langId);
}

#endregion
#region T3D Callbacks

#endregion
public LangTable_Base (){}
}}
