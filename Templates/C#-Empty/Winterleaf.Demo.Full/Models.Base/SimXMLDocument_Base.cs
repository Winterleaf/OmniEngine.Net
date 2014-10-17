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

using System.ComponentModel;
using WinterLeaf.Demo.Full.Models.User.Extendable;
using WinterLeaf.Engine;
using WinterLeaf.Engine.Classes.Decorations;
using WinterLeaf.Engine.Classes.Helpers;
using WinterLeaf.Engine.Classes.Interopt;

#endregion

namespace WinterLeaf.Demo.Full.Models.Base
{
    /// <summary>
    /// 
    /// </summary>
    [TypeConverter(typeof (TypeConverterGeneric<SimXMLDocument_Base>))]
    public partial class SimXMLDocument_Base : SimObject
    {
        #region ProxyObjects Operator Overrides

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(SimXMLDocument_Base ts, string simobjectid)
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
        public static bool operator !=(SimXMLDocument_Base ts, string simobjectid)
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
        public static implicit operator string(SimXMLDocument_Base ts)
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
        public static implicit operator SimXMLDocument_Base(string ts)
        {
            uint simobjectid = resolveobject(ts);
            return (SimXMLDocument_Base) Omni.self.getSimObject(simobjectid, typeof (SimXMLDocument_Base));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int(SimXMLDocument_Base ts)
        {
            return (int) ts._iID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator SimXMLDocument_Base(int simobjectid)
        {
            return (SimXMLDocument) Omni.self.getSimObject((uint) simobjectid, typeof (SimXMLDocument_Base));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint(SimXMLDocument_Base ts)
        {
            return ts._iID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator SimXMLDocument_Base(uint simobjectid)
        {
            return (SimXMLDocument_Base) Omni.self.getSimObject(simobjectid, typeof (SimXMLDocument_Base));
        }

        #endregion

        #region Init Persists

        #endregion

        #region Member Functions

        /// <summary>
        /// (string attributeName)   @brief Get float attribute from the current Element on the stack.   @param attributeName Name of attribute to retrieve.   @return The value of the given attribute in the form of a float.   @deprecated Use attribute().)
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public float attributeF32(string attributeName)
        {
            return m_ts.fn_SimXMLDocument_attributeF32(_ID, attributeName);
        }

        /// <summary>
        /// (string attributeName)   @brief Get int attribute from the current Element on the stack.   @param attributeName Name of attribute to retrieve.   @return The value of the given attribute in the form of an integer.   @deprecated Use attribute().)
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public int attributeS32(string attributeName)
        {
            return m_ts.fn_SimXMLDocument_attributeS32(_ID, attributeName);
        }

        /// <summary>
        /// @brief Add the given comment as a child of the document.  @param comment String containing the comment.   @tsexample   // Create a new XML document with a header, a comment and single element.   %x = new SimXMLDocument();   %x.addHeader();   %x.addComment(\"This is a test comment\");   %x.addNewElement(\"NewElement\");   %x.saveFile(\"test.xml\");   // Produces the following file:   // ?xml version=\"1.0\" encoding=\"utf-8\" standalone=\"yes\" ?>   // !--This is a test comment-->   // NewElement />   @endtsexample      @see readComment())
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public void addComment(string comment)
        {
            m_ts.fnSimXMLDocument_addComment(_ID, comment);
        }

        /// <summary>
        /// @brief Add the given text as a child of current Element.   Use getData() to retrieve any text from the current Element.   addData() and addText() may be used interchangeably.  As there is no    difference between data and text, you may also use removeText() to clear    any data from the current Element.   @param text String containing the text.   @tsexample   // Create a new XML document with a header and single element   // with some added data.   %x = new SimXMLDocument();   %x.addHeader();   %x.addNewElement(\"NewElement\");   %x.addData(\"Some text\");   %x.saveFile(\"test.xml\");   // Produces the following file:   // ?xml version=\"1.0\" encoding=\"utf-8\" standalone=\"yes\" ?>   // NewElement>Some text/NewElement>   @endtsexample   @see getData()   @see addText()   @see getText()   @see removeText())
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public void addData(string text)
        {
            m_ts.fnSimXMLDocument_addData(_ID, text);
        }

        /// <summary>
        /// @brief Add a XML header to a document.   Sometimes called a declaration, you typically add a standard header to    the document before adding any elements.  SimXMLDocument always produces    the following header:   ?xml version=\"1.0\" encoding=\"utf-8\" standalone=\"yes\" ?>     @tsexample   // Create a new XML document with just a header and single element.   %x = new SimXMLDocument();   %x.addHeader();   %x.addNewElement(\"NewElement\");   %x.saveFile(\"test.xml\");   // Produces the following file:   // ?xml version=\"1.0\" encoding=\"utf-8\" standalone=\"yes\" ?>   // NewElement />   @endtsexample)
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public void addHeader()
        {
            m_ts.fnSimXMLDocument_addHeader(_ID);
        }

        /// <summary>
        /// @brief Create a new element with the given name as child of current Element's    parent and push it onto the Element stack making it the current one.   @note This differs from pushNewElement() in that it adds the new Element to the    current Element's parent (or document if there is no parent Element).  This makes    the new Element a sibling of the current one.   @param name XML tag for the new Element.      @see pushNewElement())
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public void addNewElement(string name)
        {
            m_ts.fnSimXMLDocument_addNewElement(_ID, name);
        }

        /// <summary>
        /// @brief Add the given text as a child of current Element.   Use getText() to retrieve any text from the current Element and removeText()    to clear any text.   addText() and addData() may be used interchangeably.   @param text String containing the text.   @tsexample   // Create a new XML document with a header and single element   // with some added text.   %x = new SimXMLDocument();   %x.addHeader();   %x.addNewElement(\"NewElement\");   %x.addText(\"Some text\");   %x.saveFile(\"test.xml\");   // Produces the following file:   // ?xml version=\"1.0\" encoding=\"utf-8\" standalone=\"yes\" ?>   // NewElement>Some text/NewElement>   @endtsexample   @see getText()   @see removeText()   @see addData()   @see getData())
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public void addText(string text)
        {
            m_ts.fnSimXMLDocument_addText(_ID, text);
        }

        /// <summary>
        /// @brief Get a string attribute from the current Element on the stack.   @param attributeName Name of attribute to retrieve.   @return The attribute string if found.  Otherwise returns an empty string.)
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public string attribute(string attributeName)
        {
            return m_ts.fnSimXMLDocument_attribute(_ID, attributeName);
        }

        /// <summary>
        /// @brief Tests if the requested attribute exists.   @param attributeName Name of attribute being queried for.   @return True if the attribute exists.)
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public bool attributeExists(string attributeName)
        {
            return m_ts.fnSimXMLDocument_attributeExists(_ID, attributeName);
        }

        /// <summary>
        /// @brief Set this document to its default state.      Clears all Elements from the documents.  Equivalent to using reset()      @see reset())
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public void clear()
        {
            m_ts.fnSimXMLDocument_clear(_ID);
        }

        /// <summary>
        /// @brief Clear the last error description.)
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public void clearError()
        {
            m_ts.fnSimXMLDocument_clearError(_ID);
        }

        /// <summary>
        /// @brief Get the Element's value if it exists.   Usually returns the text from the Element.   @return The value from the Element, or an empty string if none is found.)
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public string elementValue()
        {
            return m_ts.fnSimXMLDocument_elementValue(_ID);
        }

        /// <summary>
        /// @brief Obtain the name of the current Element's first attribute.   @return String containing the first attribute's name, or an empty string if none is found.   @see nextAttribute()   @see lastAttribute()   @see prevAttribute())
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public string firstAttribute()
        {
            return m_ts.fnSimXMLDocument_firstAttribute(_ID);
        }

        /// <summary>
        /// @brief Gets the text from the current Element.   Use addData() to add text to the current Element.   getData() and getText() may be used interchangeably.  As there is no    difference between data and text, you may also use removeText() to clear    any data from the current Element.   @return String containing the text in the current Element.   @tsexample   // Using the following test.xml file as an example:   // ?xml version=\"1.0\" encoding=\"utf-8\" standalone=\"yes\" ?>   // NewElement>Some data/NewElement>   // Load in the file   %x = new SimXMLDocument();   %x.loadFile(\"test.xml\");   // Make the first Element the current one   %x.pushFirstChildElement(\"NewElement\");   // Store the current Element's data ('Some data' in this example)   // into 'result'   %result = %x.getData();   echo( %result );   @endtsexample      @see addData()   @see addText()   @see getText()   @see removeText())
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public string getData()
        {
            return m_ts.fnSimXMLDocument_getData(_ID);
        }

        /// <summary>
        /// @brief Get last error description.   @return A string of the last error message.)
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public string getErrorDesc()
        {
            return m_ts.fnSimXMLDocument_getErrorDesc(_ID);
        }

        /// <summary>
        /// @brief Gets the text from the current Element.   Use addText() to add text to the current Element and removeText()    to clear any text.   getText() and getData() may be used interchangeably.   @return String containing the text in the current Element.   @tsexample   // Using the following test.xml file as an example:   // ?xml version=\"1.0\" encoding=\"utf-8\" standalone=\"yes\" ?>   // NewElement>Some text/NewElement>   // Load in the file   %x = new SimXMLDocument();   %x.loadFile(\"test.xml\");   // Make the first Element the current one   %x.pushFirstChildElement(\"NewElement\");   // Store the current Element's text ('Some text' in this example)   // into 'result'   %result = %x.getText();   echo( %result );   @endtsexample      @see addText()   @see removeText()   @see addData()   @see getData())
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public string getText()
        {
            return m_ts.fnSimXMLDocument_getText(_ID);
        }

        /// <summary>
        /// @brief Obtain the name of the current Element's last attribute.   @return String containing the last attribute's name, or an empty string if none is found.   @see prevAttribute()   @see firstAttribute()   @see lastAttribute())
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public string lastAttribute()
        {
            return m_ts.fnSimXMLDocument_lastAttribute(_ID);
        }

        /// <summary>
        /// @brief Load in given filename and prepare it for use.   @note Clears the current document's contents.   @param fileName Name and path of XML document   @return True if the file was loaded successfully.)
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public bool loadFile(string fileName)
        {
            return m_ts.fnSimXMLDocument_loadFile(_ID, fileName);
        }

        /// <summary>
        /// @brief Get the name of the next attribute for the current Element after a call to firstAttribute().   @return String containing the next attribute's name, or an empty string if none is found.   @see firstAttribute()   @see lastAttribute()   @see prevAttribute())
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public string nextAttribute()
        {
            return m_ts.fnSimXMLDocument_nextAttribute(_ID);
        }

        /// <summary>
        /// @brief Put the next sibling Element with the given name on the stack, making it the current one.   @param name String containing name of the next sibling.   @return True if the Element was found and made the current one.)
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public bool nextSiblingElement(string name)
        {
            return m_ts.fnSimXMLDocument_nextSiblingElement(_ID, name);
        }

        /// <summary>
        /// @brief Create a document from a XML string.   @note Clears the current document's contents.   @param xmlString Valid XML to parse and store as a document.)
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public void parse(string xmlString)
        {
            m_ts.fnSimXMLDocument_parse(_ID, xmlString);
        }

        /// <summary>
        /// @brief Pop the last Element off the stack.)
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public void popElement()
        {
            m_ts.fnSimXMLDocument_popElement(_ID);
        }

        /// <summary>
        /// @brief Get the name of the previous attribute for the current Element after a call to lastAttribute().   @return String containing the previous attribute's name, or an empty string if none is found.   @see lastAttribute()   @see firstAttribute()   @see nextAttribute())
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public string prevAttribute()
        {
            return m_ts.fnSimXMLDocument_prevAttribute(_ID);
        }

        /// <summary>
        /// @brief Push the child Element at the given index onto the stack, making it the current one.   @param index Numerical index of Element being pushed.   @return True if the Element was found and made the current one.)
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public bool pushChildElement(int index)
        {
            return m_ts.fnSimXMLDocument_pushChildElement(_ID, index);
        }

        /// <summary>
        /// @brief Push the first child Element with the given name onto the stack, making it the current Element.   @param name String containing name of the child Element.   @return True if the Element was found and made the current one.   @tsexample   // Using the following test.xml file as an example:   // ?xml version=\"1.0\" encoding=\"utf-8\" standalone=\"yes\" ?>   // NewElement>Some text/NewElement>   // Load in the file   %x = new SimXMLDocument();   %x.loadFile(\"test.xml\");   // Make the first Element the current one   %x.pushFirstChildElement(\"NewElement\");   // Store the current Element's text ('Some text' in this example)   // into 'result'   %result = %x.getText();   echo( %result );   @endtsexample)
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public bool pushFirstChildElement(string name)
        {
            return m_ts.fnSimXMLDocument_pushFirstChildElement(_ID, name);
        }

        /// <summary>
        /// @brief Create a new element with the given name as child of current Element    and push it onto the Element stack making it the current one.   @note This differs from addNewElement() in that it adds the new Element as a    child of the current Element (or a child of the document if no Element exists).   @param name XML tag for the new Element.   @see addNewElement())
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public void pushNewElement(string name)
        {
            m_ts.fnSimXMLDocument_pushNewElement(_ID, name);
        }

        /// <summary>
        /// Gives the comment at the specified index, if any.   Unlike addComment() that only works at the document level, readComment() may read    comments from the document or any child Element.  The current Element (or document    if no Elements have been pushed to the stack) is the parent for any comments, and the    provided index is the number of comments in to read back.   @param index Comment index number to query from the current Element stack   @return String containing the comment, or an empty string if no comment is found.   @see addComment())
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public string readComment(int index)
        {
            return m_ts.fnSimXMLDocument_readComment(_ID, index);
        }

        /// <summary>
        /// @brief Remove any text on the current Element.   Use getText() to retrieve any text from the current Element and addText()    to add text to the current Element.  As getData() and addData() are equivalent    to getText() and addText(), removeText() will also remove any data from the    current Element.      @see addText()   @see getText()   @see addData()   @see getData())
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public void removeText()
        {
            m_ts.fnSimXMLDocument_removeText(_ID);
        }

        /// <summary>
        /// @brief Set this document to its default state.      Clears all Elements from the documents.  Equivalent to using clear()      @see clear())
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public void reset()
        {
            m_ts.fnSimXMLDocument_reset(_ID);
        }

        /// <summary>
        /// @brief Save document to the given file name.   @param fileName Path and name of XML file to save to.   @return True if the file was successfully saved.)
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public bool saveFile(string fileName)
        {
            return m_ts.fnSimXMLDocument_saveFile(_ID, fileName);
        }

        /// <summary>
        /// @brief Set the attribute of the current Element on the stack to the given value.   @param attributeName Name of attribute being changed   @param value New value to assign to the attribute)
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public void setAttribute(string attributeName, string value)
        {
            m_ts.fnSimXMLDocument_setAttribute(_ID, attributeName, value);
        }

        /// <summary>
        /// @brief Add the given SimObject's fields as attributes of the current Element on the stack.   @param objectID ID of SimObject being copied.)
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public void setObjectAttributes(string objectID)
        {
            m_ts.fnSimXMLDocument_setObjectAttributes(_ID, objectID);
        }

        #endregion

        #region T3D Callbacks

        #endregion

        public SimXMLDocument_Base()
        {
        }
    }
}