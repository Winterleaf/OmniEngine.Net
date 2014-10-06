#region

using System;
using System.ComponentModel;
using System.Text;
using WinterLeaf.Engine.Classes.Helpers;

#endregion

namespace WinterLeaf.Engine.Classes.View.Creators
    {
    /// <summary>
    /// A helper class to streamline creation of Singletons.
    /// </summary>
    [TypeConverter(typeof(TypeConverterGeneric<SingletonCreator>))]
    public sealed class SingletonCreator : Creator, IConvertible
        {
        /// <summary>
        /// Creates a new Singleton with the specified classname, datablock and C# proxy class optional
        /// </summary>
        /// <param name="className"></param>
        /// <param name="datablockName"></param>
        /// <param name="proxyclass">The C# proxy class to use for this singleton(Optional)</param>


        public SingletonCreator(string className, string singletonName , Type model )
            {
            mClassName = className;
            mDatablockName = singletonName;
            if (model != null)
                mModel = model.FullName.ToLower();
            else
                mModel = string.Empty;

            _mParams.Add("WLE_OVERRIDE_PROXY_CLASSTYPE", '"' + mModel + '"');
            }

        public SingletonCreator(string className, string singletonName , string model)
            {
            mClassName = className;
            mDatablockName = singletonName;
            if (model != null)
                mModel = model.ToLower();
            else
                mModel = string.Empty;

            _mParams.Add("WLE_OVERRIDE_PROXY_CLASSTYPE", '"' + mModel + '"');
            }

        public SingletonCreator(string className, string singletonName )
            {
            mClassName = className;
            mDatablockName = singletonName;
            mModel = string.Empty;
            _mParams.Add("WLE_OVERRIDE_PROXY_CLASSTYPE", '"' + mModel + '"');
            }

        public SingletonCreator(string className)
            {
            mClassName = className;
            mDatablockName = "";
            mModel = string.Empty;
            _mParams.Add("WLE_OVERRIDE_PROXY_CLASSTYPE", '"' + mModel + '"');
            }

        /// <summary>
        /// This will return the TorqueScript code that will be executed when Create is called.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
            {
            StringBuilder result = new StringBuilder();
            result.Append(" singleton ");
            result.Append(mClassName);
            result.Append("(");
            result.Append(mDatablockName);
            result.Append(base.ToString());
            return (result.ToString());
            }

        /// <summary>
        /// Passes the ToString() TorqueScript to the Eval statement capturing the id of the object created
        /// </summary>
        /// <returns></returns>
        public string Create()
            {
            Omni.self.Evaluate(ToString(), false);
            return mDatablockName;
            }
        }
    }