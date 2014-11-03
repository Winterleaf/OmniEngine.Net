


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
    [TypeConverter(typeof(TypeConverterGeneric<TerrainBlock_Base>))]
    public partial class TerrainBlock_Base: SceneObject
{

#region ProxyObjects Operator Overrides
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(TerrainBlock_Base ts, string simobjectid)
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
        public static bool operator !=(TerrainBlock_Base ts, string simobjectid)
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
        public static implicit operator string( TerrainBlock_Base ts)
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
        public static implicit operator TerrainBlock_Base(string ts)
            {
            uint simobjectid = resolveobject(ts);
           return  (TerrainBlock_Base) Omni.self.getSimObject(simobjectid,typeof(TerrainBlock_Base));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int( TerrainBlock_Base ts)
            {
            return (int)ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator TerrainBlock_Base(int simobjectid)
            {
            return  (TerrainBlock) Omni.self.getSimObject((uint)simobjectid,typeof(TerrainBlock_Base));
            }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint( TerrainBlock_Base ts)
            {
            return ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator TerrainBlock_Base(uint simobjectid)
            {
            return  (TerrainBlock_Base) Omni.self.getSimObject(simobjectid,typeof(TerrainBlock_Base));
            }
#endregion
#region Init Persists
/// <summary>
/// Size of base texture size per meter. 
/// </summary>
[MemberGroup("Misc")]
public int baseTexSize
       {
       get
          {
          return Omni.self.GetVar(_ID + ".baseTexSize").AsInt();
          }
       set
          {
          Omni.self.SetVar(_ID + ".baseTexSize", value.AsString());
          }
       }
/// <summary>
/// Allows the terrain to cast shadows onto itself and other objects.
/// </summary>
[MemberGroup("Misc")]
public bool castShadows
       {
       get
          {
          return Omni.self.GetVar(_ID + ".castShadows").AsBool();
          }
       set
          {
          Omni.self.SetVar(_ID + ".castShadows", value.AsString());
          }
       }
/// <summary>
/// Light map dimensions in pixels. 
/// </summary>
[MemberGroup("Misc")]
public int lightMapSize
       {
       get
          {
          return Omni.self.GetVar(_ID + ".lightMapSize").AsInt();
          }
       set
          {
          Omni.self.SetVar(_ID + ".lightMapSize", value.AsString());
          }
       }
/// <summary>
/// Not yet implemented. 
/// </summary>
[MemberGroup("Misc")]
public int screenError
       {
       get
          {
          return Omni.self.GetVar(_ID + ".screenError").AsInt();
          }
       set
          {
          Omni.self.SetVar(_ID + ".screenError", value.AsString());
          }
       }
/// <summary>
/// Indicates the spacing between points on the XY plane on the terrain. 
/// </summary>
[MemberGroup("Misc")]
public float squareSize
       {
       get
          {
          return Omni.self.GetVar(_ID + ".squareSize").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".squareSize", value.AsString());
          }
       }
/// <summary>
/// The source terrain data file. 
/// </summary>
[MemberGroup("Media")]
public String terrainFile
       {
       get
          {
          return Omni.self.GetVar(_ID + ".terrainFile").AsString();
          }
       set
          {
          Omni.self.SetVar(_ID + ".terrainFile", value.AsString());
          }
       }

#endregion
#region Member Functions
/// <summary>
/// png), (string filename, [string format]) - export the terrain block's heightmap to a bitmap file (default: png) )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  bool exportHeightMap(string fileNameStr, string format = "png"){

return pInvokes.m_ts.fn_TerrainBlock_exportHeightMap(_ID, fileNameStr, format);
}
/// <summary>
/// png), (string filePrefix, [string format]) - export the terrain block's layer maps to bitmap files (default: png) )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  bool exportLayerMaps(string filePrefixStr, string format = "png"){

return pInvokes.m_ts.fn_TerrainBlock_exportLayerMaps(_ID, filePrefixStr, format);
}
/// <summary>
/// @brief Saves the terrain block's terrain file to the specified file name.
/// 
/// 				   @param fileName Name and path of file to save terrain data to.
/// 
/// 				   @return True if file save was successful, false otherwise)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  bool save(string fileName){

return pInvokes.m_ts.fnTerrainBlock_save(_ID, fileName);
}

#endregion
#region T3D Callbacks

#endregion
public TerrainBlock_Base (){}
}}
