using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Microsoft.CSharp;
using WinterLeaf.Engine.Classes.Helpers;

namespace WinterLeaf.Engine.Classes.LiveScripts
    {
    /// <summary>
    /// Contains the Override Definition
    /// </summary>
    internal class xmlOverrideData
        {
        #region Constructors

        #region internal

        internal  xmlOverrideData()
            {
            _nameSpace = string.Empty;
            _referencedAssemblies = new List<string>();
            _functionOverrides = new List<CustomClassFunctDef>();
            _csFileNames = new List<string>();
            }

        #endregion

        #endregion

        #region Enumerations

        #region Internal

        internal enum ScriptTypes
            {
            Undefined,
            MemberFunction,
            Classes
            }

        #endregion

        #endregion

        #region Variables

        #region Private
        private string _className;
        private Assembly _compiledAssembly = null;
        private List<CustomClassFunctDef> _functionOverrides;
        private string _nameSpace;
        private List<string> _referencedAssemblies;
        private ScriptTypes _scriptType;
        private string _xmlFileName;
        private IndexingResult _iResult;
        private List<string> _csFileNames;
        #endregion

        #endregion

        #region Properties

        #region internal

        /// <summary>
        /// The Namespace to Override (ONLY Used for MemberFunction)
        /// </summary>
        internal string NameSpace
            {
            get { return _nameSpace; }
            set { _nameSpace = value.ToLower(); }
            }

        /// <summary>
        /// List of all the DLL's to include
        /// </summary>
        internal List<string> ReferencedAssemblies
            {
            get { return _referencedAssemblies; }
            set { _referencedAssemblies = value; }
            }

        /// <summary>
        /// List of the functions to override in the class (ONLY Used for MemberFunction)
        /// </summary>
        internal List<CustomClassFunctDef> FunctionOverrides
            {
            get { return _functionOverrides; }
            set { _functionOverrides = value; }
            }

        /// <summary>
        /// Name of the new class.  (ONLY Used for MemberFunction)
        /// </summary>
        internal string ClassName
            {
            get { return _className; }
            set { _className = value; }
            }

        /// <summary>
        /// Name of the XML Config file.
        /// </summary>
        internal string XmlFileName
            {
            get { return _xmlFileName; }
            set { _xmlFileName = value; }
            }

        /// <summary>
        /// The Type of XML File.
        /// </summary>
        internal ScriptTypes ScriptType
            {
            get { return _scriptType; }
            set { _scriptType = value; }
            }

        /// <summary>
        /// The C# files to compile into the DLL
        /// </summary>
        internal List<string> CsFileNames
            {
            get { return _csFileNames; }
            set { _csFileNames = value; }
            }

        /// <summary>
        /// The results of the compilation (Only Used for Classes)
        /// </summary>
        internal IndexingResult IResult
            {
            get { return _iResult; }
            set { _iResult = value; }
            }

        /// <summary>
        /// The compiled assembly.
        /// </summary>
        internal Assembly CompiledAssembly
            {
            get { return _compiledAssembly; }
            set { _compiledAssembly = value; }
            }

        #endregion

        #endregion


        #region Functions

        #region Internal
        
        /// <summary>
        /// Compiles the C# code into a in memory DLL.
        /// </summary>
        /// <returns></returns>
        internal bool Compile()
            {
            CSharpCodeProvider compiler =
                new CSharpCodeProvider(new Dictionary<String, String> { { "CompilerVersion", "v4.0" } });
            CompilerParameters parms = new CompilerParameters
            {
                GenerateExecutable = false,
                GenerateInMemory = true,
                TreatWarningsAsErrors = false
            };
            foreach (string assembly in _referencedAssemblies)
                parms.ReferencedAssemblies.Add(assembly);

#if DEBUG
            parms.IncludeDebugInformation = true;
            parms.CompilerOptions += "/debug:pdbonly";
#endif
            var results = compiler.CompileAssemblyFromFile(parms, _csFileNames.ToArray());

            CompilerErrorCollection errs = results.Errors;
            bool hardError = false;

            foreach (CompilerError ce in errs.Cast<CompilerError>().Where(ce => !ce.IsWarning))
                hardError = true;

            if (hardError)
                {
                lock (Omni.self.tick)
                    Omni.self.Error(">>csFactory::Error Processing C# Source Code.");
                foreach (CompilerError ce in errs)
                    {
                    lock (Omni.self.tick)
                        Omni.self.Error(String.Format(">>csFactory::File {0} Line {1} Column {2} MSG {3} ",
                            ce.FileName, ce.Line, ce.Column, ce.ErrorText, ce.FileName));
                    }
                return false;
                }

            CompiledAssembly = results.CompiledAssembly;


            if (ScriptType == ScriptTypes.Classes)
                return true;


            Type type = CompiledAssembly.GetType(_className);


            //Updates the Function overrides with the function ptrs.
            if (type == null) return true;
            foreach (CustomClassFunctDef fo in _functionOverrides)
            {
                MethodInfo mi = type.GetMethod(fo.mFunctName);
                if (mi != null)
                {
                    if (!mi.IsStatic)
                    {
                        lock (Omni.self.tick)
                            Omni.self.Error(
                                ">>csFactory::Error Processing C# Source Code: Function Not Static:'" +
                                fo.mFunctName + "'.");
                        return false;
                    }
                    fo.mFunctPtr = mi;
                }
                else
                {
                    lock (Omni.self.tick)
                        Omni.self.Error(
                            ">>csFactory::Error Processing C# Source Code: Could Not Find Function:'" +
                            fo.mFunctName + "'.");
                    return false;
                }
            }


            return true;
            }

        #endregion

        #endregion
        }
    }
