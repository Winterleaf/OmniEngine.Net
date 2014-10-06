using System;
using System.ComponentModel;
using System.Text;
using WinterLeaf.Engine.Classes.Helpers;

namespace WinterLeaf.Engine.Classes.View.Creators
    {
    /// <summary>
    /// This is a helper class to attempt to clean up the code
    /// when creating a object inside of torque.
    /// </summary>
    [TypeConverter(typeof(TypeConverterGeneric<ObjectCreator>))]
    public sealed class ObjectCreator : Creator, IConvertible
        {
        /// <summary>
        ///   Creates an object to template a torquescript class with.
        /// </summary>
        /// <param name="className"> The name of the object type </param>
        /// <param name="instanceName"> The name of this instance of the object </param>
        /// <param name="model">The C# proxy class to use for this singleton(Optional)</param>
        public ObjectCreator(string className, string instanceName, Type model )
            {
            mClassName = className;
            mInstanceName = instanceName;

            mModel = model != null ? model.FullName.ToLower() : string.Empty;

            _mParams.Add("WLE_OVERRIDE_PROXY_CLASSTYPE", '"' + mModel + '"');
            }
        
        public ObjectCreator(string className, string instanceName , String model )
            {
            mClassName = className;
            mInstanceName = instanceName;

            mModel = model != null ? model.ToLower() : string.Empty;

            _mParams.Add("WLE_OVERRIDE_PROXY_CLASSTYPE", '"' + mModel + '"');
            }
        public ObjectCreator(string className, string instanceName)
            {
            mClassName = className;
            mInstanceName = instanceName;

            mModel = string.Empty;

            _mParams.Add("WLE_OVERRIDE_PROXY_CLASSTYPE", '"' + mModel + '"');
            }
        public ObjectCreator(string className)
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
            result.Append(" new ");
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
        public UInt32 Create()
            {
            UInt32 r;
            string id = Omni.self.Evaluate("%tempvar = " + ToString() + " return %tempvar;", true);
            return UInt32.TryParse(id, out r) ? r : 0;
            }

        }
    }