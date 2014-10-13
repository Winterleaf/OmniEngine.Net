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

        internal xmlOverrideData()
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
        private List<string> _csFileNames;
        private List<CustomClassFunctDef> _functionOverrides;
        private IndexingResult _iResult;
        private string _nameSpace;
        private List<string> _referencedAssemblies;
        private ScriptTypes _scriptType;
        private string _xmlFileName;

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
            CSharpCodeProvider compiler = new CSharpCodeProvider(new Dictionary<String, String> {{"CompilerVersion", "v4.0"}});
            CompilerParameters parms = new CompilerParameters {GenerateExecutable = false, GenerateInMemory = true, TreatWarningsAsErrors = false};
            foreach (string assembly in _referencedAssemblies)
                parms.ReferencedAssemblies.Add(assembly);

#if DEBUG
            parms.IncludeDebugInformation = true;
            parms.CompilerOptions += "/debug:pdbonly";
#endif
            CompilerResults results = compiler.CompileAssemblyFromFile(parms, _csFileNames.ToArray());

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
                        Omni.self.Error(String.Format(">>csFactory::File {0} Line {1} Column {2} MSG {3} ", ce.FileName, ce.Line, ce.Column, ce.ErrorText, ce.FileName));
                    }
                return false;
                }

            CompiledAssembly = results.CompiledAssembly;

            if (ScriptType == ScriptTypes.Classes)
                return true;

            Type type = CompiledAssembly.GetType(_className);

            //Updates the Function overrides with the function ptrs.
            if (type == null)
                return true;
            foreach (CustomClassFunctDef fo in _functionOverrides)
                {
                MethodInfo mi = type.GetMethod(fo.mFunctName);
                if (mi != null)
                    {
                    if (!mi.IsStatic)
                        {
                        lock (Omni.self.tick)
                            Omni.self.Error(">>csFactory::Error Processing C# Source Code: Function Not Static:'" + fo.mFunctName + "'.");
                        return false;
                        }
                    fo.mFunctPtr = mi;
                    }
                else
                    {
                    lock (Omni.self.tick)
                        Omni.self.Error(">>csFactory::Error Processing C# Source Code: Could Not Find Function:'" + fo.mFunctName + "'.");
                    return false;
                    }
                }

            return true;
        }

        #endregion

        #endregion
    }
}