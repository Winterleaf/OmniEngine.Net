using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using WinterLeaf.Engine.Classes.Helpers;

namespace WinterLeaf.Engine.Classes.View.Creators
    {
    /// <summary>
    /// Class used to create Datablock objects in the T3D engine.
    /// </summary>
    [TypeConverter(typeof(TypeConverterGeneric<DatablockCreator>))]
    public sealed class DatablockCreator : Creator, IConvertible
        {


        /// <summary>
        ///   Creates an object to template a torquescript class with.
        /// </summary>
        /// <param name="className"> The name of the object type </param>
        /// <param name="instanceName"> The name of this instance of the object </param>
        /// <param name="proxyclass">The C# proxy class to use for this singleton(Optional)</param>
        public DatablockCreator(string className, string instanceName, Type model)
            {
            mClassName = className;
            mInstanceName = instanceName;
            if (model != null)
                {
                mModel = model.FullName.ToLower();
                }
            else
                mModel = string.Empty;

            _mParams.Add("WLE_OVERRIDE_PROXY_CLASSTYPE", '"' + mModel + '"');
            }
        public DatablockCreator(string className, string instanceName, string model)
            {
            mClassName = className;
            mInstanceName = instanceName;
            if (model != null)
                {
                mModel = model.ToLower();
                }
            else
                mModel = string.Empty;

            _mParams.Add("WLE_OVERRIDE_PROXY_CLASSTYPE", '"' + mModel + '"');
            }
        public DatablockCreator(string className, string instanceName)
            {
            mClassName = className;
            mInstanceName = instanceName;

            mModel = string.Empty;

            _mParams.Add("WLE_OVERRIDE_PROXY_CLASSTYPE", '"' + mModel + '"');
            }
        public DatablockCreator(string className)
            {
            mClassName = className;
            mInstanceName = string.Empty;

            mModel = string.Empty;

            _mParams.Add("WLE_OVERRIDE_PROXY_CLASSTYPE", '"' + mModel + '"');
            }



        /// <summary>
        ///   This will return the TorqueScript code that will be executed when Create is called.
        /// </summary>
        /// <returns> </returns>
        public override string ToString()
            {
            StringBuilder result = new StringBuilder();
            result.Append(" datablock ");
            result.Append(mClassName);
            result.Append("(");
            result.Append(mInstanceName);
            result.Append(base.ToString());
            return (result.ToString());
            }

        /// <summary>
        ///   Passes the ToString() TorqueScript to the Eval statement capturing the id of the object created
        /// </summary>
        /// <returns> </returns>
        //public string Create()
        //    {
        //    Omni.self.Evaluate(ToString(), false);
        //    return mInstanceName.Contains(":") ? mInstanceName.Split(':')[0].Trim() : mInstanceName;
        //    }
        public uint Create()
            {
            Omni.self.Evaluate(ToString(), false);
            return mInstanceName.Contains(":") ? ((ModelBase)mInstanceName.Split(':')[0].Trim())._iID : ((ModelBase)mInstanceName)._iID;
            }


        }
    }