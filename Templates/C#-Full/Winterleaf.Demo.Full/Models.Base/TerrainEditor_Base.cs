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
using System.ComponentModel;
using WinterLeaf.Demo.Full.Models.User.Extendable;
using WinterLeaf.Engine;
using WinterLeaf.Engine.Classes.Decorations;
using WinterLeaf.Engine.Classes.Extensions;
using WinterLeaf.Engine.Classes.Helpers;
using WinterLeaf.Engine.Classes.Interopt;
using WinterLeaf.Engine.Containers;

#endregion

namespace WinterLeaf.Demo.Full.Models.Base
{
    /// <summary>
    /// 
    /// </summary>
    [TypeConverter(typeof (TypeConverterGeneric<TerrainEditor_Base>))]
    public partial class TerrainEditor_Base : EditTSCtrl
    {
        #region ProxyObjects Operator Overrides

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(TerrainEditor_Base ts, string simobjectid)
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
        public static bool operator !=(TerrainEditor_Base ts, string simobjectid)
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
        public static implicit operator string(TerrainEditor_Base ts)
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
        public static implicit operator TerrainEditor_Base(string ts)
        {
            uint simobjectid = resolveobject(ts);
            return (TerrainEditor_Base) Omni.self.getSimObject(simobjectid, typeof (TerrainEditor_Base));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int(TerrainEditor_Base ts)
        {
            return (int) ts._iID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator TerrainEditor_Base(int simobjectid)
        {
            return (TerrainEditor) Omni.self.getSimObject((uint) simobjectid, typeof (TerrainEditor_Base));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint(TerrainEditor_Base ts)
        {
            return ts._iID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator TerrainEditor_Base(uint simobjectid)
        {
            return (TerrainEditor_Base) Omni.self.getSimObject(simobjectid, typeof (TerrainEditor_Base));
        }

        #endregion

        #region Init Persists

        /// <summary>
        /// 
        /// </summary>
        [MemberGroup("Misc")]
        public float adjustHeightMouseScale
        {
            get { return Omni.self.GetVar(_ID + ".adjustHeightMouseScale").AsFloat(); }
            set { Omni.self.SetVar(_ID + ".adjustHeightMouseScale", value.AsString()); }
        }

        /// <summary>
        /// 
        /// </summary>
        [MemberGroup("Misc")]
        public float adjustHeightVal
        {
            get { return Omni.self.GetVar(_ID + ".adjustHeightVal").AsFloat(); }
            set { Omni.self.SetVar(_ID + ".adjustHeightVal", value.AsString()); }
        }

        /// <summary>
        /// 
        /// </summary>
        [MemberGroup("Misc")]
        public ColorI borderFillColor
        {
            get { return Omni.self.GetVar(_ID + ".borderFillColor").AsColorI(); }
            set { Omni.self.SetVar(_ID + ".borderFillColor", value.AsString()); }
        }

        /// <summary>
        /// 
        /// </summary>
        [MemberGroup("Misc")]
        public ColorI borderFrameColor
        {
            get { return Omni.self.GetVar(_ID + ".borderFrameColor").AsColorI(); }
            set { Omni.self.SetVar(_ID + ".borderFrameColor", value.AsString()); }
        }

        /// <summary>
        /// 
        /// </summary>
        [MemberGroup("Misc")]
        public float borderHeight
        {
            get { return Omni.self.GetVar(_ID + ".borderHeight").AsFloat(); }
            set { Omni.self.SetVar(_ID + ".borderHeight", value.AsString()); }
        }

        /// <summary>
        /// 
        /// </summary>
        [MemberGroup("Misc")]
        public bool borderLineMode
        {
            get { return Omni.self.GetVar(_ID + ".borderLineMode").AsBool(); }
            set { Omni.self.SetVar(_ID + ".borderLineMode", value.AsString()); }
        }

        /// <summary>
        /// 
        /// </summary>
        [MemberGroup("Misc")]
        public bool isDirty
        {
            get { return Omni.self.GetVar(_ID + ".isDirty").AsBool(); }
            set { Omni.self.SetVar(_ID + ".isDirty", value.AsString()); }
        }

        /// <summary>
        /// 
        /// </summary>
        [MemberGroup("Misc")]
        public bool isMissionDirty
        {
            get { return Omni.self.GetVar(_ID + ".isMissionDirty").AsBool(); }
            set { Omni.self.SetVar(_ID + ".isMissionDirty", value.AsString()); }
        }

        /// <summary>
        /// 
        /// </summary>
        [MemberGroup("Misc")]
        public int materialGroup
        {
            get { return Omni.self.GetVar(_ID + ".materialGroup").AsInt(); }
            set { Omni.self.SetVar(_ID + ".materialGroup", value.AsString()); }
        }

        /// <summary>
        /// 
        /// </summary>
        [MemberGroup("Misc")]
        public Point2I maxBrushSize
        {
            get { return Omni.self.GetVar(_ID + ".maxBrushSize").AsPoint2I(); }
            set { Omni.self.SetVar(_ID + ".maxBrushSize", value.AsString()); }
        }

        /// <summary>
        /// 
        /// </summary>
        [MemberGroup("Misc")]
        public float noiseFactor
        {
            get { return Omni.self.GetVar(_ID + ".noiseFactor").AsFloat(); }
            set { Omni.self.SetVar(_ID + ".noiseFactor", value.AsString()); }
        }

        /// <summary>
        /// 
        /// </summary>
        [MemberGroup("Misc")]
        public int paintIndex
        {
            get { return Omni.self.GetVar(_ID + ".paintIndex").AsInt(); }
            set { Omni.self.SetVar(_ID + ".paintIndex", value.AsString()); }
        }

        /// <summary>
        /// 
        /// </summary>
        [MemberGroup("Misc")]
        public bool processUsesBrush
        {
            get { return Omni.self.GetVar(_ID + ".processUsesBrush").AsBool(); }
            set { Omni.self.SetVar(_ID + ".processUsesBrush", value.AsString()); }
        }

        /// <summary>
        /// 
        /// </summary>
        [MemberGroup("Misc")]
        public bool renderBorder
        {
            get { return Omni.self.GetVar(_ID + ".renderBorder").AsBool(); }
            set { Omni.self.SetVar(_ID + ".renderBorder", value.AsString()); }
        }

        /// <summary>
        /// 
        /// </summary>
        [MemberGroup("Misc")]
        public bool renderSolidBrush
        {
            get { return Omni.self.GetVar(_ID + ".renderSolidBrush").AsBool(); }
            set { Omni.self.SetVar(_ID + ".renderSolidBrush", value.AsString()); }
        }

        /// <summary>
        /// 
        /// </summary>
        [MemberGroup("Misc")]
        public bool renderVertexSelection
        {
            get { return Omni.self.GetVar(_ID + ".renderVertexSelection").AsBool(); }
            set { Omni.self.SetVar(_ID + ".renderVertexSelection", value.AsString()); }
        }

        /// <summary>
        /// 
        /// </summary>
        [MemberGroup("Misc")]
        public float scaleVal
        {
            get { return Omni.self.GetVar(_ID + ".scaleVal").AsFloat(); }
            set { Omni.self.SetVar(_ID + ".scaleVal", value.AsString()); }
        }

        /// <summary>
        /// 
        /// </summary>
        [MemberGroup("Misc")]
        public bool selectionHidden
        {
            get { return Omni.self.GetVar(_ID + ".selectionHidden").AsBool(); }
            set { Omni.self.SetVar(_ID + ".selectionHidden", value.AsString()); }
        }

        /// <summary>
        /// 
        /// </summary>
        [MemberGroup("Misc")]
        public float setHeightVal
        {
            get { return Omni.self.GetVar(_ID + ".setHeightVal").AsFloat(); }
            set { Omni.self.SetVar(_ID + ".setHeightVal", value.AsString()); }
        }

        /// <summary>
        /// 
        /// </summary>
        [MemberGroup("Misc")]
        public float smoothFactor
        {
            get { return Omni.self.GetVar(_ID + ".smoothFactor").AsFloat(); }
            set { Omni.self.SetVar(_ID + ".smoothFactor", value.AsString()); }
        }

        /// <summary>
        /// 
        /// </summary>
        [MemberGroup("Misc")]
        public String softSelectDefaultFilter
        {
            get { return Omni.self.GetVar(_ID + ".softSelectDefaultFilter").AsString(); }
            set { Omni.self.SetVar(_ID + ".softSelectDefaultFilter", value.AsString()); }
        }

        /// <summary>
        /// 
        /// </summary>
        [MemberGroup("Misc")]
        public String softSelectFilter
        {
            get { return Omni.self.GetVar(_ID + ".softSelectFilter").AsString(); }
            set { Omni.self.SetVar(_ID + ".softSelectFilter", value.AsString()); }
        }

        /// <summary>
        /// 
        /// </summary>
        [MemberGroup("Misc")]
        public float softSelectRadius
        {
            get { return Omni.self.GetVar(_ID + ".softSelectRadius").AsFloat(); }
            set { Omni.self.SetVar(_ID + ".softSelectRadius", value.AsString()); }
        }

        #endregion

        #region Member Functions

        /// <summary>
        /// ( string matName )   Adds a new material. )
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public int addMaterial(string matName)
        {
            return m_ts.fn_TerrainEditor_addMaterial(_ID, matName);
        }

        /// <summary>
        /// ), (TerrainBlock terrain))
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public void attachTerrain(string terrain = "")
        {
            m_ts.fn_TerrainEditor_attachTerrain(_ID, terrain);
        }

        /// <summary>
        /// (float minHeight, float maxHeight, float minSlope, float maxSlope))  
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public void autoMaterialLayer(float minHeight, float maxHeight, float minSlope, float maxSlope)
        {
            m_ts.fn_TerrainEditor_autoMaterialLayer(_ID, minHeight, maxHeight, minSlope, maxSlope);
        }

        /// <summary>
        /// )
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public void clearSelection()
        {
            m_ts.fn_TerrainEditor_clearSelection(_ID);
        }

        /// <summary>
        /// (int num))
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public string getActionName(uint index)
        {
            return m_ts.fn_TerrainEditor_getActionName(_ID, index);
        }

        /// <summary>
        /// )
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public int getActiveTerrain()
        {
            return m_ts.fn_TerrainEditor_getActiveTerrain(_ID);
        }

        /// <summary>
        /// Returns a Point2I.)
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public string getBrushPos()
        {
            return m_ts.fn_TerrainEditor_getBrushPos(_ID);
        }

        /// <summary>
        /// ())
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public float getBrushPressure()
        {
            return m_ts.fn_TerrainEditor_getBrushPressure(_ID);
        }

        /// <summary>
        /// ())
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public string getBrushSize()
        {
            return m_ts.fn_TerrainEditor_getBrushSize(_ID);
        }

        /// <summary>
        /// ())
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public float getBrushSoftness()
        {
            return m_ts.fn_TerrainEditor_getBrushSoftness(_ID);
        }

        /// <summary>
        /// ())
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public string getBrushType()
        {
            return m_ts.fn_TerrainEditor_getBrushType(_ID);
        }

        /// <summary>
        /// )
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public string getCurrentAction()
        {
            return m_ts.fn_TerrainEditor_getCurrentAction(_ID);
        }

        /// <summary>
        /// Returns the current material count. )
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public int getMaterialCount()
        {
            return m_ts.fn_TerrainEditor_getMaterialCount(_ID);
        }

        /// <summary>
        /// ( string name ) - Returns the index of the material with the given name or -1. )
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public int getMaterialIndex(string name)
        {
            return m_ts.fn_TerrainEditor_getMaterialIndex(_ID, name);
        }

        /// <summary>
        /// ( int index ) - Returns the name of the material at the given index. )
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public string getMaterialName(int index)
        {
            return m_ts.fn_TerrainEditor_getMaterialName(_ID, index);
        }

        /// <summary>
        /// () gets the list of current terrain materials.)
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public string getMaterials()
        {
            return m_ts.fn_TerrainEditor_getMaterials(_ID);
        }

        /// <summary>
        /// )
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public int getNumActions()
        {
            return m_ts.fn_TerrainEditor_getNumActions(_ID);
        }

        /// <summary>
        /// )
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public int getNumTextures()
        {
            return m_ts.fn_TerrainEditor_getNumTextures(_ID);
        }

        /// <summary>
        /// )
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public float getSlopeLimitMaxAngle()
        {
            return m_ts.fn_TerrainEditor_getSlopeLimitMaxAngle(_ID);
        }

        /// <summary>
        /// )
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public float getSlopeLimitMinAngle()
        {
            return m_ts.fn_TerrainEditor_getSlopeLimitMinAngle(_ID);
        }

        /// <summary>
        /// (S32 index))
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public int getTerrainBlock(int index)
        {
            return m_ts.fn_TerrainEditor_getTerrainBlock(_ID, index);
        }

        /// <summary>
        /// ())
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public int getTerrainBlockCount()
        {
            return m_ts.fn_TerrainEditor_getTerrainBlockCount(_ID);
        }

        /// <summary>
        /// () gets the list of current terrain materials for all terrain blocks.)
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public string getTerrainBlocksMaterialList()
        {
            return m_ts.fn_TerrainEditor_getTerrainBlocksMaterialList(_ID);
        }

        /// <summary>
        /// , , ),                                                                            (x/y/z) Gets the terrain block that is located under the given world point.                                                                           @param x/y/z The world coordinates (floating point values) you wish to query at.                                                                             These can be formatted as either a string (\"x y z\") or separately as (x, y, z)                                                                           @return Returns the ID of the requested terrain block (0 if not found).)
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public int getTerrainUnderWorldPoint(string ptOrX = "", string Y = "", string Z = "")
        {
            return m_ts.fn_TerrainEditor_getTerrainUnderWorldPoint(_ID, ptOrX, Y, Z);
        }

        /// <summary>
        /// )
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public void markEmptySquares()
        {
            m_ts.fn_TerrainEditor_markEmptySquares(_ID);
        }

        /// <summary>
        /// )
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public void mirrorTerrain(int mirrorIndex)
        {
            m_ts.fn_TerrainEditor_mirrorTerrain(_ID, mirrorIndex);
        }

        /// <summary>
        /// ), (string action=NULL))
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public void processAction(string action = "")
        {
            m_ts.fn_TerrainEditor_processAction(_ID, action);
        }

        /// <summary>
        /// ( int index ) - Remove the material at the given index. )
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public void removeMaterial(int index)
        {
            m_ts.fn_TerrainEditor_removeMaterial(_ID, index);
        }

        /// <summary>
        /// ( int index, int order )   - Reorder material at the given index to the new position, changing the order in which it is rendered / blended. )
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public void reorderMaterial(int index, int orderPos)
        {
            m_ts.fn_TerrainEditor_reorderMaterial(_ID, index, orderPos);
        }

        /// <summary>
        /// (bool clear))
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public void resetSelWeights(bool clear)
        {
            m_ts.fn_TerrainEditor_resetSelWeights(_ID, clear);
        }

        /// <summary>
        /// (string action_name))
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public void setAction(string action_name)
        {
            m_ts.fn_TerrainEditor_setAction(_ID, action_name);
        }

        /// <summary>
        /// Location)
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public void setBrushPos(Point2I pos)
        {
            m_ts.fn_TerrainEditor_setBrushPos(_ID, pos.AsString());
        }

        /// <summary>
        /// (float pressure))
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public void setBrushPressure(float pressure)
        {
            m_ts.fn_TerrainEditor_setBrushPressure(_ID, pressure);
        }

        /// <summary>
        /// (int w [, int h]))
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public void setBrushSize(int w, int h = 0)
        {
            m_ts.fn_TerrainEditor_setBrushSize(_ID, w, h);
        }

        /// <summary>
        /// (float softness))
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public void setBrushSoftness(float softness)
        {
            m_ts.fn_TerrainEditor_setBrushSoftness(_ID, softness);
        }

        /// <summary>
        /// (string type)              One of box, ellipse, selection.)
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public void setBrushType(string type)
        {
            m_ts.fn_TerrainEditor_setBrushType(_ID, type);
        }

        /// <summary>
        /// )
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public float setSlopeLimitMaxAngle(float angle)
        {
            return m_ts.fn_TerrainEditor_setSlopeLimitMaxAngle(_ID, angle);
        }

        /// <summary>
        /// )
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public float setSlopeLimitMinAngle(float angle)
        {
            return m_ts.fn_TerrainEditor_setSlopeLimitMinAngle(_ID, angle);
        }

        /// <summary>
        /// (bool overlayEnable) - sets the terraformer current heightmap to draw as an overlay over the current terrain.)
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public void setTerraformOverlay(bool overlayEnable)
        {
            m_ts.fn_TerrainEditor_setTerraformOverlay(_ID, overlayEnable);
        }

        /// <summary>
        /// ( int index, string matName )   Changes the material name at the index. )
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public bool updateMaterial(uint index, string matName)
        {
            return m_ts.fn_TerrainEditor_updateMaterial(_ID, index, matName);
        }

        #endregion

        #region T3D Callbacks

        /// <summary>
        ///  )
        /// </summary>
        [ConsoleInteraction(true)]
        public virtual void onBrushChanged()
        {
        }

        /// <summary>
        ///  )
        /// </summary>
        [ConsoleInteraction(true)]
        public virtual void onMaterialUndo()
        {
        }

        /// <summary>
        ///  )
        /// </summary>
        [ConsoleInteraction(true)]
        public virtual void onGuiUpdate(string text)
        {
        }

        /// <summary>
        ///  )
        /// </summary>
        [ConsoleInteraction(true)]
        public virtual void onActiveTerrainChange(string newTerrain)
        {
        }

        #endregion

        public TerrainEditor_Base()
        {
        }
    }
}