


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
    [TypeConverter(typeof(TypeConverterGeneric<GuiImageList_Base>))]
    public partial class GuiImageList_Base: SimObject
{

#region ProxyObjects Operator Overrides
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(GuiImageList_Base ts, string simobjectid)
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
        public static bool operator !=(GuiImageList_Base ts, string simobjectid)
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
        public static implicit operator string( GuiImageList_Base ts)
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
        public static implicit operator GuiImageList_Base(string ts)
            {
            uint simobjectid = resolveobject(ts);
           return  (GuiImageList_Base) Omni.self.getSimObject(simobjectid,typeof(GuiImageList_Base));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int( GuiImageList_Base ts)
            {
            return (int)ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator GuiImageList_Base(int simobjectid)
            {
            return  (GuiImageList) Omni.self.getSimObject((uint)simobjectid,typeof(GuiImageList_Base));
            }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint( GuiImageList_Base ts)
            {
            return ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator GuiImageList_Base(uint simobjectid)
            {
            return  (GuiImageList_Base) Omni.self.getSimObject(simobjectid,typeof(GuiImageList_Base));
            }
#endregion
#region Init Persists

#endregion
#region Member Functions
/// <summary>
/// @brief Clears the imagelist
///    @tsexample
///    // Inform the GuiImageList control to clear itself.
///    %isFinished = %thisGuiImageList.clear();
///    @endtsexample
///    @return Returns true when finished.
///    @see SimObject)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  bool clear(){

return pInvokes.m_ts.fnGuiImageList_clear(_ID);
}
/// <summary>
/// @brief Gets the number of images in the list.
///    @tsexample
///    // Request the number of images from the GuiImageList control.
///    %imageCount = %thisGuiImageList.count();
///    @endtsexample
///    @return Number of images in the control.
///    @see SimObject)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  int count(){

return pInvokes.m_ts.fnGuiImageList_count(_ID);
}
/// <summary>
/// @brief Get a path to the texture at the specified index.
///    @param index Index of the image in the list.
///    @tsexample
///    // Define the image index/n
///    %index = \"5\";
///    // Request the image path location from the control.
///    %imagePath = %thisGuiImageList.getImage(%index);
///    @endtsexample
///    @return File path to the image map for the specified index.
///    @see SimObject)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  string getImage(int index){

return pInvokes.m_ts.fnGuiImageList_getImage(_ID, index);
}
/// <summary>
/// @brief Retrieves the imageindex of a specified texture in the list.
///    @param imagePath Imagemap including filepath of image to search for
///    @tsexample
///    // Define the imagemap to search for
///    %imagePath = \"./game/client/data/images/thisImage\";
///    // Request the index entry for the defined imagemap
///    %imageIndex = %thisGuiImageList.getIndex(%imagePath);
///    @endtsexample
///    @return Index of the imagemap matching the defined image path.
///    @see SimObject)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  int getIndex(string imagePath){

return pInvokes.m_ts.fnGuiImageList_getIndex(_ID, imagePath);
}
/// <summary>
/// @brief Insert an image into imagelist- returns the image index or -1 for failure.
///    @param imagePath Imagemap, with path, to add to the list.
///    @tsexample
///    // Define the imagemap to add to the list
///    %imagePath = \"./game/client/data/images/thisImage\";
///    // Request the GuiImageList control to add the defined image to its list.
///    %imageIndex = %thisGuiImageList.insert(%imagePath);
///    @endtsexample
///    @return The index of the newly inserted imagemap, or -1 if the insertion failed.
///    @see SimObject)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  int insert(string imagePath){

return pInvokes.m_ts.fnGuiImageList_insert(_ID, imagePath);
}
/// <summary>
/// @brief Removes an image from the list by index.
///    @param index Image index to remove.
///    @tsexample
///    // Define the image index.
///    %imageIndex = \"4\";
///    // Inform the GuiImageList control to remove the image at the defined index.
///    %wasSuccessful = %thisGuiImageList.remove(%imageIndex);
///    @endtsexample
///    @return True if the operation was successful, false if it was not.
///    @see SimObject)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  bool remove(int index){

return pInvokes.m_ts.fnGuiImageList_remove(_ID, index);
}

#endregion
#region T3D Callbacks

#endregion
public GuiImageList_Base (){}
}}
