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
using WinterLeaf.Engine.Classes;
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
    [TypeConverter(typeof (TypeConverterGeneric<SimObject_Base>))]
    public partial class SimObject_Base : ModelBase
    {
        #region ProxyObjects Operator Overrides

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(SimObject_Base ts, string simobjectid)
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
        public static bool operator !=(SimObject_Base ts, string simobjectid)
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
        public static implicit operator string(SimObject_Base ts)
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
        public static implicit operator SimObject_Base(string ts)
        {
            uint simobjectid = resolveobject(ts);
            return (SimObject_Base) Omni.self.getSimObject(simobjectid, typeof (SimObject_Base));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int(SimObject_Base ts)
        {
            return (int) ts._iID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator SimObject_Base(int simobjectid)
        {
            return (SimObject) Omni.self.getSimObject((uint) simobjectid, typeof (SimObject_Base));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint(SimObject_Base ts)
        {
            return ts._iID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator SimObject_Base(uint simobjectid)
        {
            return (SimObject_Base) Omni.self.getSimObject(simobjectid, typeof (SimObject_Base));
        }

        #endregion

        #region Init Persists

        /// <summary>
        /// Whether the object can be saved out. If false, the object is purely transient in nature. 
        /// </summary>
        [MemberGroup("Persistence")]
        public bool canSave
        {
            get { return Omni.self.GetVar(_ID + ".canSave").AsBool(); }
            set { Omni.self.SetVar(_ID + ".canSave", value.AsString()); }
        }

        /// <summary>
        /// True if dynamic fields (added at runtime) should be saved. Defaults to true. 
        /// </summary>
        [MemberGroup("Persistence")]
        public bool canSaveDynamicFields
        {
            get { return Omni.self.GetVar(_ID + ".canSaveDynamicFields").AsBool(); }
            set { Omni.self.SetVar(_ID + ".canSaveDynamicFields", value.AsString()); }
        }

        /// <summary>
        /// Script class of object. 
        /// </summary>
        [MemberGroup("Object")]
        public String classx
        {
            get { return Omni.self.GetVar(_ID + ".class").AsString(); }
            set { Omni.self.SetVar(_ID + ".class", value.AsString()); }
        }

        /// <summary>
        /// Script class of object., AbstractClassRep::FIELD_HideInInspectors 
        /// </summary>
        [MemberGroup("Object")]
        public String className
        {
            get { return Omni.self.GetVar(_ID + ".className").AsString(); }
            set { Omni.self.SetVar(_ID + ".className", value.AsString()); }
        }

        /// <summary>
        /// Whether the object can be edited in the game. 
        /// </summary>
        [MemberGroup("Editing")]
        public bool editable
        {
            get { return Omni.self.GetVar(_ID + ".editable").AsBool(); }
            set { Omni.self.SetVar(_ID + ".editable", value.AsString()); }
        }

        /// <summary>
        /// ENABLED FLAG
        /// </summary>
        [MemberGroup("Component")]
        public bool Enabled
        {
            get { return Omni.self.GetVar(_ID + ".Enabled").AsBool(); }
            set { Omni.self.SetVar(_ID + ".Enabled", value.AsString()); }
        }

        /// <summary>
        /// Whether the object is visible. 
        /// </summary>
        [MemberGroup("Editing")]
        public bool hidden
        {
            get { return Omni.self.GetVar(_ID + ".hidden").AsBool(); }
            set { Omni.self.SetVar(_ID + ".hidden", value.AsString()); }
        }

        /// <summary>
        /// Optional name that may be used to lookup this object within a SimSet.
        /// </summary>
        [MemberGroup("Object")]
        public String internalName
        {
            get { return Omni.self.GetVar(_ID + ".internalName").AsString(); }
            set { Omni.self.SetVar(_ID + ".internalName", value.AsString()); }
        }

        /// <summary>
        /// Whether the object can be edited. 
        /// </summary>
        [MemberGroup("Editing")]
        public bool lockedx
        {
            get { return Omni.self.GetVar(_ID + ".locked").AsBool(); }
            set { Omni.self.SetVar(_ID + ".locked", value.AsString()); }
        }

        /// <summary>
        /// Optional global name of this object. 
        /// </summary>
        [MemberGroup("Ungrouped")]
        public TypeName name
        {
            get { return Omni.self.GetVar(_ID + ".name").AsTypeName(); }
            set { Omni.self.SetVar(_ID + ".name", value.AsString()); }
        }

        /// <summary>
        /// Group hierarchy parent of the object. 
        /// </summary>
        [MemberGroup("Object")]
        public SimObject parentGroup
        {
            get { return Omni.self.GetVar(_ID + ".parentGroup"); }
            set { Omni.self.SetVar(_ID + ".parentGroup", value.ToString()); }
        }

        /// <summary>
        /// The universally unique identifier for the object. 
        /// </summary>
        [MemberGroup("Persistence")]
        public int persistentId
        {
            get { return Omni.self.GetVar(_ID + ".persistentId").AsInt(); }
            set { Omni.self.SetVar(_ID + ".persistentId", value.AsString()); }
        }

        /// <summary>
        /// Script super-class of object. 
        /// </summary>
        [MemberGroup("Object")]
        public String superClass
        {
            get { return Omni.self.GetVar(_ID + ".superClass").AsString(); }
            set { Omni.self.SetVar(_ID + ".superClass", value.AsString()); }
        }

        /// <summary>
        /// , AbstractClassRep:: FIELD_ReadOnly 
        /// </summary>
        [MemberGroup("OMNI")]
        public int WLE_OMNI_ARRAY_POSTION
        {
            get { return Omni.self.GetVar(_ID + ".WLE_OMNI_ARRAY_POSTION").AsInt(); }
            set { Omni.self.SetVar(_ID + ".WLE_OMNI_ARRAY_POSTION", value.AsString()); }
        }

        /// <summary>
        /// , AbstractClassRep:: FIELD_ReadOnly 
        /// </summary>
        [MemberGroup("OMNI")]
        public String WLE_OVERRIDE_PROXY_CLASSTYPE
        {
            get { return Omni.self.GetVar(_ID + ".WLE_OVERRIDE_PROXY_CLASSTYPE").AsString(); }
            set { Omni.self.SetVar(_ID + ".WLE_OVERRIDE_PROXY_CLASSTYPE", value.AsString()); }
        }

        #endregion

        #region Member Functions

        /// <summary>
        /// Copy fields from another object onto this one.  The objects must 
        ///    be of same type. Everything from the object will overwrite what's 
        ///    in this object; extra fields in this object will remain. This 
        ///    includes dynamic fields.
        ///    @param fromObject The object from which to copy fields. )
        /// 
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public void assignFieldsFrom(string fromObject)
        {
            m_ts.fn_SimObject_assignFieldsFrom(_ID, fromObject);
        }

        /// <summary>
        /// Delete and remove the object. )
        /// 
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public void delete()
        {
            m_ts.fn_SimObject_delete(_ID);
        }

        /// <summary>
        /// Dump the native C++ class hierarchy of this object's C++ class to the console. )
        /// 
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public void dumpClassHierarchy()
        {
            m_ts.fn_SimObject_dumpClassHierarchy(_ID);
        }

        /// <summary>
        /// List the methods defined on this object.
        ///    Each description is a newline-separated vector with the following elements:
        ///    - Minimum number of arguments.
        ///    - Maximum number of arguments.
        ///    - Prototype string.
        ///    - Full script file path (if script method).
        ///    - Line number of method definition in script (if script method).
        ///    - Documentation string (not including prototype).  This takes up the remainder of the vector.
        ///    @return An ArrayObject populated with (name,description) pairs of all methods defined on the object. )
        /// 
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public string dumpMethods()
        {
            return m_ts.fn_SimObject_dumpMethods(_ID);
        }

        /// <summary>
        /// Get whether the object will be included in saves.
        ///    @return True if the object will be saved; false otherwise. )
        /// 
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public bool getCanSave()
        {
            return m_ts.fn_SimObject_getCanSave(_ID);
        }

        /// <summary>
        /// Get the name of the C++ class which the object is an instance of.
        ///    @return The name of the C++ class of the object. )
        /// 
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public string getClassName()
        {
            return m_ts.fn_SimObject_getClassName(_ID);
        }

        /// <summary>
        /// Get the name of the class namespace assigned to this object.
        ///    @return The name of the 'class' namespace. )
        /// 
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public string getClassNamespace()
        {
            return m_ts.fn_SimObject_getClassNamespace(_ID);
        }

        /// <summary>
        /// Get the line number at which the object is defined in its file.
        ///    @return The line number of the object's definition in script.
        ///    @see getFilename())
        /// 
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public int getDeclarationLine()
        {
            return m_ts.fn_SimObject_getDeclarationLine(_ID);
        }

        /// <summary>
        /// Get a value of a dynamic field by index.
        ///    @param index The index of the dynamic field.
        ///    @return The value of the dynamic field at the given index or \"\". )
        /// 
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public string getDynamicField(int index)
        {
            return m_ts.fn_SimObject_getDynamicField(_ID, index);
        }

        /// <summary>
        /// Get the number of dynamic fields defined on the object.
        ///    @return The number of dynamic fields defined on the object. )
        /// 
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public int getDynamicFieldCount()
        {
            return m_ts.fn_SimObject_getDynamicFieldCount(_ID);
        }

        /// <summary>
        /// Retrieve the value of a static field by index.
        ///    @param index The index of the static field.
        ///    @return The value of the static field with the given index or \"\". )
        /// 
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public string getField(int index)
        {
            return m_ts.fn_SimObject_getField(_ID, index);
        }

        /// <summary>
        /// Get the number of static fields on the object.
        ///    @return The number of static fields defined on the object. )
        /// 
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public int getFieldCount()
        {
            return m_ts.fn_SimObject_getFieldCount(_ID);
        }

        /// <summary>
        /// Get the console type code of the given field.
        ///    @return The numeric type code for the underlying console type of the given field. )
        /// 
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public string getFieldType(string fieldName)
        {
            return m_ts.fn_SimObject_getFieldType(_ID, fieldName);
        }

        /// <summary>
        /// Return the value of the given field on this object.
        ///    @param fieldName The name of the field.  If it includes a field index, the index is parsed out.
        ///    @param index Optional parameter to specify the index of an array field separately.
        ///    @return The value of the given field or \"\" if undefined. )
        /// 
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public string getFieldValue(string fieldName, int index = -1)
        {
            return m_ts.fn_SimObject_getFieldValue(_ID, fieldName, index);
        }

        /// <summary>
        /// Returns the filename the object is attached to.
        ///    @return The name of the file the object is associated with; usually the file the object was loaded from. )
        /// 
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public string getFilename()
        {
            return m_ts.fn_SimObject_getFilename(_ID);
        }

        /// <summary>
        /// Get the name of the superclass namespace assigned to this object.
        ///    @return The name of the 'superClass' namespace. )
        /// 
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public string getSuperClassNamespace()
        {
            return m_ts.fn_SimObject_getSuperClassNamespace(_ID);
        }

        /// <summary>
        /// ())
        /// 
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public bool isEnabled()
        {
            return m_ts.fn_SimObject_isEnabled(_ID);
        }

        /// <summary>
        /// Get whether the object has been marked as expanded. (in editor)
        ///    @return True if the object is marked expanded. )
        /// 
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public bool isExpanded()
        {
            return m_ts.fn_SimObject_isExpanded(_ID);
        }

        /// <summary>
        /// Test whether the given field is defined on this object.
        ///    @param fieldName The name of the field.
        ///    @return True if the object implements the given field. )
        /// 
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public bool isField(string fieldName)
        {
            return m_ts.fn_SimObject_isField(_ID, fieldName);
        }

        /// <summary>
        /// Test whether the namespace of this object is a direct or indirect child to the given namespace.
        ///    @param name The name of a namespace.
        ///    @return True if the given namespace name is within the namespace hierarchy of this object. )
        /// 
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public bool isInNamespaceHierarchy(string name)
        {
            return m_ts.fn_SimObject_isInNamespaceHierarchy(_ID, name);
        }

        /// <summary>
        /// Test whether this object is a member of the specified class.
        ///    @param className Name of a native C++ class.
        ///    @return True if this object is an instance of the given C++ class or any of its super classes. )
        /// 
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public bool isMemberOfClass(string className)
        {
            return m_ts.fn_SimObject_isMemberOfClass(_ID, className);
        }

        /// <summary>
        /// Test whether the given method is defined on this object.
        ///    @param The name of the method.
        ///    @return True if the object implements the given method. )
        /// 
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public bool isMethod(string methodName)
        {
            return m_ts.fn_SimObject_isMethod(_ID, methodName);
        }

        /// <summary>
        ///  ),
        ///    Save out the object to the given file.
        ///    @param fileName The name of the file to save to.
        ///    @param selectedOnly If true, only objects marked as selected will be saved out.
        ///    @param preAppendString Text which will be preprended directly to the object serialization.
        ///    @param True on success, false on failure. )
        /// 
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public bool save(string fileName, bool selectedOnly = false, string preAppendString = "")
        {
            return m_ts.fn_SimObject_save(_ID, fileName, selectedOnly, preAppendString);
        }

        /// <summary>
        /// Retrieve the value of a static field by index.
        ///    @param index The index of the static field.
        ///    @return The value of the static field with the given index or \"\". )
        /// 
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public bool saveToXML(string profileName, string fileName)
        {
            return m_ts.fn_SimObject_saveToXML(_ID, profileName, fileName);
        }

        /// <summary>
        /// Set whether the object will be included in saves.
        ///    @param value If true, the object will be included in saves; if false, it will be excluded. )
        /// 
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public void setCanSave(bool value = true)
        {
            m_ts.fn_SimObject_setCanSave(_ID, value);
        }

        /// <summary>
        /// Assign a class namespace to this object.
        ///    @param name The name of the 'class' namespace for this object. )
        /// 
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public void setClassNamespace(string name)
        {
            m_ts.fn_SimObject_setClassNamespace(_ID, name);
        }

        /// <summary>
        /// (enabled))
        /// 
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public void setEnabled(bool enabled)
        {
            m_ts.fn_SimObject_setEnabled(_ID, enabled);
        }

        /// <summary>
        /// Set the console type code for the given field.
        ///    @param fieldName The name of the dynamic field to change to type for.
        ///    @param type The name of the console type.
        ///    @note This only works for dynamic fields.  Types of static fields cannot be changed. )
        /// 
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public void setFieldType(string fieldName, string type)
        {
            m_ts.fn_SimObject_setFieldType(_ID, fieldName, type);
        }

        /// <summary>
        /// Set the value of the given field on this object.
        ///    @param fieldName The name of the field to assign to.  If it includes an array index, the index will be parsed out.
        ///    @param value The new value to assign to the field.
        ///    @param index Optional argument to specify an index for an array field.
        ///    @return True. )
        /// 
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public bool setFieldValue(string fieldName, string value, int index = -1)
        {
            return m_ts.fn_SimObject_setFieldValue(_ID, fieldName, value, index);
        }

        /// <summary>
        /// Sets the object's file name and path
        ///    @param fileName The name of the file to associate this object with. )
        /// 
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public void setFilename(string fileName)
        {
            m_ts.fn_SimObject_setFilename(_ID, fileName);
        }

        /// <summary>
        /// Set whether the object has been marked as expanded. (in editor)
        ///    @param state True if the object is to be marked expanded; false if not. )
        /// 
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public void setIsExpanded(bool state = true)
        {
            m_ts.fn_SimObject_setIsExpanded(_ID, state);
        }

        /// <summary>
        /// Assign a superclass namespace to this object.
        ///    @param name The name of the 'superClass' namespace for this object. )
        /// 
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public void setSuperClassNamespace(string name)
        {
            m_ts.fn_SimObject_setSuperClassNamespace(_ID, name);
        }

        /// <summary>
        /// Assign a persistent ID to the object if it does not already have one. )
        /// 
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public void assignPersistentId()
        {
            m_ts.fnSimObject_assignPersistentId(_ID);
        }

        /// <summary>
        /// ( SimObject, call, const char*, 3, 0, ( string method, string args... ) Dynamically call a method on an object.
        ///    @param method Name of method to call.
        ///    @param args Zero or more arguments for the method.
        ///    @return The result of the method call. )
        /// 
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public string call(string a2, string a3 = "", string a4 = "", string a5 = "", string a6 = "", string a7 = "", string a8 = "", string a9 = "", string a10 = "", string a11 = "", string a12 = "", string a13 = "", string a14 = "", string a15 = "", string a16 = "", string a17 = "", string a18 = "", string a19 = "")
        {
            return m_ts.fnSimObject_call(_ID, a2, a3, a4, a5, a6, a7, a8, a9, a10, a11, a12, a13, a14, a15, a16, a17, a18, a19);
        }

        /// <summary>
        /// Create a copy of this object.
        ///    @return An exact duplicate of this object. )
        /// 
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public string clone()
        {
            return m_ts.fnSimObject_clone(_ID);
        }

        /// <summary>
        /// Create a copy of this object and all its subobjects.
        ///    @return An exact duplicate of this object and all objects it references. )
        /// 
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public string deepClone()
        {
            return m_ts.fnSimObject_deepClone(_ID);
        }

        /// <summary>
        /// Dump a description of all fields and methods defined on this object to the console.
        ///    @param detailed Whether to print detailed information about members. )
        /// 
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public void dump(bool detailed = false)
        {
            m_ts.fnSimObject_dump(_ID, detailed);
        }

        /// <summary>
        /// Dump the hierarchy of this object up to RootGroup to the console. )
        /// 
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public void dumpGroupHierarchy()
        {
            m_ts.fnSimObject_dumpGroupHierarchy(_ID);
        }

        /// <summary>
        /// Return some behind-the-scenes information on the object.
        ///    @return An ArrayObject filled with internal information about the object. )
        /// 
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public string getDebugInfo()
        {
            return m_ts.fnSimObject_getDebugInfo(_ID);
        }

        /// <summary>
        /// Get the group that this object is contained in.
        ///    @note If not assigned to particular SimGroup, an object belongs to RootGroup.
        ///    @return The SimGroup object to which the object belongs. )
        /// 
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public string getGroup()
        {
            return m_ts.fnSimObject_getGroup(_ID);
        }

        /// <summary>
        /// Get the underlying unique numeric ID of the object.
        ///    @note Object IDs are unique only during single engine runs.
        ///    @return The unique numeric ID of the object. )
        /// 
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public int getId()
        {
            return m_ts.fnSimObject_getId(_ID);
        }

        /// <summary>
        /// Get the internal name of the object.
        ///    @return The internal name of the object. )
        /// 
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public string getInternalName()
        {
            return m_ts.fnSimObject_getInternalName(_ID);
        }

        /// <summary>
        /// Get the global name of the object.
        ///    @return The global name assigned to the object. )
        /// 
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public string getName()
        {
            return m_ts.fnSimObject_getName(_ID);
        }

        /// <summary>
        /// Test whether the object belongs directly or indirectly to the given group.
        ///    @param group The SimGroup object.
        ///    @return True if the object is a child of the given group or a child of a group that the given group is directly or indirectly a child to. )
        /// 
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public bool isChildOfGroup(string group)
        {
            return m_ts.fnSimObject_isChildOfGroup(_ID, group);
        }

        /// <summary>
        /// Editable/Non-editable object in the game.
        ///    @return If the object is editable or not. )
        /// 
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public bool isEditable()
        {
            return m_ts.fnSimObject_isEditable(_ID);
        }

        /// <summary>
        /// Return true if the object is only used by the editor.
        ///    @return True if this object exists only for the sake of editing. )
        /// 
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public bool isEditorOnly()
        {
            return m_ts.fnSimObject_isEditorOnly(_ID);
        }

        /// <summary>
        /// Get whether this object may be renamed.
        ///    @return True if this object can be renamed; false otherwise. )
        /// 
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public bool isNameChangeAllowed()
        {
            return m_ts.fnSimObject_isNameChangeAllowed(_ID);
        }

        /// <summary>
        /// Get whether the object has been marked as selected. (in editor)
        ///    @return True if the object is currently selected. )
        /// 
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public bool isSelected()
        {
            return m_ts.fnSimObject_isSelected(_ID);
        }

        /// <summary>
        /// ( SimObject,schedule, S32, 4, 0, ( float time, string method, string args... ) Delay an invocation of a method.
        ///    @param time The number of milliseconds after which to invoke the method.  This is a soft limit.
        ///    @param method The method to call.
        ///    @param args The arguments with which to call the method.
        ///    @return The numeric ID of the created schedule.  Can be used to cancel the call. )
        /// 
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public int schedule(string a2, string a3, string a4 = "", string a5 = "", string a6 = "", string a7 = "", string a8 = "", string a9 = "", string a10 = "", string a11 = "", string a12 = "", string a13 = "", string a14 = "", string a15 = "", string a16 = "", string a17 = "", string a18 = "", string a19 = "")
        {
            return m_ts.fnSimObject_schedule(_ID, a2, a3, a4, a5, a6, a7, a8, a9, a10, a11, a12, a13, a14, a15, a16, a17, a18, a19);
        }

        /// <summary>
        /// Editable/Non-editable object in the game.
        ///    @param value If true, the object will be editable; if false, the object will not be editable. )
        /// 
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public void setEditable(bool value = true)
        {
            m_ts.fnSimObject_setEditable(_ID, value);
        }

        /// <summary>
        /// Set/clear the editor-only flag on this object.
        ///    @param value If true, the object is marked as existing only for the editor. )
        /// 
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public void setEditorOnly(bool value = true)
        {
            m_ts.fnSimObject_setEditorOnly(_ID, value);
        }

        /// <summary>
        /// Hide/unhide the object.
        ///    @param value If true, the object will be hidden; if false, the object will be unhidden. )
        /// 
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public void setHidden(bool value = true)
        {
            m_ts.fnSimObject_setHidden(_ID, value);
        }

        /// <summary>
        /// Set the internal name of the object.
        ///    @param newInternalName The new internal name for the object. )
        /// 
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public void setInternalName(string newInternalName)
        {
            m_ts.fnSimObject_setInternalName(_ID, newInternalName);
        }

        /// <summary>
        /// Set whether the object has been marked as selected. (in editor)
        ///    @param state True if object is to be marked selected; false if not. )
        /// 
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public void setIsSelected(bool state = true)
        {
            m_ts.fnSimObject_setIsSelected(_ID, state);
        }

        /// <summary>
        /// Lock/unlock the object in the editor.
        ///    @param value If true, the object will be locked; if false, the object will be unlocked. )
        /// 
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public void setLocked(bool value = true)
        {
            m_ts.fnSimObject_setLocked(_ID, value);
        }

        /// <summary>
        /// Set the global name of the object.
        ///    @param newName The new global name to assign to the object.
        ///    @note If name changing is disallowed on the object, the method will fail with a console error. )
        /// 
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public void setName(string newName)
        {
            m_ts.fnSimObject_setName(_ID, newName);
        }

        /// <summary>
        /// Set whether this object can be renamed from its first name.
        ///    @param value If true, renaming is allowed for this object; if false, trying to change the name of the object will generate a console error. )
        /// 
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public void setNameChangeAllowed(bool value = true)
        {
            m_ts.fnSimObject_setNameChangeAllowed(_ID, value);
        }

        /// <summary>
        /// (SimObject, signal, void, 3, 4, evaluates strings stored in dynamic fields take a string as parameter)
        /// 
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public void signal(string a2, string a3 = "")
        {
            m_ts.fnSimObject_signal(_ID, a2, a3);
        }

        #endregion

        #region T3D Callbacks

        /// <summary>
        /// )
        /// </summary>
        [ConsoleInteraction(true)]
        public virtual void onDefineFieldTypes()
        {
        }

        /// <summary>
        /// )
        /// </summary>
        [ConsoleInteraction(true)]
        public virtual void setInfo(string info)
        {
        }

        /// <summary>
        /// )
        /// </summary>
        [ConsoleInteraction(true)]
        public virtual void setSelectionObjectsByCount(string count)
        {
        }

        /// <summary>
        /// )
        /// </summary>
        [ConsoleInteraction(true)]
        public virtual void onClick(string SelectedidString)
        {
        }

        /// <summary>
        /// )
        /// </summary>
        [ConsoleInteraction(true)]
        public virtual void onDblClick(string SelectedidString)
        {
        }

        /// <summary>
        /// )
        /// </summary>
        [ConsoleInteraction(true)]
        public virtual void onEndDrag(string obj)
        {
        }

        /// <summary>
        /// )
        /// </summary>
        [ConsoleInteraction(true)]
        public virtual void onGuiUpdate(string text)
        {
        }

        #endregion

        public SimObject_Base()
        {
        }
    }
}