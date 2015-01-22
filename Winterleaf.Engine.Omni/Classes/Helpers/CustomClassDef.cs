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

#if Using_Mono
using System;
using System.Collections.Generic;
using System.Reflection;

namespace WinterLeaf.Engine.Classes.Helpers
    {
    /// <summary>
    /// Internal use.
    /// </summary>
    internal class CustomClassDef
        {
        private List<string> _allowedcallbacks = new List<string>();

        private string _mClassName;
        private ConstructorInfo _mCtor;
        //CallBack Name and reflection info.
        private Dictionary<string, CustomClassFunctDef> _mFuncts = new Dictionary<string, CustomClassFunctDef>();

        private Type _mType;

#region "Set/Get"

        public string mClassName
            {
            get { return _mClassName; }
            set { _mClassName = value; }
            }

        public Dictionary<string, CustomClassFunctDef> mFuncts
            {
            get { return _mFuncts; }
            set { _mFuncts = value; }
            }

        public ConstructorInfo mCtor
            {
            get { return _mCtor; }
            set { _mCtor = value; }
            }

        public Type mType
            {
            get { return _mType; }
            set { _mType = value; }
            }

        #endregion

        public List<string> Allowedcallbacks
            {
            get { return _allowedcallbacks; }
            set { _allowedcallbacks = value; }
            }
        }

    internal class CustomClassFunctDef
        {
        private string _mFunctName = string.Empty;
        private MethodInfo _mFunctPtr = null;
        private ParameterInfo[] _mParams = null;

#region "Set/Get"

        public CustomClassFunctDef(string name)
            {
            _mFunctName = name;
            }

        public CustomClassFunctDef()
        { }

        public MethodInfo mFunctPtr
            {
            get { return _mFunctPtr; }
            set
                {
                _mFunctPtr = value;
                _mParams = value != null ? value.GetParameters() : null;
                //_callback = DelegateHelper.Create(value);
                }
            }

        public string mFunctName
            {
            get { return _mFunctName; }
            set { _mFunctName = value; }
            }

        public ParameterInfo[] MParams
            {
            get { return _mParams; }
            }

        #endregion

        public object CallFunction(object o, object[] tparams)
            {

            object retValue ="";
            if (Omni.self.ScriptExtensions_HandleExceptions)
                try
                    {
                    if (_mFunctPtr.ReturnType == typeof(bool))
                        retValue = (bool)_mFunctPtr.Invoke(o, tparams) ? 1 : 0;
                    else
                        retValue = _mFunctPtr.Invoke(o, tparams);
                    }
                catch (Exception ex)
                    {
                    retValue = "";
                    Omni.self.Error("ERROR!!! " + ex.Message);
                    Omni.self.Error(ex.InnerException.ToString());
                    }
            else
                {
                if (_mFunctPtr.ReturnType == typeof(bool))
                    retValue = (bool)_mFunctPtr.Invoke(o, tparams) ? 1 : 0;
                else
                    retValue = _mFunctPtr.Invoke(o, tparams);
                }




            return retValue ?? "";
            }
        }
    }
#else
// Copyright (C) 2012 Winterleaf Entertainment L,L,C.

#region

using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;

#endregion

namespace WinterLeaf.Engine.Classes.Helpers
{
    /// <summary>
    /// 
    /// </summary>
    internal class CustomClassDef
    {
        private List<string> _allowedcallbacks = new List<string>();

        private string _mClassName;
        private ConstructorInfo _mCtor;
        //CallBack Name and reflection info.
        private Dictionary<string, CustomClassFunctDef> _mFuncts = new Dictionary<string, CustomClassFunctDef>();

        private Type _mType;

        #region "Set/Get"

        public string mClassName
        {
            get { return _mClassName; }
            set { _mClassName = value; }
        }

        public Dictionary<string, CustomClassFunctDef> mFuncts
        {
            get { return _mFuncts; }
            set { _mFuncts = value; }
        }

        public ConstructorInfo mCtor
        {
            get { return _mCtor; }
            set { _mCtor = value; }
        }

        public Type mType
        {
            get { return _mType; }
            set { _mType = value; }
        }

        #endregion

        public List<string> Allowedcallbacks
        {
            get { return _allowedcallbacks; }
            set { _allowedcallbacks = value; }
        }

    }

    internal class CustomClassFunctDef
    {
        private string _mFunctName;
        private MethodInfo _mFunctPtr;
        private ParameterInfo[] _mParams;

        private LateBoundMethodWithReturnType callback = null;

        #region "Set/Get"

        public MethodInfo mFunctPtr
        {
            get { return _mFunctPtr; }
            set
            {
                _mFunctPtr = value;
                _mParams = value.GetParameters();
                callback = DelegateHelper.Create(value);
            }
        }

        public string mFunctName
        {
            get { return _mFunctName; }
            set { _mFunctName = value; }
        }

        public ParameterInfo[] MParams
        {
            get { return _mParams; }
        }

        #endregion

        public CustomClassFunctDef(string name)
        {
            _mFunctName = name;
        }

        public CustomClassFunctDef()
        {
        }

        public object CallFunction(object o, object[] tparams)
        {
            object returnValue = callback(o, tparams);
            if (returnValue is bool)
                return (bool) returnValue ? 1 : 0;
            return returnValue;
        }
    }

    internal delegate object LateBoundMethodWithReturnType(object target, object[] arguments);

    internal static class DelegateHelper
    {
        internal static LateBoundMethodWithReturnType Create(MethodInfo method)
        {
            if (!method.IsStatic)
                return method.ReturnType == typeof (void) ? CreateFunctHasNoReturn(method) : CreateFunctHasReturn(method);
            return method.ReturnType == typeof (void) ? CreateStaticFunctHasNoReturn(method) : CreateStaticFunctHasReturn(method);
        }

        #region Private Functions

        private static LateBoundMethodWithReturnType CreateFunctHasReturn(MethodInfo method)
        {
            ParameterExpression instanceParameter = Expression.Parameter(typeof (object), "target");

            ParameterExpression argumentsParameter = Expression.Parameter(typeof (object[]), "arguments");

            MethodCallExpression call = Expression.Call(Expression.Convert(instanceParameter, method.DeclaringType), method, CreateParameterExpressions(method, argumentsParameter));

            Expression<LateBoundMethodWithReturnType> lambda = Expression.Lambda<LateBoundMethodWithReturnType>(Expression.Convert(call, typeof (object)), instanceParameter, argumentsParameter);

            return lambda.Compile();
        }

        private static LateBoundMethodWithReturnType CreateFunctHasNoReturn(MethodInfo method)
        {
            ParameterExpression instanceParameter = Expression.Parameter(typeof (object), "target");

            ParameterExpression argumentsParameter = Expression.Parameter(typeof (object[]), "arguments");

            BlockExpression block = Expression.Block(typeof (string), Expression.Call(Expression.Convert(instanceParameter, method.DeclaringType), method, CreateParameterExpressions(method, argumentsParameter)), Expression.Constant(""));

            return Expression.Lambda<LateBoundMethodWithReturnType>(block, instanceParameter, argumentsParameter).Compile();
        }

        private static LateBoundMethodWithReturnType CreateStaticFunctHasReturn(MethodInfo method)
        {
            ParameterExpression instanceParameter = Expression.Parameter(typeof (object), "target");

            ParameterExpression argumentsParameter = Expression.Parameter(typeof (object[]), "arguments");

            MethodCallExpression call = Expression.Call(null, method, CreateParameterExpressions(method, argumentsParameter));

            Expression<LateBoundMethodWithReturnType> lambda = Expression.Lambda<LateBoundMethodWithReturnType>(Expression.Convert(call, typeof (object)), instanceParameter, argumentsParameter);
            return lambda.Compile();
        }

        private static LateBoundMethodWithReturnType CreateStaticFunctHasNoReturn(MethodInfo method)
        {
            ParameterExpression instanceParameter = Expression.Parameter(typeof (object), "target");

            ParameterExpression argumentsParameter = Expression.Parameter(typeof (object[]), "arguments");

            BlockExpression block = Expression.Block(typeof (string), Expression.Call(null, method, CreateParameterExpressions(method, argumentsParameter)), Expression.Constant(""));
            return Expression.Lambda<LateBoundMethodWithReturnType>(block, instanceParameter, argumentsParameter).Compile();
        }

        private static UnaryExpression[] CreateParameterExpressions(MethodInfo method, Expression argumentsParameter)
        {
            return method.GetParameters().Select((parameter, index) => Expression.Convert(Expression.ArrayIndex(argumentsParameter, Expression.Constant(index)), parameter.ParameterType)).ToArray();
        }

        #endregion
    }
}

#endif