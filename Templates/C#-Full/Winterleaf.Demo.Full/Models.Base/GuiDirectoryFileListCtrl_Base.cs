


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
    [TypeConverter(typeof(TypeConverterGeneric<GuiDirectoryFileListCtrl_Base>))]
    public partial class GuiDirectoryFileListCtrl_Base: GuiListBoxCtrl
{

#region ProxyObjects Operator Overrides
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(GuiDirectoryFileListCtrl_Base ts, string simobjectid)
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
        public static bool operator !=(GuiDirectoryFileListCtrl_Base ts, string simobjectid)
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
        public static implicit operator string( GuiDirectoryFileListCtrl_Base ts)
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
        public static implicit operator GuiDirectoryFileListCtrl_Base(string ts)
            {
            uint simobjectid = resolveobject(ts);
           return  (GuiDirectoryFileListCtrl_Base) Omni.self.getSimObject(simobjectid,typeof(GuiDirectoryFileListCtrl_Base));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int( GuiDirectoryFileListCtrl_Base ts)
            {
            return (int)ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator GuiDirectoryFileListCtrl_Base(int simobjectid)
            {
            return  (GuiDirectoryFileListCtrl) Omni.self.getSimObject((uint)simobjectid,typeof(GuiDirectoryFileListCtrl_Base));
            }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint( GuiDirectoryFileListCtrl_Base ts)
            {
            return ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator GuiDirectoryFileListCtrl_Base(uint simobjectid)
            {
            return  (GuiDirectoryFileListCtrl_Base) Omni.self.getSimObject(simobjectid,typeof(GuiDirectoryFileListCtrl_Base));
            }
#endregion
#region Init Persists
/// <summary>
/// Tab-delimited list of file name patterns. Only matched files will be displayed. 
/// </summary>
[MemberGroup("")]
public String fileFilter
       {
       get
          {
          return Omni.self.GetVar(_ID + ".fileFilter").AsString();
          }
       set
          {
          Omni.self.SetVar(_ID + ".fileFilter", value.AsString());
          }
       }
/// <summary>
/// Path in game directory from which to list files. 
/// </summary>
[MemberGroup("")]
public String filePath
       {
       get
          {
          return Omni.self.GetVar(_ID + ".filePath").AsString();
          }
       set
          {
          Omni.self.SetVar(_ID + ".filePath", value.AsString());
          }
       }

#endregion
#region Member Functions
/// <summary>
/// Get the currently selected filename.
///    @return The filename of the currently selected file )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  string getSelectedFile(){

return pInvokes.m_ts.fnGuiDirectoryFileListCtrl_getSelectedFile(_ID);
}
/// <summary>
/// Get the list of selected files.
///    @return A space separated list of selected files )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  string getSelectedFiles(){

return pInvokes.m_ts.fnGuiDirectoryFileListCtrl_getSelectedFiles(_ID);
}
/// <summary>
/// Update the file list. )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void reload(){

pInvokes.m_ts.fnGuiDirectoryFileListCtrl_reload(_ID);
}
/// <summary>
/// Set the file filter.
///    @param filter Tab-delimited list of file name patterns. Only matched files will be displayed. )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void setFilter(string filter){

pInvokes.m_ts.fnGuiDirectoryFileListCtrl_setFilter(_ID, filter);
}
/// <summary>
/// Set the search path and file filter.
///    @param path   Path in game directory from which to list files.
///    @param filter Tab-delimited list of file name patterns. Only matched files will be displayed. )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  bool setPath(string path, string filter){

return pInvokes.m_ts.fnGuiDirectoryFileListCtrl_setPath(_ID, path, filter);
}

#endregion
#region T3D Callbacks

#endregion
public GuiDirectoryFileListCtrl_Base (){}
}}
