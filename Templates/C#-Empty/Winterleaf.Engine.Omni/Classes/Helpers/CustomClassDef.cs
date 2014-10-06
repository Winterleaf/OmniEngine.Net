
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
        public List<string> Allowedcallbacks
            {
            get { return _allowedcallbacks; }
            set { _allowedcallbacks = value; }
            }

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
        }

    internal class CustomClassFunctDef
        {
        private string _mFunctName;
        private MethodInfo _mFunctPtr;
        ParameterInfo[] _mParams;

        LateBoundMethodWithReturnType callback = null;

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

        public object CallFunction(object o, object[] tparams)
            {
            object returnValue = callback(o, tparams);
            if (returnValue is bool)
                return (bool)returnValue ? 1 : 0;
            return returnValue;
            }

        public CustomClassFunctDef(string name)
            {
            _mFunctName = name;
            }
        public CustomClassFunctDef()
        { }
        }

    internal delegate object LateBoundMethodWithReturnType(object target, object[] arguments);

    internal static class DelegateHelper
        {
        static internal LateBoundMethodWithReturnType Create(MethodInfo method)
            {
            if (!method.IsStatic)
                return method.ReturnType == typeof(void) ? CreateFunctHasNoReturn(method) : CreateFunctHasReturn(method);
            return method.ReturnType == typeof(void) ? CreateStaticFunctHasNoReturn(method) : CreateStaticFunctHasReturn(method);
            }
        #region Private Functions
        private static LateBoundMethodWithReturnType CreateFunctHasReturn(MethodInfo method)
            {
            ParameterExpression instanceParameter = Expression.Parameter(typeof(object), "target");

            ParameterExpression argumentsParameter = Expression.Parameter(typeof(object[]), "arguments");

            MethodCallExpression call =
                Expression.Call(Expression.Convert(instanceParameter, method.DeclaringType), method, CreateParameterExpressions(method, argumentsParameter));

            Expression<LateBoundMethodWithReturnType> lambda =
                Expression.Lambda<LateBoundMethodWithReturnType>(Expression.Convert(call, typeof(object)), instanceParameter, argumentsParameter);

            return lambda.Compile();
            }
        private static LateBoundMethodWithReturnType CreateFunctHasNoReturn(MethodInfo method)
            {
            ParameterExpression instanceParameter = Expression.Parameter(typeof(object), "target");

            ParameterExpression argumentsParameter = Expression.Parameter(typeof(object[]), "arguments");

            BlockExpression block =
                Expression.Block(
                    typeof(string),
                    Expression.Call(Expression.Convert(instanceParameter, method.DeclaringType), method, CreateParameterExpressions(method, argumentsParameter)),
                    Expression.Constant(""));

            return Expression.Lambda<LateBoundMethodWithReturnType>(block, instanceParameter, argumentsParameter).Compile();
            }
        private static LateBoundMethodWithReturnType CreateStaticFunctHasReturn(MethodInfo method)
            {
            ParameterExpression instanceParameter = Expression.Parameter(typeof(object), "target");

            ParameterExpression argumentsParameter = Expression.Parameter(typeof(object[]), "arguments");

            MethodCallExpression call = Expression.Call(null, method, CreateParameterExpressions(method, argumentsParameter));

            Expression<LateBoundMethodWithReturnType> lambda =
                Expression.Lambda<LateBoundMethodWithReturnType>(Expression.Convert(call, typeof(object)), instanceParameter, argumentsParameter);
            return lambda.Compile();
            }
        private static LateBoundMethodWithReturnType CreateStaticFunctHasNoReturn(MethodInfo method)
            {

            ParameterExpression instanceParameter = Expression.Parameter(typeof(object), "target");

            ParameterExpression argumentsParameter = Expression.Parameter(typeof(object[]), "arguments");

            BlockExpression block =
                Expression.Block(
                    typeof(string),
                    Expression.Call(null, method, CreateParameterExpressions(method, argumentsParameter)),
                    Expression.Constant(""));
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