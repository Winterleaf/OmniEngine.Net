using System;
using System.Collections.Generic;
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
    [TypeConverter(typeof(TypeConverterGeneric<ModelBase>))]
    public class ModelBase : pInvokes, IConvertible
        {
        public static readonly pInvokes omni = new pInvokes();

        public static ulong Objectcount = 0;

        ~ModelBase()
            {
            Objectcount--;
            }

        public ModelBase()
            {
            Objectcount++;
            }


        //Does an unsafe cast of the torque object model.
        public T unSafeCast<T>()
            {
            return (T)myReflections.ChangeType(Omni.self.GetSimObjectUnsafe(_iID, typeof(T)), typeof(T));
            }


        public bool IsSameOrSubclass(Type potentialDescendant)
        {
            return this.GetType().IsSameOrSubclass(potentialDescendant);
        }

        #region Variables

        public string _ID = "0";
        public uint _iID;

        #endregion

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
            return (this._ID == (string)myReflections.ChangeType(obj, typeof(string)));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
            {
            return (int)_iID;
            }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(ModelBase ts, string simobjectid)
            {
            return object.ReferenceEquals(ts, null) ? object.ReferenceEquals(simobjectid, null) : ts.Equals(simobjectid);
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator !=(ModelBase ts, string simobjectid)
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
                if (ts.Trim() == string.Empty) return simobjectid;
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
                if (ts.Trim() == string.Empty) return simobjectid;
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
            return Omni.self.getSimObject(simobjectid, typeof(ModelBase));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int(ModelBase ts)
            {
            return (int)ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator ModelBase(int ts)
            {
            return Omni.self.getSimObject((uint)ts, typeof(ModelBase));
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
            return Omni.self.getSimObject(ts, typeof(ModelBase));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override string ToString()
            {
            return _ID;
            }
        }
    }