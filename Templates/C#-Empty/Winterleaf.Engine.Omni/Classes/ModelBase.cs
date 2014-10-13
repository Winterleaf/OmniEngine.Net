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
using System.ComponentModel;
using WinterLeaf.Engine.Classes.Extensions;
using WinterLeaf.Engine.Classes.Helpers;
using WinterLeaf.Engine.Classes.Interopt;

namespace WinterLeaf.Engine.Classes
{
    /// <summary>
    /// This class provides the base functionality that all C# Models have in the OMNI Framework.
    /// This is the BASE class of all models.
    /// </summary>
    [TypeConverter(typeof (TypeConverterGeneric<ModelBase>))]
    public class ModelBase : pInvokes, IConvertible
    {
        public static readonly pInvokes omni = new pInvokes();

        public static ulong Objectcount = 0;

        public ModelBase()
        {
            Objectcount++;
        }

        //Does an unsafe cast of the torque object model.

        /// <summary>
        /// The T3D SimObject ID
        /// </summary>
        public string ID
        {
            get { return _ID; }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="key"></param>
        public string this[string key]
        {
            get { return Omni.self == null ? null : Omni.self.GetVar(_ID.Trim() + "." + key); }
            set
            {
                if (Omni.self != null)
                    Omni.self.SetVar(_ID.Trim() + "." + key, value);
            }
        }

        #region IConvertible Members

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public TypeCode GetTypeCode()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="provider"></param>
        /// <returns></returns>
        public bool ToBoolean(IFormatProvider provider)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="provider"></param>
        /// <returns></returns>
        public char ToChar(IFormatProvider provider)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="provider"></param>
        /// <returns></returns>
        public sbyte ToSByte(IFormatProvider provider)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="provider"></param>
        /// <returns></returns>
        public byte ToByte(IFormatProvider provider)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="provider"></param>
        /// <returns></returns>
        public short ToInt16(IFormatProvider provider)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="provider"></param>
        /// <returns></returns>
        public ushort ToUInt16(IFormatProvider provider)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="provider"></param>
        /// <returns></returns>
        public int ToInt32(IFormatProvider provider)
        {
            int i;
            return int.TryParse(_ID, out i) ? i : 0;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="provider"></param>
        /// <returns></returns>
        public uint ToUInt32(IFormatProvider provider)
        {
            uint i;
            return uint.TryParse(_ID, out i) ? i : 0;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="provider"></param>
        /// <returns></returns>
        public long ToInt64(IFormatProvider provider)
        {
            Int64 i;
            return Int64.TryParse(_ID, out i) ? i : 0;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="provider"></param>
        /// <returns></returns>
        public ulong ToUInt64(IFormatProvider provider)
        {
            UInt64 i;
            return UInt64.TryParse(_ID, out i) ? i : 0;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="provider"></param>
        /// <returns></returns>
        public float ToSingle(IFormatProvider provider)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="provider"></param>
        /// <returns></returns>
        public double ToDouble(IFormatProvider provider)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="provider"></param>
        /// <returns></returns>
        public decimal ToDecimal(IFormatProvider provider)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="provider"></param>
        /// <returns></returns>
        public DateTime ToDateTime(IFormatProvider provider)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="provider"></param>
        /// <returns></returns>
        public string ToString(IFormatProvider provider)
        {
            return _ID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="conversionType"></param>
        /// <param name="provider"></param>
        /// <returns></returns>
        public object ToType(Type conversionType, IFormatProvider provider)
        {
            throw new NotImplementedException();
        }

        #endregion

        ~ModelBase()
        {
            Objectcount--;
        }

        public T unSafeCast<T>()
        {
            return (T) myReflections.ChangeType(Omni.self.GetSimObjectUnsafe(_iID, typeof (T)), typeof (T));
        }

        public bool IsSameOrSubclass(Type potentialDescendant)
        {
            return this.GetType().IsSameOrSubclass(potentialDescendant);
        }

        /// <summary>
        /// Gets the count of objects in the SimSet
        /// </summary>
        /// <returns></returns>
        public int getCount()
        {
            return Omni.self.fnSimSet_getCount(_ID);
        }

        /// <summary>
        /// Gets the object X in the SimSet
        /// </summary>
        /// <param name="i"></param>
        /// <returns></returns>
        public ModelBase getObject(uint i)
        {
            return Omni.self.fnSimSet_getObject(_ID, i);
        }

        /// <summary>
        /// If the CSharp callback isn't found this flag determines whether OMNI will look in TorqueScript.
        /// </summary>
        /// <returns></returns>
        public virtual bool OnFunctionNotFoundCallTorqueScript()
        {
            return true;
        }

        /// <summary>
        /// Deletes the object from the simulation
        /// </summary>
        public void delete()
        {
            Omni.self.fn_SimObject_delete(_ID);
        }

        /// <summary>
        /// Returns the ID of the object as a string.
        /// </summary>
        /// <returns></returns>
        public string GetID()
        {
            return _ID;
        }

        internal virtual void SetUpObject(uint simobjectid)
        {
            _ID = simobjectid.AsString();
            _iID = simobjectid;
        }

        /// <summary>
        /// Returns true if T3D object.
        /// </summary>
        /// <returns></returns>
        public virtual bool isObject()
        {
            return _iID != 0 && Omni.self.IsObject(ID);
        }

        /// <summary>
        /// Gets the Classname of the object
        /// </summary>
        /// <returns></returns>
        public virtual string getClassName()
        {
            return Omni.self.GetClassName(ID);
        }

        /// <summary>
        /// Gets the name of the object
        /// </summary>
        /// <returns></returns>
        public virtual string getName()
        {
            return Omni.self.GetName(ID);
        }

        /// <summary>
        /// returns if the field specified exists
        /// </summary>
        /// <param name="field"></param>
        /// <returns></returns>
        public virtual bool isField(string field)
        {
            return Omni.self.SimObjectIsField(ID, field);
        }

        /// <summary>
        /// Checks if the method specified exists
        /// </summary>
        /// <param name="method"></param>
        /// <returns></returns>
        public virtual bool isMethod(string method)
        {
            return Omni.self.fn_isMethod(ID, method);
        }

        /// <summary>
        /// Returns the datablock to the object.
        /// </summary>
        /// <returns></returns>
        public virtual string getDataBlock()
        {
            return Omni.self.GetDatablock(ID).AsString();
        }

        /// <summary>
        /// Calls the member function on the object with parameters.
        /// </summary>
        /// <param name="function"></param>
        /// <param name="parameters"></param>
        /// <returns></returns>
        public virtual string call(string function, string[] parameters)
        {
            return Omni.self.SimObjectCall(_ID, function, parameters);
        }

        /// <summary>
        /// Calls the Torque script function directly w/ parameters by passing the CSharp.
        /// </summary>
        /// <param name="function"></param>
        /// <param name="parameters"></param>
        /// <returns></returns>
        public virtual string callScript(string function, string[] parameters)
        {
            return Omni.self.SimObjectCallScript(_ID, function, parameters);
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
        /// <returns></returns>
        public override int GetHashCode()
        {
            return (int) _iID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(ModelBase ts, string simobjectid)
        {
            return ReferenceEquals(ts, null) ? ReferenceEquals(simobjectid, null) : ts.Equals(simobjectid);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator !=(ModelBase ts, string simobjectid)
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
        public static implicit operator string(ModelBase ts)
        {
            return ts._ID;
        }

        /// <summary>
        /// Resolves the string passed to a simobject.
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static uint resolveobject(string ts)
        {
            uint simobjectid = 0;
            if (!ts.IsNumeric())
                {
                if (ts.Trim() == string.Empty)
                    return simobjectid;
#if DEBUG
                string old = ts;
#endif
                simobjectid = Omni.self.GetObjectID(ts);
#if DEBUG
                if (simobjectid == 0)
                    Omni.self.Error("WARNING:: COULD NOT RESOLVE '" + old + "' to an object.");
#endif
                }
            else
                {
                if (ts.Trim() == string.Empty)
                    return simobjectid;
                uint ui;
                if (uint.TryParse(ts, out ui))
                    simobjectid = ui;
                }
            return simobjectid;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator ModelBase(string ts)
        {
            uint simobjectid = resolveobject(ts);
            return Omni.self.getSimObject(simobjectid, typeof (ModelBase));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int(ModelBase ts)
        {
            return (int) ts._iID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator ModelBase(int ts)
        {
            return Omni.self.getSimObject((uint) ts, typeof (ModelBase));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint(ModelBase ts)
        {
            return ts._iID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator ModelBase(uint ts)
        {
            return Omni.self.getSimObject(ts, typeof (ModelBase));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return _ID;
        }

        #region Variables

        public string _ID = "0";
        public uint _iID;

        #endregion
    }
}